using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{

    public partial class FormBanHang : Form
    {
        
        private readonly SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private readonly KhachHangBUS khachHangBUS = new KhachHangBUS();

        
        private readonly List<ChiTietHoaDonDTO> gioHang = new List<ChiTietHoaDonDTO>();
        private readonly BindingSource bsGioHang = new BindingSource();

        private SanPhamDTO sanPhamDangChon;

        
        private bool dangCapNhat;

        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        private static string ThuMucAnh
        {
            get { return Path.Combine(Application.StartupPath, "Images"); }
        }

        public FormBanHang()
        {
            InitializeComponent();
        }

        

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            if (PhienLamViec.NhanVien != null)
            {
                lblNhanVien.Text = "Nhân viên lập hóa đơn: " + PhienLamViec.NhanVien.HoTen + " (" + PhienLamViec.NhanVien.MaNhanVien + ")";
            }
            else
            {
                lblNhanVien.Text = "Chưa xác định nhân viên đăng nhập";
                btnThanhToan.Enabled = false;
            }

            bsGioHang.DataSource = gioHang;
            dgvGioHang.DataSource = bsGioHang;

            NapKhachHang();
            TaiDanhSachSanPham("");
            CapNhatTongTien();
        }

       
        private void NapKhachHang()
        {
            try
            {
                List<KhachHangDTO> danhSach = khachHangBUS.LayTatCa();
                KhachHangDTO khachVangLai = new KhachHangDTO();
                khachVangLai.MaKhachHang = "";
                khachVangLai.HoTen = "Khách vãng lai";
                danhSach.Insert(0, khachVangLai);

                cboKhachHang.DataSource = danhSach;
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKhachHang";
                cboKhachHang.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách khách hàng.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void TaiDanhSachSanPham(string tuKhoa)
        {
            try
            {
                List<SanPhamDTO> danhSach = sanPhamBUS.TimKiemDangKinhDoanh(tuKhoa);
                dgvSanPham.DataSource = danhSach;

                if (danhSach.Count == 0)
                {
                    dgvSanPham.ClearSelection();
                    HienSanPham(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách sản phẩm.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSachSanPham(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSachSanPham(txtTimKiem.Text.Trim());
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0) return;
            HienSanPham(dgvSanPham.SelectedRows[0].DataBoundItem as SanPhamDTO);
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ThemVaoGio(1);
        }

       
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvSanPham.Columns[e.ColumnIndex].Name != "colSoLuongTon" || e.Value == null) return;

            int ton;
            if (!int.TryParse(Convert.ToString(e.Value), out ton)) return;
            if (ton <= 0)
                e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);
            else if (ton <= SanPhamBUS.NguongTonKhoThap)
                e.CellStyle.ForeColor = Color.FromArgb(230, 81, 0);
        }

       
        private void HienSanPham(SanPhamDTO sanPham)
        {
            sanPhamDangChon = sanPham;

            if (picSanPham.Image != null)
            {
                picSanPham.Image.Dispose();
                picSanPham.Image = null;
            }

            if (sanPham == null)
            {
                lblTenSanPham.Text = "Chọn một sản phẩm trong danh sách";
                lblMaSanPham.Text = "";
                lblSizeMau.Text = "";
                lblGiaBan.Text = "";
                lblTonKho.Text = "";
                btnThemVaoGio.Enabled = false;
                return;
            }

            lblTenSanPham.Text = sanPham.TenSanPham;
            lblMaSanPham.Text = "Mã sản phẩm: " + sanPham.MaSanPham;
            lblSizeMau.Text = "Size: " + sanPham.TenKichThuoc + "   •   Màu: " + sanPham.TenMauSac;
            lblGiaBan.Text = sanPham.GiaBan.ToString("N0", viVN) + " đ";

            if (sanPham.SoLuongTon <= 0)
            {
                lblTonKho.Text = "Hết hàng";
                lblTonKho.ForeColor = Color.FromArgb(198, 40, 40);
            }
            else
            {
                lblTonKho.Text = "Còn lại: " + sanPham.SoLuongTon;
                lblTonKho.ForeColor = sanPham.SoLuongTon <= SanPhamBUS.NguongTonKhoThap
                    ? Color.FromArgb(230, 81, 0) : Color.FromArgb(56, 142, 60);
            }

            
            nudSoLuong.Maximum = Math.Max(1, sanPham.SoLuongTon);
            nudSoLuong.Value = 1;
            btnThemVaoGio.Enabled = sanPham.SoLuongTon > 0;

            HienAnh(sanPham.HinhAnh);
        }

        
        private void HienAnh(string tenFile)
        {
            if (string.IsNullOrWhiteSpace(tenFile)) return;

            try
            {
                string duongDan = Path.Combine(ThuMucAnh, tenFile);
                if (!File.Exists(duongDan)) return;
                using (Image goc = Image.FromFile(duongDan))
                {
                    picSanPham.Image = new Bitmap(goc);
                }
            }
            catch (Exception)
            {
                picSanPham.Image = null;
            }
        }

       

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            ThemVaoGio((int)nudSoLuong.Value);
        }

       
        private void ThemVaoGio(int soLuong)
        {
            if (sanPhamDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            KetQua ketQua = hoaDonBUS.ThemVaoGio(gioHang, sanPhamDangChon, soLuong);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không thêm được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapNhatGio();
            ChonDongGio(sanPhamDangChon.MaSanPham);
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            DoiSoLuongDongChon(+1);
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            DoiSoLuongDongChon(-1);
        }

       
        private void DoiSoLuongDongChon(int buoc)
        {
            ChiTietHoaDonDTO dong = LayDongGioDangChon();
            if (dong == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong giỏ hàng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma = dong.MaSanPham;
            KetQua ketQua = hoaDonBUS.CapNhatSoLuong(gioHang, ma, dong.SoLuong + buoc);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không đổi được số lượng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapNhatGio();
            ChonDongGio(ma);
        }

        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonDTO dong = LayDongGioDangChon();
            if (dong == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong giỏ hàng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            KetQua ketQua = hoaDonBUS.XoaKhoiGio(gioHang, dong.MaSanPham);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CapNhatGio();
        }

        private ChiTietHoaDonDTO LayDongGioDangChon()
        {
            if (dgvGioHang.SelectedRows.Count == 0) return null;
            return dgvGioHang.SelectedRows[0].DataBoundItem as ChiTietHoaDonDTO;
        }

      
        private void ChonDongGio(string maSanPham)
        {
            foreach (DataGridViewRow dong in dgvGioHang.Rows)
            {
                ChiTietHoaDonDTO ct = dong.DataBoundItem as ChiTietHoaDonDTO;
                if (ct != null && ct.MaSanPham == maSanPham)
                {
                    dgvGioHang.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        private void CapNhatGio()
        {
            bsGioHang.ResetBindings(false);
            CapNhatTongTien();
        }

       
        private void CapNhatTongTien()
        {
            decimal tongTien = hoaDonBUS.TinhTongTien(gioHang);

            dangCapNhat = true;
            if (nudPhanTram.Value > 0)
            {
                decimal soTien = hoaDonBUS.TinhGiamGiaTheoPhanTram(tongTien, nudPhanTram.Value);
                nudGiamGia.Value = Math.Min(soTien, nudGiamGia.Maximum);
            }
            else if (nudGiamGia.Value > tongTien)
            {
                nudGiamGia.Value = tongTien;     
            }
            dangCapNhat = false;

            decimal thanhTien = hoaDonBUS.TinhThanhTien(tongTien, nudGiamGia.Value);
            lblTongTien.Text = tongTien.ToString("N0", viVN) + " đ";
            lblThanhTien.Text = thanhTien.ToString("N0", viVN) + " đ";
            CapNhatTienThua();
        }

       
        private void nudPhanTram_ValueChanged(object sender, EventArgs e)
        {
            if (dangCapNhat) return;
            CapNhatTongTien();
        }

       
        private void nudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            if (dangCapNhat) return;

            dangCapNhat = true;
            nudPhanTram.Value = 0;
            dangCapNhat = false;
            CapNhatTongTien();
        }

        private void nudKhachDua_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTienThua();
        }

       
        private void CapNhatTienThua()
        {
            decimal thanhTien = hoaDonBUS.TinhThanhTien(hoaDonBUS.TinhTongTien(gioHang), nudGiamGia.Value);
            decimal khachDua = nudKhachDua.Value;

            if (khachDua <= 0)
            {
                lblTienThua.Text = "";
            }
            else if (khachDua >= thanhTien)
            {
                lblTienThua.Text = "Tiền thừa: " + (khachDua - thanhTien).ToString("N0", viVN) + " đ";
                lblTienThua.ForeColor = Color.FromArgb(56, 142, 60);
            }
            else
            {
                lblTienThua.Text = "Còn thiếu: " + (thanhTien - khachDua).ToString("N0", viVN) + " đ";
                lblTienThua.ForeColor = Color.FromArgb(198, 40, 40);
            }
        }

       

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống. Vui lòng thêm sản phẩm trước khi thanh toán.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (PhienLamViec.NhanVien == null)
            {
                MessageBox.Show("Chưa xác định được nhân viên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal tongTien = hoaDonBUS.TinhTongTien(gioHang);
            decimal giamGia = nudGiamGia.Value;
            decimal thanhTien = hoaDonBUS.TinhThanhTien(tongTien, giamGia);
            bool ghiNo = chkGhiNo.Checked;
            string trangThai = ghiNo ? HoaDonBUS.TrangThaiChuaThanhToan : HoaDonBUS.TrangThaiDaThanhToan;

            if (!ghiNo && nudKhachDua.Value > 0 && nudKhachDua.Value < thanhTien)
            {
                MessageBox.Show("Số tiền khách đưa chưa đủ. Còn thiếu "
                                + (thanhTien - nudKhachDua.Value).ToString("N0", viVN) + " đ.", "Chưa đủ tiền",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudKhachDua.Focus();
                return;
            }

            DialogResult hoi = MessageBox.Show(
                "Xác nhận " + (ghiNo ? "lập hóa đơn ghi nợ" : "thanh toán") + " đơn hàng?\n\n"
                + "Khách hàng: " + cboKhachHang.Text + "\n"
                + "Thành tiền: " + thanhTien.ToString("N0", viVN) + " đ",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            string maKhachHang = Convert.ToString(cboKhachHang.SelectedValue);   
            Cursor = Cursors.WaitCursor;
            KetQua ketQua;
            try
            {
                ketQua = hoaDonBUS.ThanhToan(maKhachHang, PhienLamViec.NhanVien.MaNhanVien, gioHang, giamGia, trangThai);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TaiDanhSachSanPham(txtTimKiem.Text.Trim());     
                return;
            }

            string maHoaDon = ketQua.MaMoi;
            DialogResult hoiIn = MessageBox.Show(ketQua.ThongBao + "\n\nBạn có muốn in hóa đơn không?",
                                                 "Thanh toán thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            LamMoiDon();
            TaiDanhSachSanPham(txtTimKiem.Text.Trim());

            if (hoiIn == DialogResult.Yes) InHoaDonVuaLap(maHoaDon);
        }

        // Lấy hóa đơn vừa lưu từ CSDL rồi mở màn hình xem trước khi in
        private void InHoaDonVuaLap(string maHoaDon)
        {
            try
            {
                HoaDonDTO hoaDon = hoaDonBUS.LayTheoMa(maHoaDon);
                List<ChiTietHoaDonDTO> chiTiet = hoaDonBUS.LayChiTiet(maHoaDon);
                InHoaDon.XemTruocVaIn(this, hoaDon, chiTiet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không in được hóa đơn.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0 && nudGiamGia.Value == 0 && nudKhachDua.Value == 0) return;

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn hủy đơn hàng đang lập? Giỏ hàng sẽ bị xóa.",
                                               "Hủy đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes) LamMoiDon();
        }

        // Làm mới: tải lại danh sách sản phẩm (tồn kho mới nhất) và khách hàng, giữ nguyên giỏ hàng
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            string khachDangChon = Convert.ToString(cboKhachHang.SelectedValue);
            NapKhachHang();
            cboKhachHang.SelectedValue = khachDangChon;
            TaiDanhSachSanPham("");
        }

        // Xóa giỏ hàng và đưa các ô về mặc định để lập đơn mới
        private void LamMoiDon()
        {
            gioHang.Clear();

            dangCapNhat = true;
            nudPhanTram.Value = 0;
            nudGiamGia.Value = 0;
            dangCapNhat = false;

            nudKhachDua.Value = 0;
            chkGhiNo.Checked = false;
            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;

            CapNhatGio();
        }
    }
}