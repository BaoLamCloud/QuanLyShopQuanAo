using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng SanPham (JOIN các bảng danh mục để lấy tên hiển thị).</summary>
    public class SanPhamDAO
    {
        // Câu SELECT dùng chung: lấy cột của SanPham và tên từ các bảng liên quan
        private const string CauSelect =
            "SELECT sp.MaSanPham, sp.TenSanPham, sp.MaDanhMuc, sp.MaThuongHieu, sp.MaKichThuoc, sp.MaMauSac, " +
            "       sp.MaChatLieu, sp.MaNhaCungCap, sp.GiaNhap, sp.GiaBan, sp.TyLeLai, sp.SoLuongTon, sp.HinhAnh, sp.MoTa, " +
            "       sp.TrangThai, sp.NgayTao, " +
            "       dm.TenDanhMuc, th.TenThuongHieu, kt.TenKichThuoc, ms.TenMauSac, cl.TenChatLieu, ncc.TenNhaCungCap " +
            "FROM SanPham sp " +
            "JOIN DanhMuc dm     ON dm.MaDanhMuc = sp.MaDanhMuc " +
            "JOIN ThuongHieu th  ON th.MaThuongHieu = sp.MaThuongHieu " +
            "JOIN KichThuoc kt   ON kt.MaKichThuoc = sp.MaKichThuoc " +
            "JOIN MauSac ms      ON ms.MaMauSac = sp.MaMauSac " +
            "JOIN ChatLieu cl    ON cl.MaChatLieu = sp.MaChatLieu " +
            "JOIN NhaCungCap ncc ON ncc.MaNhaCungCap = sp.MaNhaCungCap ";

        // Điều kiện tìm kiếm dùng chung (mã, tên sản phẩm, danh mục, thương hiệu)
        private const string DieuKienTimKiem =
            "(sp.MaSanPham LIKE @TuKhoa OR sp.TenSanPham LIKE @TuKhoa " +
            " OR dm.TenDanhMuc LIKE @TuKhoa OR th.TenThuongHieu LIKE @TuKhoa) ";

        // Chuyển DataTable thành List<SanPhamDTO> bằng LINQ
        private List<SanPhamDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new SanPhamDTO
            {
                MaSanPham = Convert.ToString(dong["MaSanPham"]),
                TenSanPham = Convert.ToString(dong["TenSanPham"]),
                MaDanhMuc = Convert.ToInt32(dong["MaDanhMuc"]),
                MaThuongHieu = Convert.ToInt32(dong["MaThuongHieu"]),
                MaKichThuoc = Convert.ToInt32(dong["MaKichThuoc"]),
                MaMauSac = Convert.ToInt32(dong["MaMauSac"]),
                MaChatLieu = Convert.ToInt32(dong["MaChatLieu"]),
                MaNhaCungCap = Convert.ToString(dong["MaNhaCungCap"]),
                GiaNhap = Convert.ToDecimal(dong["GiaNhap"]),
                GiaBan = Convert.ToDecimal(dong["GiaBan"]),
                TyLeLai = Convert.ToDecimal(dong["TyLeLai"]),
                SoLuongTon = Convert.ToInt32(dong["SoLuongTon"]),
                HinhAnh = Convert.ToString(dong["HinhAnh"]),
                MoTa = Convert.ToString(dong["MoTa"]),
                TrangThai = Convert.ToBoolean(dong["TrangThai"]),
                NgayTao = Convert.ToDateTime(dong["NgayTao"]),
                TenDanhMuc = Convert.ToString(dong["TenDanhMuc"]),
                TenThuongHieu = Convert.ToString(dong["TenThuongHieu"]),
                TenKichThuoc = Convert.ToString(dong["TenKichThuoc"]),
                TenMauSac = Convert.ToString(dong["TenMauSac"]),
                TenChatLieu = Convert.ToString(dong["TenChatLieu"]),
                TenNhaCungCap = Convert.ToString(dong["TenNhaCungCap"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ sản phẩm.</summary>
        public List<SanPhamDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(CauSelect + "ORDER BY sp.MaSanPham");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy sản phẩm theo mã, không có thì trả về null.</summary>
        public SanPhamDTO LayTheoMa(string ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE sp.MaSanPham = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã, tên sản phẩm, danh mục hoặc thương hiệu.</summary>
        public List<SanPhamDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE " + DieuKienTimKiem + "ORDER BY sp.MaSanPham",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy các sản phẩm đang kinh doanh (dùng cho form bán hàng và phiếu nhập).</summary>
        public List<SanPhamDTO> LayDangKinhDoanh()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(CauSelect + "WHERE sp.TrangThai = 1 ORDER BY sp.TenSanPham");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Tìm trong các sản phẩm đang kinh doanh (dùng cho ô tìm kiếm ở form bán hàng).</summary>
        public List<SanPhamDTO> TimKiemDangKinhDoanh(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE sp.TrangThai = 1 AND " + DieuKienTimKiem + "ORDER BY sp.TenSanPham",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy các sản phẩm có tồn kho nhỏ hơn hoặc bằng ngưỡng (cảnh báo sắp hết hàng).</summary>
        public List<SanPhamDTO> LayTonKhoThap(int nguong)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE sp.SoLuongTon <= @Nguong ORDER BY sp.SoLuongTon, sp.MaSanPham",
                new SqlParameter("@Nguong", nguong));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra mã sản phẩm đã tồn tại chưa.</summary>
        public bool TonTaiMa(string ma)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM SanPham WHERE MaSanPham = @Ma",
                new SqlParameter("@Ma", ma));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Sinh mã mới dạng SP001, SP002, ...</summary>
        public string TaoMaMoi()
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaSanPham, 3, 10) AS INT)), 0) + 1 FROM SanPham");
            return "SP" + Convert.ToInt32(kq).ToString("D3");
        }

        /// <summary>Lấy số lượng tồn hiện tại của sản phẩm (không có sản phẩm thì trả về 0).</summary>
        public int LaySoLuongTon(string ma)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = @Ma",
                new SqlParameter("@Ma", ma));
            return kq == null || kq == DBNull.Value ? 0 : Convert.ToInt32(kq);
        }

        /// <summary>Đếm tổng số sản phẩm (dùng cho trang chủ / thống kê).</summary>
        public int DemTatCa()
        {
            return Convert.ToInt32(KetNoiCSDL.LayGiaTri("SELECT COUNT(*) FROM SanPham"));
        }

        /// <summary>Thêm sản phẩm mới. Trả về số dòng được thêm.</summary>
        public int Them(SanPhamDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO SanPham (MaSanPham, TenSanPham, MaDanhMuc, MaThuongHieu, MaKichThuoc, MaMauSac, MaChatLieu, " +
                "                     MaNhaCungCap, GiaNhap, GiaBan, TyLeLai, SoLuongTon, HinhAnh, MoTa, TrangThai, NgayTao) " +
                "VALUES (@Ma, @Ten, @MaDanhMuc, @MaThuongHieu, @MaKichThuoc, @MaMauSac, @MaChatLieu, " +
                "        @MaNhaCungCap, @GiaNhap, @GiaBan, @TyLeLai, @SoLuongTon, @HinhAnh, @MoTa, @TrangThai, @NgayTao)",
                TaoThamSo(dto));
        }

        /// <summary>Cập nhật sản phẩm theo mã (không đổi ngày tạo). Trả về số dòng được sửa.</summary>
        public int Sua(SanPhamDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE SanPham SET TenSanPham = @Ten, MaDanhMuc = @MaDanhMuc, MaThuongHieu = @MaThuongHieu, " +
                "       MaKichThuoc = @MaKichThuoc, MaMauSac = @MaMauSac, MaChatLieu = @MaChatLieu, " +
                "       MaNhaCungCap = @MaNhaCungCap, GiaNhap = @GiaNhap, GiaBan = @GiaBan, TyLeLai = @TyLeLai, " +
                "       SoLuongTon = @SoLuongTon, HinhAnh = @HinhAnh, MoTa = @MoTa, TrangThai = @TrangThai " +
                "WHERE MaSanPham = @Ma",
                TaoThamSo(dto));
        }

        /// <summary>Xóa sản phẩm theo mã (lỗi nếu sản phẩm đã có trong hóa đơn hoặc phiếu nhập).</summary>
        public int Xoa(string ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM SanPham WHERE MaSanPham = @Ma",
                new SqlParameter("@Ma", ma));
        }

        /// <summary>
        /// Cộng/trừ tồn kho TRONG MỘT TRANSACTION đang mở (dùng cho thanh toán và nhập hàng).
        /// soLuongThayDoi &lt; 0: trừ kho (bán), &gt; 0: cộng kho (nhập, hoặc hoàn lại khi hủy hóa đơn).
        /// Trả về 0 nếu không đủ tồn (tồn sau khi trừ sẽ bị âm) hoặc không có sản phẩm; khi đó nơi gọi phải Rollback.
        /// </summary>
        public int CapNhatTonKho(SqlConnection conn, SqlTransaction tran, string maSanPham, int soLuongThayDoi)
        {
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE SanPham SET SoLuongTon = SoLuongTon + @ThayDoi " +
                "WHERE MaSanPham = @Ma AND SoLuongTon + @ThayDoi >= 0", conn, tran))
            {
                cmd.Parameters.AddWithValue("@ThayDoi", soLuongThayDoi);
                cmd.Parameters.AddWithValue("@Ma", maSanPham);
                return cmd.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// Tính lại GIÁ NHẬP (giá vốn) hiện tại của sản phẩm từ TẤT CẢ các lần đã nhập (bảng ChiTietPhieuNhap):
        ///     giá nhập hiện tại = tổng (số lượng x giá nhập) / tổng số lượng
        /// Ví dụ: tháng 8 nhập 10 cái giá 80.000, tháng 9 nhập 10 cái giá 90.000 -> (800.000 + 900.000) / 20 = 85.000.
        /// Nếu sản phẩm có tỷ lệ lãi (TyLeLai > 0) thì GIÁ BÁN cũng tự cập nhật = giá nhập mới x (1 + TyLeLai/100).
        /// Sản phẩm chưa có lần nhập nào thì giữ nguyên giá nhập hiện có.
        /// Chạy TRONG transaction đang mở (gọi sau khi đã thêm/xóa chi tiết phiếu nhập). Trả về số dòng được cập nhật.
        /// </summary>
        public int TinhLaiGiaVonTuLichSuNhap(SqlConnection conn, SqlTransaction tran, string maSanPham)
        {
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE sp SET " +
                " sp.GiaNhap = x.GiaVon, " +
                " sp.GiaBan = CASE WHEN sp.TyLeLai > 0 THEN ROUND(x.GiaVon * (1 + sp.TyLeLai / 100.0), 0) ELSE sp.GiaBan END " +
                "FROM SanPham sp " +
                "CROSS APPLY (SELECT ROUND(SUM(CAST(ct.SoLuong AS DECIMAL(29,0)) * ct.GiaNhap) / SUM(ct.SoLuong), 0) AS GiaVon " +
                "             FROM ChiTietPhieuNhap ct WHERE ct.MaSanPham = sp.MaSanPham) x " +
                "WHERE sp.MaSanPham = @Ma AND x.GiaVon IS NOT NULL", conn, tran))
            {
                cmd.Parameters.AddWithValue("@Ma", maSanPham);
                return cmd.ExecuteNonQuery();
            }
        }

        // Tạo mảng tham số dùng chung cho Them và Sua (chỉ tạo mới mỗi lần gọi, không dùng lại)
        private SqlParameter[] TaoThamSo(SanPhamDTO dto)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@Ma", dto.MaSanPham),
                new SqlParameter("@Ten", dto.TenSanPham),
                new SqlParameter("@MaDanhMuc", dto.MaDanhMuc),
                new SqlParameter("@MaThuongHieu", dto.MaThuongHieu),
                new SqlParameter("@MaKichThuoc", dto.MaKichThuoc),
                new SqlParameter("@MaMauSac", dto.MaMauSac),
                new SqlParameter("@MaChatLieu", dto.MaChatLieu),
                new SqlParameter("@MaNhaCungCap", dto.MaNhaCungCap),
                new SqlParameter("@GiaNhap", dto.GiaNhap),
                new SqlParameter("@GiaBan", dto.GiaBan),
                new SqlParameter("@TyLeLai", dto.TyLeLai),
                new SqlParameter("@SoLuongTon", dto.SoLuongTon),
                new SqlParameter("@HinhAnh", (object)dto.HinhAnh ?? DBNull.Value),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value),
                new SqlParameter("@TrangThai", dto.TrangThai),
                new SqlParameter("@NgayTao", dto.NgayTao)
            };
        }
    }
}