namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng NhaCungCap.</summary>
    public class NhaCungCapDTO
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }

        public NhaCungCapDTO() { }

        public NhaCungCapDTO(string maNhaCungCap, string tenNhaCungCap, string soDienThoai,
                             string email, string diaChi, string ghiChu)
        {
            MaNhaCungCap = maNhaCungCap;
            TenNhaCungCap = tenNhaCungCap;
            SoDienThoai = soDienThoai;
            Email = email;
            DiaChi = diaChi;
            GhiChu = ghiChu;
        }
    }
}
