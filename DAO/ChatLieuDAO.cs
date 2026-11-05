using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    /// <summary>Truy cập dữ liệu bảng ChatLieu (SELECT, INSERT, UPDATE, DELETE).</summary>
    public class ChatLieuDAO
    {
        // Chuyển DataTable thành List<ChatLieuDTO> bằng LINQ
        private List<ChatLieuDTO> ChuyenDanhSach(DataTable bang)
        {
            return bang.Rows.Cast<DataRow>().Select(dong => new ChatLieuDTO
            {
                MaChatLieu = Convert.ToInt32(dong["MaChatLieu"]),
                TenChatLieu = Convert.ToString(dong["TenChatLieu"])
            }).ToList();
        }

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<ChatLieuDTO> LayTatCa()
        {
            DataTable bang = KetNoiCSDL.LayDuLieu("SELECT MaChatLieu, TenChatLieu FROM ChatLieu ORDER BY MaChatLieu");
            return ChuyenDanhSach(bang);
        }

        /// <summary>Lấy một dòng theo mã, không có thì trả về null.</summary>
        public ChatLieuDTO LayTheoMa(int ma)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaChatLieu, TenChatLieu FROM ChatLieu WHERE MaChatLieu = @Ma",
                new SqlParameter("@Ma", ma));
            return ChuyenDanhSach(bang).FirstOrDefault();
        }

        /// <summary>Tìm theo mã hoặc tên.</summary>
        public List<ChatLieuDTO> TimKiem(string tuKhoa)
        {
            DataTable bang = KetNoiCSDL.LayDuLieu(
                "SELECT MaChatLieu, TenChatLieu FROM ChatLieu " +
                "WHERE CAST(MaChatLieu AS NVARCHAR(10)) LIKE @TuKhoa OR TenChatLieu LIKE @TuKhoa " +
                "ORDER BY MaChatLieu",
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDanhSach(bang);
        }

        /// <summary>Kiểm tra tên đã tồn tại chưa (bỏ qua dòng có mã = maLoaiTru, dùng khi sửa).</summary>
        public bool TonTaiTen(string ten, int maLoaiTru)
        {
            object kq = KetNoiCSDL.LayGiaTri(
                "SELECT COUNT(*) FROM ChatLieu WHERE TenChatLieu = @Ten AND MaChatLieu <> @MaLoaiTru",
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MaLoaiTru", maLoaiTru));
            return Convert.ToInt32(kq) > 0;
        }

        /// <summary>Thêm mới (mã tự tăng). Trả về số dòng được thêm.</summary>
        public int Them(ChatLieuDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "INSERT INTO ChatLieu (TenChatLieu) VALUES (@Ten)",
                new SqlParameter("@Ten", dto.TenChatLieu));
        }

        /// <summary>Cập nhật theo mã. Trả về số dòng được sửa.</summary>
        public int Sua(ChatLieuDTO dto)
        {
            return KetNoiCSDL.ThucThi(
                "UPDATE ChatLieu SET TenChatLieu = @Ten WHERE MaChatLieu = @Ma",
                new SqlParameter("@Ten", dto.TenChatLieu),
                new SqlParameter("@Ma", dto.MaChatLieu));
        }

        /// <summary>Xóa theo mã. Trả về số dòng bị xóa (lỗi nếu đang được sản phẩm sử dụng).</summary>
        public int Xoa(int ma)
        {
            return KetNoiCSDL.ThucThi(
                "DELETE FROM ChatLieu WHERE MaChatLieu = @Ma",
                new SqlParameter("@Ma", ma));
        }
    }
}
