using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng KhachHang.</summary>
    public class KhachHangDAO
    {
        private const string CotCanLay = "MaKhachHang, HoTen, SoDienThoai, Email, DiaChi, NgayTao";

        // Chuyển DataTable thành List<KhachHangDTO> bằng LINQ
        private List<KhachHangDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new KhachHangDTO
            {
                MaKhachHang = Convert.ToString(dong["MaKhachHang"]),
                HoTen = Convert.ToString(dong["HoTen"]),
                SoDienThoai = Convert.ToString(dong["SoDienThoai"]),
                Email = Convert.ToString(dong["Email"]),
                DiaChi = Convert.ToString(dong["DiaChi"]),
                NgayTao = Convert.ToDateTime(dong["NgayTao"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ khách hàng.</summary>
        public List<KhachHangDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT " + CotCanLay + " FROM KhachHang ORDER BY MaKhachHang");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một khách hàng theo mã, không có thì trả về null.</summary>
        public KhachHangDTO LayTheoMa(string ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM KhachHang WHERE MaKhachHang = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã, họ tên hoặc số điện thoại.</summary>
        public List<KhachHangDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT " + CotCanLay + " FROM KhachHang " +
                "WHERE MaKhachHang LIKE @TuKhoa OR HoTen LIKE @TuKhoa OR SoDienThoai LIKE @TuKhoa " +
                "ORDER BY MaKhachHang",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra mã đã tồn tại chưa.</summary>
        public bool TonTaiMa(string ma)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang = @Ma",
                new SqlParameter("@Ma", ma));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Sinh mã mới dạng KH001, KH002, ...</summary>
        public string TaoMaMoi()
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaKhachHang, 3, 10) AS INT)), 0) + 1 FROM KhachHang");
            return "KH" + Convert.ToInt32(kq).ToString("D3");
        }

        /// <summary>Thêm mới. Trả về số dòng được thêm.</summary>
        public int Them(KhachHangDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO KhachHang (MaKhachHang, HoTen, SoDienThoai, Email, DiaChi, NgayTao) " +
                "VALUES (@Ma, @HoTen, @Sdt, @Email, @DiaChi, @NgayTao)",
                new SqlParameter("@Ma", dto.MaKhachHang),
                new SqlParameter("@HoTen", dto.HoTen),
                new SqlParameter("@Sdt", (object)dto.SoDienThoai ?? DBNull.Value),
                new SqlParameter("@Email", (object)dto.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)dto.DiaChi ?? DBNull.Value),
                new SqlParameter("@NgayTao", dto.NgayTao));
        }

        /// <summary>Cập nhật theo mã (không đổi ngày tạo). Trả về số dòng được sửa.</summary>
        public int Sua(KhachHangDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE KhachHang SET HoTen = @HoTen, SoDienThoai = @Sdt, Email = @Email, DiaChi = @DiaChi " +
                "WHERE MaKhachHang = @Ma",
                new SqlParameter("@Ma", dto.MaKhachHang),
                new SqlParameter("@HoTen", dto.HoTen),
                new SqlParameter("@Sdt", (object)dto.SoDienThoai ?? DBNull.Value),
                new SqlParameter("@Email", (object)dto.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object)dto.DiaChi ?? DBNull.Value));
        }

        /// <summary>Xóa theo mã (lỗi nếu khách hàng đã có hóa đơn).</summary>
        public int Xoa(string ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM KhachHang WHERE MaKhachHang = @Ma",
                new SqlParameter("@Ma", ma));
        }

        /// <summary>Đếm tổng số khách hàng (dùng cho trang chủ / thống kê).</summary>
        public int DemTatCa()
        {
            return Convert.ToInt32(KetNoiCSDL.LayGiaTri("SELECT COUNT(*) FROM KhachHang"));
        }
    }
}
