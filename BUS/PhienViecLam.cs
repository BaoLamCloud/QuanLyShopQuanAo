using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Lưu thông tin người đang đăng nhập (dùng chung cho toàn bộ chương trình).</summary>
    public static class PhienLamViec
    {
        public const string VaiTroQuanTri = "QuanTri";
        public const string VaiTroBanHang = "BanHang";

        public static TaiKhoanDTO TaiKhoan { get; private set; }
        public static NhanVienDTO NhanVien { get; private set; }

        public static bool DaDangNhap
        {
            get { return TaiKhoan != null; }
        }

        public static bool LaQuanTri
        {
            get { return TaiKhoan != null && TaiKhoan.VaiTro == VaiTroQuanTri; }
        }

        public static void BatDau(TaiKhoanDTO taiKhoan, NhanVienDTO nhanVien)
        {
            TaiKhoan = taiKhoan;
            NhanVien = nhanVien;
        }

        public static void KetThuc()
        {
            TaiKhoan = null;
            NhanVien = null;
        }
    }
}
