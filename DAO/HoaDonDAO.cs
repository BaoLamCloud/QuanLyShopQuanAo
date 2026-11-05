using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>
    /// Truy cập dữ liệu bảng HoaDon: thanh toán (transaction), đổi trạng thái, xóa, tìm kiếm và các truy vấn thống kê.
    /// Quy ước: hóa đơn "Đã hủy" thì KHÔNG chiếm tồn kho; hóa đơn khác đã trừ tồn kho khi lập.
    /// </summary>
    public class HoaDonDAO
    {
        private const string TrangThaiDaHuy = "Đã hủy";
        private const string TrangThaiDaThanhToan = "Đã thanh toán";

        private readonly SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private readonly ChiTietHoaDonDAO chiTietDAO = new ChiTietHoaDonDAO();

        // Câu SELECT dùng chung: lấy thêm tên khách hàng (khách vãng lai nếu NULL) và tên nhân viên
        private const string CauSelect =
            "SELECT hd.MaHoaDon, hd.MaKhachHang, hd.MaNhanVien, hd.NgayLap, hd.TongTien, hd.GiamGia, " +
            "       hd.ThanhTien, hd.TrangThaiThanhToan, " +
            "       ISNULL(kh.HoTen, N'Khách vãng lai') AS TenKhachHang, nv.HoTen AS TenNhanVien " +
            "FROM HoaDon hd " +
            "LEFT JOIN KhachHang kh ON kh.MaKhachHang = hd.MaKhachHang " +
            "JOIN NhanVien nv       ON nv.MaNhanVien = hd.MaNhanVien ";

        // Chuyển DataTable thành List<HoaDonDTO> bằng LINQ
        private List<HoaDonDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new HoaDonDTO
            {
                MaHoaDon = Convert.ToString(dong["MaHoaDon"]),
                // MaKhachHang có thể NULL (khách vãng lai)
                MaKhachHang = dong["MaKhachHang"] == DBNull.Value ? null : Convert.ToString(dong["MaKhachHang"]),
                MaNhanVien = Convert.ToString(dong["MaNhanVien"]),
                NgayLap = Convert.ToDateTime(dong["NgayLap"]),
                TongTien = Convert.ToDecimal(dong["TongTien"]),
                GiamGia = Convert.ToDecimal(dong["GiamGia"]),
                ThanhTien = Convert.ToDecimal(dong["ThanhTien"]),
                TrangThaiThanhToan = Convert.ToString(dong["TrangThaiThanhToan"]),
                TenKhachHang = Convert.ToString(dong["TenKhachHang"]),
                TenNhanVien = Convert.ToString(dong["TenNhanVien"])
            }).ToList();
        }

        // Tạo tham số ngày kiểu DateTime (cho phép NULL = không lọc)
        private SqlParameter ThamSoNgay(string ten, DateTime? giaTri)
        {
            SqlParameter p = new SqlParameter(ten, SqlDbType.DateTime);
            p.Value = giaTri.HasValue ? (object)giaTri.Value : DBNull.Value;
            return p;
        }

        /* ===================== TRUY VẤN CƠ BẢN ===================== */

        /// <summary>Lấy toàn bộ hóa đơn, mới nhất trước.</summary>
        public List<HoaDonDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(CauSelect + "ORDER BY hd.NgayLap DESC, hd.MaHoaDon DESC");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy hóa đơn theo mã, không có thì trả về null.</summary>
        public HoaDonDTO LayTheoMa(string ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE hd.MaHoaDon = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>
        /// Tìm theo mã hóa đơn hoặc tên khách hàng, có thể lọc thêm theo khoảng ngày.
        /// tuNgay / denNgay = null nghĩa là không giới hạn phía đó (denNgay tính đến hết ngày đó).
        /// </summary>
        public List<HoaDonDTO> TimKiem(string tuKhoa, DateTime? tuNgay, DateTime? denNgay)
        {
            DateTime? tu = tuNgay.HasValue ? (DateTime?)tuNgay.Value.Date : null;
            DateTime? den = denNgay.HasValue ? (DateTime?)denNgay.Value.Date.AddDays(1) : null;

            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect +
                "WHERE (hd.MaHoaDon LIKE @TuKhoa OR ISNULL(kh.HoTen, N'Khách vãng lai') LIKE @TuKhoa) " +
                "  AND (@Tu IS NULL OR hd.NgayLap >= @Tu) " +
                "  AND (@Den IS NULL OR hd.NgayLap < @Den) " +
                "ORDER BY hd.NgayLap DESC, hd.MaHoaDon DESC",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"),
                ThamSoNgay("@Tu", tu),
                ThamSoNgay("@Den", den));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy N hóa đơn gần nhất (cho trang chủ).</summary>
        public List<HoaDonDTO> LayGanDay(int soLuong)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect.Replace("SELECT hd.MaHoaDon", "SELECT TOP (@SoLuong) hd.MaHoaDon") +
                "ORDER BY hd.NgayLap DESC, hd.MaHoaDon DESC",
                new SqlParameter("@SoLuong", soLuong));
            return ChuyenDanhSach(bang);
        }

        /* ===================== GHI DỮ LIỆU (TRANSACTION) ===================== */

        /// <summary>
        /// THANH TOÁN: trong MỘT transaction sẽ (1) sinh mã hóa đơn, (2) thêm hóa đơn, (3) thêm từng chi tiết,
        /// (4) trừ tồn kho từng sản phẩm. Bất kỳ bước nào lỗi (ví dụ hết hàng) thì rollback toàn bộ.
        /// Trả về mã hóa đơn vừa tạo. Lỗi sẽ ném Exception có thông báo tiếng Việt.
        /// </summary>
        public string ThanhToan(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> dsChiTiet)
        {
            using (SqlConnection conn = KetNoiCSDL.TaoKetNoi())
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    throw new Exception(KetNoiCSDL.DichLoiSql(ex), ex);
                }

                // Serializable để hai máy cùng thanh toán không sinh trùng mã hóa đơn
                using (SqlTransaction tran = conn.BeginTransaction(IsolationLevel.Serializable))
                {
                    try
                    {
                        hoaDon.MaHoaDon = TaoMaMoi(conn, tran, hoaDon.NgayLap);

                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO HoaDon (MaHoaDon, MaKhachHang, MaNhanVien, NgayLap, TongTien, GiamGia, ThanhTien, TrangThaiThanhToan) " +
                            "VALUES (@Ma, @MaKH, @MaNV, @NgayLap, @TongTien, @GiamGia, @ThanhTien, @TrangThai)", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Ma", hoaDon.MaHoaDon);
                            cmd.Parameters.AddWithValue("@MaKH", (object)hoaDon.MaKhachHang ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@MaNV", hoaDon.MaNhanVien);
                            cmd.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);
                            cmd.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                            cmd.Parameters.AddWithValue("@GiamGia", hoaDon.GiamGia);
                            cmd.Parameters.AddWithValue("@ThanhTien", hoaDon.ThanhTien);
                            cmd.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThaiThanhToan);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (ChiTietHoaDonDTO ct in dsChiTiet)
                        {
                            ct.MaHoaDon = hoaDon.MaHoaDon;
                            chiTietDAO.Them(conn, tran, ct);

                            // Hóa đơn không phải "Đã hủy" thì trừ tồn kho
                            if (hoaDon.TrangThaiThanhToan != TrangThaiDaHuy)
                            {
                                int soDong = sanPhamDAO.CapNhatTonKho(conn, tran, ct.MaSanPham, -ct.SoLuong);
                                if (soDong == 0)
                                    throw new Exception("Sản phẩm " + ct.MaSanPham + " không đủ số lượng tồn kho để bán.");
                            }
                        }

                        tran.Commit();
                        return hoaDon.MaHoaDon;
                    }
                    catch (Exception ex)
                    {
                        HuyTransaction(tran);
                        SqlException loiSql = ex as SqlException;
                        if (loiSql != null) throw new Exception(KetNoiCSDL.DichLoiSql(loiSql), ex);
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Đổi trạng thái hóa đơn. Chuyển sang "Đã hủy" thì hoàn lại tồn kho; từ "Đã hủy" sang trạng thái khác thì trừ lại tồn kho
        /// (báo lỗi nếu không đủ hàng). Tất cả trong một transaction.
        /// </summary>
        public void DoiTrangThai(string maHoaDon, string trangThaiMoi)
        {
            using (SqlConnection conn = KetNoiCSDL.TaoKetNoi())
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    throw new Exception(KetNoiCSDL.DichLoiSql(ex), ex);
                }

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        string trangThaiCu = LayTrangThaiTrongTransaction(conn, tran, maHoaDon);

                        if (trangThaiCu != trangThaiMoi)
                        {
                            bool cuDaHuy = trangThaiCu == TrangThaiDaHuy;
                            bool moiDaHuy = trangThaiMoi == TrangThaiDaHuy;

                            if (!cuDaHuy && moiDaHuy)
                                DieuChinhTonKho(conn, tran, maHoaDon, +1);   // hủy: hoàn lại hàng vào kho
                            else if (cuDaHuy && !moiDaHuy)
                                DieuChinhTonKho(conn, tran, maHoaDon, -1);   // khôi phục: trừ lại hàng

                            using (SqlCommand cmd = new SqlCommand(
                                "UPDATE HoaDon SET TrangThaiThanhToan = @TrangThai WHERE MaHoaDon = @Ma", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                                cmd.Parameters.AddWithValue("@Ma", maHoaDon);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        HuyTransaction(tran);
                        SqlException loiSql = ex as SqlException;
                        if (loiSql != null) throw new Exception(KetNoiCSDL.DichLoiSql(loiSql), ex);
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa hóa đơn (chi tiết bị xóa theo nhờ ON DELETE CASCADE). Nếu hóa đơn chưa hủy thì hoàn lại tồn kho trước khi xóa.
        /// </summary>
        public void Xoa(string maHoaDon)
        {
            using (SqlConnection conn = KetNoiCSDL.TaoKetNoi())
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    throw new Exception(KetNoiCSDL.DichLoiSql(ex), ex);
                }

                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        string trangThai = LayTrangThaiTrongTransaction(conn, tran, maHoaDon);

                        if (trangThai != TrangThaiDaHuy)
                            DieuChinhTonKho(conn, tran, maHoaDon, +1);

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = @Ma", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Ma", maHoaDon);
                            cmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        HuyTransaction(tran);
                        SqlException loiSql = ex as SqlException;
                        if (loiSql != null) throw new Exception(KetNoiCSDL.DichLoiSql(loiSql), ex);
                        throw;
                    }
                }
            }
        }

        /* ===================== HÀM PHỤ DÙNG TRONG TRANSACTION ===================== */

        // Sinh mã dạng HDyyyyMMddNNN (NNN là số thứ tự trong ngày)
        private string TaoMaMoi(SqlConnection conn, SqlTransaction tran, DateTime ngay)
        {
            string tienTo = "HD" + ngay.ToString("yyyyMMdd");
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(TRY_CAST(RIGHT(MaHoaDon, 3) AS INT)), 0) + 1 FROM HoaDon WHERE MaHoaDon LIKE @TienTo", conn, tran))
            {
                cmd.Parameters.AddWithValue("@TienTo", tienTo + "%");
                int soThuTu = Convert.ToInt32(cmd.ExecuteScalar());
                return tienTo + soThuTu.ToString("D3");
            }
        }

        // Đọc trạng thái hiện tại của hóa đơn và khóa dòng đó cho đến khi transaction kết thúc
        private string LayTrangThaiTrongTransaction(SqlConnection conn, SqlTransaction tran, string maHoaDon)
        {
            using (SqlCommand cmd = new SqlCommand(
                "SELECT TrangThaiThanhToan FROM HoaDon WITH (UPDLOCK) WHERE MaHoaDon = @Ma", conn, tran))
            {
                cmd.Parameters.AddWithValue("@Ma", maHoaDon);
                object kq = cmd.ExecuteScalar();
                if (kq == null) throw new Exception("Không tìm thấy hóa đơn " + maHoaDon + ".");
                return Convert.ToString(kq);
            }
        }

        // heSo = +1: cộng tồn kho theo chi tiết hóa đơn (hoàn hàng); heSo = -1: trừ tồn kho
        private void DieuChinhTonKho(SqlConnection conn, SqlTransaction tran, string maHoaDon, int heSo)
        {
            List<ChiTietHoaDonDTO> dsChiTiet = chiTietDAO.LayTheoHoaDon(conn, tran, maHoaDon);
            foreach (ChiTietHoaDonDTO ct in dsChiTiet)
            {
                int soDong = sanPhamDAO.CapNhatTonKho(conn, tran, ct.MaSanPham, heSo * ct.SoLuong);
                if (soDong == 0)
                    throw new Exception("Sản phẩm " + ct.MaSanPham + " không đủ số lượng tồn kho để thực hiện thao tác này.");
            }
        }

        // Rollback an toàn (bỏ qua lỗi nếu transaction đã bị SQL Server hủy)
        private void HuyTransaction(SqlTransaction tran)
        {
            try { tran.Rollback(); }
            catch (Exception) { }
        }

        /* ===================== THỐNG KÊ ===================== */
        // Doanh thu chỉ tính hóa đơn "Đã thanh toán". Khoảng ngày tính từ đầu ngày tuNgay đến hết ngày denNgay.

        /// <summary>Đếm số hóa đơn (không tính hóa đơn đã hủy) trong khoảng ngày.</summary>
        public int DemHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM HoaDon WHERE TrangThaiThanhToan <> N'" + TrangThaiDaHuy + "' " +
                "AND NgayLap >= @Tu AND NgayLap < @Den",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
            return Convert.ToInt32(kq);
        }

        /// <summary>Đếm tất cả hóa đơn không tính hóa đơn đã hủy (thẻ "Số hóa đơn" ở trang chủ).</summary>
        public int DemTatCa()
        {
            return Convert.ToInt32(KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM HoaDon WHERE TrangThaiThanhToan <> N'" + TrangThaiDaHuy + "'"));
        }

        /// <summary>Tổng doanh thu (hóa đơn đã thanh toán) trong khoảng ngày.</summary>
        public decimal TongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(SUM(ThanhTien), 0) FROM HoaDon WHERE TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "' " +
                "AND NgayLap >= @Tu AND NgayLap < @Den",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
            return Convert.ToDecimal(kq);
        }

        /// <summary>Tổng doanh thu của tất cả hóa đơn đã thanh toán (thẻ "Doanh thu" ở trang chủ).</summary>
        public decimal TongDoanhThuTatCa()
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(SUM(ThanhTien), 0) FROM HoaDon WHERE TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "'");
            return Convert.ToDecimal(kq);
        }

        /// <summary>Đếm số khách hàng khác nhau đã mua hàng (có hóa đơn đã thanh toán) trong khoảng ngày.</summary>
        public int DemKhachHangDaMua(DateTime tuNgay, DateTime denNgay)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(DISTINCT MaKhachHang) FROM HoaDon WHERE MaKhachHang IS NOT NULL " +
                "AND TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "' AND NgayLap >= @Tu AND NgayLap < @Den",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
            return Convert.ToInt32(kq);
        }

        /// <summary>Doanh thu theo ngày. Cột trả về: Ngay, SoHoaDon, DoanhThu.</summary>
        public DataTable DoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return KetNoiCSDL.LayDuLieu(
                "SELECT CAST(NgayLap AS DATE) AS Ngay, COUNT(*) AS SoHoaDon, SUM(ThanhTien) AS DoanhThu " +
                "FROM HoaDon WHERE TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "' " +
                "AND NgayLap >= @Tu AND NgayLap < @Den " +
                "GROUP BY CAST(NgayLap AS DATE) ORDER BY Ngay",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
        }

        /// <summary>Doanh thu theo tháng. Cột trả về: Nam, Thang, SoHoaDon, DoanhThu.</summary>
        public DataTable DoanhThuTheoThang(DateTime tuNgay, DateTime denNgay)
        {
            return KetNoiCSDL.LayDuLieu(
                "SELECT YEAR(NgayLap) AS Nam, MONTH(NgayLap) AS Thang, COUNT(*) AS SoHoaDon, SUM(ThanhTien) AS DoanhThu " +
                "FROM HoaDon WHERE TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "' " +
                "AND NgayLap >= @Tu AND NgayLap < @Den " +
                "GROUP BY YEAR(NgayLap), MONTH(NgayLap) ORDER BY Nam, Thang",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
        }

        /// <summary>Doanh thu theo năm. Cột trả về: Nam, SoHoaDon, DoanhThu.</summary>
        public DataTable DoanhThuTheoNam(DateTime tuNgay, DateTime denNgay)
        {
            return KetNoiCSDL.LayDuLieu(
                "SELECT YEAR(NgayLap) AS Nam, COUNT(*) AS SoHoaDon, SUM(ThanhTien) AS DoanhThu " +
                "FROM HoaDon WHERE TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "' " +
                "AND NgayLap >= @Tu AND NgayLap < @Den " +
                "GROUP BY YEAR(NgayLap) ORDER BY Nam",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
        }

        /// <summary>Sản phẩm bán chạy nhất. Cột trả về: MaSanPham, TenSanPham, TongSoLuong, DoanhThu.</summary>
        public DataTable SanPhamBanChay(DateTime tuNgay, DateTime denNgay, int soLuongLay)
        {
            return KetNoiCSDL.LayDuLieu(
                "SELECT TOP (@Top) sp.MaSanPham, sp.TenSanPham, SUM(ct.SoLuong) AS TongSoLuong, SUM(ct.ThanhTien) AS DoanhThu " +
                "FROM ChiTietHoaDon ct " +
                "JOIN HoaDon hd  ON hd.MaHoaDon = ct.MaHoaDon " +
                "JOIN SanPham sp ON sp.MaSanPham = ct.MaSanPham " +
                "WHERE hd.TrangThaiThanhToan = N'" + TrangThaiDaThanhToan + "' " +
                "AND hd.NgayLap >= @Tu AND hd.NgayLap < @Den " +
                "GROUP BY sp.MaSanPham, sp.TenSanPham " +
                "ORDER BY TongSoLuong DESC, sp.MaSanPham",
                new SqlParameter("@Top", soLuongLay),
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
        }
    }
}
