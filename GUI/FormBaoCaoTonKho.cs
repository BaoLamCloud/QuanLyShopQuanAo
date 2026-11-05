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
    /// Hộp thoại liệt kê các sản phẩm đang kinh doanh sắp hết hàng (tồn kho thấp), mở từ dòng cảnh báo ở trang chủ.
    /// Có thể xuất danh sách ra Excel, hoặc (quản trị viên) bấm "Nhập hàng" để chuyển sang form phiếu nhập.
    /// Giao diện nằm trong FormCanhBaoTonKho.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormCanhBaoTonKho : Form
    {
        private readonly SanPhamBUS sanPhamBUS = new SanPhamBUS();

        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        /// <summary>true nếu người dùng bấm "Nhập hàng" (form trang chủ sẽ mở form phiếu nhập).</summary>
        public bool MoPhieuNhap { get; private set; }
        public event Action YeuCauMoPhieuNhap;

        public FormCanhBaoTonKho()
        {
            InitializeComponent();
            // Visual Studio Designer không lưu AutoGenerateColumns nên phải đặt ở đây
            dgvTonThap.AutoGenerateColumns = false;
        }

        private void FormCanhBaoTonKho_Load(object sender, EventArgs e)
        {
            lblMoTa.Text = "Sản phẩm đang kinh doanh có tồn kho từ " + SanPhamBUS.NguongTonKhoThap + " trở xuống (màu đỏ: đã hết hàng).";

            // Chỉ quản trị viên được nhập hàng
            btnNhapHang.Visible = PhienLamViec.LaQuanTri;

            TaiDanhSach();
        }

        // Lấy các sản phẩm đang kinh doanh có tồn kho thấp, ít hàng nhất lên đầu
        private List<SanPhamDTO> LayDanhSach()
        {
            return sanPhamBUS.LayTonKhoThap()
                             .Where(x => x.TrangThai)
                             .OrderBy(x => x.SoLuongTon)
                             .ThenBy(x => x.MaSanPham)
                             .ToList();
        }

        private void TaiDanhSach()
        {
            try
            {
                List<SanPhamDTO> danhSach = LayDanhSach();
                dgvTonThap.DataSource = danhSach;

                int soHet = danhSach.Count(x => x.SoLuongTon <= 0);
                lblTongSo.Text = "Tổng: " + danhSach.Count + " sản phẩm" + (soHet > 0 ? " (trong đó " + soHet + " đã hết hàng)" : "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách sản phẩm.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hết hàng: chữ đỏ đậm; còn ít: chữ cam
        private void dgvTonThap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvTonThap.Columns[e.ColumnIndex].Name != "colTon" || e.Value == null) return;

            int ton;
            if (!int.TryParse(Convert.ToString(e.Value), out ton)) return;

            e.CellStyle.ForeColor = ton <= 0 ? Color.FromArgb(198, 40, 40) : Color.FromArgb(230, 81, 0);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            MoPhieuNhap = true;

            // Yêu cầu FormTrangChu mở trang Phiếu nhập
            YeuCauMoPhieuNhap?.Invoke();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Xuất danh sách đang hiển thị ra file Excel
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            List<SanPhamDTO> danhSach = dgvTonThap.DataSource as List<SanPhamDTO>;
            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào sắp hết hàng để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string[]> thongTin = new List<string[]>();
            thongTin.Add(new string[] { "Ngưỡng cảnh báo:", "tồn kho từ " + SanPhamBUS.NguongTonKhoThap + " trở xuống" });
            thongTin.Add(new string[] { "Xuất lúc:", DateTime.Now.ToString("dd/MM/yyyy HH:mm", viVN) });

            string[] cacCot = { "STT", "Mã sản phẩm", "Tên sản phẩm", "Size", "Màu sắc", "Nhà cung cấp", "Tồn kho" };
            List<object[]> cacDong = danhSach
                .Select((x, i) => new object[] { i + 1, x.MaSanPham, x.TenSanPham, x.TenKichThuoc, x.TenMauSac, x.TenNhaCungCap, x.SoLuongTon })
                .ToList();

            XuatFile.XuatExcel(this, "SanPhamSapHetHang_" + DateTime.Now.ToString("yyyyMMdd_HHmm"),
                               "DANH SÁCH SẢN PHẨM SẮP HẾT HÀNG", thongTin, cacCot, cacDong, null);
        }
    }
}