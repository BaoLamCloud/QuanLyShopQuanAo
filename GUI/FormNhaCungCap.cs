using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form quản lý nhà cung cấp: xem, tìm kiếm, thêm, sửa, xóa.
    /// Giao diện nằm trong FormNhaCungCap.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormNhaCungCap : Form
    {
        // Đối tượng BUS xử lý nghiệp vụ
        private readonly NhaCungCapBUS bus = new NhaCungCapBUS();

        // Đang ở chế độ sửa (đã chọn một dòng) hay chế độ nhập mới
        private bool dangSua;

        // Mã của dòng đang chọn
        private string maDangChon;

        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormNhaCungCap_Load(object sender, EventArgs e)
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
                List<NhaCungCapDTO> danhSach = bus.TimKiem(tuKhoa);
                dgvNhaCungCap.DataSource = danhSach;
                lblTongSo.Text = "Tổng: " + danhSach.Count + " nhà cung cấp";

                if (danhSach.Count == 0)
                {
                    dgvNhaCungCap.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách nhà cung cấp.\n" + ex.Message, "Lỗi",
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
        private void dgvNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count == 0) return;

            NhaCungCapDTO doiTuong = dgvNhaCungCap.SelectedRows[0].DataBoundItem as NhaCungCapDTO;
            if (doiTuong != null) HienChiTiet(doiTuong);
        }

        // Chọn lại dòng có mã tương ứng sau khi tải lại danh sách
        private void ChonDong(string ma)
        {
            foreach (DataGridViewRow dong in dgvNhaCungCap.Rows)
            {
                NhaCungCapDTO doiTuong = dong.DataBoundItem as NhaCungCapDTO;
                if (doiTuong != null && doiTuong.MaNhaCungCap == ma)
                {
                    dgvNhaCungCap.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== VÙNG NHẬP LIỆU ===================== */

        // Đưa dữ liệu của một dòng lên các ô nhập
        private void HienChiTiet(NhaCungCapDTO doiTuong)
        {
            dangSua = true;
            maDangChon = doiTuong.MaNhaCungCap;
            txtMaNhaCungCap.Text = doiTuong.MaNhaCungCap;
            txtMaNhaCungCap.ReadOnly = true;            // không cho đổi mã khi đang sửa
            txtTenNhaCungCap.Text = doiTuong.TenNhaCungCap ?? "";
            txtSoDienThoai.Text = doiTuong.SoDienThoai ?? "";
            txtEmail.Text = doiTuong.Email ?? "";
            txtDiaChi.Text = doiTuong.DiaChi ?? "";
            txtGhiChu.Text = doiTuong.GhiChu ?? "";
        }

        // Xóa trắng form để nhập mới
        private void LamMoiForm()
        {
            dangSua = false;
            maDangChon = null;
            try
            {
                txtMaNhaCungCap.Text = bus.TaoMaMoi();
            }
            catch (Exception)
            {
                txtMaNhaCungCap.Text = "";
            }
            txtMaNhaCungCap.ReadOnly = false;
            txtTenNhaCungCap.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtGhiChu.Clear();
            dgvNhaCungCap.ClearSelection();
            txtTenNhaCungCap.Focus();
        }

        // Đọc dữ liệu từ các ô nhập thành một đối tượng DTO
        private NhaCungCapDTO LayDuLieuTuForm()
        {
            NhaCungCapDTO doiTuong = new NhaCungCapDTO();
            doiTuong.MaNhaCungCap = txtMaNhaCungCap.Text.Trim();
            doiTuong.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
            doiTuong.SoDienThoai = txtSoDienThoai.Text.Trim();
            doiTuong.Email = txtEmail.Text.Trim();
            doiTuong.DiaChi = txtDiaChi.Text.Trim();
            doiTuong.GhiChu = txtGhiChu.Text.Trim();
            return doiTuong;
        }

        /* ===================== THÊM / SỬA / XÓA / LÀM MỚI ===================== */

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO doiTuong = LayDuLieuTuForm();
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
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NhaCungCapDTO doiTuong = LayDuLieuTuForm();
            doiTuong.MaNhaCungCap = maDangChon;
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
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp \"" + txtTenNhaCungCap.Text + "\"?",
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