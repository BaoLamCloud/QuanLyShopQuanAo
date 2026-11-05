using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>
    /// Truy cập dữ liệu bảng ChiTietPhieuNhap.
    /// Việc thêm chi tiết luôn nằm trong transaction của PhieuNhapDAO.NhapHang nên các hàm ghi dữ liệu
    /// nhận sẵn SqlConnection và SqlTransaction.
    /// </summary>
    public class ChiTietPhieuNhapDAO
    {
        /// <summary>Lấy chi tiết của một phiếu nhập kèm tên sản phẩm (dùng để hiển thị).</summary>
        public List<ChiTietPhieuNhapDTO> LayTheoPhieuNhap(string maPhieuNhap)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT ct.MaPhieuNhap, ct.MaSanPham, ct.SoLuong, ct.GiaNhap, ct.ThanhTien, sp.TenSanPham " +
                "FROM ChiTietPhieuNhap ct " +
                "JOIN SanPham sp ON sp.MaSanPham = ct.MaSanPham " +
                "WHERE ct.MaPhieuNhap = @Ma " +
                "ORDER BY ct.MaSanPham",
                new SqlParameter("@Ma", maPhieuNhap));

            return bang.Rows.Cast<DataRow>().Select(dong => new ChiTietPhieuNhapDTO
            {
                MaPhieuNhap = Convert.ToString(dong["MaPhieuNhap"]),
                MaSanPham = Convert.ToString(dong["MaSanPham"]),
                SoLuong = Convert.ToInt32(dong["SoLuong"]),
                GiaNhap = Convert.ToDecimal(dong["GiaNhap"]),
                ThanhTien = Convert.ToDecimal(dong["ThanhTien"]),
                TenSanPham = Convert.ToString(dong["TenSanPham"])
            }).ToList();
        }

        /// <summary>Lấy chi tiết phiếu nhập TRONG transaction đang mở (dùng khi xóa phiếu để trừ lại tồn kho).</summary>
        public List<ChiTietPhieuNhapDTO> LayTheoPhieuNhap(SqlConnection conn, SqlTransaction tran, string maPhieuNhap)
        {
            List<ChiTietPhieuNhapDTO> danhSach = new List<ChiTietPhieuNhapDTO>();
            using (SqlCommand cmd = new SqlCommand(
                "SELECT MaPhieuNhap, MaSanPham, SoLuong, GiaNhap, ThanhTien FROM ChiTietPhieuNhap WHERE MaPhieuNhap = @Ma",
                conn, tran))
            {
                cmd.Parameters.AddWithValue("@Ma", maPhieuNhap);
                using (SqlDataReader doc = cmd.ExecuteReader())
                {
                    while (doc.Read())
                    {
                        ChiTietPhieuNhapDTO ct = new ChiTietPhieuNhapDTO();
                        ct.MaPhieuNhap = doc.GetString(0);
                        ct.MaSanPham = doc.GetString(1);
                        ct.SoLuong = doc.GetInt32(2);
                        ct.GiaNhap = doc.GetDecimal(3);
                        ct.ThanhTien = doc.GetDecimal(4);
                        danhSach.Add(ct);
                    }
                }
            }
            return danhSach;
        }

        /// <summary>
        /// Lấy tổng số lượng và tổng giá trị (số lượng x giá nhập) của TẤT CẢ các lần đã nhập một sản phẩm.
        /// Chưa từng nhập thì cả hai bằng 0.
        /// </summary>
        public void LayTongNhap(string maSanPham, out int tongSoLuong, out decimal tongGiaTri)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT ISNULL(SUM(SoLuong), 0) AS TongSoLuong, " +
                "       ISNULL(SUM(CAST(SoLuong AS DECIMAL(29,0)) * GiaNhap), 0) AS TongGiaTri " +
                "FROM ChiTietPhieuNhap WHERE MaSanPham = @Ma",
                new SqlParameter("@Ma", maSanPham));

            tongSoLuong = Convert.ToInt32(bang.Rows[0]["TongSoLuong"]);
            tongGiaTri = Convert.ToDecimal(bang.Rows[0]["TongGiaTri"]);
        }

        /// <summary>Thêm một dòng chi tiết phiếu nhập TRONG transaction đang mở.</summary>
        public int Them(SqlConnection conn, SqlTransaction tran, ChiTietPhieuNhapDTO ct)
        {
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSanPham, SoLuong, GiaNhap, ThanhTien) " +
                "VALUES (@MaPhieuNhap, @MaSanPham, @SoLuong, @GiaNhap, @ThanhTien)", conn, tran))
            {
                cmd.Parameters.AddWithValue("@MaPhieuNhap", ct.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@MaSanPham", ct.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@GiaNhap", ct.GiaNhap);
                cmd.Parameters.AddWithValue("@ThanhTien", ct.ThanhTien);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}