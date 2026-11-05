namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng ChiTietHoaDon.</summary>
    public class ChiTietHoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        // Thuộc tính phụ (lấy bằng JOIN với SanPham) để hiển thị lên giỏ hàng / chi tiết hóa đơn
        public string TenSanPham { get; set; }
        public string TenKichThuoc { get; set; }
        public string TenMauSac { get; set; }

        public ChiTietHoaDonDTO() { }

        public ChiTietHoaDonDTO(string maHoaDon, string maSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            MaHoaDon = maHoaDon;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
