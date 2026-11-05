using System;

namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng SanPham. Mỗi dòng là một biến thể (một size + một màu).</summary>
    public class SanPhamDTO
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaDanhMuc { get; set; }
        public int MaThuongHieu { get; set; }
        public int MaKichThuoc { get; set; }
        public int MaMauSac { get; set; }
        public int MaChatLieu { get; set; }
        public string MaNhaCungCap { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public decimal TyLeLai { get; set; }       // tỷ lệ lãi mong muốn (%); > 0 thì giá bán = giá nhập x (1 + TyLeLai/100)
        public int SoLuongTon { get; set; }
        public string HinhAnh { get; set; }       // tên file ảnh trong thư mục Images
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }       // true: đang kinh doanh, false: ngừng
        public DateTime NgayTao { get; set; }

        // Các thuộc tính phụ: không phải cột của bảng SanPham.
        // DAO lấy bằng JOIN để hiển thị tên lên DataGridView.
        public string TenDanhMuc { get; set; }
        public string TenThuongHieu { get; set; }
        public string TenKichThuoc { get; set; }
        public string TenMauSac { get; set; }
        public string TenChatLieu { get; set; }
        public string TenNhaCungCap { get; set; }

        public SanPhamDTO()
        {
            TrangThai = true;
            NgayTao = DateTime.Now;
        }

        public SanPhamDTO(string maSanPham, string tenSanPham, int maDanhMuc, int maThuongHieu,
                          int maKichThuoc, int maMauSac, int maChatLieu, string maNhaCungCap,
                          decimal giaNhap, decimal giaBan, int soLuongTon,
                          string hinhAnh, string moTa, bool trangThai, DateTime ngayTao)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            MaDanhMuc = maDanhMuc;
            MaThuongHieu = maThuongHieu;
            MaKichThuoc = maKichThuoc;
            MaMauSac = maMauSac;
            MaChatLieu = maChatLieu;
            MaNhaCungCap = maNhaCungCap;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            SoLuongTon = soLuongTon;
            HinhAnh = hinhAnh;
            MoTa = moTa;
            TrangThai = trangThai;
            NgayTao = ngayTao;
        }
    }
}