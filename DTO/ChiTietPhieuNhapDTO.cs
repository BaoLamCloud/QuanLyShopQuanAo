namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng ChiTietPhieuNhap.</summary>
    public class ChiTietPhieuNhapDTO
    {
        public string MaPhieuNhap { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal ThanhTien { get; set; }

        // Thuộc tính phụ (lấy bằng JOIN với SanPham) để hiển thị
        public string TenSanPham { get; set; }

        public ChiTietPhieuNhapDTO() { }

        public ChiTietPhieuNhapDTO(string maPhieuNhap, string maSanPham, int soLuong, decimal giaNhap, decimal thanhTien)
        {
            MaPhieuNhap = maPhieuNhap;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
            ThanhTien = thanhTien;
        }
    }
}
