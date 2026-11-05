using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng TaiKhoan (JOIN NhanVien để lấy tên nhân viên).</summary>
    public class TaiKhoanDAO
    {
        // Câu SELECT dùng chung, có JOIN để lấy tên nhân viên liên kết
        private const string CauSelect =
            "SELECT tk.TenDangNhap, tk.MatKhauHash, tk.Muoi, tk.VaiTro, tk.MaNhanVien, tk.TrangThai, " +
            "       nv.HoTen AS TenNhanVien " +
            "FROM TaiKhoan tk " +
            "JOIN NhanVien nv ON nv.MaNhanVien = tk.MaNhanVien ";

        // Chuyển DataTable thành List<TaiKhoanDTO> bằng LINQ
        private List<TaiKhoanDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new TaiKhoanDTO
            {
                TenDangNhap = Convert.ToString(dong["TenDangNhap"]),
                MatKhauHash = Convert.ToString(dong["MatKhauHash"]),
                Muoi = Convert.ToString(dong["Muoi"]),
                VaiTro = Convert.ToString(dong["VaiTro"]),
                MaNhanVien = Convert.ToString(dong["MaNhanVien"]),
                TrangThai = Convert.ToBoolean(dong["TrangThai"]),
                TenNhanVien = Convert.ToString(dong["TenNhanVien"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ tài khoản.</summary>
        public List<TaiKhoanDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(CauSelect + "ORDER BY tk.TenDangNhap");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy tài khoản theo tên đăng nhập (dùng khi đăng nhập), không có thì trả về null.</summary>
        public TaiKhoanDTO LayTheoTenDangNhap(string tenDangNhap)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE tk.TenDangNhap = @Ten",
                new SqlParameter("@Ten", tenDangNhap));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo tên đăng nhập hoặc tên nhân viên.</summary>
        public List<TaiKhoanDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                CauSelect + "WHERE tk.TenDangNhap LIKE @TuKhoa OR nv.HoTen LIKE @TuKhoa ORDER BY tk.TenDangNhap",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra tên đăng nhập đã tồn tại chưa.</summary>
        public bool TonTaiTenDangNhap(string tenDangNhap)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Ten",
                new SqlParameter("@Ten", tenDangNhap));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Kiểm tra nhân viên đã có tài khoản chưa (mỗi nhân viên chỉ có 1 tài khoản).</summary>
        public bool NhanVienDaCoTaiKhoan(string maNhanVien, string tenDangNhapLoaiTru)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM TaiKhoan WHERE MaNhanVien = @MaNV AND TenDangNhap <> @Ten",
                new SqlParameter("@MaNV", maNhanVien),
                new SqlParameter("@Ten", tenDangNhapLoaiTru ?? ""));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Đếm số quản trị viên đang hoạt động (để không cho xóa/khóa quản trị viên cuối cùng).</summary>
        public int DemQuanTriDangHoatDong()
        {
            return Convert.ToInt32(KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM TaiKhoan WHERE VaiTro = N'QuanTri' AND TrangThai = 1"));
        }

        /// <summary>Thêm tài khoản mới (mật khẩu đã băm sẵn ở BUS). Trả về số dòng được thêm.</summary>
        public int Them(TaiKhoanDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO TaiKhoan (TenDangNhap, MatKhauHash, Muoi, VaiTro, MaNhanVien, TrangThai) " +
                "VALUES (@Ten, @Hash, @Muoi, @VaiTro, @MaNV, @TrangThai)",
                new SqlParameter("@Ten", dto.TenDangNhap),
                new SqlParameter("@Hash", dto.MatKhauHash),
                new SqlParameter("@Muoi", dto.Muoi),
                new SqlParameter("@VaiTro", dto.VaiTro),
                new SqlParameter("@MaNV", dto.MaNhanVien),
                new SqlParameter("@TrangThai", dto.TrangThai));
        }

        /// <summary>Sửa vai trò, nhân viên liên kết, trạng thái (KHÔNG đổi mật khẩu).</summary>
        public int Sua(TaiKhoanDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE TaiKhoan SET VaiTro = @VaiTro, MaNhanVien = @MaNV, TrangThai = @TrangThai " +
                "WHERE TenDangNhap = @Ten",
                new SqlParameter("@Ten", dto.TenDangNhap),
                new SqlParameter("@VaiTro", dto.VaiTro),
                new SqlParameter("@MaNV", dto.MaNhanVien),
                new SqlParameter("@TrangThai", dto.TrangThai));
        }

        /// <summary>Đổi mật khẩu: lưu hash và muối mới.</summary>
        public int DoiMatKhau(string tenDangNhap, string matKhauHashMoi, string muoiMoi)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE TaiKhoan SET MatKhauHash = @Hash, Muoi = @Muoi WHERE TenDangNhap = @Ten",
                new SqlParameter("@Ten", tenDangNhap),
                new SqlParameter("@Hash", matKhauHashMoi),
                new SqlParameter("@Muoi", muoiMoi));
        }

        /// <summary>Xóa tài khoản theo tên đăng nhập.</summary>
        public int Xoa(string tenDangNhap)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM TaiKhoan WHERE TenDangNhap = @Ten",
                new SqlParameter("@Ten", tenDangNhap));
        }
    }
}
