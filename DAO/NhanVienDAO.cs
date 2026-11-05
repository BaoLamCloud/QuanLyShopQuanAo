using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng NhanVien.</summary>
    public class NhanVienDAO
    {
        private const string CotCanLay =
            "MaNhanVien, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, DiaChi, NgayVaoLam, TrangThai";

        // Chuyển DataTable thành List<NhanVienDTO> bằng LINQ
        private List<NhanVienDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new NhanVienDTO
            {
                MaNhanVien = Convert.ToString(dong["MaNhanVien"]),
                HoTen = Convert.ToString(dong["HoTen"]),
                GioiTinh = Convert.ToString(dong["GioiTinh"]),
                // NgaySinh có thể NULL trong CSDL
                NgaySinh = dong["NgaySinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dong["NgaySinh"]),
                SoDienThoai = Convert.ToString(dong["SoDienThoai"]),
                Email = Convert.ToString(dong["Email"]),
                DiaChi = Convert.ToString(dong["DiaChi"]),
                NgayVaoLam = Convert.ToDateTime(dong["NgayVaoLam"]),
                TrangThai = Convert.ToBoolean(dong["TrangThai"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ nhân viên.</summary>
        public List<NhanVienDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT " + CotCanLay + " FROM NhanVien ORDER BY MaNhanVien");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy các nhân viên đang làm việc (dùng cho combobox chọn nhân viên).</summary>
        public List<NhanVienDTO> LayDangLam()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM NhanVien WHERE TrangThai = 1 ORDER BY MaNhanVien");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một nhân viên theo mã, không có thì trả về null.</summary>
        public NhanVienDTO LayTheoMa(string ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM NhanVien WHERE MaNhanVien = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã, họ tên hoặc số điện thoại.</summary>
        public List<NhanVienDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM NhanVien " +
                "WHERE MaNhanVien LIKE @TuKhoa OR HoTen LIKE @TuKhoa OR SoDienThoai LIKE @TuKhoa " +
                "ORDER BY MaNhanVien",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra mã đã tồn tại chưa.</summary>
        public bool TonTaiMa(string ma)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @Ma",
                new SqlParameter("@Ma", ma));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Sinh mã mới dạng NV001, NV002, ...</summary>
        public string TaoMaMoi()
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaNhanVien, 3, 10) AS INT)), 0) + 1 FROM NhanVien");
            return "NV" + Convert.ToInt32(kq).ToString("D3");
        }

        /// <summary>Thêm mới. Trả về số dòng được thêm.</summary>
        public int Them(NhanVienDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, DiaChi, NgayVaoLam, TrangThai) " +
                "VALUES (@Ma, @HoTen, @GioiTinh, @NgaySinh, @Sdt, @Email, @DiaChi, @NgayVaoLam, @TrangThai)",
                new SqlParameter("@Ma", dto.MaNhanVien),
                new SqlParameter("@HoTen", dto.HoTen),
                new SqlParameter("@GioiTinh", dto.GioiTinh),
                new SqlParameter("@NgaySinh", (object)dto.NgaySinh ?? DBNull.Value),
                new SqlParameter("@Sdt", (object)dto.SoDienThoai ?? DBNull.Value),
                new SqlParameter("@Email", (object)dto.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)dto.DiaChi ?? DBNull.Value),
                new SqlParameter("@NgayVaoLam", dto.NgayVaoLam),
                new SqlParameter("@TrangThai", dto.TrangThai));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(NhanVienDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, " +
                "SoDienThoai = @Sdt, Email = @Email, DiaChi = @DiaChi, NgayVaoLam = @NgayVaoLam, TrangThai = @TrangThai " +
                "WHERE MaNhanVien = @Ma",
                new SqlParameter("@Ma", dto.MaNhanVien),
                new SqlParameter("@HoTen", dto.HoTen),
                new SqlParameter("@GioiTinh", dto.GioiTinh),
                new SqlParameter("@NgaySinh", (object)dto.NgaySinh ?? DBNull.Value),
                new SqlParameter("@Sdt", (object)dto.SoDienThoai ?? DBNull.Value),
                new SqlParameter("@Email", (object)dto.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)dto.DiaChi ?? DBNull.Value),
                new SqlParameter("@NgayVaoLam", dto.NgayVaoLam),
                new SqlParameter("@TrangThai", dto.TrangThai));
        }

        /// <summary>Xóa theo mã (lỗi nếu nhân viên đã có tài khoản, hóa đơn hoặc phiếu nhập).</summary>
        public int Xoa(string ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM NhanVien WHERE MaNhanVien = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
