namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng DanhMuc.</summary>
    public class DanhMucDTO
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }

        public DanhMucDTO() { }

        public DanhMucDTO(int maDanhMuc, string tenDanhMuc, string moTa)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
            MoTa = moTa;
        }
    }
}
