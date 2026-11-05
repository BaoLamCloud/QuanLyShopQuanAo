using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng PhieuNhap: nhập hàng (transaction), xóa phiếu, tìm kiếm.</summary>
    public class PhieuNhapDAO
    {
        private readonly SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private readonly ChiTietPhieuNhapDAO chiTietDAO = new ChiTietPhieuNhapDAO();

        // Câu SELECT dùng chung: lấy thêm tên nhà cung cấp và tên nhân viên
        private const string CauSelect =
            "SELECT pn.MaPhieuNhap, pn.MaNhaCungCap, pn.MaNhanVien, pn.NgayNhap, pn.TongTien, pn.GhiChu, " +
            "       ncc.TenNhaCungCap, nv.HoTen AS TenNhanVien " +
            "FROM PhieuNhap pn " +
            "JOIN NhaCungCap ncc ON ncc.MaNhaCungCap = pn.MaNhaCungCap " +
            "JOIN NhanVien nv    ON nv.MaNhanVien = pn.MaNhanVien ";

        // Chuyển DataTable thành List<PhieuNhapDTO> bằng LINQ
        private List<PhieuNhapDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new PhieuNhapDTO
            {
                MaPhieuNhap = Convert.ToString(dong["MaPhieuNhap"]),
                MaNhaCungCap = Convert.ToString(dong["MaNhaCungCap"]),
                MaNhanVien = Convert.ToString(dong["MaNhanVien"]),
                NgayNhap = Convert.ToDateTime(dong["NgayNhap"]),
                TongTien = Convert.ToDecimal(dong["TongTien"]),
                GhiChu = Convert.ToString(dong["GhiChu"]),
                TenNhaCungCap = Convert.ToString(dong["TenNhaCungCap"]),
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

        /// <summary>Lấy toàn bộ phiếu nhập, mới nhất trước.</summary>
        public List<PhieuNhapDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(CauSelect + "ORDER BY pn.NgayNhap DESC, pn.MaPhieuNhap DESC");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy phiếu nhập theo mã, không có thì trả về null.</summary>
        public PhieuNhapDTO LayTheoMa(string ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE pn.MaPhieuNhap = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã phiếu hoặc tên nhà cung cấp, có thể lọc theo khoảng ngày (null = không giới hạn).</summary>
        public List<PhieuNhapDTO> TimKiem(string tuKhoa, DateTime? tuNgay, DateTime? denNgay)
        {
            DateTime? tu = tuNgay.HasValue ? (DateTime?)tuNgay.Value.Date : null;
            DateTime? den = denNgay.HasValue ? (DateTime?)denNgay.Value.Date.AddDays(1) : null;

            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect +
                "WHERE (pn.MaPhieuNhap LIKE @TuKhoa OR ncc.TenNhaCungCap LIKE @TuKhoa) " +
                "  AND (@Tu IS NULL OR pn.NgayNhap >= @Tu) " +
                "  AND (@Den IS NULL OR pn.NgayNhap < @Den) " +
                "ORDER BY pn.NgayNhap DESC, pn.MaPhieuNhap DESC",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"),
                ThamSoNgay("@Tu", tu),
                ThamSoNgay("@Den", den));
            return ChuyenDanhSach(bang);
        }

        /// <summary>
        /// NHẬP HÀNG: trong MỘT transaction sẽ (1) sinh mã phiếu, (2) thêm phiếu nhập, (3) thêm từng chi tiết,
        /// (4) cộng tồn kho từng sản phẩm. Lỗi ở bất kỳ bước nào thì rollback toàn bộ.
        /// Trả về mã phiếu nhập vừa tạo.
        /// </summary>
        public string NhapHang(PhieuNhapDTO phieu, List<ChiTietPhieuNhapDTO> dsChiTiet)
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

                using (SqlTransaction tran = conn.BeginTransaction(IsolationLevel.Serializable))
                {
                    try
                    {
                        phieu.MaPhieuNhap = TaoMaMoi(conn, tran, phieu.NgayNhap);

                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO PhieuNhap (MaPhieuNhap, MaNhaCungCap, MaNhanVien, NgayNhap, TongTien, GhiChu) " +
                            "VALUES (@Ma, @MaNCC, @MaNV, @NgayNhap, @TongTien, @GhiChu)", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Ma", phieu.MaPhieuNhap);
                            cmd.Parameters.AddWithValue("@MaNCC", phieu.MaNhaCungCap);
                            cmd.Parameters.AddWithValue("@MaNV", phieu.MaNhanVien);
                            cmd.Parameters.AddWithValue("@NgayNhap", phieu.NgayNhap);
                            cmd.Parameters.AddWithValue("@TongTien", phieu.TongTien);
                            cmd.Parameters.AddWithValue("@GhiChu", (object)phieu.GhiChu ?? DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (ChiTietPhieuNhapDTO ct in dsChiTiet)
                        {
                            ct.MaPhieuNhap = phieu.MaPhieuNhap;
                            chiTietDAO.Them(conn, tran, ct);

                            // Cộng tồn kho
                            int soDong = sanPhamDAO.CapNhatTonKho(conn, tran, ct.MaSanPham, ct.SoLuong);
                            if (soDong == 0)
                                throw new Exception("Không cập nhật được tồn kho cho sản phẩm " + ct.MaSanPham + ".");

                            // Tính lại giá nhập (trung bình các lần nhập) và giá bán (nếu có tỷ lệ lãi)
                            sanPhamDAO.TinhLaiGiaVonTuLichSuNhap(conn, tran, ct.MaSanPham);
                        }

                        tran.Commit();
                        return phieu.MaPhieuNhap;
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
        /// Xóa phiếu nhập: trừ lại số lượng đã nhập khỏi tồn kho rồi xóa phiếu (chi tiết xóa theo nhờ ON DELETE CASCADE).
        /// Nếu hàng đã bán bớt nên tồn kho không đủ để trừ lại thì báo lỗi và không xóa gì cả.
        /// Sau khi xóa, giá nhập (giá vốn) của các sản phẩm trong phiếu được tính lại từ các lần nhập còn lại.
        /// </summary>
        public void Xoa(string maPhieuNhap)
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
                        List<ChiTietPhieuNhapDTO> dsChiTiet = chiTietDAO.LayTheoPhieuNhap(conn, tran, maPhieuNhap);
                        foreach (ChiTietPhieuNhapDTO ct in dsChiTiet)
                        {
                            int soDong = sanPhamDAO.CapNhatTonKho(conn, tran, ct.MaSanPham, -ct.SoLuong);
                            if (soDong == 0)
                                throw new Exception("Không thể xóa phiếu nhập vì tồn kho hiện tại của sản phẩm "
                                                    + ct.MaSanPham + " không đủ để hoàn lại số lượng đã nhập.");
                        }

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM PhieuNhap WHERE MaPhieuNhap = @Ma", conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Ma", maPhieuNhap);
                            cmd.ExecuteNonQuery();
                        }

                        // Phiếu đã bị xóa khỏi lịch sử nhập nên tính lại giá nhập (và giá bán) của các sản phẩm liên quan
                        foreach (ChiTietPhieuNhapDTO ct in dsChiTiet)
                        {
                            sanPhamDAO.TinhLaiGiaVonTuLichSuNhap(conn, tran, ct.MaSanPham);
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

        /// <summary>Tổng tiền nhập hàng trong khoảng ngày (dùng cho thống kê).</summary>
        public decimal TongTienNhap(DateTime tuNgay, DateTime denNgay)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(SUM(TongTien), 0) FROM PhieuNhap WHERE NgayNhap >= @Tu AND NgayNhap < @Den",
                new SqlParameter("@Tu", tuNgay.Date),
                new SqlParameter("@Den", denNgay.Date.AddDays(1)));
            return Convert.ToDecimal(kq);
        }

        // Sinh mã dạng PNyyyyMMddNNN (NNN là số thứ tự trong ngày)
        private string TaoMaMoi(SqlConnection conn, SqlTransaction tran, DateTime ngay)
        {
            string tienTo = "PN" + ngay.ToString("yyyyMMdd");
            using (SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(MAX(TRY_CAST(RIGHT(MaPhieuNhap, 3) AS INT)), 0) + 1 FROM PhieuNhap WHERE MaPhieuNhap LIKE @TienTo", conn, tran))
            {
                cmd.Parameters.AddWithValue("@TienTo", tienTo + "%");
                int soThuTu = Convert.ToInt32(cmd.ExecuteScalar());
                return tienTo + soThuTu.ToString("D3");
            }
        }

        // Rollback an toàn (bỏ qua lỗi nếu transaction đã bị SQL Server hủy)
        private void HuyTransaction(SqlTransaction tran)
        {
            try { tran.Rollback(); }
            catch (Exception) { }
        }
    }
}