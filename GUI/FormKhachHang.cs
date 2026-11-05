using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form quản lý khách hàng: xem, tìm kiếm, thêm, sửa, xóa.
    /// Giao diện nằm trong FormKhachHang.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormKhachHang : Form
    {
        // Đối tượng BUS xử lý nghiệp vụ
        private readonly KhachHangBUS bus = new KhachHangBUS();

        // Đang ở chế độ sửa (đã chọn một dòng) hay chế độ nhập mới
        private bool dangSua;

        // Mã của dòng đang chọn
        private string maDangChon;

        public FormKhachHang()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            TaiDanhSach("");
            LamMoiForm();
        }

        // Phân quyền
        private void PhanQuyen()
        {
            // Nhân viên bán hàng được thêm/sửa nhưng không được xóa
            if (!PhienLamViec.LaQuanTri)
            {
                btnXoa.Enabled = false;
            }
        }

        /* ===================== DANH SÁCH VÀ TÌM KIẾM ===================== */

        // Tải danh sách (tuKhoa rỗng = tất cả) lên DataGridView
        private void TaiDanhSach(string tuKhoa)
        {
            try
            {
                List<KhachHangDTO> danhSach = bus.TimKiem(tuKhoa);
                dgvKhachHang.DataSource = danhSach;
                lblTongSo.Text = "Tổng: " + danhSach.Count + " khách hàng";

                if (danhSach.Count == 0)
                {
                    dgvKhachHang.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách khách hàng.\n" + ex.Message, "Lỗi",
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
        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0) return;

            KhachHangDTO doiTuong = dgvKhachHang.SelectedRows[0].DataBoundItem as KhachHangDTO;
            if (doiTuong != null) HienChiTiet(doiTuong);
        }

        // Chọn lại dòng có mã tương ứng sau khi tải lại danh sách
        private void ChonDong(string ma)
        {
            foreach (DataGridViewRow dong in dgvKhachHang.Rows)
            {
                KhachHangDTO doiTuong = dong.DataBoundItem as KhachHangDTO;
                if (doiTuong != null && doiTuong.MaKhachHang == ma)
                {
                    dgvKhachHang.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== VÙNG NHẬP LIỆU ===================== */

        // Đưa dữ liệu của một dòng lên các ô nhập
        private void HienChiTiet(KhachHangDTO doiTuong)
        {
            dangSua = true;
            maDangChon = doiTuong.MaKhachHang;
            txtMaKhachHang.Text = doiTuong.MaKhachHang;
            txtMaKhachHang.ReadOnly = true;            // không cho đổi mã khi đang sửa
            txtNgayTao.Text = doiTuong.NgayTao.ToString("dd/MM/yyyy HH:mm");
            txtHoTen.Text = doiTuong.HoTen ?? "";
            txtSoDienThoai.Text = doiTuong.SoDienThoai ?? "";
            txtEmail.Text = doiTuong.Email ?? "";
            txtDiaChi.Text = doiTuong.DiaChi ?? "";
        }

        // Xóa trắng form để nhập mới
        private void LamMoiForm()
        {
            dangSua = false;
            maDangChon = null;
            try
            {
                txtMaKhachHang.Text = bus.TaoMaMoi();
            }
            catch (Exception)
            {
                txtMaKhachHang.Text = "";
            }
            txtMaKhachHang.ReadOnly = false;
            txtNgayTao.Text = "(tự động)";
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dgvKhachHang.ClearSelection();
            txtHoTen.Focus();
        }

        // Đọc dữ liệu từ các ô nhập thành một đối tượng DTO
        private KhachHangDTO LayDuLieuTuForm()
        {
            KhachHangDTO doiTuong = new KhachHangDTO();
            doiTuong.MaKhachHang = txtMaKhachHang.Text.Trim();
            doiTuong.HoTen = txtHoTen.Text.Trim();
            doiTuong.SoDienThoai = txtSoDienThoai.Text.Trim();
            doiTuong.Email = txtEmail.Text.Trim();
            doiTuong.DiaChi = txtDiaChi.Text.Trim();
            return doiTuong;
        }

        /* ===================== THÊM / SỬA / XÓA / LÀM MỚI ===================== */

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO doiTuong = LayDuLieuTuForm();
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
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            KhachHangDTO doiTuong = LayDuLieuTuForm();
            doiTuong.MaKhachHang = maDangChon;
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
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa khách hàng \"" + txtHoTen.Text + "\"?",
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