using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ khách hàng: kiểm tra dữ liệu rồi gọi KhachHangDAO.</summary>
    public class KhachHangBUS
    {
        private readonly KhachHangDAO dao = new KhachHangDAO();

        public List<KhachHangDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public KhachHangDTO LayTheoMa(string ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm theo mã, họ tên hoặc số điện thoại; từ khóa rỗng thì trả về toàn bộ.</summary>
        public List<KhachHangDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        /// <summary>Sinh mã mới (KH001, KH002, ...) để hiển thị sẵn trên form.</summary>
        public string TaoMaMoi()
        {
            return dao.TaoMaMoi();
        }

        /// <summary>Tổng số khách hàng (thẻ thống kê trang chủ).</summary>
        public int DemTatCa()
        {
            return dao.DemTatCa();
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(KhachHangDTO dto)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.MaKhachHang)) return "Vui lòng nhập mã khách hàng.";
            if (dto.MaKhachHang.Trim().Length > 10) return "Mã khách hàng không được dài quá 10 ký tự.";
            if (!KiemTraDuLieu.LaMaHopLe(dto.MaKhachHang)) return "Mã khách hàng chỉ gồm chữ cái không dấu, số, gạch ngang hoặc gạch dưới.";
            if (KiemTraDuLieu.LaTrong(dto.HoTen)) return "Vui lòng nhập họ tên khách hàng.";
            if (dto.HoTen.Trim().Length > 100) return "Họ tên không được dài quá 100 ký tự.";
            if (!KiemTraDuLieu.LaTrong(dto.SoDienThoai) && !KiemTraDuLieu.LaSoDienThoaiHopLe(dto.SoDienThoai))
                return "Số điện thoại không hợp lệ (ví dụ: 0987654321).";
            if (!KiemTraDuLieu.LaTrong(dto.Email) && (!KiemTraDuLieu.LaEmailHopLe(dto.Email) || dto.Email.Trim().Length > 100))
                return "Email không hợp lệ.";
            if (dto.DiaChi != null && dto.DiaChi.Trim().Length > 255) return "Địa chỉ không được dài quá 255 ký tự.";
            return null;
        }

        private void ChuanHoa(KhachHangDTO dto)
        {
            dto.MaKhachHang = dto.MaKhachHang.Trim().ToUpper();
            dto.HoTen = dto.HoTen.Trim();
            dto.SoDienThoai = KiemTraDuLieu.ChuanHoaTuyChon(dto.SoDienThoai);
            dto.Email = KiemTraDuLieu.ChuanHoaTuyChon(dto.Email);
            dto.DiaChi = KiemTraDuLieu.ChuanHoaTuyChon(dto.DiaChi);
        }

        public KetQua Them(KhachHangDTO dto)
        {
            try
            {
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (dao.TonTaiMa(dto.MaKhachHang))
                    return KetQua.Loi("Mã khách hàng '" + dto.MaKhachHang + "' đã tồn tại.");

                dto.NgayTao = DateTime.Now;
                dao.Them(dto);
                return KetQua.Ok("Thêm khách hàng thành công.", dto.MaKhachHang);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        public KetQua Sua(KhachHangDTO dto)
        {
            try
            {
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (!dao.TonTaiMa(dto.MaKhachHang))
                    return KetQua.Loi("Không tìm thấy khách hàng cần sửa.");

                dao.Sua(dto);
                return KetQua.Ok("Cập nhật khách hàng thành công.");
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
                if (KiemTraDuLieu.LaTrong(ma)) return KetQua.Loi("Vui lòng chọn khách hàng cần xóa.");
                if (!dao.TonTaiMa(ma.Trim())) return KetQua.Loi("Không tìm thấy khách hàng cần xóa.");

                dao.Xoa(ma.Trim());
                return KetQua.Ok("Xóa khách hàng thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa khách hàng (có thể khách hàng đã có hóa đơn). " + ex.Message);
            }
        }
    }
}
