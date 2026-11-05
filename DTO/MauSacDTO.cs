namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng MauSac.</summary>
    public class MauSacDTO
    {
        public int MaMauSac { get; set; }
        public string TenMauSac { get; set; }

        public MauSacDTO() { }

        public MauSacDTO(int maMauSac, string tenMauSac)
        {
            MaMauSac = maMauSac;
            TenMauSac = tenMauSac;
        }
    }
}
