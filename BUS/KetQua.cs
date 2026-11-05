namespace QuanLyShopQuanAo.BUS
{
    /// <summary>
    /// Kết quả trả về từ các hàm Thêm / Sửa / Xóa / Thanh toán của BUS.
    /// GUI chỉ cần đọc ThanhCong và hiển thị ThongBao bằng MessageBox.
    /// </summary>
    public class KetQua
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        /// <summary>Mã vừa được tạo (ví dụ mã hóa đơn, mã phiếu nhập). Có thể null.</summary>
        public string MaMoi { get; set; }

        private KetQua() { }

        public static KetQua Ok(string thongBao, string maMoi = null)
        {
            return new KetQua { ThanhCong = true, ThongBao = thongBao, MaMoi = maMoi };
        }

        public static KetQua Loi(string thongBao)
        {
            return new KetQua { ThanhCong = false, ThongBao = thongBao };
        }
    }
}
