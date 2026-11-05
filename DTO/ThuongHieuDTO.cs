namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng ThuongHieu.</summary>
    public class ThuongHieuDTO
    {
        public int MaThuongHieu { get; set; }
        public string TenThuongHieu { get; set; }
        public string MoTa { get; set; }

        public ThuongHieuDTO() { }

        public ThuongHieuDTO(int maThuongHieu, string tenThuongHieu, string moTa)
        {
            MaThuongHieu = maThuongHieu;
            TenThuongHieu = tenThuongHieu;
            MoTa = moTa;
        }
    }
}
