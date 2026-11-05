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
    /// Form quản lý hóa đơn: tìm kiếm theo mã/tên khách/ngày/trạng thái, xem chi tiết,
    /// đổi trạng thái (hủy hóa đơn hoàn lại tồn kho), xóa và in hóa đơn.
    /// Giao diện nằm trong FormHoaDon.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormHoaDon : Form
    {
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();

        // Mã hóa đơn đang chọn (null nếu chưa chọn)
        private string maDangChon;

        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        public FormHoaDon()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // Chỉ quản trị viên được xóa hóa đơn
            if (!PhienLamViec.LaQuanTri) btnXoa.Enabled = false;

            cboLocTrangThai.SelectedIndex = 0;
            TaiDanhSach();
        }

        /* ===================== DANH SÁCH VÀ TÌM KIẾM ===================== */

        // Tải danh sách theo từ khóa, khoảng ngày và trạng thái đang chọn ở phần bộ lọc
        private void TaiDanhSach()
        {
            try
            {
                DateTime? tuNgay = dtpTuNgay.Checked ? (DateTime?)dtpTuNgay.Value.Date : null;
                DateTime? denNgay = dtpDenNgay.Checked ? (DateTime?)dtpDenNgay.Value.Date : null;

                List<HoaDonDTO> danhSach = hoaDonBUS.TimKiem(txtTimKiem.Text.Trim(), tuNgay, denNgay);

                // Lọc theo trạng thái (mục đầu tiên là "Tất cả trạng thái")
                if (cboLocTrangThai.SelectedIndex > 0)
                {
                    string trangThai = cboLocTrangThai.SelectedItem.ToString();
                    danhSach = danhSach.Where(x => x.TrangThaiThanhToan == trangThai).ToList();
                }

                dgvHoaDon.DataSource = danhSach;

                decimal doanhThu = danhSach.Where(x => x.TrangThaiThanhToan == HoaDonBUS.TrangThaiDaThanhToan)
                                           .Sum(x => x.ThanhTien);
                lblTongSo.Text = "Tổng: " + danhSach.Count + " hóa đơn   •   Doanh thu (đã thanh toán): "
                                 + doanhThu.ToString("N0", viVN) + " đ";

                if (danhSach.Count == 0)
                {
                    dgvHoaDon.ClearSelection();
                    XoaChiTiet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không tải được danh sách hóa đơn",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSach();
            }
        }

        // Bỏ toàn bộ bộ lọc và tải lại
        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTrangThai.SelectedIndex = 0;
            dtpTuNgay.Checked = false;
            dtpDenNgay.Checked = false;
            TaiDanhSach();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnBoLoc_Click(sender, e);
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0) return;

            HoaDonDTO hoaDon = dgvHoaDon.SelectedRows[0].DataBoundItem as HoaDonDTO;
            if (hoaDon != null) HienChiTiet(hoaDon);
        }

        // Tô màu cột trạng thái
        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvHoaDon.Columns[e.ColumnIndex].Name != "colTrangThai" || e.Value == null) return;

            string trangThai = Convert.ToString(e.Value);
            if (trangThai == HoaDonBUS.TrangThaiDaThanhToan)
                e.CellStyle.ForeColor = Color.FromArgb(46, 125, 50);
            else if (trangThai == HoaDonBUS.TrangThaiChuaThanhToan)
                e.CellStyle.ForeColor = Color.FromArgb(230, 81, 0);
            else if (trangThai == HoaDonBUS.TrangThaiDaHuy)
                e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);
        }

        // Chọn lại dòng có mã tương ứng sau khi tải lại danh sách
        private void ChonDong(string maHoaDon)
        {
            foreach (DataGridViewRow dong in dgvHoaDon.Rows)
            {
                HoaDonDTO hoaDon = dong.DataBoundItem as HoaDonDTO;
                if (hoaDon != null && hoaDon.MaHoaDon == maHoaDon)
                {
                    dgvHoaDon.CurrentCell = dong.Cells[0];
                    dong.Selected = true;
                    return;
                }
            }
        }

        /* ===================== THÔNG TIN VÀ CHI TIẾT ===================== */

        // Hiện thông tin hóa đơn và danh sách chi tiết ở bên phải
        private void HienChiTiet(HoaDonDTO hoaDon)
        {
            maDangChon = hoaDon.MaHoaDon;

            txtMaHoaDon.Text = hoaDon.MaHoaDon;
            txtNgayLap.Text = hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm", viVN);
            txtKhachHang.Text = hoaDon.TenKhachHang;
            txtNhanVien.Text = hoaDon.TenNhanVien;
            txtTongTien.Text = hoaDon.TongTien.ToString("N0", viVN);
            txtGiamGia.Text = hoaDon.GiamGia.ToString("N0", viVN);
            txtThanhTien.Text = hoaDon.ThanhTien.ToString("N0", viVN);
            cboTrangThai.SelectedItem = hoaDon.TrangThaiThanhToan;

            try
            {
                dgvChiTiet.DataSource = hoaDonBUS.LayChiTiet(hoaDon.MaHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được chi tiết hóa đơn.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa trắng phần thông tin khi không còn hóa đơn nào được chọn
        private void XoaChiTiet()
        {
            maDangChon = null;
            txtMaHoaDon.Clear();
            txtNgayLap.Clear();
            txtKhachHang.Clear();
            txtNhanVien.Clear();
            txtTongTien.Clear();
            txtGiamGia.Clear();
            txtThanhTien.Clear();
            cboTrangThai.SelectedIndex = -1;
            dgvChiTiet.DataSource = null;
        }

        /* ===================== CẬP NHẬT / XÓA / IN ===================== */

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái mới.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string trangThaiMoi = cboTrangThai.SelectedItem.ToString();
            HoaDonDTO hoaDon;
            try
            {
                hoaDon = hoaDonBUS.LayTheoMa(maDangChon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn. Danh sách sẽ được tải lại.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSach();
                return;
            }
            if (hoaDon.TrangThaiThanhToan == trangThaiMoi)
            {
                MessageBox.Show("Trạng thái không thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hủy hóa đơn hoặc khôi phục hóa đơn đã hủy làm thay đổi tồn kho: chỉ quản trị viên được làm
            bool lienQuanHuy = trangThaiMoi == HoaDonBUS.TrangThaiDaHuy || hoaDon.TrangThaiThanhToan == HoaDonBUS.TrangThaiDaHuy;
            if (lienQuanHuy && !PhienLamViec.LaQuanTri)
            {
                MessageBox.Show("Chỉ quản trị viên mới được hủy hoặc khôi phục hóa đơn.", "Không đủ quyền",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noiDung = "Đổi trạng thái hóa đơn " + hoaDon.MaHoaDon + " từ \"" + hoaDon.TrangThaiThanhToan
                             + "\" sang \"" + trangThaiMoi + "\"?";
            if (trangThaiMoi == HoaDonBUS.TrangThaiDaHuy)
                noiDung += "\n\nSố lượng sản phẩm trong hóa đơn sẽ được hoàn lại vào kho.";
            else if (hoaDon.TrangThaiThanhToan == HoaDonBUS.TrangThaiDaHuy)
                noiDung += "\n\nSố lượng sản phẩm trong hóa đơn sẽ được trừ lại khỏi kho.";

            if (MessageBox.Show(noiDung, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            KetQua ketQua = hoaDonBUS.DoiTrangThai(maDangChon, trangThaiMoi);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không cập nhật được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string ma = maDangChon;
            TaiDanhSach();
            ChonDong(ma);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult hoi = MessageBox.Show(
                "Bạn có chắc muốn xóa hẳn hóa đơn " + maDangChon + "?\n"
                + "Hóa đơn chưa hủy sẽ được hoàn lại số lượng vào kho. Thao tác này không thể hoàn tác.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (hoi != DialogResult.Yes) return;

            KetQua ketQua = hoaDonBUS.Xoa(maDangChon);
            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Không xóa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(ketQua.ThongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                HoaDonDTO hoaDon = hoaDonBUS.LayTheoMa(maDangChon);
                List<ChiTietHoaDonDTO> chiTiet = hoaDonBUS.LayChiTiet(maDangChon);
                InHoaDon.XemTruocVaIn(this, hoaDon, chiTiet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không in được hóa đơn.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}