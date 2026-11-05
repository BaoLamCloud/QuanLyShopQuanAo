using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ thương hiệu: kiểm tra dữ liệu rồi gọi ThuongHieuDAO.</summary>
    public class ThuongHieuBUS
    {
        private readonly ThuongHieuDAO dao = new ThuongHieuDAO();

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<ThuongHieuDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        /// <summary>Lấy theo mã, không có thì trả về null.</summary>
        public ThuongHieuDTO LayTheoMa(int ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm kiếm; từ khóa rỗng thì trả về toàn bộ danh sách.</summary>
        public List<ThuongHieuDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(ThuongHieuDTO dto, bool laSua)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.TenThuongHieu)) return "Vui lòng nhập tên thương hiệu.";
            if (dto.TenThuongHieu.Trim().Length > 100) return "Tên thương hiệu không được dài quá 100 ký tự.";
            if (dto.MoTa != null && dto.MoTa.Trim().Length > 255) return "Mô tả không được dài quá 255 ký tự.";
            if (dao.TonTaiTen(dto.TenThuongHieu.Trim(), laSua ? dto.MaThuongHieu : 0))
                return "Thương hiệu '" + dto.TenThuongHieu.Trim() + "' đã tồn tại.";
            return null;
        }

        /// <summary>Thêm mới.</summary>
        public KetQua Them(ThuongHieuDTO dto)
        {
            try
            {
                string loi = KiemTra(dto, false);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenThuongHieu = dto.TenThuongHieu.Trim();
                dto.MoTa = KiemTraDuLieu.ChuanHoaTuyChon(dto.MoTa);
                dao.Them(dto);
                return KetQua.Ok("Thêm thương hiệu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Cập nhật.</summary>
        public KetQua Sua(ThuongHieuDTO dto)
        {
            try
            {
                if (dto == null || dto.MaThuongHieu <= 0) return KetQua.Loi("Vui lòng chọn thương hiệu cần sửa.");
                if (dao.LayTheoMa(dto.MaThuongHieu) == null) return KetQua.Loi("Không tìm thấy thương hiệu cần sửa.");

                string loi = KiemTra(dto, true);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenThuongHieu = dto.TenThuongHieu.Trim();
                dto.MoTa = KiemTraDuLieu.ChuanHoaTuyChon(dto.MoTa);
                dao.Sua(dto);
                return KetQua.Ok("Cập nhật thương hiệu thành công.");
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
                if (ma <= 0) return KetQua.Loi("Vui lòng chọn thương hiệu cần xóa.");
                if (dao.LayTheoMa(ma) == null) return KetQua.Loi("Không tìm thấy thương hiệu cần xóa.");

                dao.Xoa(ma);
                return KetQua.Ok("Xóa thương hiệu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa thương hiệu. " + ex.Message);
            }
        }
    }
}
