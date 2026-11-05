using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form thống kê: lọc theo khoảng ngày, xem doanh thu theo ngày/tháng/năm (bảng + biểu đồ),
    /// sản phẩm bán chạy, sản phẩm tồn kho thấp, số hóa đơn, số khách hàng, tiền nhập hàng.
    /// Giao diện nằm trong FormThongKe.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormThongKe : Form
    {
        // Các đối tượng BUS
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private readonly SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private readonly KhachHangBUS khachHangBUS = new KhachHangBUS();
        private readonly PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();

        // Cờ để bỏ qua sự kiện khi chương trình tự đổi giá trị các ô lọc
        private bool dangKhoiTao;

        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        public FormThongKe()
        {
            InitializeComponent();
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // Mặc định: xem 30 ngày qua, doanh thu theo ngày
            dangKhoiTao = true;
            cboKieuThongKe.SelectedIndex = 0;
            cboKhoangNhanh.SelectedIndex = 2;
            DatKhoangNgay(2);
            dangKhoiTao = false;

            TaiThongKe();
        }

        // Đặt ngày bắt đầu/kết thúc theo lựa chọn nhanh (gọi trong lúc dangKhoiTao = true)
        private void DatKhoangNgay(int luaChon)
        {
            DateTime homNay = DateTime.Today;
            DateTime dauThangNay = new DateTime(homNay.Year, homNay.Month, 1);
            DateTime tu;
            DateTime den;

            switch (luaChon)
            {
                case 0: tu = homNay; den = homNay; break;                                   // Hôm nay
                case 1: tu = homNay.AddDays(-6); den = homNay; break;                       // 7 ngày qua
                case 2: tu = homNay.AddDays(-29); den = homNay; break;                      // 30 ngày qua
                case 3: tu = dauThangNay; den = homNay; break;                              // Tháng này
                case 4: tu = dauThangNay.AddMonths(-1); den = dauThangNay.AddDays(-1); break; // Tháng trước
                case 5: tu = new DateTime(homNay.Year, 1, 1); den = homNay; break;          // Năm nay
                default: return;                                                            // Tùy chọn: giữ nguyên
            }

            dtpTuNgay.Value = tu;
            dtpDenNgay.Value = den;
        }

        /* ===================== SỰ KIỆN BỘ LỌC ===================== */

        private void cboKhoangNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangKhoiTao) return;

            dangKhoiTao = true;
            DatKhoangNgay(cboKhoangNhanh.SelectedIndex);
            dangKhoiTao = false;
            TaiThongKe();
        }

        // Người dùng tự chọn ngày thì chuyển ô "Khoảng thời gian" sang "Tùy chọn"
        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            DatTuyChon();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            DatTuyChon();
        }

        private void DatTuyChon()
        {
            if (dangKhoiTao) return;

            dangKhoiTao = true;
            cboKhoangNhanh.SelectedIndex = 6;
            dangKhoiTao = false;
        }

        private void cboKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangKhoiTao) TaiThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TaiThongKe();
        }

        /* ===================== TẢI THỐNG KÊ ===================== */

        private void TaiThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;
            int kieu = cboKieuThongKe.SelectedIndex;   // 0: ngày, 1: tháng, 2: năm

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Khoảng ngày không hợp lệ",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kieu == 0 && (denNgay - tuNgay).TotalDays > 366)
            {
                MessageBox.Show("Khi xem theo ngày, vui lòng chọn khoảng tối đa 366 ngày (hoặc chuyển sang xem theo tháng/năm).",
                                "Khoảng ngày quá dài", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                // 5 thẻ số liệu
                lblDoanhThu.Text = hoaDonBUS.TongDoanhThu(tuNgay, denNgay).ToString("N0", viVN) + " đ";
                lblSoHoaDon.Text = hoaDonBUS.DemHoaDon(tuNgay, denNgay).ToString("N0", viVN);
                lblSoSanPham.Text = sanPhamBUS.DemTatCa().ToString("N0", viVN);
                lblKhachHang.Text = hoaDonBUS.DemKhachHangDaMua(tuNgay, denNgay) + " / " + khachHangBUS.DemTatCa();
                lblTienNhap.Text = phieuNhapBUS.TongTienNhap(tuNgay, denNgay).ToString("N0", viVN) + " đ";

                // Bảng và biểu đồ doanh thu theo kỳ
                DataTable bangDoanhThu = TaoBangDoanhThu(tuNgay, denNgay, kieu);
                dgvDoanhThu.DataSource = bangDoanhThu;
                VeBieuDo(bangDoanhThu);

                // Sản phẩm bán chạy trong khoảng ngày, sản phẩm tồn kho thấp (hiện tại)
                dgvBanChay.DataSource = hoaDonBUS.SanPhamBanChay(tuNgay, denNgay, 10);
                dgvTonThap.DataSource = sanPhamBUS.LayTonKhoThap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được thống kê.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Tạo bảng doanh thu theo kỳ (cột Ky, SoHoaDon, DoanhThu); kỳ không có hóa đơn vẫn hiện với giá trị 0
        private DataTable TaoBangDoanhThu(DateTime tuNgay, DateTime denNgay, int kieu)
        {
            DataTable ketQua = new DataTable();
            ketQua.Columns.Add("Ky", typeof(string));
            ketQua.Columns.Add("SoHoaDon", typeof(int));
            ketQua.Columns.Add("DoanhThu", typeof(decimal));

            if (kieu == 0)
            {
                // Theo ngày
                DataTable bang = hoaDonBUS.DoanhThuTheoNgay(tuNgay, denNgay);
                var theoNgay = bang.Rows.Cast<DataRow>().ToDictionary(dong => Convert.ToDateTime(dong["Ngay"]).Date);

                for (DateTime ngay = tuNgay; ngay <= denNgay; ngay = ngay.AddDays(1))
                {
                    int soHoaDon = 0;
                    decimal doanhThu = 0;
                    DataRow dong;
                    if (theoNgay.TryGetValue(ngay, out dong))
                    {
                        soHoaDon = Convert.ToInt32(dong["SoHoaDon"]);
                        doanhThu = Convert.ToDecimal(dong["DoanhThu"]);
                    }
                    ketQua.Rows.Add(ngay.ToString("dd/MM/yyyy", viVN), soHoaDon, doanhThu);
                }
            }
            else if (kieu == 1)
            {
                // Theo tháng
                DataTable bang = hoaDonBUS.DoanhThuTheoThang(tuNgay, denNgay);
                var theoThang = bang.Rows.Cast<DataRow>().ToDictionary(
                    dong => Convert.ToInt32(dong["Nam"]) * 100 + Convert.ToInt32(dong["Thang"]));

                for (DateTime thang = new DateTime(tuNgay.Year, tuNgay.Month, 1); thang <= denNgay; thang = thang.AddMonths(1))
                {
                    int soHoaDon = 0;
                    decimal doanhThu = 0;
                    DataRow dong;
                    if (theoThang.TryGetValue(thang.Year * 100 + thang.Month, out dong))
                    {
                        soHoaDon = Convert.ToInt32(dong["SoHoaDon"]);
                        doanhThu = Convert.ToDecimal(dong["DoanhThu"]);
                    }
                    ketQua.Rows.Add(thang.ToString("MM/yyyy", viVN), soHoaDon, doanhThu);
                }
            }
            else
            {
                // Theo năm
                DataTable bang = hoaDonBUS.DoanhThuTheoNam(tuNgay, denNgay);
                var theoNam = bang.Rows.Cast<DataRow>().ToDictionary(dong => Convert.ToInt32(dong["Nam"]));

                for (int nam = tuNgay.Year; nam <= denNgay.Year; nam++)
                {
                    int soHoaDon = 0;
                    decimal doanhThu = 0;
                    DataRow dong;
                    if (theoNam.TryGetValue(nam, out dong))
                    {
                        soHoaDon = Convert.ToInt32(dong["SoHoaDon"]);
                        doanhThu = Convert.ToDecimal(dong["DoanhThu"]);
                    }
                    ketQua.Rows.Add(nam.ToString(), soHoaDon, doanhThu);
                }
            }

            return ketQua;
        }

        // Vẽ biểu đồ cột từ bảng doanh thu theo kỳ
        private void VeBieuDo(DataTable bang)
        {
            System.Windows.Forms.DataVisualization.Charting.Series chuoi = chartDoanhThu.Series["DoanhThu"];
            chuoi.Points.Clear();

            foreach (DataRow dong in bang.Rows)
            {
                chuoi.Points.AddXY(Convert.ToString(dong["Ky"]), (double)Convert.ToDecimal(dong["DoanhThu"]));
            }
        }
    }
}