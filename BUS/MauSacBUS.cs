using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ màu sắc: kiểm tra dữ liệu rồi gọi MauSacDAO.</summary>
    public class MauSacBUS
    {
        private readonly MauSacDAO dao = new MauSacDAO();

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<MauSacDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        /// <summary>Lấy theo mã, không có thì trả về null.</summary>
        public MauSacDTO LayTheoMa(int ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm kiếm; từ khóa rỗng thì trả về toàn bộ danh sách.</summary>
        public List<MauSacDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(MauSacDTO dto, bool laSua)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.TenMauSac)) return "Vui lòng nhập tên màu sắc.";
            if (dto.TenMauSac.Trim().Length > 50) return "Tên màu sắc không được dài quá 50 ký tự.";
            if (dao.TonTaiTen(dto.TenMauSac.Trim(), laSua ? dto.MaMauSac : 0))
                return "Màu sắc '" + dto.TenMauSac.Trim() + "' đã tồn tại.";
            return null;
        }

        /// <summary>Thêm mới.</summary>
        public KetQua Them(MauSacDTO dto)
        {
            try
            {
                string loi = KiemTra(dto, false);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenMauSac = dto.TenMauSac.Trim();
                dao.Them(dto);
                return KetQua.Ok("Thêm màu sắc thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Cập nhật.</summary>
        public KetQua Sua(MauSacDTO dto)
        {
            try
            {
                if (dto == null || dto.MaMauSac <= 0) return KetQua.Loi("Vui lòng chọn màu sắc cần sửa.");
                if (dao.LayTheoMa(dto.MaMauSac) == null) return KetQua.Loi("Không tìm thấy màu sắc cần sửa.");

                string loi = KiemTra(dto, true);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenMauSac = dto.TenMauSac.Trim();
                dao.Sua(dto);
                return KetQua.Ok("Cập nhật màu sắc thành công.");
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
                if (ma <= 0) return KetQua.Loi("Vui lòng chọn màu sắc cần xóa.");
                if (dao.LayTheoMa(ma) == null) return KetQua.Loi("Không tìm thấy màu sắc cần xóa.");

                dao.Xoa(ma);
                return KetQua.Ok("Xóa màu sắc thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa màu sắc. " + ex.Message);
            }
        }
    }
}
