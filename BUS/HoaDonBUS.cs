using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>
    /// Xử lý nghiệp vụ hóa đơn: giỏ hàng, tính tiền, kiểm tra tồn kho, thanh toán, đổi trạng thái, thống kê.
    /// Giỏ hàng là một List&lt;ChiTietHoaDonDTO&gt; do form bán hàng giữ; BUS chỉ kiểm tra và tính toán.
    /// </summary>
    public class HoaDonBUS
    {
        public const string TrangThaiDaThanhToan = "Đã thanh toán";
        public const string TrangThaiChuaThanhToan = "Chưa thanh toán";
        public const string TrangThaiDaHuy = "Đã hủy";

        /// <summary>Danh sách trạng thái để đổ vào combobox.</summary>
        public static readonly string[] DanhSachTrangThai = { TrangThaiDaThanhToan, TrangThaiChuaThanhToan, TrangThaiDaHuy };

        private readonly HoaDonDAO hoaDonDAO = new HoaDonDAO();
        private readonly SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private readonly KhachHangDAO khachHangDAO = new KhachHangDAO();
        private readonly NhanVienDAO nhanVienDAO = new NhanVienDAO();
        private readonly ChiTietHoaDonBUS chiTietBUS = new ChiTietHoaDonBUS();

        /* ===================== TRUY VẤN ===================== */

        public List<HoaDonDTO> LayTatCa()
        {
            return hoaDonDAO.LayTatCa();
        }

        public HoaDonDTO LayTheoMa(string ma)
        {
            return hoaDonDAO.LayTheoMa(ma);
        }

        /// <summary>N hóa đơn gần nhất (trang chủ).</summary>
        public List<HoaDonDTO> LayGanDay(int soLuong)
        {
            return hoaDonDAO.LayGanDay(soLuong);
        }

        /// <summary>Chi tiết của một hóa đơn.</summary>
        public List<ChiTietHoaDonDTO> LayChiTiet(string maHoaDon)
        {
            return chiTietBUS.LayTheoHoaDon(maHoaDon);
        }

        /// <summary>Tìm theo mã hóa đơn hoặc tên khách, lọc theo khoảng ngày (null = không giới hạn).</summary>
        public List<HoaDonDTO> TimKiem(string tuKhoa, DateTime? tuNgay, DateTime? denNgay)
        {
            if (tuNgay.HasValue && denNgay.HasValue && tuNgay.Value.Date > denNgay.Value.Date)
                throw new Exception("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            return hoaDonDAO.TimKiem(tuKhoa == null ? "" : tuKhoa.Trim(), tuNgay, denNgay);
        }

        /* ===================== GIỎ HÀNG VÀ TÍNH TIỀN ===================== */

        /// <summary>Thêm sản phẩm vào giỏ (cộng dồn nếu đã có), kiểm tra tồn kho.</summary>
        public KetQua ThemVaoGio(List<ChiTietHoaDonDTO> gio, SanPhamDTO sanPham, int soLuong)
        {
            try
            {
                if (gio == null || sanPham == null) return KetQua.Loi("Vui lòng chọn sản phẩm cần thêm.");
                if (soLuong <= 0) return KetQua.Loi("Số lượng phải lớn hơn 0.");
                if (!sanPham.TrangThai) return KetQua.Loi("Sản phẩm '" + sanPham.TenSanPham + "' đã ngừng kinh doanh.");

                int tonKho = sanPhamDAO.LaySoLuongTon(sanPham.MaSanPham);
                ChiTietHoaDonDTO dongCu = gio.FirstOrDefault(x => x.MaSanPham == sanPham.MaSanPham);
                int soLuongMoi = (dongCu != null ? dongCu.SoLuong : 0) + soLuong;

                if (soLuongMoi > tonKho)
                    return KetQua.Loi("Sản phẩm '" + sanPham.TenSanPham + "' chỉ còn " + tonKho + " trong kho.");

                if (dongCu != null)
                {
                    dongCu.SoLuong = soLuongMoi;
                    dongCu.ThanhTien = dongCu.SoLuong * dongCu.DonGia;
                }
                else
                {
                    ChiTietHoaDonDTO dong = new ChiTietHoaDonDTO();
                    dong.MaSanPham = sanPham.MaSanPham;
                    dong.TenSanPham = sanPham.TenSanPham;
                    dong.TenKichThuoc = sanPham.TenKichThuoc;
                    dong.TenMauSac = sanPham.TenMauSac;
                    dong.SoLuong = soLuong;
                    dong.DonGia = sanPham.GiaBan;
                    dong.ThanhTien = soLuong * sanPham.GiaBan;
                    gio.Add(dong);
                }
                return KetQua.Ok("Đã thêm vào giỏ hàng.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Đặt lại số lượng một dòng trong giỏ (tăng/giảm). Số lượng &lt;= 0 thì xóa dòng khỏi giỏ.</summary>
        public KetQua CapNhatSoLuong(List<ChiTietHoaDonDTO> gio, string maSanPham, int soLuongMoi)
        {
            try
            {
                if (gio == null) return KetQua.Loi("Giỏ hàng không hợp lệ.");
                ChiTietHoaDonDTO dong = gio.FirstOrDefault(x => x.MaSanPham == maSanPham);
                if (dong == null) return KetQua.Loi("Không tìm thấy sản phẩm trong giỏ hàng.");

                if (soLuongMoi <= 0)
                {
                    gio.Remove(dong);
                    return KetQua.Ok("Đã xóa sản phẩm khỏi giỏ hàng.");
                }

                int tonKho = sanPhamDAO.LaySoLuongTon(maSanPham);
                if (soLuongMoi > tonKho)
                    return KetQua.Loi("Sản phẩm '" + dong.TenSanPham + "' chỉ còn " + tonKho + " trong kho.");

                dong.SoLuong = soLuongMoi;
                dong.ThanhTien = dong.SoLuong * dong.DonGia;
                return KetQua.Ok("Đã cập nhật số lượng.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Xóa một sản phẩm khỏi giỏ.</summary>
        public KetQua XoaKhoiGio(List<ChiTietHoaDonDTO> gio, string maSanPham)
        {
            if (gio == null) return KetQua.Loi("Giỏ hàng không hợp lệ.");
            ChiTietHoaDonDTO dong = gio.FirstOrDefault(x => x.MaSanPham == maSanPham);
            if (dong == null) return KetQua.Loi("Không tìm thấy sản phẩm trong giỏ hàng.");
            gio.Remove(dong);
            return KetQua.Ok("Đã xóa sản phẩm khỏi giỏ hàng.");
        }

        /// <summary>Tổng tiền hàng của giỏ.</summary>
        public decimal TinhTongTien(List<ChiTietHoaDonDTO> gio)
        {
            if (gio == null) return 0;
            return gio.Sum(x => x.ThanhTien);
        }

        /// <summary>Giảm giá theo phần trăm (0-100), làm tròn đến đồng.</summary>
        public decimal TinhGiamGiaTheoPhanTram(decimal tongTien, decimal phanTram)
        {
            if (phanTram < 0) phanTram = 0;
            if (phanTram > 100) phanTram = 100;
            return Math.Round(tongTien * phanTram / 100m, 0);
        }

        /// <summary>Thành tiền = tổng tiền - giảm giá (không âm).</summary>
        public decimal TinhThanhTien(decimal tongTien, decimal giamGia)
        {
            decimal ketQua = tongTien - giamGia;
            return ketQua < 0 ? 0 : ketQua;
        }

        /* ===================== THANH TOÁN ===================== */

        /// <summary>
        /// Thanh toán giỏ hàng. BUS kiểm tra lại toàn bộ (nhân viên, khách hàng, tồn kho, giá lấy lại từ CSDL)
        /// rồi gọi DAO lưu hóa đơn + chi tiết + trừ tồn kho trong một transaction.
        /// maKhachHang để trống = khách vãng lai. trangThai chỉ nhận "Đã thanh toán" hoặc "Chưa thanh toán".
        /// </summary>
        public KetQua ThanhToan(string maKhachHang, string maNhanVien, List<ChiTietHoaDonDTO> gio,
                                decimal giamGia, string trangThai)
        {
            try
            {
                if (gio == null || gio.Count == 0) return KetQua.Loi("Giỏ hàng đang trống.");
                if (KiemTraDuLieu.LaTrong(maNhanVien)) return KetQua.Loi("Chưa xác định được nhân viên lập hóa đơn.");
                if (trangThai != TrangThaiDaThanhToan && trangThai != TrangThaiChuaThanhToan)
                    return KetQua.Loi("Trạng thái thanh toán không hợp lệ.");

                NhanVienDTO nv = nhanVienDAO.LayTheoMa(maNhanVien.Trim());
                if (nv == null || !nv.TrangThai) return KetQua.Loi("Nhân viên lập hóa đơn không hợp lệ hoặc đã nghỉ việc.");

                string maKH = KiemTraDuLieu.ChuanHoaTuyChon(maKhachHang);
                if (maKH != null && khachHangDAO.LayTheoMa(maKH) == null)
                    return KetQua.Loi("Khách hàng được chọn không tồn tại.");

                // Gộp các dòng trùng sản phẩm, lấy lại giá bán và tồn kho từ CSDL (không tin dữ liệu ở giỏ)
                List<ChiTietHoaDonDTO> dsChiTiet = new List<ChiTietHoaDonDTO>();
                var nhom = gio.GroupBy(x => x.MaSanPham)
                              .Select(g => new { Ma = g.Key, SoLuong = g.Sum(x => x.SoLuong) });
                foreach (var dong in nhom)
                {
                    if (dong.SoLuong <= 0) return KetQua.Loi("Số lượng sản phẩm " + dong.Ma + " không hợp lệ.");

                    SanPhamDTO sp = sanPhamDAO.LayTheoMa(dong.Ma);
                    if (sp == null) return KetQua.Loi("Sản phẩm " + dong.Ma + " không tồn tại.");
                    if (!sp.TrangThai) return KetQua.Loi("Sản phẩm '" + sp.TenSanPham + "' đã ngừng kinh doanh.");
                    if (sp.SoLuongTon < dong.SoLuong)
                        return KetQua.Loi("Sản phẩm '" + sp.TenSanPham + "' chỉ còn " + sp.SoLuongTon + " trong kho.");

                    ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();
                    ct.MaSanPham = sp.MaSanPham;
                    ct.SoLuong = dong.SoLuong;
                    ct.DonGia = sp.GiaBan;
                    ct.ThanhTien = sp.GiaBan * dong.SoLuong;
                    dsChiTiet.Add(ct);
                }

                decimal tongTien = dsChiTiet.Sum(x => x.ThanhTien);
                if (giamGia < 0) return KetQua.Loi("Giảm giá không được âm.");
                if (giamGia > tongTien) return KetQua.Loi("Giảm giá không được lớn hơn tổng tiền hàng.");

                HoaDonDTO hoaDon = new HoaDonDTO();
                hoaDon.MaKhachHang = maKH;
                hoaDon.MaNhanVien = nv.MaNhanVien;
                hoaDon.NgayLap = DateTime.Now;
                hoaDon.TongTien = tongTien;
                hoaDon.GiamGia = giamGia;
                hoaDon.ThanhTien = tongTien - giamGia;
                hoaDon.TrangThaiThanhToan = trangThai;

                string maHoaDon = hoaDonDAO.ThanhToan(hoaDon, dsChiTiet);
                return KetQua.Ok("Thanh toán thành công. Mã hóa đơn: " + maHoaDon, maHoaDon);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /* ===================== ĐỔI TRẠNG THÁI / XÓA ===================== */

        /// <summary>Đổi trạng thái hóa đơn (hủy hóa đơn sẽ hoàn lại tồn kho).</summary>
        public KetQua DoiTrangThai(string maHoaDon, string trangThaiMoi)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(maHoaDon)) return KetQua.Loi("Vui lòng chọn hóa đơn.");
                if (!DanhSachTrangThai.Contains(trangThaiMoi)) return KetQua.Loi("Trạng thái không hợp lệ.");

                hoaDonDAO.DoiTrangThai(maHoaDon.Trim(), trangThaiMoi);
                return KetQua.Ok("Cập nhật trạng thái hóa đơn thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Hủy hóa đơn (hoàn lại tồn kho).</summary>
        public KetQua HuyHoaDon(string maHoaDon)
        {
            return DoiTrangThai(maHoaDon, TrangThaiDaHuy);
        }

        /// <summary>Xóa hẳn hóa đơn (hoàn lại tồn kho nếu hóa đơn chưa hủy).</summary>
        public KetQua Xoa(string maHoaDon)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(maHoaDon)) return KetQua.Loi("Vui lòng chọn hóa đơn cần xóa.");

                hoaDonDAO.Xoa(maHoaDon.Trim());
                return KetQua.Ok("Xóa hóa đơn thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /* ===================== THỐNG KÊ ===================== */

        private void KiemTraKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay.Date > denNgay.Date)
                throw new Exception("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
        }

        public int DemTatCa()
        {
            return hoaDonDAO.DemTatCa();
        }

        public decimal TongDoanhThuTatCa()
        {
            return hoaDonDAO.TongDoanhThuTatCa();
        }

        public int DemHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return hoaDonDAO.DemHoaDon(tuNgay, denNgay);
        }

        public decimal TongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return hoaDonDAO.TongDoanhThu(tuNgay, denNgay);
        }

        public int DemKhachHangDaMua(DateTime tuNgay, DateTime denNgay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return hoaDonDAO.DemKhachHangDaMua(tuNgay, denNgay);
        }

        /// <summary>Cột: Ngay, SoHoaDon, DoanhThu.</summary>
        public DataTable DoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return hoaDonDAO.DoanhThuTheoNgay(tuNgay, denNgay);
        }

        /// <summary>Cột: Nam, Thang, SoHoaDon, DoanhThu.</summary>
        public DataTable DoanhThuTheoThang(DateTime tuNgay, DateTime denNgay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return hoaDonDAO.DoanhThuTheoThang(tuNgay, denNgay);
        }

        /// <summary>Cột: Nam, SoHoaDon, DoanhThu.</summary>
        public DataTable DoanhThuTheoNam(DateTime tuNgay, DateTime denNgay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return hoaDonDAO.DoanhThuTheoNam(tuNgay, denNgay);
        }

        /// <summary>Cột: MaSanPham, TenSanPham, TongSoLuong, DoanhThu.</summary>
        public DataTable SanPhamBanChay(DateTime tuNgay, DateTime denNgay, int soLuongLay)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            if (soLuongLay <= 0) soLuongLay = 10;
            return hoaDonDAO.SanPhamBanChay(tuNgay, denNgay, soLuongLay);
        }
    }
}
