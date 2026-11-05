namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng KichThuoc.</summary>
    public class KichThuocDTO
    {
        public int MaKichThuoc { get; set; }
        public string TenKichThuoc { get; set; }

        public KichThuocDTO() { }

        public KichThuocDTO(int maKichThuoc, string tenKichThuoc)
        {
            MaKichThuoc = maKichThuoc;
            TenKichThuoc = tenKichThuoc;
        }
    }
}
