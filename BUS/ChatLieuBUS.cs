using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ chất liệu: kiểm tra dữ liệu rồi gọi ChatLieuDAO.</summary>
    public class ChatLieuBUS
    {
        private readonly ChatLieuDAO dao = new ChatLieuDAO();

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<ChatLieuDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        /// <summary>Lấy theo mã, không có thì trả về null.</summary>
        public ChatLieuDTO LayTheoMa(int ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm kiếm; từ khóa rỗng thì trả về toàn bộ danh sách.</summary>
        public List<ChatLieuDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(ChatLieuDTO dto, bool laSua)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.TenChatLieu)) return "Vui lòng nhập tên chất liệu.";
            if (dto.TenChatLieu.Trim().Length > 50) return "Tên chất liệu không được dài quá 50 ký tự.";
            if (dao.TonTaiTen(dto.TenChatLieu.Trim(), laSua ? dto.MaChatLieu : 0))
                return "Chất liệu '" + dto.TenChatLieu.Trim() + "' đã tồn tại.";
            return null;
        }

        /// <summary>Thêm mới.</summary>
        public KetQua Them(ChatLieuDTO dto)
        {
            try
            {
                string loi = KiemTra(dto, false);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenChatLieu = dto.TenChatLieu.Trim();
                dao.Them(dto);
                return KetQua.Ok("Thêm chất liệu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Cập nhật.</summary>
        public KetQua Sua(ChatLieuDTO dto)
        {
            try
            {
                if (dto == null || dto.MaChatLieu <= 0) return KetQua.Loi("Vui lòng chọn chất liệu cần sửa.");
                if (dao.LayTheoMa(dto.MaChatLieu) == null) return KetQua.Loi("Không tìm thấy chất liệu cần sửa.");

                string loi = KiemTra(dto, true);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenChatLieu = dto.TenChatLieu.Trim();
                dao.Sua(dto);
                return KetQua.Ok("Cập nhật chất liệu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Xóa (không xóa được nếu đang có sản phẩm sử dụng).</summary>
        public KetQua Xoa(int ma)
        {
            try
            {
                if (ma <= 0) return KetQua.Loi("Vui lòng chọn chất liệu cần xóa.");
                if (dao.LayTheoMa(ma) == null) return KetQua.Loi("Không tìm thấy chất liệu cần xóa.");

                dao.Xoa(ma);
                return KetQua.Ok("Xóa chất liệu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa chất liệu. " + ex.Message);
            }
        }
    }
}
