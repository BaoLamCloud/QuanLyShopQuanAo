using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Hỗ trợ xem trước và in hóa đơn (dùng chung cho FormBanHang và FormHoaDon).
    /// Chỉ vẽ dữ liệu có sẵn lên trang in, không truy cập CSDL.
    /// </summary>
    public static class InHoaDon
    {
        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        /// <summary>Mở cửa sổ xem trước hóa đơn; từ đó người dùng có thể bấm nút in.</summary>
        public static void XemTruocVaIn(IWin32Window chuSoHuu, HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> dsChiTiet)
        {
            if (hoaDon == null || dsChiTiet == null)
            {
                MessageBox.Show("Không có dữ liệu hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int chiSoDong = 0;   // dòng chi tiết sẽ vẽ tiếp theo (dùng khi hóa đơn dài nhiều trang)

                PrintDocument taiLieu = new PrintDocument();
                taiLieu.DocumentName = "Hóa đơn " + hoaDon.MaHoaDon;
                taiLieu.BeginPrint += (sender, e) => { chiSoDong = 0; };
                taiLieu.PrintPage += (sender, e) => { chiSoDong = VeTrang(e, hoaDon, dsChiTiet, chiSoDong); };

                using (PrintPreviewDialog xemTruoc = new PrintPreviewDialog())
                {
                    xemTruoc.Document = taiLieu;
                    xemTruoc.Text = "Hóa đơn " + hoaDon.MaHoaDon;
                    xemTruoc.Width = 900;
                    xemTruoc.Height = 700;
                    xemTruoc.StartPosition = FormStartPosition.CenterScreen;
                    xemTruoc.ShowDialog(chuSoHuu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể in hóa đơn (máy chưa cài máy in?).\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Định dạng tiền: 1.234.567 đ
        private static string Tien(decimal soTien)
        {
            return string.Format(viVN, "{0:N0} đ", soTien);
        }

        // Vẽ một trang hóa đơn. Trả về chỉ số dòng chi tiết cần vẽ ở trang kế tiếp.
        private static int VeTrang(PrintPageEventArgs e, HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> dsChiTiet, int batDau)
        {
            Graphics g = e.Graphics;
            Rectangle le = e.MarginBounds;
            float trai = le.Left;
            float rong = le.Width;
            float y = le.Top;

            // Vị trí các cột của bảng chi tiết
            float xTen = trai; float wTen = rong * 0.44f;
            float xSoLuong = trai + rong * 0.46f; float wSoLuong = rong * 0.08f;
            float xDonGia = trai + rong * 0.56f; float wDonGia = rong * 0.20f;
            float xThanhTien = trai + rong * 0.78f; float wThanhTien = rong * 0.22f;

            using (Font fTieuDe = new Font("Arial", 18, FontStyle.Bold))
            using (Font fTieuDeCon = new Font("Arial", 13, FontStyle.Bold))
            using (Font fThuong = new Font("Arial", 10))
            using (Font fDam = new Font("Arial", 10, FontStyle.Bold))
            using (Font fNghieng = new Font("Arial", 10, FontStyle.Italic))
            using (StringFormat giua = new StringFormat { Alignment = StringAlignment.Center })
            using (StringFormat phai = new StringFormat { Alignment = StringAlignment.Far })
            using (Pen but = new Pen(Color.Black, 1))
            {
                float caoDong = fThuong.GetHeight(g) + 4;

                if (batDau == 0)
                {
                    g.DrawString("SHOP QUẦN ÁO", fTieuDe, Brushes.Black, new RectangleF(trai, y, rong, 32), giua);
                    y += 34;
                    g.DrawString("HÓA ĐƠN BÁN HÀNG", fTieuDeCon, Brushes.Black, new RectangleF(trai, y, rong, 24), giua);
                    y += 34;

                    g.DrawString("Mã hóa đơn: " + hoaDon.MaHoaDon, fDam, Brushes.Black, trai, y); y += caoDong;
                    g.DrawString("Ngày lập: " + hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm", viVN), fThuong, Brushes.Black, trai, y); y += caoDong;
                    g.DrawString("Khách hàng: " + hoaDon.TenKhachHang, fThuong, Brushes.Black, trai, y); y += caoDong;
                    g.DrawString("Nhân viên: " + hoaDon.TenNhanVien, fThuong, Brushes.Black, trai, y); y += caoDong;
                    g.DrawString("Trạng thái: " + hoaDon.TrangThaiThanhToan, fThuong, Brushes.Black, trai, y); y += caoDong + 8;
                }
                else
                {
                    g.DrawString("Hóa đơn " + hoaDon.MaHoaDon + " (tiếp theo)", fDam, Brushes.Black, trai, y);
                    y += caoDong + 8;
                }

                // Tiêu đề bảng
                g.DrawString("Sản phẩm", fDam, Brushes.Black, new RectangleF(xTen, y, wTen, caoDong));
                g.DrawString("SL", fDam, Brushes.Black, new RectangleF(xSoLuong, y, wSoLuong, caoDong), phai);
                g.DrawString("Đơn giá", fDam, Brushes.Black, new RectangleF(xDonGia, y, wDonGia, caoDong), phai);
                g.DrawString("Thành tiền", fDam, Brushes.Black, new RectangleF(xThanhTien, y, wThanhTien, caoDong), phai);
                y += caoDong;
                g.DrawLine(but, trai, y, trai + rong, y);
                y += 4;

                // Các dòng chi tiết
                int i = batDau;
                for (; i < dsChiTiet.Count; i++)
                {
                    ChiTietHoaDonDTO ct = dsChiTiet[i];
                    string ten = ct.TenSanPham + " (" + ct.TenKichThuoc + ", " + ct.TenMauSac + ")";
                    SizeF kichThuoc = g.MeasureString(ten, fThuong, (int)wTen);
                    float caoHang = Math.Max(kichThuoc.Height, fThuong.GetHeight(g)) + 6;

                    // Hết chỗ thì sang trang mới (luôn vẽ ít nhất một dòng mỗi trang)
                    if (y + caoHang > le.Bottom - 20 && i > batDau)
                    {
                        e.HasMorePages = true;
                        return i;
                    }

                    g.DrawString(ten, fThuong, Brushes.Black, new RectangleF(xTen, y, wTen, caoHang));
                    g.DrawString(ct.SoLuong.ToString(viVN), fThuong, Brushes.Black, new RectangleF(xSoLuong, y, wSoLuong, caoHang), phai);
                    g.DrawString(ct.DonGia.ToString("N0", viVN), fThuong, Brushes.Black, new RectangleF(xDonGia, y, wDonGia, caoHang), phai);
                    g.DrawString(ct.ThanhTien.ToString("N0", viVN), fThuong, Brushes.Black, new RectangleF(xThanhTien, y, wThanhTien, caoHang), phai);
                    y += caoHang;
                }

                // Phần tổng cần khoảng 110 điểm; không đủ chỗ thì sang trang mới
                if (y + 110 > le.Bottom)
                {
                    e.HasMorePages = true;
                    return i;
                }

                y += 2;
                g.DrawLine(but, trai, y, trai + rong, y);
                y += 6;

                float xNhan = trai + rong * 0.40f;
                float wNhan = rong * 0.38f;
                g.DrawString("Tổng tiền hàng:", fThuong, Brushes.Black, new RectangleF(xNhan, y, wNhan, caoDong), phai);
                g.DrawString(Tien(hoaDon.TongTien), fThuong, Brushes.Black, new RectangleF(xThanhTien, y, wThanhTien, caoDong), phai);
                y += caoDong;
                g.DrawString("Giảm giá:", fThuong, Brushes.Black, new RectangleF(xNhan, y, wNhan, caoDong), phai);
                g.DrawString(Tien(hoaDon.GiamGia), fThuong, Brushes.Black, new RectangleF(xThanhTien, y, wThanhTien, caoDong), phai);
                y += caoDong;
                g.DrawString("THÀNH TIỀN:", fDam, Brushes.Black, new RectangleF(xNhan, y, wNhan, caoDong), phai);
                g.DrawString(Tien(hoaDon.ThanhTien), fDam, Brushes.Black, new RectangleF(xThanhTien, y, wThanhTien, caoDong), phai);
                y += caoDong + 16;

                g.DrawString("Cảm ơn quý khách và hẹn gặp lại!", fNghieng, Brushes.Black, new RectangleF(trai, y, rong, caoDong), giua);
            }

            e.HasMorePages = false;
            return dsChiTiet.Count;
        }
    }
}