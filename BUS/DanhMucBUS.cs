using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ danh mục: kiểm tra dữ liệu rồi gọi DanhMucDAO.</summary>
    public class DanhMucBUS
    {
        private readonly DanhMucDAO dao = new DanhMucDAO();

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<DanhMucDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        /// <summary>Lấy theo mã, không có thì trả về null.</summary>
        public DanhMucDTO LayTheoMa(int ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm kiếm; từ khóa rỗng thì trả về toàn bộ danh sách.</summary>
        public List<DanhMucDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(DanhMucDTO dto, bool laSua)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.TenDanhMuc)) return "Vui lòng nhập tên danh mục.";
            if (dto.TenDanhMuc.Trim().Length > 100) return "Tên danh mục không được dài quá 100 ký tự.";
            if (dto.MoTa != null && dto.MoTa.Trim().Length > 255) return "Mô tả không được dài quá 255 ký tự.";
            if (dao.TonTaiTen(dto.TenDanhMuc.Trim(), laSua ? dto.MaDanhMuc : 0))
                return "Danh mục '" + dto.TenDanhMuc.Trim() + "' đã tồn tại.";
            return null;
        }

        /// <summary>Thêm mới.</summary>
        public KetQua Them(DanhMucDTO dto)
        {
            try
            {
                string loi = KiemTra(dto, false);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenDanhMuc = dto.TenDanhMuc.Trim();
                dto.MoTa = KiemTraDuLieu.ChuanHoaTuyChon(dto.MoTa);
                dao.Them(dto);
                return KetQua.Ok("Thêm danh mục thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Cập nhật.</summary>
        public KetQua Sua(DanhMucDTO dto)
        {
            try
            {
                if (dto == null || dto.MaDanhMuc <= 0) return KetQua.Loi("Vui lòng chọn danh mục cần sửa.");
                if (dao.LayTheoMa(dto.MaDanhMuc) == null) return KetQua.Loi("Không tìm thấy danh mục cần sửa.");

                string loi = KiemTra(dto, true);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenDanhMuc = dto.TenDanhMuc.Trim();
                dto.MoTa = KiemTraDuLieu.ChuanHoaTuyChon(dto.MoTa);
                dao.Sua(dto);
                return KetQua.Ok("Cập nhật danh mục thành công.");
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
                if (ma <= 0) return KetQua.Loi("Vui lòng chọn danh mục cần xóa.");
                if (dao.LayTheoMa(ma) == null) return KetQua.Loi("Không tìm thấy danh mục cần xóa.");

                dao.Xoa(ma);
                return KetQua.Ok("Xóa danh mục thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa danh mục. " + ex.Message);
            }
        }
    }
}
