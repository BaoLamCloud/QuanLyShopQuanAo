using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng KichThuoc (SELECT, INSERT, UPDATE, DELETE).</summary>
    public class KichThuocDAO
    {
        // Chuyển DataTable thành List<KichThuocDTO> bằng LINQ
        private List<KichThuocDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new KichThuocDTO
            {
                MaKichThuoc = Convert.ToInt32(dong["MaKichThuoc"]),
                TenKichThuoc = Convert.ToString(dong["TenKichThuoc"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<KichThuocDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT MaKichThuoc, TenKichThuoc FROM KichThuoc ORDER BY MaKichThuoc");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một dòng theo mã, không có thì trả về null.</summary>
        public KichThuocDTO LayTheoMa(int ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaKichThuoc, TenKichThuoc FROM KichThuoc WHERE MaKichThuoc = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã hoặc tên.</summary>
        public List<KichThuocDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaKichThuoc, TenKichThuoc FROM KichThuoc " +
                "WHERE CAST(MaKichThuoc AS NVARCHAR(10)) LIKE @TuKhoa OR TenKichThuoc LIKE @TuKhoa " +
                "ORDER BY MaKichThuoc",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra tên đã tồn tại chưa (bỏ qua dòng có mã = maLoaiTru, dùng khi sửa).</summary>
        public bool TonTaiTen(string ten, int maLoaiTru)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM KichThuoc WHERE TenKichThuoc = @Ten AND MaKichThuoc <> @MaLoaiTru",
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MaLoaiTru", maLoaiTru));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Thêm mới (mã tự tăng). Trả về số dòng được thêm.</summary>
        public int Them(KichThuocDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO KichThuoc (TenKichThuoc) VALUES (@Ten)",
                new SqlParameter("@Ten", dto.TenKichThuoc));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(KichThuocDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE KichThuoc SET TenKichThuoc = @Ten WHERE MaKichThuoc = @Ma",
                new SqlParameter("@Ten", dto.TenKichThuoc),
                new SqlParameter("@Ma", dto.MaKichThuoc));
        }

        /// <summary>Xóa theo mã. Trả về số dòng bị xóa (lỗi nếu đang được sản phẩm sử dụng).</summary>
        public int Xoa(int ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM KichThuoc WHERE MaKichThuoc = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
