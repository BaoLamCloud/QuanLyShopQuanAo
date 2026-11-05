using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form quản lý danh mục: xem, tìm kiếm, thêm, sửa, xóa.
    /// Giao diện nằm trong FormDanhMuc.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormDanhMuc : Form
    {
        // Đối tượng BUS xử lý nghiệp vụ
        private readonly DanhMucBUS bus = new DanhMucBUS();

        // Đang ở chế độ sửa (đã chọn một dòng) hay chế độ nhập mới
        private bool dangSua;

        // Mã của dòng đang chọn
        private int maDangChon;

        public FormDanhMuc()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormDanhMuc_Load(object sender, EventArgs e)
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
                List<DanhMucDTO> danhSach = bus.TimKiem(tuKhoa);
                dgvDanhMuc.DataSource = danhSach;
                lblTongSo.Text = "Tổng: " + danhSach.Count + " danh mục";

                if (danhSach.Count == 0)
                {
                    dgvDanhMuc.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách danh mục.\n" + ex.Message, "Lỗi",
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
        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhMuc.SelectedRows.Count == 0) return;

            DanhMucDTO doiTuong = dgvDanhMuc.SelectedRows[0].DataBoundItem as DanhMucDTO;
            if (doiTuong != null) HienChiTiet(doiTuong);
        }

        // Chọn lại dòng có mã tương ứng sau khi tải lại danh sách
        private void ChonDong(int ma)
        {
            foreach (DataGridViewRow dong in dgvDanhMuc.Rows)
            {
                DanhMucDTO doiTuong = dong.DataBoundItem as DanhMucDTO;
                if (doiTuong != null && doiTuong.MaDanhMuc == ma)
                {
                    dgvDanhMuc.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== VÙNG NHẬP LIỆU ===================== */

        // Đưa dữ liệu của một dòng lên các ô nhập
        private void HienChiTiet(DanhMucDTO doiTuong)
        {
            dangSua = true;
            maDangChon = doiTuong.MaDanhMuc;
            txtMaDanhMuc.Text = doiTuong.MaDanhMuc.ToString();
            txtTenDanhMuc.Text = doiTuong.TenDanhMuc ?? "";
            txtMoTa.Text = doiTuong.MoTa ?? "";
        }

        // Xóa trắng form để nhập mới
        private void LamMoiForm()
        {
            dangSua = false;
            maDangChon = 0;
            txtMaDanhMuc.Text = "(tự động)";
            txtTenDanhMuc.Clear();
            txtMoTa.Clear();
            dgvDanhMuc.ClearSelection();
            txtTenDanhMuc.Focus();
        }

        // Đọc dữ liệu từ các ô nhập thành một đối tượng DTO
        private DanhMucDTO LayDuLieuTuForm()
        {
            DanhMucDTO doiTuong = new DanhMucDTO();
            doiTuong.TenDanhMuc = txtTenDanhMuc.Text.Trim();
            doiTuong.MoTa = txtMoTa.Text.Trim();
            return doiTuong;
        }

        /* ===================== THÊM / SỬA / XÓA / LÀM MỚI ===================== */

        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhMucDTO doiTuong = LayDuLieuTuForm();
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
                MessageBox.Show("Vui lòng chọn danh mục cần sửa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DanhMucDTO doiTuong = LayDuLieuTuForm();
            doiTuong.MaDanhMuc = maDangChon;
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
                MessageBox.Show("Vui lòng chọn danh mục cần xóa trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa danh mục \"" + txtTenDanhMuc.Text + "\"?",
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