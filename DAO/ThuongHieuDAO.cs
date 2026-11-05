using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng ThuongHieu (SELECT, INSERT, UPDATE, DELETE).</summary>
    public class ThuongHieuDAO
    {
        // Chuyển DataTable thành List<ThuongHieuDTO> bằng LINQ
        private List<ThuongHieuDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new ThuongHieuDTO
            {
                MaThuongHieu = Convert.ToInt32(dong["MaThuongHieu"]),
                TenThuongHieu = Convert.ToString(dong["TenThuongHieu"]),
                MoTa = Convert.ToString(dong["MoTa"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<ThuongHieuDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT MaThuongHieu, TenThuongHieu, MoTa FROM ThuongHieu ORDER BY MaThuongHieu");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một dòng theo mã, không có thì trả về null.</summary>
        public ThuongHieuDTO LayTheoMa(int ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaThuongHieu, TenThuongHieu, MoTa FROM ThuongHieu WHERE MaThuongHieu = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã hoặc tên hoặc mô tả.</summary>
        public List<ThuongHieuDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaThuongHieu, TenThuongHieu, MoTa FROM ThuongHieu " +
                "WHERE CAST(MaThuongHieu AS NVARCHAR(10)) LIKE @TuKhoa OR TenThuongHieu LIKE @TuKhoa OR MoTa LIKE @TuKhoa " +
                "ORDER BY MaThuongHieu",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra tên đã tồn tại chưa (bỏ qua dòng có mã = maLoaiTru, dùng khi sửa).</summary>
        public bool TonTaiTen(string ten, int maLoaiTru)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM ThuongHieu WHERE TenThuongHieu = @Ten AND MaThuongHieu <> @MaLoaiTru",
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MaLoaiTru", maLoaiTru));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Thêm mới (mã tự tăng). Trả về số dòng được thêm.</summary>
        public int Them(ThuongHieuDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO ThuongHieu (TenThuongHieu, MoTa) VALUES (@Ten, @MoTa)",
                new SqlParameter("@Ten", dto.TenThuongHieu),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(ThuongHieuDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE ThuongHieu SET TenThuongHieu = @Ten, MoTa = @MoTa WHERE MaThuongHieu = @Ma",
                new SqlParameter("@Ten", dto.TenThuongHieu),
                new SqlParameter("@Ma", dto.MaThuongHieu),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value));
        }

        /// <summary>Xóa theo mã. Trả về số dòng bị xóa (lỗi nếu đang được sản phẩm sử dụng).</summary>
        public int Xoa(int ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM ThuongHieu WHERE MaThuongHieu = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
