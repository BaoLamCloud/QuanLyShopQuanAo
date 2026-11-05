using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ nhà cung cấp: kiểm tra dữ liệu rồi gọi NhaCungCapDAO.</summary>
    public class NhaCungCapBUS
    {
        private readonly NhaCungCapDAO dao = new NhaCungCapDAO();

        public List<NhaCungCapDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public NhaCungCapDTO LayTheoMa(string ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm theo mã, tên hoặc số điện thoại; từ khóa rỗng thì trả về toàn bộ.</summary>
        public List<NhaCungCapDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        /// <summary>Sinh mã mới (NCC001, NCC002, ...) để hiển thị sẵn trên form.</summary>
        public string TaoMaMoi()
        {
            return dao.TaoMaMoi();
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(NhaCungCapDTO dto)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.MaNhaCungCap)) return "Vui lòng nhập mã nhà cung cấp.";
            if (dto.MaNhaCungCap.Trim().Length > 10) return "Mã nhà cung cấp không được dài quá 10 ký tự.";
            if (!KiemTraDuLieu.LaMaHopLe(dto.MaNhaCungCap)) return "Mã nhà cung cấp chỉ gồm chữ cái không dấu, số, gạch ngang hoặc gạch dưới.";
            if (KiemTraDuLieu.LaTrong(dto.TenNhaCungCap)) return "Vui lòng nhập tên nhà cung cấp.";
            if (dto.TenNhaCungCap.Trim().Length > 150) return "Tên nhà cung cấp không được dài quá 150 ký tự.";
            if (!KiemTraDuLieu.LaTrong(dto.SoDienThoai) && !KiemTraDuLieu.LaSoDienThoaiHopLe(dto.SoDienThoai))
                return "Số điện thoại không hợp lệ (ví dụ: 0901234567).";
            if (!KiemTraDuLieu.LaTrong(dto.Email) && (!KiemTraDuLieu.LaEmailHopLe(dto.Email) || dto.Email.Trim().Length > 100))
                return "Email không hợp lệ.";
            if (dto.DiaChi != null && dto.DiaChi.Trim().Length > 255) return "Địa chỉ không được dài quá 255 ký tự.";
            if (dto.GhiChu != null && dto.GhiChu.Trim().Length > 255) return "Ghi chú không được dài quá 255 ký tự.";
            return null;
        }

        // Chuẩn hóa: cắt khoảng trắng, mã viết hoa, trường tùy chọn rỗng thì để null
        private void ChuanHoa(NhaCungCapDTO dto)
        {
            dto.MaNhaCungCap = dto.MaNhaCungCap.Trim().ToUpper();
            dto.TenNhaCungCap = dto.TenNhaCungCap.Trim();
            dto.SoDienThoai = KiemTraDuLieu.ChuanHoaTuyChon(dto.SoDienThoai);
            dto.Email = KiemTraDuLieu.ChuanHoaTuyChon(dto.Email);
            dto.DiaChi = KiemTraDuLieu.ChuanHoaTuyChon(dto.DiaChi);
            dto.GhiChu = KiemTraDuLieu.ChuanHoaTuyChon(dto.GhiChu);
        }

        public KetQua Them(NhaCungCapDTO dto)
        {
            try
            {
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (dao.TonTaiMa(dto.MaNhaCungCap))
                    return KetQua.Loi("Mã nhà cung cấp '" + dto.MaNhaCungCap + "' đã tồn tại.");

                dao.Them(dto);
                return KetQua.Ok("Thêm nhà cung cấp thành công.", dto.MaNhaCungCap);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        public KetQua Sua(NhaCungCapDTO dto)
        {
            try
            {
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (!dao.TonTaiMa(dto.MaNhaCungCap))
                    return KetQua.Loi("Không tìm thấy nhà cung cấp cần sửa.");

                dao.Sua(dto);
                return KetQua.Ok("Cập nhật nhà cung cấp thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        public KetQua Xoa(string ma)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(ma)) return KetQua.Loi("Vui lòng chọn nhà cung cấp cần xóa.");
                if (!dao.TonTaiMa(ma.Trim())) return KetQua.Loi("Không tìm thấy nhà cung cấp cần xóa.");

                dao.Xoa(ma.Trim());
                return KetQua.Ok("Xóa nhà cung cấp thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa nhà cung cấp (có thể đang có sản phẩm hoặc phiếu nhập liên quan). " + ex.Message);
            }
        }
    }
}
