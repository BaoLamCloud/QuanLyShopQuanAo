using System;

namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng KhachHang.</summary>
    public class KhachHangDTO
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTao { get; set; }

        public KhachHangDTO()
        {
            NgayTao = DateTime.Now;
        }

        public KhachHangDTO(string maKhachHang, string hoTen, string soDienThoai,
                            string email, string diaChi, DateTime ngayTao)
        {
            MaKhachHang = maKhachHang;
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            Email = email;
            DiaChi = diaChi;
            NgayTao = ngayTao;
        }
    }
}
