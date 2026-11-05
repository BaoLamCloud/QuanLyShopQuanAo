using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng MauSac (SELECT, INSERT, UPDATE, DELETE).</summary>
    public class MauSacDAO
    {
        // Chuyển DataTable thành List<MauSacDTO> bằng LINQ
        private List<MauSacDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new MauSacDTO
            {
                MaMauSac = Convert.ToInt32(dong["MaMauSac"]),
                TenMauSac = Convert.ToString(dong["TenMauSac"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<MauSacDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT MaMauSac, TenMauSac FROM MauSac ORDER BY MaMauSac");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một dòng theo mã, không có thì trả về null.</summary>
        public MauSacDTO LayTheoMa(int ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaMauSac, TenMauSac FROM MauSac WHERE MaMauSac = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã hoặc tên.</summary>
        public List<MauSacDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaMauSac, TenMauSac FROM MauSac " +
                "WHERE CAST(MaMauSac AS NVARCHAR(10)) LIKE @TuKhoa OR TenMauSac LIKE @TuKhoa " +
                "ORDER BY MaMauSac",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra tên đã tồn tại chưa (bỏ qua dòng có mã = maLoaiTru, dùng khi sửa).</summary>
        public bool TonTaiTen(string ten, int maLoaiTru)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM MauSac WHERE TenMauSac = @Ten AND MaMauSac <> @MaLoaiTru",
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MaLoaiTru", maLoaiTru));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Thêm mới (mã tự tăng). Trả về số dòng được thêm.</summary>
        public int Them(MauSacDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO MauSac (TenMauSac) VALUES (@Ten)",
                new SqlParameter("@Ten", dto.TenMauSac));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(MauSacDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE MauSac SET TenMauSac = @Ten WHERE MaMauSac = @Ma",
                new SqlParameter("@Ten", dto.TenMauSac),
                new SqlParameter("@Ma", dto.MaMauSac));
        }

        /// <summary>Xóa theo mã. Trả về số dòng bị xóa (lỗi nếu đang được sản phẩm sử dụng).</summary>
        public int Xoa(int ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM MauSac WHERE MaMauSac = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
