using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>
    /// Xử lý nghiệp vụ tài khoản: đăng nhập, thêm/sửa/xóa, đổi mật khẩu, phân quyền.
    /// Mật khẩu KHÔNG lưu dạng văn bản thuần: lưu SHA-256( Muoi + MatKhau ), viết hoa, 64 ký tự hex.
    /// </summary>
    public class TaiKhoanBUS
    {
        private const int DoDaiMatKhauToiThieu = 6;

        private readonly TaiKhoanDAO dao = new TaiKhoanDAO();
        private readonly NhanVienDAO nhanVienDAO = new NhanVienDAO();

        /* ===================== MẬT KHẨU ===================== */

        /// <summary>Băm SHA-256 của (muối + mật khẩu), trả về chuỗi hex viết hoa 64 ký tự.</summary>
        public static string BamMatKhau(string muoi, string matKhau)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(muoi + matKhau));
                StringBuilder sb = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        /// <summary>Tạo chuỗi muối ngẫu nhiên 16 ký tự (chữ và số).</summary>
        public static string TaoMuoi()
        {
            const string kyTu = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            byte[] buf = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(buf);
            }
            char[] kq = new char[16];
            for (int i = 0; i < kq.Length; i++) kq[i] = kyTu[buf[i] % kyTu.Length];
            return new string(kq);
        }

        // Kiểm tra mật khẩu mới: trả về thông báo lỗi hoặc null nếu hợp lệ
        private string KiemTraMatKhauMoi(string matKhau)
        {
            if (string.IsNullOrEmpty(matKhau)) return "Vui lòng nhập mật khẩu.";
            if (matKhau.Length < DoDaiMatKhauToiThieu) return "Mật khẩu phải có ít nhất " + DoDaiMatKhauToiThieu + " ký tự.";
            if (matKhau.Length > 50) return "Mật khẩu không được dài quá 50 ký tự.";
            return null;
        }

        /* ===================== ĐĂNG NHẬP ===================== */

        /// <summary>
        /// Kiểm tra đăng nhập. Thành công thì lưu thông tin vào PhienLamViec.
        /// Dùng một thông báo chung khi sai tên hoặc sai mật khẩu để không lộ tên đăng nhập nào tồn tại.
        /// </summary>
        public KetQua DangNhap(string tenDangNhap, string matKhau)
        {
            if (KiemTraDuLieu.LaTrong(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                return KetQua.Loi("Vui lòng nhập tên đăng nhập và mật khẩu.");

            try
            {
                TaiKhoanDTO tk = dao.LayTheoTenDangNhap(tenDangNhap.Trim());
                if (tk == null || !string.Equals(tk.MatKhauHash, BamMatKhau(tk.Muoi, matKhau), StringComparison.Ordinal))
                    return KetQua.Loi("Tên đăng nhập hoặc mật khẩu không đúng.");

                if (!tk.TrangThai)
                    return KetQua.Loi("Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên.");

                NhanVienDTO nv = nhanVienDAO.LayTheoMa(tk.MaNhanVien);
                if (nv == null || !nv.TrangThai)
                    return KetQua.Loi("Nhân viên liên kết với tài khoản này đã nghỉ việc.");

                PhienLamViec.BatDau(tk, nv);
                return KetQua.Ok("Đăng nhập thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Đăng xuất: xóa thông tin phiên làm việc.</summary>
        public void DangXuat()
        {
            PhienLamViec.KetThuc();
        }

        /* ===================== TRUY VẤN ===================== */

        public List<TaiKhoanDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public TaiKhoanDTO LayTheoTenDangNhap(string tenDangNhap)
        {
            return dao.LayTheoTenDangNhap(tenDangNhap);
        }

        /// <summary>Tìm theo tên đăng nhập hoặc tên nhân viên; từ khóa rỗng thì trả về toàn bộ.</summary>
        public List<TaiKhoanDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        /* ===================== THÊM / SỬA / XÓA ===================== */

        // Kiểm tra các trường chung (vai trò, nhân viên liên kết); trả về lỗi hoặc null
        private string KiemTraChung(TaiKhoanDTO dto)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (dto.VaiTro != PhienLamViec.VaiTroQuanTri && dto.VaiTro != PhienLamViec.VaiTroBanHang)
                return "Vui lòng chọn vai trò (Quản trị viên hoặc Nhân viên bán hàng).";
            if (KiemTraDuLieu.LaTrong(dto.MaNhanVien)) return "Vui lòng chọn nhân viên liên kết.";
            if (nhanVienDAO.LayTheoMa(dto.MaNhanVien.Trim()) == null) return "Nhân viên liên kết không tồn tại.";
            if (dao.NhanVienDaCoTaiKhoan(dto.MaNhanVien.Trim(), dto.TenDangNhap == null ? "" : dto.TenDangNhap.Trim()))
                return "Nhân viên này đã có tài khoản khác.";
            return null;
        }

        /// <summary>Thêm tài khoản mới. matKhau là mật khẩu gõ vào (sẽ được băm trước khi lưu).</summary>
        public KetQua Them(TaiKhoanDTO dto, string matKhau)
        {
            try
            {
                if (dto == null) return KetQua.Loi("Dữ liệu không hợp lệ.");
                if (KiemTraDuLieu.LaTrong(dto.TenDangNhap)) return KetQua.Loi("Vui lòng nhập tên đăng nhập.");
                if (!Regex.IsMatch(dto.TenDangNhap.Trim(), @"^[A-Za-z0-9_.]{3,50}$"))
                    return KetQua.Loi("Tên đăng nhập gồm 3-50 ký tự: chữ cái không dấu, số, dấu chấm hoặc gạch dưới.");

                string loiMatKhau = KiemTraMatKhauMoi(matKhau);
                if (loiMatKhau != null) return KetQua.Loi(loiMatKhau);

                string loi = KiemTraChung(dto);
                if (loi != null) return KetQua.Loi(loi);

                dto.TenDangNhap = dto.TenDangNhap.Trim();
                dto.MaNhanVien = dto.MaNhanVien.Trim();
                if (dao.TonTaiTenDangNhap(dto.TenDangNhap))
                    return KetQua.Loi("Tên đăng nhập '" + dto.TenDangNhap + "' đã tồn tại.");

                dto.Muoi = TaoMuoi();
                dto.MatKhauHash = BamMatKhau(dto.Muoi, matKhau);
                dao.Them(dto);
                return KetQua.Ok("Thêm tài khoản thành công.", dto.TenDangNhap);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Sửa vai trò, nhân viên liên kết, trạng thái (không đổi mật khẩu).</summary>
        public KetQua Sua(TaiKhoanDTO dto)
        {
            try
            {
                if (dto == null || KiemTraDuLieu.LaTrong(dto.TenDangNhap)) return KetQua.Loi("Vui lòng chọn tài khoản cần sửa.");
                dto.TenDangNhap = dto.TenDangNhap.Trim();

                TaiKhoanDTO cu = dao.LayTheoTenDangNhap(dto.TenDangNhap);
                if (cu == null) return KetQua.Loi("Không tìm thấy tài khoản cần sửa.");

                string loi = KiemTraChung(dto);
                if (loi != null) return KetQua.Loi(loi);
                dto.MaNhanVien = dto.MaNhanVien.Trim();

                // Không cho hạ quyền hoặc khóa quản trị viên hoạt động cuối cùng
                bool cuLaQuanTriHoatDong = cu.VaiTro == PhienLamViec.VaiTroQuanTri && cu.TrangThai;
                bool moiConLaQuanTriHoatDong = dto.VaiTro == PhienLamViec.VaiTroQuanTri && dto.TrangThai;
                if (cuLaQuanTriHoatDong && !moiConLaQuanTriHoatDong && dao.DemQuanTriDangHoatDong() <= 1)
                    return KetQua.Loi("Không thể hạ quyền hoặc khóa quản trị viên hoạt động cuối cùng.");

                // Không cho tự khóa tài khoản đang đăng nhập
                if (PhienLamViec.TaiKhoan != null && !dto.TrangThai &&
                    string.Equals(PhienLamViec.TaiKhoan.TenDangNhap, dto.TenDangNhap, StringComparison.OrdinalIgnoreCase))
                    return KetQua.Loi("Không thể khóa tài khoản đang đăng nhập.");

                dao.Sua(dto);
                return KetQua.Ok("Cập nhật tài khoản thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Xóa tài khoản (không xóa chính mình hoặc quản trị viên hoạt động cuối cùng).</summary>
        public KetQua Xoa(string tenDangNhap)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(tenDangNhap)) return KetQua.Loi("Vui lòng chọn tài khoản cần xóa.");
                tenDangNhap = tenDangNhap.Trim();

                TaiKhoanDTO tk = dao.LayTheoTenDangNhap(tenDangNhap);
                if (tk == null) return KetQua.Loi("Không tìm thấy tài khoản cần xóa.");

                if (PhienLamViec.TaiKhoan != null &&
                    string.Equals(PhienLamViec.TaiKhoan.TenDangNhap, tenDangNhap, StringComparison.OrdinalIgnoreCase))
                    return KetQua.Loi("Không thể xóa tài khoản đang đăng nhập.");

                if (tk.VaiTro == PhienLamViec.VaiTroQuanTri && tk.TrangThai && dao.DemQuanTriDangHoatDong() <= 1)
                    return KetQua.Loi("Không thể xóa quản trị viên hoạt động cuối cùng.");

                dao.Xoa(tenDangNhap);
                return KetQua.Ok("Xóa tài khoản thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /* ===================== ĐỔI / ĐẶT LẠI MẬT KHẨU ===================== */

        /// <summary>Người dùng tự đổi mật khẩu: phải nhập đúng mật khẩu cũ.</summary>
        public KetQua DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi, string xacNhanMatKhauMoi)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(tenDangNhap)) return KetQua.Loi("Không xác định được tài khoản.");
                if (string.IsNullOrEmpty(matKhauCu)) return KetQua.Loi("Vui lòng nhập mật khẩu hiện tại.");

                string loi = KiemTraMatKhauMoi(matKhauMoi);
                if (loi != null) return KetQua.Loi(loi);
                if (matKhauMoi != xacNhanMatKhauMoi) return KetQua.Loi("Mật khẩu xác nhận không khớp.");
                if (matKhauMoi == matKhauCu) return KetQua.Loi("Mật khẩu mới phải khác mật khẩu hiện tại.");

                TaiKhoanDTO tk = dao.LayTheoTenDangNhap(tenDangNhap.Trim());
                if (tk == null) return KetQua.Loi("Không tìm thấy tài khoản.");
                if (!string.Equals(tk.MatKhauHash, BamMatKhau(tk.Muoi, matKhauCu), StringComparison.Ordinal))
                    return KetQua.Loi("Mật khẩu hiện tại không đúng.");

                string muoiMoi = TaoMuoi();
                dao.DoiMatKhau(tk.TenDangNhap, BamMatKhau(muoiMoi, matKhauMoi), muoiMoi);
                return KetQua.Ok("Đổi mật khẩu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Quản trị viên đặt lại mật khẩu cho tài khoản khác (không cần mật khẩu cũ).</summary>
        public KetQua DatLaiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            try
            {
                if (!PhienLamViec.LaQuanTri) return KetQua.Loi("Chỉ quản trị viên mới được đặt lại mật khẩu.");
                if (KiemTraDuLieu.LaTrong(tenDangNhap)) return KetQua.Loi("Vui lòng chọn tài khoản cần đặt lại mật khẩu.");

                string loi = KiemTraMatKhauMoi(matKhauMoi);
                if (loi != null) return KetQua.Loi(loi);

                if (!dao.TonTaiTenDangNhap(tenDangNhap.Trim())) return KetQua.Loi("Không tìm thấy tài khoản.");

                string muoiMoi = TaoMuoi();
                dao.DoiMatKhau(tenDangNhap.Trim(), BamMatKhau(muoiMoi, matKhauMoi), muoiMoi);
                return KetQua.Ok("Đặt lại mật khẩu thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }
    }
}
