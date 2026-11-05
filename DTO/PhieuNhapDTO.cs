using System;

namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng PhieuNhap.</summary>
    public class PhieuNhapDTO
    {
        public string MaPhieuNhap { get; set; }
        public string MaNhaCungCap { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
        public string GhiChu { get; set; }

        // Thuộc tính phụ (lấy bằng JOIN): hiển thị tên nhà cung cấp, tên nhân viên
        public string TenNhaCungCap { get; set; }
        public string TenNhanVien { get; set; }

        public PhieuNhapDTO()
        {
            NgayNhap = DateTime.Now;
        }

        public PhieuNhapDTO(string maPhieuNhap, string maNhaCungCap, string maNhanVien,
                            DateTime ngayNhap, decimal tongTien, string ghiChu)
        {
            MaPhieuNhap = maPhieuNhap;
            MaNhaCungCap = maNhaCungCap;
            MaNhanVien = maNhanVien;
            NgayNhap = ngayNhap;
            TongTien = tongTien;
            GhiChu = ghiChu;
        }
    }
}
