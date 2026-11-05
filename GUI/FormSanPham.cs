using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form quản lý sản phẩm: xem, tìm kiếm, thêm, sửa, xóa, chọn ảnh.
    /// Giao diện nằm trong FormSanPham.Designer.cs, file này chỉ xử lý logic.
    /// Nhân viên bán hàng chỉ được xem (các nút và ô nhập bị khóa).
    /// </summary>
    public partial class FormSanPham : Form
    {
        // Các đối tượng BUS
        private readonly SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private readonly DanhMucBUS danhMucBUS = new DanhMucBUS();
        private readonly ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        private readonly KichThuocBUS kichThuocBUS = new KichThuocBUS();
        private readonly MauSacBUS mauSacBUS = new MauSacBUS();
        private readonly ChatLieuBUS chatLieuBUS = new ChatLieuBUS();
        private readonly NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

        // Mã sản phẩm đang được chọn trong lưới (null = đang ở chế độ nhập sản phẩm mới)
        private string maDangChon;

        // Tên file ảnh hiện có của sản phẩm đang chọn (lưu trong CSDL)
        private string tenFileAnhHienTai;

        // Đường dẫn file ảnh người dùng vừa chọn (chưa sao chép vào thư mục Images)
        private string duongDanAnhMoi;

        // Cờ để bỏ qua sự kiện ValueChanged khi chương trình tự gán giá trị lên các ô nhập
        private bool dangNap;

        // Thư mục chứa ảnh sản phẩm: cùng thư mục với file chạy (bin\Debug\Images)
        private static string ThuMucAnh
        {
            get { return Path.Combine(Application.StartupPath, "Images"); }
        }

        public FormSanPham()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                NapDanhSachLuaChon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh mục lựa chọn.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PhanQuyen();
            TaiDanhSach("");

            // Quản trị viên: mở form ở trạng thái sẵn sàng nhập sản phẩm mới
            if (PhienLamViec.LaQuanTri) LamMoiForm();
        }

        // Nhân viên bán hàng chỉ được xem: khóa toàn bộ vùng nhập liệu
        private void PhanQuyen()
        {
            if (!PhienLamViec.LaQuanTri)
            {
                pnlThongTin.Enabled = false;
                lblChiXem.Visible = true;
            }
        }

        // Đổ dữ liệu vào các combobox
        private void NapDanhSachLuaChon()
        {
            cboDanhMuc.DataSource = danhMucBUS.LayTatCa();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";

            cboThuongHieu.DataSource = thuongHieuBUS.LayTatCa();
            cboThuongHieu.DisplayMember = "TenThuongHieu";
            cboThuongHieu.ValueMember = "MaThuongHieu";

            cboKichThuoc.DataSource = kichThuocBUS.LayTatCa();
            cboKichThuoc.DisplayMember = "TenKichThuoc";
            cboKichThuoc.ValueMember = "MaKichThuoc";

            cboMauSac.DataSource = mauSacBUS.LayTatCa();
            cboMauSac.DisplayMember = "TenMauSac";
            cboMauSac.ValueMember = "MaMauSac";

            cboChatLieu.DataSource = chatLieuBUS.LayTatCa();
            cboChatLieu.DisplayMember = "TenChatLieu";
            cboChatLieu.ValueMember = "MaChatLieu";

            cboNhaCungCap.DataSource = nhaCungCapBUS.LayTatCa();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "MaNhaCungCap";
        }

        /* ===================== DANH SÁCH VÀ TÌM KIẾM ===================== */

        // Tải danh sách sản phẩm (tuKhoa rỗng = tất cả) lên DataGridView
        private void TaiDanhSach(string tuKhoa)
        {
            try
            {
                List<SanPhamDTO> danhSach = sanPhamBUS.TimKiem(tuKhoa);
                dgvSanPham.DataSource = danhSach;
                lblTongSo.Text = "Tổng: " + danhSach.Count + " sản phẩm";

                if (danhSach.Count == 0)
                {
                    dgvSanPham.ClearSelection();
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
            TaiDanhSach(txtTimKiem.Text.Trim());
        }

        // Nhấn Enter trong ô tìm kiếm thì tìm luôn
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSach(txtTimKiem.Text.Trim());
            }
        }

        // Chọn một dòng trong lưới thì hiện chi tiết sang vùng nhập liệu
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0) return;

            SanPhamDTO sanPham = dgvSanPham.SelectedRows[0].DataBoundItem as SanPhamDTO;
            if (sanPham != null) HienChiTiet(sanPham);
        }

        // Hiển thị "Đang kinh doanh / Ngừng kinh doanh" và tô đỏ số lượng tồn thấp
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string tenCot = dgvSanPham.Columns[e.ColumnIndex].Name;
            if (tenCot == "colTrangThai" && e.Value is bool)
            {
                e.Value = (bool)e.Value ? "Đang kinh doanh" : "Ngừng kinh doanh";
                e.FormattingApplied = true;
            }
            else if (tenCot == "colSoLuongTon" && e.Value != null)
            {
                int ton;
                if (int.TryParse(Convert.ToString(e.Value), out ton) && ton <= SanPhamBUS.NguongTonKhoThap)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);
                }
            }
        }

        // Chọn lại dòng có mã tương ứng sau khi tải lại danh sách
        private void ChonDong(string maSanPham)
        {
            foreach (DataGridViewRow dong in dgvSanPham.Rows)
            {
                SanPhamDTO sanPham = dong.DataBoundItem as SanPhamDTO;
                if (sanPham != null && sanPham.MaSanPham == maSanPham)
                {
                    dgvSanPham.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== VÙNG NHẬP LIỆU ===================== */

        // Đưa dữ liệu của một sản phẩm lên các ô nhập
        private void HienChiTiet(SanPhamDTO sanPham)
        {
            maDangChon = sanPham.MaSanPham;
            tenFileAnhHienTai = sanPham.HinhAnh;
            duongDanAnhMoi = null;

            txtMaSanPham.Text = sanPham.MaSanPham;
            txtMaSanPham.ReadOnly = true;            // không cho đổi mã khi đang sửa
            txtTenSanPham.Text = sanPham.TenSanPham;
            cboDanhMuc.SelectedValue = sanPham.MaDanhMuc;
            cboThuongHieu.SelectedValue = sanPham.MaThuongHieu;
            cboKichThuoc.SelectedValue = sanPham.MaKichThuoc;
            cboMauSac.SelectedValue = sanPham.MaMauSac;
            cboChatLieu.SelectedValue = sanPham.MaChatLieu;
            cboNhaCungCap.SelectedValue = sanPham.MaNhaCungCap;
            dangNap = true;
            GanSo(nudGiaNhap, sanPham.GiaNhap);
            GanSo(nudTyLeLai, sanPham.TyLeLai);
            GanSo(nudGiaBan, sanPham.GiaBan);
            dangNap = false;
            CapNhatCheDoGiaBan();
            GanSo(nudSoLuongTon, sanPham.SoLuongTon);
            chkDangKinhDoanh.Checked = sanPham.TrangThai;
            txtMoTa.Text = sanPham.MoTa ?? "";

            HienAnh(sanPham.HinhAnh);
        }

        // Gán giá trị cho NumericUpDown, tránh lỗi khi vượt giới hạn
        private void GanSo(NumericUpDown o, decimal giaTri)
        {
            o.Value = Math.Min(Math.Max(giaTri, o.Minimum), o.Maximum);
        }

        // Xóa trắng form để nhập sản phẩm mới (mã mới được sinh sẵn)
        private void LamMoiForm()
        {
            maDangChon = null;
            tenFileAnhHienTai = null;
            duongDanAnhMoi = null;

            try
            {
                txtMaSanPham.Text = sanPhamBUS.TaoMaMoi();
            }
            catch (Exception)
            {
                txtMaSanPham.Text = "";
            }
            txtMaSanPham.ReadOnly = false;
            txtTenSanPham.Clear();
            cboDanhMuc.SelectedIndex = -1;
            cboThuongHieu.SelectedIndex = -1;
            cboKichThuoc.SelectedIndex = -1;
            cboMauSac.SelectedIndex = -1;
            cboChatLieu.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            dangNap = true;
            nudGiaNhap.Value = 0;
            nudTyLeLai.Value = 0;
            nudGiaBan.Value = 0;
            dangNap = false;
            CapNhatCheDoGiaBan();
            nudSoLuongTon.Value = 0;
            chkDangKinhDoanh.Checked = true;
            txtMoTa.Clear();
            HienAnh(null);

            dgvSanPham.ClearSelection();
            txtTenSanPham.Focus();
        }

        // Đọc dữ liệu từ các ô nhập thành một SanPhamDTO
        private SanPhamDTO LayDuLieuTuForm()
        {
            SanPhamDTO sanPham = new SanPhamDTO();
            sanPham.MaSanPham = txtMaSanPham.Text.Trim();
            sanPham.TenSanPham = txtTenSanPham.Text.Trim();
            sanPham.MaDanhMuc = LayMaSo(cboDanhMuc);
            sanPham.MaThuongHieu = LayMaSo(cboThuongHieu);
            sanPham.MaKichThuoc = LayMaSo(cboKichThuoc);
            sanPham.MaMauSac = LayMaSo(cboMauSac);
            sanPham.MaChatLieu = LayMaSo(cboChatLieu);
            sanPham.MaNhaCungCap = cboNhaCungCap.SelectedValue == null ? "" : cboNhaCungCap.SelectedValue.ToString();
            sanPham.GiaNhap = nudGiaNhap.Value;
            sanPham.GiaBan = nudGiaBan.Value;
            sanPham.TyLeLai = nudTyLeLai.Value;
            sanPham.SoLuongTon = (int)nudSoLuongTon.Value;
            sanPham.TrangThai = chkDangKinhDoanh.Checked;
            sanPham.MoTa = txtMoTa.Text;

            // Có chọn ảnh mới thì đặt tên file theo mã sản phẩm (vd sp001.jpg); không thì giữ ảnh cũ
            if (duongDanAnhMoi != null)
                sanPham.HinhAnh = sanPham.MaSanPham.ToLower() + Path.GetExtension(duongDanAnhMoi).ToLower();
            else
                sanPham.HinhAnh = tenFileAnhHienTai;

            return sanPham;
        }

        // Lấy mã số của mục đang chọn trong combobox (0 nếu chưa chọn)
        private int LayMaSo(ComboBox cbo)
        {
            return cbo.SelectedValue == null ? 0 : Convert.ToInt32(cbo.SelectedValue);
        }

        /* ===================== TÍNH GIÁ BÁN ===================== */
        // Công thức: giá bán = giá nhập (giá vốn) x (1 + tỷ lệ lãi / 100)
        // Ví dụ: giá vốn 90.000, lãi 40% -> 90.000 x 1,4 = 126.000.
        // Tỷ lệ lãi > 0: giá bán tự tính (và tự cập nhật khi giá nhập đổi, kể cả khi nhập hàng).
        // Tỷ lệ lãi = 0: người dùng tự nhập giá bán.

        private void nudGiaNhap_ValueChanged(object sender, EventArgs e)
        {
            TinhLaiGiaBan();
        }

        private void nudTyLeLai_ValueChanged(object sender, EventArgs e)
        {
            TinhLaiGiaBan();
        }

        // Người dùng đổi giá nhập hoặc tỷ lệ lãi: tính lại giá bán (nếu có tỷ lệ lãi)
        private void TinhLaiGiaBan()
        {
            if (dangNap) return;

            if (nudTyLeLai.Value > 0)
            {
                GanSo(nudGiaBan, SanPhamBUS.TinhGiaBan(nudGiaNhap.Value, nudTyLeLai.Value));
            }
            CapNhatCheDoGiaBan();
        }

        // Có tỷ lệ lãi thì khóa ô giá bán (tự tính), ngược lại cho nhập tay
        private void CapNhatCheDoGiaBan()
        {
            bool tuTinh = nudTyLeLai.Value > 0;
            nudGiaBan.Enabled = !tuTinh && pnlThongTin.Enabled;
            lblGiaBan.Text = tuTinh ? "Giá bán (đ) - tự tính" : "Giá bán (đ)";
        }

        /* ===================== HÌNH ẢNH ===================== */

        // Hiện ảnh từ thư mục Images (không khóa file ảnh); không có ảnh thì để trống
        private void HienAnh(string tenFile)
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }
            if (string.IsNullOrWhiteSpace(tenFile)) return;

            NapAnhVaoPictureBox(Path.Combine(ThuMucAnh, tenFile));
        }

        // Đọc ảnh từ file rồi sao chép sang Bitmap để không bị khóa file
        private void NapAnhVaoPictureBox(string duongDan)
        {
            try
            {
                if (!File.Exists(duongDan)) return;
                using (Image goc = Image.FromFile(duongDan))
                {
                    picHinhAnh.Image = new Bitmap(goc);
                }
            }
            catch (Exception)
            {
                picHinhAnh.Image = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (ofdChonAnh.ShowDialog() != DialogResult.OK) return;

            FileInfo thongTin = new FileInfo(ofdChonAnh.FileName);
            if (thongTin.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("Ảnh quá lớn (tối đa 5 MB). Vui lòng chọn ảnh nhỏ hơn.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            duongDanAnhMoi = ofdChonAnh.FileName;
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }
            NapAnhVaoPictureBox(duongDanAnhMoi);
        }

        // Sao chép ảnh vừa chọn vào thư mục Images sau khi lưu sản phẩm thành công
        private void LuuFileAnh(SanPhamDTO sanPham)
        {
            if (duongDanAnhMoi == null) return;

            try
            {
                Directory.CreateDirectory(ThuMucAnh);
                string dich = Path.Combine(ThuMucAnh, sanPham.HinhAnh);
                File.Copy(duongDanAnhMoi, dich, true);
                tenFileAnhHienTai = sanPham.HinhAnh;
                duongDanAnhMoi = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã lưu sản phẩm nhưng không sao chép được ảnh.\n" + ex.Message, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* ===================== THÊM / SỬA / XÓA / LÀM MỚI ===================== */

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamDTO sanPham = LayDuLieuTuForm();
            KetQua ketQua = sanPhamBUS.Them(sanPham);

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không thêm được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LuuFileAnh(sanPham);
            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            ChonDong(ketQua.MaMoi);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SanPhamDTO sanPham = LayDuLieuTuForm();
            sanPham.MaSanPham = maDangChon;
            if (duongDanAnhMoi != null)
                sanPham.HinhAnh = maDangChon.ToLower() + Path.GetExtension(duongDanAnhMoi).ToLower();

            KetQua ketQua = sanPhamBUS.Sua(sanPham);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không sửa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LuuFileAnh(sanPham);
            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            ChonDong(maDangChon);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + maDangChon + " - " + txtTenSanPham.Text + "?",
                                               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            KetQua ketQua = sanPhamBUS.Xoa(maDangChon);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            LamMoiForm();
        }

        // Làm mới: xóa ô tìm kiếm, tải lại danh sách đầy đủ và chuẩn bị nhập sản phẩm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDanhSach("");
            LamMoiForm();
        }
    }
}