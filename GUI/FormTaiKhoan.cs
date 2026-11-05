using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form tài khoản.
    ///  - Mọi người dùng: đổi mật khẩu của chính mình (phần phía dưới).
    ///  - Quản trị viên: xem danh sách, thêm/sửa/xóa tài khoản, phân quyền, khóa/mở khóa, đặt lại mật khẩu.
    /// Giao diện nằm trong FormTaiKhoan.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormTaiKhoan : Form
    {
        // Các đối tượng BUS
        private readonly TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private readonly NhanVienBUS nhanVienBUS = new NhanVienBUS();

        // Tên đăng nhập đang chọn trong lưới (null = đang ở chế độ thêm mới)
        private string tenDangNhapDangChon;

        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            string tenDangNhap = PhienLamViec.TaiKhoan != null ? PhienLamViec.TaiKhoan.TenDangNhap : "";
            lblTieuDeDoiMatKhau.Text = "ĐỔI MẬT KHẨU CỦA BẠN" + (tenDangNhap.Length > 0 ? "  (tài khoản: " + tenDangNhap + ")" : "");

            if (!PhienLamViec.LaQuanTri)
            {
                // Nhân viên bán hàng chỉ được đổi mật khẩu của mình: ẩn phần quản trị
                pnlThongTin.Visible = false;
                pnlDauDanhSach.Visible = false;
                dgvTaiKhoan.Visible = false;
                pnlDoiMatKhau.Dock = DockStyle.Top;
                return;
            }

            NapNhanVien();
            TaiDanhSach("");
            LamMoiForm();
        }

        // Đổ danh sách nhân viên vào combobox (hiển thị "mã - họ tên" nhờ sự kiện Format)
        private void NapNhanVien()
        {
            try
            {
                cboNhanVien.DataSource = nhanVienBUS.LayTatCa();
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNhanVien";
                cboNhanVien.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách nhân viên.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNhanVien_Format(object sender, ListControlConvertEventArgs e)
        {
            NhanVienDTO nhanVien = e.ListItem as NhanVienDTO;
            if (nhanVien != null) e.Value = nhanVien.MaNhanVien + " - " + nhanVien.HoTen;
        }

        /* ===================== DANH SÁCH TÀI KHOẢN ===================== */

        private void TaiDanhSach(string tuKhoa)
        {
            try
            {
                dgvTaiKhoan.DataSource = taiKhoanBUS.TimKiem(tuKhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách tài khoản.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSach(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSach(txtTimKiem.Text.Trim());
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0) return;

            TaiKhoanDTO taiKhoan = dgvTaiKhoan.SelectedRows[0].DataBoundItem as TaiKhoanDTO;
            if (taiKhoan != null) HienChiTiet(taiKhoan);
        }

        // Hiển thị tên vai trò và trạng thái bằng tiếng Việt
        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string tenCot = dgvTaiKhoan.Columns[e.ColumnIndex].Name;
            if (tenCot == "colVaiTro" && e.Value != null)
            {
                e.Value = Convert.ToString(e.Value) == PhienLamViec.VaiTroQuanTri ? "Quản trị viên" : "Nhân viên bán hàng";
                e.FormattingApplied = true;
            }
            else if (tenCot == "colTrangThai" && e.Value is bool)
            {
                bool hoatDong = (bool)e.Value;
                e.Value = hoatDong ? "Hoạt động" : "Đã khóa";
                e.CellStyle.ForeColor = hoatDong ? Color.FromArgb(46, 125, 50) : Color.FromArgb(198, 40, 40);
                e.FormattingApplied = true;
            }
        }

        // Chọn lại dòng có tên đăng nhập tương ứng sau khi tải lại danh sách
        private void ChonDong(string tenDangNhap)
        {
            foreach (DataGridViewRow dong in dgvTaiKhoan.Rows)
            {
                TaiKhoanDTO taiKhoan = dong.DataBoundItem as TaiKhoanDTO;
                if (taiKhoan != null && string.Equals(taiKhoan.TenDangNhap, tenDangNhap, StringComparison.OrdinalIgnoreCase))
                {
                    dgvTaiKhoan.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== VÙNG NHẬP LIỆU ===================== */

        private void HienChiTiet(TaiKhoanDTO taiKhoan)
        {
            tenDangNhapDangChon = taiKhoan.TenDangNhap;

            txtTenDangNhap.Text = taiKhoan.TenDangNhap;
            txtTenDangNhap.ReadOnly = true;         // không đổi tên đăng nhập khi đang sửa
            txtMatKhau.Clear();
            cboVaiTro.SelectedIndex = taiKhoan.VaiTro == PhienLamViec.VaiTroQuanTri ? 0 : 1;
            cboNhanVien.SelectedValue = taiKhoan.MaNhanVien;
            chkHoatDong.Checked = taiKhoan.TrangThai;
        }

        private void LamMoiForm()
        {
            tenDangNhapDangChon = null;

            txtTenDangNhap.Clear();
            txtTenDangNhap.ReadOnly = false;
            txtMatKhau.Clear();
            cboVaiTro.SelectedIndex = 1;            // mặc định: nhân viên bán hàng
            cboNhanVien.SelectedIndex = -1;
            chkHoatDong.Checked = true;

            dgvTaiKhoan.ClearSelection();
            txtTenDangNhap.Focus();
        }

        // Đọc dữ liệu từ ô nhập (mật khẩu được truyền riêng cho BUS)
        private TaiKhoanDTO LayDuLieuTuForm()
        {
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
            taiKhoan.TenDangNhap = txtTenDangNhap.Text.Trim();
            taiKhoan.VaiTro = cboVaiTro.SelectedIndex == 0 ? PhienLamViec.VaiTroQuanTri : PhienLamViec.VaiTroBanHang;
            taiKhoan.MaNhanVien = cboNhanVien.SelectedValue == null ? "" : cboNhanVien.SelectedValue.ToString();
            taiKhoan.TrangThai = chkHoatDong.Checked;
            return taiKhoan;
        }

        /* ===================== THÊM / SỬA / XÓA / ĐẶT LẠI MẬT KHẨU ===================== */

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taiKhoan = LayDuLieuTuForm();
            KetQua ketQua = taiKhoanBUS.Them(taiKhoan, txtMatKhau.Text);

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
            if (tenDangNhapDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TaiKhoanDTO taiKhoan = LayDuLieuTuForm();
            taiKhoan.TenDangNhap = tenDangNhapDangChon;
            KetQua ketQua = taiKhoanBUS.Sua(taiKhoan);

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không sửa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string ten = tenDangNhapDangChon;
            TaiDanhSach(txtTimKiem.Text.Trim());
            ChonDong(ten);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tenDangNhapDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa tài khoản \"" + tenDangNhapDangChon + "\"?",
                                               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            KetQua ketQua = taiKhoanBUS.Xoa(tenDangNhapDangChon);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach(txtTimKiem.Text.Trim());
            LamMoiForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDanhSach("");
            LamMoiForm();
        }

        // Quản trị viên đặt lại mật khẩu cho tài khoản đang chọn, mật khẩu mới lấy từ ô "Mật khẩu"
        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (tenDangNhapDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần đặt lại mật khẩu trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới vào ô \"Mật khẩu\".", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            DialogResult hoi = MessageBox.Show("Đặt lại mật khẩu cho tài khoản \"" + tenDangNhapDangChon + "\"?",
                                               "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            KetQua ketQua = taiKhoanBUS.DatLaiMatKhau(tenDangNhapDangChon, txtMatKhau.Text);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không đặt lại được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMatKhau.Clear();
        }

        /* ===================== ĐỔI MẬT KHẨU CỦA CHÍNH MÌNH ===================== */

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool an = !chkHienMatKhau.Checked;
            txtMatKhauCu.UseSystemPasswordChar = an;
            txtMatKhauMoi.UseSystemPasswordChar = an;
            txtXacNhanMatKhau.UseSystemPasswordChar = an;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (PhienLamViec.TaiKhoan == null)
            {
                MessageBox.Show("Chưa xác định được tài khoản đang đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KetQua ketQua = taiKhoanBUS.DoiMatKhau(PhienLamViec.TaiKhoan.TenDangNhap,
                                                   txtMatKhauCu.Text, txtMatKhauMoi.Text, txtXacNhanMatKhau.Text);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không đổi được mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhanMatKhau.Clear();
        }
    }
}