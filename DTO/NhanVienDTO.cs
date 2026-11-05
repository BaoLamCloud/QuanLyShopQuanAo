using System;

namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng NhanVien.</summary>
    public class NhanVienDTO
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }          // "Nam" hoặc "Nữ"
        public DateTime? NgaySinh { get; set; }       // cho phép null (cột NgaySinh có thể để trống)
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public bool TrangThai { get; set; }           // true: đang làm, false: nghỉ việc

        public NhanVienDTO()
        {
            GioiTinh = "Nam";
            NgayVaoLam = DateTime.Today;
            TrangThai = true;
        }

        public NhanVienDTO(string maNhanVien, string hoTen, string gioiTinh, DateTime? ngaySinh,
                           string soDienThoai, string email, string diaChi,
                           DateTime ngayVaoLam, bool trangThai)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SoDienThoai = soDienThoai;
            Email = email;
            DiaChi = diaChi;
            NgayVaoLam = ngayVaoLam;
            TrangThai = trangThai;
        }
    }
}
