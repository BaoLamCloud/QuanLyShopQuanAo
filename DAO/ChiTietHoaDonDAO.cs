using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>
    /// Truy cập dữ liệu bảng ChiTietHoaDon.
    /// Việc thêm chi tiết luôn nằm trong transaction của HoaDonDAO.ThanhToan nên các hàm ghi dữ liệu
    /// nhận sẵn SqlConnection và SqlTransaction.
    /// </summary>
    public class ChiTietHoaDonDAO
    {
        /// <summary>Lấy chi tiết của một hóa đơn kèm tên sản phẩm, kích thước, màu sắc (dùng để hiển thị).</summary>
        public List<ChiTietHoaDonDTO> LayTheoHoaDon(string maHoaDon)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT ct.MaHoaDon, ct.MaSanPham, ct.SoLuong, ct.DonGia, ct.ThanhTien, " +
                "       sp.TenSanPham, kt.TenKichThuoc, ms.TenMauSac " +
                "FROM ChiTietHoaDon ct " +
                "JOIN SanPham sp   ON sp.MaSanPham = ct.MaSanPham " +
                "JOIN KichThuoc kt ON kt.MaKichThuoc = sp.MaKichThuoc " +
                "JOIN MauSac ms    ON ms.MaMauSac = sp.MaMauSac " +
                "WHERE ct.MaHoaDon = @Ma " +
                "ORDER BY ct.MaSanPham",
                new SqlParameter("@Ma", maHoaDon));

            return bang.Rows.Cast<DataRow>().Select(dong => new ChiTietHoaDonDTO
            {
                MaHoaDon = Convert.ToString(dong["MaHoaDon"]),
                MaSanPham = Convert.ToString(dong["MaSanPham"]),
                SoLuong = Convert.ToInt32(dong["SoLuong"]),
                DonGia = Convert.ToDecimal(dong["DonGia"]),
                ThanhTien = Convert.ToDecimal(dong["ThanhTien"]),
                TenSanPham = Convert.ToString(dong["TenSanPham"]),
                TenKichThuoc = Convert.ToString(dong["TenKichThuoc"]),
                TenMauSac = Convert.ToString(dong["TenMauSac"])
            }).ToList();
        }

        /// <summary>
        /// Lấy chi tiết (chỉ mã sản phẩm, số lượng, đơn giá, thành tiền) TRONG transaction đang mở.
        /// Dùng khi hủy / xóa hóa đơn để hoàn lại tồn kho.
        /// </summary>
        public List<ChiTietHoaDonDTO> LayTheoHoaDon(SqlConnection conn, SqlTransaction tran, string maHoaDon)
        {
            List<ChiTietHoaDonDTO> danhSach = new List<ChiTietHoaDonDTO>();
            using (SqlCommand cmd = new SqlCommand(
                "SELECT MaHoaDon, MaSanPham, SoLuong, DonGia, ThanhTien FROM ChiTietHoaDon WHERE MaHoaDon = @Ma",
                conn, tran))
            {
                cmd.Parameters.AddWithValue("@Ma", maHoaDon);
                // Đọc hết dữ liệu rồi đóng reader trước khi chạy lệnh tiếp theo trên cùng kết nối
                using (SqlDataReader doc = cmd.ExecuteReader())
                {
                    while (doc.Read())
                    {
                        ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();
                        ct.MaHoaDon = doc.GetString(0);
                        ct.MaSanPham = doc.GetString(1);
                        ct.SoLuong = doc.GetInt32(2);
                        ct.DonGia = doc.GetDecimal(3);
                        ct.ThanhTien = doc.GetDecimal(4);
                        danhSach.Add(ct);
                    }
                }
            }
            return danhSach;
        }

        /// <summary>Thêm một dòng chi tiết hóa đơn TRONG transaction đang mở.</summary>
        public int Them(SqlConnection conn, SqlTransaction tran, ChiTietHoaDonDTO ct)
        {
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong, DonGia, ThanhTien) " +
                "VALUES (@MaHoaDon, @MaSanPham, @SoLuong, @DonGia, @ThanhTien)", conn, tran))
            {
                cmd.Parameters.AddWithValue("@MaHoaDon", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaSanPham", ct.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);
                cmd.Parameters.AddWithValue("@ThanhTien", ct.ThanhTien);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
