using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>
    /// Quản lý kết nối SQL Server tập trung.
    /// Tất cả DAO đều dùng chung lớp này, chuỗi kết nối đọc từ App.config.
    /// </summary>
    public static class KetNoiCSDL
    {
        // Tên chuỗi kết nối khai báo trong App.config
        private const string TenChuoiKetNoi = "QuanLyShopQuanAo";

        /// <summary>Lấy chuỗi kết nối từ App.config.</summary>
        public static string ChuoiKetNoi
        {
            get
            {
                ConnectionStringSettings cauHinh = ConfigurationManager.ConnectionStrings[TenChuoiKetNoi];
                if (cauHinh == null || string.IsNullOrWhiteSpace(cauHinh.ConnectionString))
                    throw new Exception("Không tìm thấy chuỗi kết nối '" + TenChuoiKetNoi + "' trong App.config.");
                return cauHinh.ConnectionString;
            }
        }

        /// <summary>Tạo một SqlConnection mới (chưa mở). Nhớ dùng trong khối using.</summary>
        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(ChuoiKetNoi);
        }

        /// <summary>Kiểm tra kết nối. Trả về true nếu mở được, ngược lại trả về lý do lỗi.</summary>
        public static bool KiemTraKetNoi(out string thongBaoLoi)
        {
            thongBaoLoi = "";
            try
            {
                using (SqlConnection conn = TaoKetNoi())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Không kết nối được SQL Server.\n"
                            + "Hãy kiểm tra Data Source trong App.config và chắc chắn đã chạy file QuanLyShopQuanAo.sql.\n\n"
                            + "Chi tiết: " + ex.Message;
                return false;
            }
        }

        /// <summary>Chạy câu SELECT, trả về DataTable. Dùng tham số để chống SQL Injection.</summary>
        public static DataTable LayDuLieu(string sql, params SqlParameter[] thamSo)
        {
            try
            {
                using (SqlConnection conn = TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable bang = new DataTable();
                        adapter.Fill(bang);
                        return bang;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(DichLoiSql(ex), ex);
            }
        }

        /// <summary>Chạy INSERT / UPDATE / DELETE, trả về số dòng bị ảnh hưởng.</summary>
        public static int ThucThi(string sql, params SqlParameter[] thamSo)
        {
            try
            {
                using (SqlConnection conn = TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(DichLoiSql(ex), ex);
            }
        }

        /// <summary>Chạy câu lệnh trả về một giá trị (COUNT, SUM, ...). Có thể trả về null hoặc DBNull.</summary>
        public static object LayGiaTri(string sql, params SqlParameter[] thamSo)
        {
            try
            {
                using (SqlConnection conn = TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (thamSo != null) cmd.Parameters.AddRange(thamSo);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(DichLoiSql(ex), ex);
            }
        }

        /// <summary>Đổi lỗi SQL thường gặp sang thông báo tiếng Việt dễ hiểu.</summary>
        public static string DichLoiSql(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                case 2601:
                    return "Dữ liệu bị trùng (mã hoặc tên đã tồn tại).";
                case 547:
                    return "Dữ liệu đang được sử dụng ở nơi khác hoặc tham chiếu không hợp lệ nên không thể thực hiện thao tác.";
                case 515:
                    return "Thiếu dữ liệu bắt buộc.";
                case 4060:
                case 18456:
                    return "Không đăng nhập được vào cơ sở dữ liệu QuanLyShopQuanAo. Hãy chạy file SQL và kiểm tra App.config.";
                case -1:
                case 2:
                case 53:
                    return "Không kết nối được SQL Server. Hãy kiểm tra Data Source trong App.config.";
                default:
                    return "Lỗi cơ sở dữ liệu: " + ex.Message;
            }
        }
    }
}