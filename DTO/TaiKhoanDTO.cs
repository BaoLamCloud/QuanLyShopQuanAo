namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng TaiKhoan.</summary>
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhauHash { get; set; }   // SHA-256(Muoi + MatKhau), viết hoa
        public string Muoi { get; set; }
        public string VaiTro { get; set; }        // "QuanTri" hoặc "BanHang"
        public string MaNhanVien { get; set; }
        public bool TrangThai { get; set; }       // true: hoạt động, false: bị khóa

        // Thuộc tính phụ: không phải cột của bảng TaiKhoan, DAO lấy bằng JOIN với NhanVien để hiển thị
        public string TenNhanVien { get; set; }

        public TaiKhoanDTO()
        {
            VaiTro = "BanHang";
            TrangThai = true;
        }

        public TaiKhoanDTO(string tenDangNhap, string matKhauHash, string muoi,
                           string vaiTro, string maNhanVien, bool trangThai)
        {
            TenDangNhap = tenDangNhap;
            MatKhauHash = matKhauHash;
            Muoi = muoi;
            VaiTro = vaiTro;
            MaNhanVien = maNhanVien;
            TrangThai = trangThai;
        }
    }
}
