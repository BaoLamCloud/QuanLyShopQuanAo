using System.Text.RegularExpressions;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Các hàm kiểm tra và chuẩn hóa dữ liệu nhập dùng chung cho các BUS.</summary>
    public static class KiemTraDuLieu
    {
        /// <summary>Chuỗi null, rỗng hoặc chỉ có khoảng trắng.</summary>
        public static bool LaTrong(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        /// <summary>Số điện thoại Việt Nam: bắt đầu bằng 0 hoặc +84, tổng 10-11 chữ số.</summary>
        public static bool LaSoDienThoaiHopLe(string s)
        {
            return !LaTrong(s) && Regex.IsMatch(s.Trim(), @"^(\+84|0)\d{9,10}$");
        }

        /// <summary>Email có dạng ten@mien.xyz.</summary>
        public static bool LaEmailHopLe(string s)
        {
            return !LaTrong(s) && Regex.IsMatch(s.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>Mã chỉ gồm chữ cái không dấu, số, dấu gạch ngang hoặc gạch dưới.</summary>
        public static bool LaMaHopLe(string s)
        {
            return !LaTrong(s) && Regex.IsMatch(s.Trim(), @"^[A-Za-z0-9_\-]+$");
        }

        /// <summary>Cắt khoảng trắng hai đầu; nếu rỗng thì trả về null (để lưu NULL vào CSDL).</summary>
        public static string ChuanHoaTuyChon(string s)
        {
            return LaTrong(s) ? null : s.Trim();
        }
    }
}
