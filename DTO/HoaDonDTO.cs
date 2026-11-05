using System;

namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng HoaDon.</summary>
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }       // null = khách vãng lai
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string TrangThaiThanhToan { get; set; } // "Đã thanh toán", "Chưa thanh toán", "Đã hủy"

        // Thuộc tính phụ (lấy bằng JOIN): hiển thị tên khách hàng, tên nhân viên
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }

        public HoaDonDTO()
        {
            NgayLap = DateTime.Now;
            TrangThaiThanhToan = "Đã thanh toán";
        }

        public HoaDonDTO(string maHoaDon, string maKhachHang, string maNhanVien, DateTime ngayLap,
                         decimal tongTien, decimal giamGia, decimal thanhTien, string trangThaiThanhToan)
        {
            MaHoaDon = maHoaDon;
            MaKhachHang = maKhachHang;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            TongTien = tongTien;
            GiamGia = giamGia;
            ThanhTien = thanhTien;
            TrangThaiThanhToan = trangThaiThanhToan;
        }
    }
}
