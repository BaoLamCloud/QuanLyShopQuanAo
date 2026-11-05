using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng DanhMuc (SELECT, INSERT, UPDATE, DELETE).</summary>
    public class DanhMucDAO
    {
        // Chuyển DataTable thành List<DanhMucDTO> bằng LINQ
        private List<DanhMucDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new DanhMucDTO
            {
                MaDanhMuc = Convert.ToInt32(dong["MaDanhMuc"]),
                TenDanhMuc = Convert.ToString(dong["TenDanhMuc"]),
                MoTa = Convert.ToString(dong["MoTa"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<DanhMucDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT MaDanhMuc, TenDanhMuc, MoTa FROM DanhMuc ORDER BY MaDanhMuc");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một dòng theo mã, không có thì trả về null.</summary>
        public DanhMucDTO LayTheoMa(int ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM DanhMuc WHERE MaDanhMuc = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã hoặc tên hoặc mô tả.</summary>
        public List<DanhMucDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM DanhMuc " +
                "WHERE CAST(MaDanhMuc AS NVARCHAR(10)) LIKE @TuKhoa OR TenDanhMuc LIKE @TuKhoa OR MoTa LIKE @TuKhoa " +
                "ORDER BY MaDanhMuc",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra tên đã tồn tại chưa (bỏ qua dòng có mã = maLoaiTru, dùng khi sửa).</summary>
        public bool TonTaiTen(string ten, int maLoaiTru)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM DanhMuc WHERE TenDanhMuc = @Ten AND MaDanhMuc <> @MaLoaiTru",
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MaLoaiTru", maLoaiTru));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Thêm mới (mã tự tăng). Trả về số dòng được thêm.</summary>
        public int Them(DanhMucDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO DanhMuc (TenDanhMuc, MoTa) VALUES (@Ten, @MoTa)",
                new SqlParameter("@Ten", dto.TenDanhMuc),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(DanhMucDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE DanhMuc SET TenDanhMuc = @Ten, MoTa = @MoTa WHERE MaDanhMuc = @Ma",
                new SqlParameter("@Ten", dto.TenDanhMuc),
                new SqlParameter("@Ma", dto.MaDanhMuc),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value));
        }

        /// <summary>Xóa theo mã. Trả về số dòng bị xóa (lỗi nếu đang được sản phẩm sử dụng).</summary>
        public int Xoa(int ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM DanhMuc WHERE MaDanhMuc = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
