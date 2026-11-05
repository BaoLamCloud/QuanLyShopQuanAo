using System;
using System.Security.Cryptography;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>
    /// Nghiệp vụ mã xác nhận (captcha) khi đăng nhập: sinh mã ngẫu nhiên và kiểm tra mã người dùng nhập.
    /// Việc vẽ hình ảnh captcha nằm ở GUI (CaptchaHinh), lớp này không dùng đến giao diện.
    /// </summary>
    public class CaptchaBUS
    {
        // Bỏ các ký tự dễ nhầm lẫn: số 0 và chữ O, số 1 và chữ I, chữ L
        private const string KyTuChoPhep = "ABCDEFGHJKMNPQRSTUVWXYZ23456789";

        /// <summary>Sinh mã captcha ngẫu nhiên (mặc định 5 ký tự), dùng bộ sinh số ngẫu nhiên mật mã.</summary>
        public string TaoMa(int doDai = 5)
        {
            if (doDai < 4) doDai = 4;

            byte[] boDem = new byte[doDai];
            using (RandomNumberGenerator ngauNhien = RandomNumberGenerator.Create())
            {
                ngauNhien.GetBytes(boDem);
            }

            char[] ketQua = new char[doDai];
            for (int i = 0; i < doDai; i++)
            {
                ketQua[i] = KyTuChoPhep[boDem[i] % KyTuChoPhep.Length];
            }
            return new string(ketQua);
        }

        /// <summary>So sánh mã nhập với mã đúng, không phân biệt chữ hoa/thường và bỏ khoảng trắng hai đầu.</summary>
        public bool KiemTra(string maDung, string maNhap)
        {
            if (string.IsNullOrWhiteSpace(maDung) || string.IsNullOrWhiteSpace(maNhap)) return false;
            return string.Equals(maDung.Trim(), maNhap.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}