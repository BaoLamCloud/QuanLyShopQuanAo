using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace QuanLyShopQuanAo.GUI
{
   
    public static class CaptchaHinh
    {
        private static readonly Random ngauNhien = new Random();

        /// <summary>Tạo ảnh captcha kích thước rong x cao. Người gọi chịu trách nhiệm Dispose ảnh khi không dùng nữa.</summary>
        public static Bitmap Ve(string ma, int rong, int cao)
        {
            Bitmap anh = new Bitmap(rong, cao);

            using (Graphics g = Graphics.FromImage(anh))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                // Nền gradient kem - be
                using (LinearGradientBrush nen = new LinearGradientBrush(new Rectangle(0, 0, rong, cao),
                           Color.FromArgb(255, 248, 240), Color.FromArgb(245, 222, 179), 20f))
                {
                    g.FillRectangle(nen, 0, 0, rong, cao);
                }

                // Các đường nhiễu
                for (int i = 0; i < 6; i++)
                {
                    using (Pen but = new Pen(MauNgauNhien(90, 200, 140), 1.6f))
                    {
                        g.DrawLine(but, ngauNhien.Next(rong), ngauNhien.Next(cao), ngauNhien.Next(rong), ngauNhien.Next(cao));
                    }
                }

                // Từng ký tự: cỡ chữ, màu, độ nghiêng ngẫu nhiên
                float oRong = (float)rong / (ma.Length + 0.6f);
                for (int i = 0; i < ma.Length; i++)
                {
                    string kyTu = ma[i].ToString();
                    using (Font chu = new Font("Arial", ngauNhien.Next(20, 27), FontStyle.Bold))
                    using (SolidBrush co = new SolidBrush(MauNgauNhien(20, 110, 255)))
                    {
                        GraphicsState trangThai = g.Save();
                        g.TranslateTransform(oRong * (i + 0.85f), cao / 2f);
                        g.RotateTransform(ngauNhien.Next(-18, 19));
                        SizeF kichThuoc = g.MeasureString(kyTu, chu);
                        g.DrawString(kyTu, chu, co, -kichThuoc.Width / 2f, -kichThuoc.Height / 2f);
                        g.Restore(trangThai);
                    }
                }

                // Viền ngoài
                using (Pen vien = new Pen(Color.FromArgb(188, 170, 164), 1))
                {
                    g.DrawRectangle(vien, 0, 0, rong - 1, cao - 1);
                }
            }

            // Chấm nhiễu
            for (int i = 0; i < 70; i++)
            {
                anh.SetPixel(ngauNhien.Next(rong), ngauNhien.Next(cao), MauNgauNhien(60, 190, 255));
            }

            return anh;
        }

        // Màu ngẫu nhiên với mỗi thành phần R, G, B nằm trong [thap, cao)
        private static Color MauNgauNhien(int thap, int cao, int doDuc)
        {
            return Color.FromArgb(doDuc > 255 ? 255 : doDuc, ngauNhien.Next(thap, cao), ngauNhien.Next(thap, cao), ngauNhien.Next(thap, cao));
        }
    }
}