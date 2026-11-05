using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ kích thước: kiểm tra dữ liệu rồi gọi KichThuocDAO.</summary>
    public class KichThuocBUS
    {
        private readonly KichThuocDAO dao = new KichThuocDAO();

        /// <summary>Lấy toàn bộ danh sách.</summary>
        public List<KichThuocDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        /// <summary>Lấy theo mã, không có thì trả về null.</summary>
        public KichThuocDTO LayTheoMa(int ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm kiếm; từ khóa rỗng thì trả về toàn bộ danh sách.</summary>
        public List<KichThuocDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(KichThuocDTO dto, bool laSua)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.TenKichThuoc)) return "Vui lòng nhập tên kích thước.";
            if (dto.TenKichThuoc.Trim().Length > 20) return "Tên kích thước không được dài quá 20 ký tự.";
            if (dao.TonTaiTen(dto.TenKichThuoc.Trim(), laSua ? dto.MaKichThuoc : 0))
                return "Kích thước '" + dto.TenKichThuoc.Trim() + "' đã tồn tại.";
            return null;
        }

        /// <summary>Thêm mới.</summary>
        public KetQua Them(KichThuocDTO dto)
        {
            try
            {
                string loi = KiemTra(dto, false);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenKichThuoc = dto.TenKichThuoc.Trim();
                dao.Them(dto);
                return KetQua.Ok("Thêm kích thước thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Cập nhật.</summary>
        public KetQua Sua(KichThuocDTO dto)
        {
            try
            {
                if (dto == null || dto.MaKichThuoc <= 0) return KetQua.Loi("Vui lòng chọn kích thước cần sửa.");
                if (dao.LayTheoMa(dto.MaKichThuoc) == null) return KetQua.Loi("Không tìm thấy kích thước cần sửa.");

                string loi = KiemTra(dto, true);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenKichThuoc = dto.TenKichThuoc.Trim();
                dao.Sua(dto);
                return KetQua.Ok("Cập nhật kích thước thành công.");
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
                if (ma <= 0) return KetQua.Loi("Vui lòng chọn kích thước cần xóa.");
                if (dao.LayTheoMa(ma) == null) return KetQua.Loi("Không tìm thấy kích thước cần xóa.");

                dao.Xoa(ma);
                return KetQua.Ok("Xóa kích thước thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa kích thước. " + ex.Message);
            }
        }
    }
}
