
using System;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chạy ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mở form đăng nhập trước
            using (QuanLyShopQuanAo.GUI.FormDangNhap formDangNhap =
                   new QuanLyShopQuanAo.GUI.FormDangNhap())
            {
                // Chỉ mở trang chủ khi đăng nhập thành công
                if (formDangNhap.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(
                        new QuanLyShopQuanAo.GUI.FormTrangChu());
                }
            }
        }
    }
}
