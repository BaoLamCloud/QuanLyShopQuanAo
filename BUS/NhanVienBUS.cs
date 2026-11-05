using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ nhân viên: kiểm tra dữ liệu rồi gọi NhanVienDAO.</summary>
    public class NhanVienBUS
    {
        private readonly NhanVienDAO dao = new NhanVienDAO();

        public List<NhanVienDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        /// <summary>Chỉ lấy nhân viên đang làm việc (dùng cho combobox).</summary>
        public List<NhanVienDTO> LayDangLam()
        {
            return dao.LayDangLam();
        }

        public NhanVienDTO LayTheoMa(string ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm theo mã, họ tên hoặc số điện thoại; từ khóa rỗng thì trả về toàn bộ.</summary>
        public List<NhanVienDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        /// <summary>Sinh mã mới (NV001, NV002, ...) để hiển thị sẵn trên form.</summary>
        public string TaoMaMoi()
        {
            return dao.TaoMaMoi();
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(NhanVienDTO dto)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.MaNhanVien)) return "Vui lòng nhập mã nhân viên.";
            if (dto.MaNhanVien.Trim().Length > 10) return "Mã nhân viên không được dài quá 10 ký tự.";
            if (!KiemTraDuLieu.LaMaHopLe(dto.MaNhanVien)) return "Mã nhân viên chỉ gồm chữ cái không dấu, số, gạch ngang hoặc gạch dưới.";
            if (KiemTraDuLieu.LaTrong(dto.HoTen)) return "Vui lòng nhập họ tên nhân viên.";
            if (dto.HoTen.Trim().Length > 100) return "Họ tên không được dài quá 100 ký tự.";
            if (dto.GioiTinh != "Nam" && dto.GioiTinh != "Nữ") return "Vui lòng chọn giới tính (Nam hoặc Nữ).";

            if (dto.NgaySinh.HasValue)
            {
                if (dto.NgaySinh.Value.Date > DateTime.Today.AddYears(-16))
                    return "Nhân viên phải đủ 16 tuổi trở lên.";
                if (dto.NgayVaoLam.Date < dto.NgaySinh.Value.Date)
                    return "Ngày vào làm không được trước ngày sinh.";
            }
            if (dto.NgayVaoLam.Date > DateTime.Today) return "Ngày vào làm không được ở tương lai.";

            if (!KiemTraDuLieu.LaTrong(dto.SoDienThoai) && !KiemTraDuLieu.LaSoDienThoaiHopLe(dto.SoDienThoai))
                return "Số điện thoại không hợp lệ (ví dụ: 0912345678).";
            if (!KiemTraDuLieu.LaTrong(dto.Email) && (!KiemTraDuLieu.LaEmailHopLe(dto.Email) || dto.Email.Trim().Length > 100))
                return "Email không hợp lệ.";
            if (dto.DiaChi != null && dto.DiaChi.Trim().Length > 255) return "Địa chỉ không được dài quá 255 ký tự.";
            return null;
        }

        private void ChuanHoa(NhanVienDTO dto)
        {
            dto.MaNhanVien = dto.MaNhanVien.Trim().ToUpper();
            dto.HoTen = dto.HoTen.Trim();
            dto.SoDienThoai = KiemTraDuLieu.ChuanHoaTuyChon(dto.SoDienThoai);
            dto.Email = KiemTraDuLieu.ChuanHoaTuyChon(dto.Email);
            dto.DiaChi = KiemTraDuLieu.ChuanHoaTuyChon(dto.DiaChi);
        }

        public KetQua Them(NhanVienDTO dto)
        {
            try
            {
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (dao.TonTaiMa(dto.MaNhanVien))
                    return KetQua.Loi("Mã nhân viên '" + dto.MaNhanVien + "' đã tồn tại.");

                dao.Them(dto);
                return KetQua.Ok("Thêm nhân viên thành công.", dto.MaNhanVien);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        public KetQua Sua(NhanVienDTO dto)
        {
            try
            {
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (!dao.TonTaiMa(dto.MaNhanVien))
                    return KetQua.Loi("Không tìm thấy nhân viên cần sửa.");

                dao.Sua(dto);
                return KetQua.Ok("Cập nhật nhân viên thành công.");
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
                if (KiemTraDuLieu.LaTrong(ma)) return KetQua.Loi("Vui lòng chọn nhân viên cần xóa.");
                if (!dao.TonTaiMa(ma.Trim())) return KetQua.Loi("Không tìm thấy nhân viên cần xóa.");

                // Không cho xóa chính nhân viên đang đăng nhập
                if (PhienLamViec.NhanVien != null &&
                    string.Equals(PhienLamViec.NhanVien.MaNhanVien, ma.Trim(), StringComparison.OrdinalIgnoreCase))
                    return KetQua.Loi("Không thể xóa nhân viên đang đăng nhập.");

                dao.Xoa(ma.Trim());
                return KetQua.Ok("Xóa nhân viên thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa nhân viên (có thể nhân viên đã có tài khoản, hóa đơn hoặc phiếu nhập). "
                                  + "Bạn có thể chuyển trạng thái sang nghỉ việc thay vì xóa. " + ex.Message);
            }
        }
    }
}
