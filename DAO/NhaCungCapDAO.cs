using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng NhaCungCap.</summary>
    public class NhaCungCapDAO
    {
        private const string CotCanLay = "MaNhaCungCap, TenNhaCungCap, SoDienThoai, Email, DiaChi, GhiChu";

        // Chuyển DataTable thành List<NhaCungCapDTO> bằng LINQ
        private List<NhaCungCapDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new NhaCungCapDTO
            {
                MaNhaCungCap = Convert.ToString(dong["MaNhaCungCap"]),
                TenNhaCungCap = Convert.ToString(dong["TenNhaCungCap"]),
                SoDienThoai = Convert.ToString(dong["SoDienThoai"]),
                Email = Convert.ToString(dong["Email"]),
                DiaChi = Convert.ToString(dong["DiaChi"]),
                GhiChu = Convert.ToString(dong["GhiChu"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ nhà cung cấp.</summary>
        public List<NhaCungCapDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT " + CotCanLay + " FROM NhaCungCap ORDER BY MaNhaCungCap");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một nhà cung cấp theo mã, không có thì trả về null.</summary>
        public NhaCungCapDTO LayTheoMa(string ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM NhaCungCap WHERE MaNhaCungCap = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã, tên hoặc số điện thoại.</summary>
        public List<NhaCungCapDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM NhaCungCap " +
                "WHERE MaNhaCungCap LIKE @TuKhoa OR TenNhaCungCap LIKE @TuKhoa OR SoDienThoai LIKE @TuKhoa " +
                "ORDER BY MaNhaCungCap",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra mã đã tồn tại chưa.</summary>
        public bool TonTaiMa(string ma)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM NhaCungCap WHERE MaNhaCungCap = @Ma",
                new SqlParameter("@Ma", ma));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Sinh mã mới dạng NCC001, NCC002, ...</summary>
        public string TaoMaMoi()
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaNhaCungCap, 4, 10) AS INT)), 0) + 1 FROM NhaCungCap");
            return "NCC" + Convert.ToInt32(kq).ToString("D3");
        }

        /// <summary>Thêm mới. Trả về số dòng được thêm.</summary>
        public int Them(NhaCungCapDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, SoDienThoai, Email, DiaChi, GhiChu) " +
                "VALUES (@Ma, @Ten, @Sdt, @Email, @DiaChi, @GhiChu)",
                new SqlParameter("@Ma", dto.MaNhaCungCap),
                new SqlParameter("@Ten", dto.TenNhaCungCap),
                new SqlParameter("@Sdt", (object)dto.SoDienThoai ?? DBNull.Value),
                new SqlParameter("@Email", (object)dto.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)dto.DiaChi ?? DBNull.Value),
                new SqlParameter("@GhiChu", (object)dto.GhiChu ?? DBNull.Value));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(NhaCungCapDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE NhaCungCap SET TenNhaCungCap = @Ten, SoDienThoai = @Sdt, Email = @Email, " +
                "DiaChi = @DiaChi, GhiChu = @GhiChu WHERE MaNhaCungCap = @Ma",
                new SqlParameter("@Ma", dto.MaNhaCungCap),
                new SqlParameter("@Ten", dto.TenNhaCungCap),
                new SqlParameter("@Sdt", (object)dto.SoDienThoai ?? DBNull.Value),
                new SqlParameter("@Email", (object)dto.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)dto.DiaChi ?? DBNull.Value),
                new SqlParameter("@GhiChu", (object)dto.GhiChu ?? DBNull.Value));
        }

        /// <summary>Xóa theo mã (lỗi nếu nhà cung cấp đang có sản phẩm hoặc phiếu nhập).</summary>
        public int Xoa(string ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM NhaCungCap WHERE MaNhaCungCap = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
