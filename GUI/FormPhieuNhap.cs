using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form quản lý phiếu nhập gồm 2 tab:
    ///   - Lập phiếu nhập: chọn nhà cung cấp, thêm sản phẩm nhập, xác nhận (cộng tồn kho trong một transaction).
    ///   - Lịch sử phiếu nhập: tìm kiếm, xem chi tiết, xóa phiếu (trừ lại tồn kho).
    /// Giao diện nằm trong FormPhieuNhap.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormPhieuNhap : Form
    {
        // Các đối tượng BUS
        private readonly PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        private readonly SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private readonly NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

        // Danh sách hàng nhập của phiếu đang lập và nguồn dữ liệu gắn với lưới
        private readonly List<ChiTietPhieuNhapDTO> danhSachNhap = new List<ChiTietPhieuNhapDTO>();
        private readonly BindingSource bsNhap = new BindingSource();

        // Sản phẩm đang chọn ở danh sách bên trái
        private SanPhamDTO sanPhamDangChon;

        // Mã phiếu đang chọn ở tab lịch sử (null nếu chưa chọn)
        private string maPhieuDangChon;

        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        public FormPhieuNhap()
        {
            InitializeComponent();
            // Visual Studio Designer không lưu thuộc tính AutoGenerateColumns, nên phải đặt ở đây:
            // nếu để mặc định (true) thì lưới sẽ tự sinh cột theo mọi thuộc tính của DTO và mất cột đã thiết kế.
            dgvSanPham.AutoGenerateColumns = false;
            dgvChiTietNhap.AutoGenerateColumns = false;
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvChiTietPN.AutoGenerateColumns = false;
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            if (PhienLamViec.NhanVien != null)
            {
                lblNhanVien.Text = "Nhân viên lập phiếu: " + PhienLamViec.NhanVien.HoTen + " (" + PhienLamViec.NhanVien.MaNhanVien + ")";
            }
            else
            {
                lblNhanVien.Text = "Chưa xác định nhân viên đăng nhập";
                btnXacNhanNhap.Enabled = false;
            }
            lblNgayNhap.Text = "Ngày nhập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm", viVN);

            // Chỉ quản trị viên được xóa phiếu nhập
            if (!PhienLamViec.LaQuanTri) btnXoaPhieu.Enabled = false;

            bsNhap.DataSource = danhSachNhap;
            dgvChiTietNhap.DataSource = bsNhap;

            NapNhaCungCap();
            TaiDanhSachSanPham("");
            HienSanPham(null);
            CapNhatTongTien();
        }

        // Đổ danh sách nhà cung cấp vào combobox
        private void NapNhaCungCap()
        {
            try
            {
                cboNhaCungCap.DataSource = nhaCungCapBUS.LayTatCa();
                cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                cboNhaCungCap.ValueMember = "MaNhaCungCap";
                cboNhaCungCap.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách nhà cung cấp.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi chuyển sang tab lịch sử thì tải danh sách phiếu nhập
        private void tabPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPhieuNhap.SelectedTab == tabLichSu)
            {
                TaiLichSu();
            }
        }

        /* ===================== TAB 1: LẬP PHIẾU NHẬP ===================== */

        // Tải các sản phẩm đang kinh doanh (tuKhoa rỗng = tất cả)
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

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            TaiDanhSachSanPham(txtTimKiemSP.Text.Trim());
        }

        private void txtTimKiemSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSachSanPham(txtTimKiemSP.Text.Trim());
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0) return;
            HienSanPham(dgvSanPham.SelectedRows[0].DataBoundItem as SanPhamDTO);
        }

        // Nhấp đúp: thêm nhanh 1 cái với giá nhập hiện tại của sản phẩm
        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || sanPhamDangChon == null) return;
            ThemVaoPhieu(1, sanPhamDangChon.GiaNhap);
        }

        // Hiện sản phẩm đang chọn và điền sẵn giá nhập gần nhất
        private void HienSanPham(SanPhamDTO sanPham)
        {
            sanPhamDangChon = sanPham;

            if (sanPham == null)
            {
                lblSanPhamChon.Text = "Chưa chọn sản phẩm (nhấp đúp để thêm nhanh 1 cái)";
                lblGiaVonDuKien.Text = "";
                btnThemVaoPhieu.Enabled = false;
                return;
            }

            lblSanPhamChon.Text = sanPham.MaSanPham + " - " + sanPham.TenSanPham
                                  + " (" + sanPham.TenKichThuoc + ", " + sanPham.TenMauSac + ")";
            nudGiaNhap.Value = Math.Min(Math.Max(sanPham.GiaNhap, nudGiaNhap.Minimum), nudGiaNhap.Maximum);
            btnThemVaoPhieu.Enabled = true;
            CapNhatGiaVonDuKien();
        }

        /* ===================== GIÁ NHẬP (GIÁ VỐN) DỰ KIẾN ===================== */
        // Giá nhập hiện tại = trung bình các lần nhập, có trọng số theo số lượng:
        //     tổng (số lượng x giá nhập) / tổng số lượng
        // Ví dụ: tháng 8 nhập 10 cái giá 80.000, tháng 9 nhập 10 cái giá 90.000 -> (800.000 + 900.000) / 20 = 85.000.

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatGiaVonDuKien();
        }

        private void nudGiaNhap_ValueChanged(object sender, EventArgs e)
        {
            CapNhatGiaVonDuKien();
        }

        // Hiện giá nhập hiện tại và giá nhập sau khi nhập thêm số lượng/giá đang nhập ở ô bên cạnh
        private void CapNhatGiaVonDuKien()
        {
            if (sanPhamDangChon == null)
            {
                lblGiaVonDuKien.Text = "";
                return;
            }

            try
            {
                decimal hienTai = phieuNhapBUS.TinhGiaVonSauKhiNhap(sanPhamDangChon.MaSanPham, 0, 0);
                if (hienTai <= 0) hienTai = sanPhamDangChon.GiaNhap;     // chưa có lần nhập nào: dùng giá nhập đang lưu

                decimal duKien = phieuNhapBUS.TinhGiaVonSauKhiNhap(sanPhamDangChon.MaSanPham, (int)nudSoLuong.Value, nudGiaNhap.Value);

                lblGiaVonDuKien.Text = "Giá nhập hiện tại: " + hienTai.ToString("N0", viVN) + " đ   →   sau khi nhập: "
                                       + duKien.ToString("N0", viVN) + " đ  (trung bình các lần nhập, tính theo số lượng)";
            }
            catch (Exception)
            {
                lblGiaVonDuKien.Text = "";
            }
        }

        private void btnThemVaoPhieu_Click(object sender, EventArgs e)
        {
            ThemVaoPhieu((int)nudSoLuong.Value, nudGiaNhap.Value);
        }

        // Thêm sản phẩm đang chọn vào danh sách nhập (BUS kiểm tra số lượng, giá)
        private void ThemVaoPhieu(int soLuong, decimal giaNhap)
        {
            if (sanPhamDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            KetQua ketQua = phieuNhapBUS.ThemDong(danhSachNhap, sanPhamDangChon, soLuong, giaNhap);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không thêm được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapNhatDanhSachNhap();
            nudSoLuong.Value = 1;
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvChiTietNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách nhập.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ChiTietPhieuNhapDTO dong = dgvChiTietNhap.SelectedRows[0].DataBoundItem as ChiTietPhieuNhapDTO;
            if (dong == null) return;

            KetQua ketQua = phieuNhapBUS.XoaDong(danhSachNhap, dong.MaSanPham);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CapNhatDanhSachNhap();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            if (danhSachNhap.Count == 0) return;

            DialogResult hoi = MessageBox.Show("Xóa toàn bộ sản phẩm trong danh sách nhập?", "Xác nhận",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            danhSachNhap.Clear();
            CapNhatDanhSachNhap();
        }

        // Xuất phiếu nhập đang lập (chưa xác nhận) ra file Excel
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (danhSachNhap.Count == 0)
            {
                MessageBox.Show("Danh sách hàng nhập đang trống, chưa có gì để xuất.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string[]> thongTin = new List<string[]>();
            thongTin.Add(new string[] { "Nhà cung cấp:", cboNhaCungCap.SelectedIndex < 0 ? "(chưa chọn)" : cboNhaCungCap.Text });
            thongTin.Add(new string[] { "Nhân viên lập phiếu:", PhienLamViec.NhanVien != null ? PhienLamViec.NhanVien.HoTen : "" });
            thongTin.Add(new string[] { "Ngày nhập:", DateTime.Now.ToString("dd/MM/yyyy HH:mm", viVN) });
            thongTin.Add(new string[] { "Ghi chú:", txtGhiChu.Text.Trim() });

            string[] cacCot = { "STT", "Mã sản phẩm", "Tên sản phẩm", "Số lượng", "Giá nhập (đ)", "Thành tiền (đ)" };
            List<object[]> cacDong = danhSachNhap
                .Select((x, i) => new object[] { i + 1, x.MaSanPham, x.TenSanPham, x.SoLuong, x.GiaNhap, x.ThanhTien })
                .ToList();
            object[] dongTong = { "", "", "TỔNG CỘNG", danhSachNhap.Sum(x => x.SoLuong), "", phieuNhapBUS.TinhTongTien(danhSachNhap) };

            XuatFile.XuatExcel(this, "PhieuNhap_Nhap_" + DateTime.Now.ToString("yyyyMMdd_HHmm"),
                               "PHIẾU NHẬP HÀNG (CHƯA XÁC NHẬN)", thongTin, cacCot, cacDong, dongTong);
        }

        // Vẽ lại lưới và tính lại tổng tiền
        private void CapNhatDanhSachNhap()
        {
            bsNhap.ResetBindings(false);
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            lblTongTien.Text = phieuNhapBUS.TinhTongTien(danhSachNhap).ToString("N0", viVN) + " đ";
        }

        // Xác nhận nhập hàng: lưu phiếu, chi tiết và cộng tồn kho (một transaction trong DAO)
        private void btnXacNhanNhap_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhaCungCap.Focus();
                return;
            }
            if (danhSachNhap.Count == 0)
            {
                MessageBox.Show("Danh sách hàng nhập đang trống. Vui lòng thêm sản phẩm.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (PhienLamViec.NhanVien == null)
            {
                MessageBox.Show("Chưa xác định được nhân viên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult hoi = MessageBox.Show(
                "Xác nhận nhập hàng từ \"" + cboNhaCungCap.Text + "\"?\n\n"
                + "Số mặt hàng: " + danhSachNhap.Count + "\n"
                + "Tổng tiền: " + phieuNhapBUS.TinhTongTien(danhSachNhap).ToString("N0", viVN) + " đ\n\n"
                + "Tồn kho sẽ được cộng thêm ngay sau khi xác nhận.\n"
                + "Giá nhập của từng sản phẩm được tính lại = trung bình các lần nhập (theo số lượng); giá bán tự cập nhật với sản phẩm có tỷ lệ lãi.",
                "Xác nhận nhập hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            Cursor = Cursors.WaitCursor;
            KetQua ketQua;
            try
            {
                ketQua = phieuNhapBUS.NhapHang(Convert.ToString(cboNhaCungCap.SelectedValue),
                                               PhienLamViec.NhanVien.MaNhanVien, txtGhiChu.Text, danhSachNhap);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Nhập hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiPhieu();
            TaiDanhSachSanPham(txtTimKiemSP.Text.Trim());     // tải lại để thấy tồn kho mới
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            if (danhSachNhap.Count == 0 && cboNhaCungCap.SelectedIndex < 0 && txtGhiChu.Text.Length == 0) return;

            DialogResult hoi = MessageBox.Show("Hủy phiếu nhập đang lập? Dữ liệu chưa xác nhận sẽ bị xóa.", "Hủy phiếu",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes) LamMoiPhieu();
        }

        // Đưa phiếu đang lập về trạng thái trống
        private void LamMoiPhieu()
        {
            danhSachNhap.Clear();
            cboNhaCungCap.SelectedIndex = -1;
            txtGhiChu.Clear();
            nudSoLuong.Value = 1;
            lblNgayNhap.Text = "Ngày nhập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm", viVN);
            CapNhatDanhSachNhap();
        }

        /* ===================== TAB 2: LỊCH SỬ PHIẾU NHẬP ===================== */

        // Tải danh sách phiếu nhập theo từ khóa và khoảng ngày
        private void TaiLichSu()
        {
            try
            {
                DateTime? tuNgay = dtpTuNgayPN.Checked ? (DateTime?)dtpTuNgayPN.Value.Date : null;
                DateTime? denNgay = dtpDenNgayPN.Checked ? (DateTime?)dtpDenNgayPN.Value.Date : null;

                List<PhieuNhapDTO> danhSach = phieuNhapBUS.TimKiem(txtTimKiemPN.Text.Trim(), tuNgay, denNgay);
                dgvPhieuNhap.DataSource = danhSach;

                decimal tongTien = danhSach.Sum(x => x.TongTien);
                lblTongSoPN.Text = "Tổng: " + danhSach.Count + " phiếu nhập   •   Tổng tiền nhập: "
                                   + tongTien.ToString("N0", viVN) + " đ";

                if (danhSach.Count == 0)
                {
                    dgvPhieuNhap.ClearSelection();
                    XoaChiTietPN();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không tải được lịch sử phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiemPN_Click(object sender, EventArgs e)
        {
            TaiLichSu();
        }

        private void txtTimKiemPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiLichSu();
            }
        }

        private void btnBoLocPN_Click(object sender, EventArgs e)
        {
            txtTimKiemPN.Clear();
            dtpTuNgayPN.Checked = false;
            dtpDenNgayPN.Checked = false;
            TaiLichSu();
        }

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0) return;

            PhieuNhapDTO phieu = dgvPhieuNhap.SelectedRows[0].DataBoundItem as PhieuNhapDTO;
            if (phieu != null) HienChiTietPN(phieu);
        }

        private void HienChiTietPN(PhieuNhapDTO phieu)
        {
            maPhieuDangChon = phieu.MaPhieuNhap;
            txtPNMaPhieu.Text = phieu.MaPhieuNhap;
            txtPNNgayNhap.Text = phieu.NgayNhap.ToString("dd/MM/yyyy HH:mm", viVN);
            txtPNNhaCungCap.Text = phieu.TenNhaCungCap;
            txtPNNhanVien.Text = phieu.TenNhanVien;
            txtPNTongTien.Text = phieu.TongTien.ToString("N0", viVN);
            txtPNGhiChu.Text = phieu.GhiChu ?? "";

            try
            {
                dgvChiTietPN.DataSource = phieuNhapBUS.LayChiTiet(phieu.MaPhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được chi tiết phiếu nhập.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaChiTietPN()
        {
            maPhieuDangChon = null;
            txtPNMaPhieu.Clear();
            txtPNNgayNhap.Clear();
            txtPNNhaCungCap.Clear();
            txtPNNhanVien.Clear();
            txtPNTongTien.Clear();
            txtPNGhiChu.Clear();
            dgvChiTietPN.DataSource = null;
        }

        // Xuất danh sách phiếu nhập đang hiển thị (đã lọc) ra file Excel
        private void btnXuatDanhSach_Click(object sender, EventArgs e)
        {
            List<PhieuNhapDTO> danhSach = dgvPhieuNhap.DataSource as List<PhieuNhapDTO>;
            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Không có phiếu nhập nào để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string[]> thongTin = new List<string[]>();
            thongTin.Add(new string[] { "Số phiếu nhập:", danhSach.Count.ToString(viVN) });
            thongTin.Add(new string[] { "Xuất lúc:", DateTime.Now.ToString("dd/MM/yyyy HH:mm", viVN) });

            string[] cacCot = { "STT", "Mã phiếu", "Ngày nhập", "Nhà cung cấp", "Nhân viên", "Tổng tiền (đ)", "Ghi chú" };
            List<object[]> cacDong = danhSach
                .Select((x, i) => new object[] { i + 1, x.MaPhieuNhap, x.NgayNhap, x.TenNhaCungCap, x.TenNhanVien, x.TongTien, x.GhiChu })
                .ToList();
            object[] dongTong = { "", "", "", "", "TỔNG CỘNG", danhSach.Sum(x => x.TongTien), "" };

            XuatFile.XuatExcel(this, "DanhSachPhieuNhap_" + DateTime.Now.ToString("yyyyMMdd_HHmm"),
                               "DANH SÁCH PHIẾU NHẬP", thongTin, cacCot, cacDong, dongTong);
        }

        // Xuất chi tiết của phiếu nhập đang chọn ra file Excel
        private void btnXuatChiTiet_Click(object sender, EventArgs e)
        {
            if (maPhieuDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                PhieuNhapDTO phieu = phieuNhapBUS.LayTheoMa(maPhieuDangChon);
                List<ChiTietPhieuNhapDTO> chiTiet = phieuNhapBUS.LayChiTiet(maPhieuDangChon);
                if (phieu == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập. Danh sách sẽ được tải lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiLichSu();
                    return;
                }

                List<string[]> thongTin = new List<string[]>();
                thongTin.Add(new string[] { "Mã phiếu nhập:", phieu.MaPhieuNhap });
                thongTin.Add(new string[] { "Ngày nhập:", phieu.NgayNhap.ToString("dd/MM/yyyy HH:mm", viVN) });
                thongTin.Add(new string[] { "Nhà cung cấp:", phieu.TenNhaCungCap });
                thongTin.Add(new string[] { "Nhân viên lập phiếu:", phieu.TenNhanVien });
                thongTin.Add(new string[] { "Ghi chú:", phieu.GhiChu ?? "" });

                string[] cacCot = { "STT", "Mã sản phẩm", "Tên sản phẩm", "Số lượng", "Giá nhập (đ)", "Thành tiền (đ)" };
                List<object[]> cacDong = chiTiet
                    .Select((x, i) => new object[] { i + 1, x.MaSanPham, x.TenSanPham, x.SoLuong, x.GiaNhap, x.ThanhTien })
                    .ToList();
                object[] dongTong = { "", "", "TỔNG CỘNG", chiTiet.Sum(x => x.SoLuong), "", phieu.TongTien };

                XuatFile.XuatExcel(this, "PhieuNhap_" + phieu.MaPhieuNhap, "PHIẾU NHẬP HÀNG " + phieu.MaPhieuNhap,
                                   thongTin, cacCot, cacDong, dongTong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xuất được phiếu nhập.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa phiếu nhập: tồn kho bị trừ lại; nếu hàng đã bán bớt thì BUS/DAO báo lỗi và không xóa
        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (maPhieuDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show(
                "Bạn có chắc muốn xóa phiếu nhập " + maPhieuDangChon + "?\n"
                + "Số lượng đã nhập sẽ bị trừ lại khỏi tồn kho. Thao tác này không thể hoàn tác.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (hoi != DialogResult.Yes) return;

            KetQua ketQua = phieuNhapBUS.Xoa(maPhieuDangChon);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiLichSu();
            TaiDanhSachSanPham(txtTimKiemSP.Text.Trim());     // tồn kho đã đổi
        }
    }
}