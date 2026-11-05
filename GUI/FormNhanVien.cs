using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form quản lý nhân viên: xem, tìm kiếm, thêm, sửa, xóa.
    /// Giao diện nằm trong FormNhanVien.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormNhanVien : Form
    {
        // Đối tượng BUS xử lý nghiệp vụ
        private readonly NhanVienBUS bus = new NhanVienBUS();

        // Đang ở chế độ sửa (đã chọn một dòng) hay chế độ nhập mới
        private bool dangSua;

        // Mã của dòng đang chọn
        private string maDangChon;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            TaiDanhSach("");
            LamMoiForm();
        }

        // Phân quyền
        private void PhanQuyen()
        {
            // Chức năng dành cho quản trị viên: người khác chỉ được xem
            if (!PhienLamViec.LaQuanTri)
            {
                pnlThongTin.Enabled = false;
            }
        }

        /* ===================== DANH SÁCH VÀ TÌM KIẾM ===================== */

        // Tải danh sách (tuKhoa rỗng = tất cả) lên DataGridView
        private void TaiDanhSach(string tuKhoa)
        {
            try
            {
                List<NhanVienDTO> danhSach = bus.TimKiem(tuKhoa);
                dgvNhanVien.DataSource = danhSach;
                lblTongSo.Text = "Tổng: " + danhSach.Count + " nhân viên";

                if (danhSach.Count == 0)
                {
                    dgvNhanVien.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách nhân viên.\n" + ex.Message, "Lỗi",
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
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0) return;

            NhanVienDTO doiTuong = dgvNhanVien.SelectedRows[0].DataBoundItem as NhanVienDTO;
            if (doiTuong != null) HienChiTiet(doiTuong);
        }

        // Hiển thị chữ thay cho true/false ở cột trạng thái
        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colTrangThai" && e.Value is bool)
            {
                bool giaTri = (bool)e.Value;
                e.Value = giaTri ? "Đang làm" : "Nghỉ việc";
                e.CellStyle.ForeColor = giaTri ? Color.FromArgb(46, 125, 50) : Color.FromArgb(198, 40, 40);
                e.FormattingApplied = true;
            }
        }

        // Chọn lại dòng có mã tương ứng sau khi tải lại danh sách
        private void ChonDong(string ma)
        {
            foreach (DataGridViewRow dong in dgvNhanVien.Rows)
            {
                NhanVienDTO doiTuong = dong.DataBoundItem as NhanVienDTO;
                if (doiTuong != null && doiTuong.MaNhanVien == ma)
                {
                    dgvNhanVien.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== VÙNG NHẬP LIỆU ===================== */

        // Đưa dữ liệu của một dòng lên các ô nhập
        private void HienChiTiet(NhanVienDTO doiTuong)
        {
            dangSua = true;
            maDangChon = doiTuong.MaNhanVien;
            txtMaNhanVien.Text = doiTuong.MaNhanVien;
            txtMaNhanVien.ReadOnly = true;            // không cho đổi mã khi đang sửa
            txtHoTen.Text = doiTuong.HoTen ?? "";
            cboGioiTinh.SelectedIndex = cboGioiTinh.Items.IndexOf(doiTuong.GioiTinh);
            if (doiTuong.NgaySinh.HasValue)
            {
                dtpNgaySinh.Value = doiTuong.NgaySinh.Value;
                dtpNgaySinh.Checked = true;
            }
            else
            {
                dtpNgaySinh.Checked = false;
            }
            txtSoDienThoai.Text = doiTuong.SoDienThoai ?? "";
            txtEmail.Text = doiTuong.Email ?? "";
            txtDiaChi.Text = doiTuong.DiaChi ?? "";
            dtpNgayVaoLam.Value = doiTuong.NgayVaoLam;
            chkDangLamViec.Checked = doiTuong.TrangThai;
        }

        // Xóa trắng form để nhập mới
        private void LamMoiForm()
        {
            dangSua = false;
            maDangChon = null;
            try
            {
                txtMaNhanVien.Text = bus.TaoMaMoi();
            }
            catch (Exception)
            {
                txtMaNhanVien.Text = "";
            }
            txtMaNhanVien.ReadOnly = false;
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            dtpNgaySinh.Checked = false;
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNgayVaoLam.Value = DateTime.Today;
            chkDangLamViec.Checked = true;
            dgvNhanVien.ClearSelection();
            txtHoTen.Focus();
        }

        // Đọc dữ liệu từ các ô nhập thành một đối tượng DTO
        private NhanVienDTO LayDuLieuTuForm()
        {
            NhanVienDTO doiTuong = new NhanVienDTO();
            doiTuong.MaNhanVien = txtMaNhanVien.Text.Trim();
            doiTuong.HoTen = txtHoTen.Text.Trim();
            doiTuong.GioiTinh = cboGioiTinh.SelectedItem == null ? "" : cboGioiTinh.SelectedItem.ToString();
            doiTuong.NgaySinh = dtpNgaySinh.Checked ? (DateTime?)dtpNgaySinh.Value.Date : null;
            doiTuong.SoDienThoai = txtSoDienThoai.Text.Trim();
            doiTuong.Email = txtEmail.Text.Trim();
            doiTuong.DiaChi = txtDiaChi.Text.Trim();
            doiTuong.NgayVaoLam = dtpNgayVaoLam.Value.Date;
            doiTuong.TrangThai = chkDangLamViec.Checked;
            return doiTuong;
        }

        /* ===================== THÊM / SỬA / XÓA / LÀM MỚI ===================== */

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO doiTuong = LayDuLieuTuForm();
            KetQua ketQua = bus.Them(doiTuong);

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không thêm được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            LamMoiForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NhanVienDTO doiTuong = LayDuLieuTuForm();
            doiTuong.MaNhanVien = maDangChon;
            KetQua ketQua = bus.Sua(doiTuong);

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không sửa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            ChonDong(maDangChon);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa nhân viên \"" + txtHoTen.Text + "\"?",
                                               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            KetQua ketQua = bus.Xoa(maDangChon);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            LamMoiForm();
        }

        // Làm mới: xóa ô tìm kiếm, tải lại danh sách đầy đủ và chuẩn bị nhập mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDanhSach("");
            LamMoiForm();
        }
    }
}