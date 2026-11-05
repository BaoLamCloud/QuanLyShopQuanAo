namespace QuanLyShopQuanAo.DTO
{
    /// <summary>Bảng ChatLieu.</summary>
    public class ChatLieuDTO
    {
        public int MaChatLieu { get; set; }
        public string TenChatLieu { get; set; }

        public ChatLieuDTO() { }

        public ChatLieuDTO(int maChatLieu, string tenChatLieu)
        {
            MaChatLieu = maChatLieu;
            TenChatLieu = tenChatLieu;
        }
    }
}
