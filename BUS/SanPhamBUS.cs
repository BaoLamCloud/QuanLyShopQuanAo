using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ sản phẩm: kiểm tra dữ liệu rồi gọi SanPhamDAO.</summary>
    public class SanPhamBUS
    {
        /// <summary>Sản phẩm có tồn kho từ mức này trở xuống được coi là sắp hết hàng.</summary>
        public const int NguongTonKhoThap = 5;

        private readonly SanPhamDAO dao = new SanPhamDAO();

        public List<SanPhamDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public SanPhamDTO LayTheoMa(string ma)
        {
            return dao.LayTheoMa(ma);
        }

        /// <summary>Tìm theo mã, tên, danh mục hoặc thương hiệu; từ khóa rỗng thì trả về toàn bộ.</summary>
        public List<SanPhamDTO> TimKiem(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayTatCa();
            return dao.TimKiem(tuKhoa.Trim());
        }

        /// <summary>Lấy các sản phẩm đang kinh doanh (form bán hàng, phiếu nhập).</summary>
        public List<SanPhamDTO> LayDangKinhDoanh()
        {
            return dao.LayDangKinhDoanh();
        }

        /// <summary>Tìm trong các sản phẩm đang kinh doanh; từ khóa rỗng thì trả về tất cả.</summary>
        public List<SanPhamDTO> TimKiemDangKinhDoanh(string tuKhoa)
        {
            if (KiemTraDuLieu.LaTrong(tuKhoa)) return dao.LayDangKinhDoanh();
            return dao.TimKiemDangKinhDoanh(tuKhoa.Trim());
        }

        /// <summary>Sản phẩm sắp hết hàng (tồn kho &lt;= ngưỡng).</summary>
        public List<SanPhamDTO> LayTonKhoThap()
        {
            return dao.LayTonKhoThap(NguongTonKhoThap);
        }

        public List<SanPhamDTO> LayTonKhoThap(int nguong)
        {
            return dao.LayTonKhoThap(nguong);
        }

        /// <summary>Sinh mã mới (SP001, SP002, ...) để hiển thị sẵn trên form.</summary>
        public string TaoMaMoi()
        {
            return dao.TaoMaMoi();
        }

        /// <summary>Tổng số sản phẩm (thẻ thống kê trang chủ).</summary>
        public int DemTatCa()
        {
            return dao.DemTatCa();
        }

        /// <summary>
        /// Công thức giá bán: giá bán = giá nhập (giá vốn) x (1 + tỷ lệ lãi / 100), làm tròn đến đồng.
        /// Ví dụ: giá vốn 90.000, lãi 40% -> 90.000 x 1,4 = 126.000.
        /// </summary>
        public static decimal TinhGiaBan(decimal giaNhap, decimal tyLeLai)
        {
            return Math.Round(giaNhap * (1 + tyLeLai / 100m), 0, MidpointRounding.AwayFromZero);
        }

        // Có tỷ lệ lãi thì giá bán luôn được tính lại từ giá nhập (không tin giá bán do giao diện gửi lên)
        private void TuTinhGiaBan(SanPhamDTO dto)
        {
            if (dto != null && dto.TyLeLai > 0)
                dto.GiaBan = TinhGiaBan(dto.GiaNhap, dto.TyLeLai);
        }

        // Kiểm tra dữ liệu: trả về thông báo lỗi, hoặc null nếu hợp lệ
        private string KiemTra(SanPhamDTO dto)
        {
            if (dto == null) return "Dữ liệu không hợp lệ.";
            if (KiemTraDuLieu.LaTrong(dto.MaSanPham)) return "Vui lòng nhập mã sản phẩm.";
            if (dto.MaSanPham.Trim().Length > 10) return "Mã sản phẩm không được dài quá 10 ký tự.";
            if (!KiemTraDuLieu.LaMaHopLe(dto.MaSanPham)) return "Mã sản phẩm chỉ gồm chữ cái không dấu, số, gạch ngang hoặc gạch dưới.";
            if (KiemTraDuLieu.LaTrong(dto.TenSanPham)) return "Vui lòng nhập tên sản phẩm.";
            if (dto.TenSanPham.Trim().Length > 150) return "Tên sản phẩm không được dài quá 150 ký tự.";

            if (dto.MaDanhMuc <= 0) return "Vui lòng chọn danh mục.";
            if (dto.MaThuongHieu <= 0) return "Vui lòng chọn thương hiệu.";
            if (dto.MaKichThuoc <= 0) return "Vui lòng chọn kích thước.";
            if (dto.MaMauSac <= 0) return "Vui lòng chọn màu sắc.";
            if (dto.MaChatLieu <= 0) return "Vui lòng chọn chất liệu.";
            if (KiemTraDuLieu.LaTrong(dto.MaNhaCungCap)) return "Vui lòng chọn nhà cung cấp.";

            if (dto.GiaNhap < 0) return "Giá nhập không được âm.";
            if (dto.GiaBan <= 0) return "Giá bán phải lớn hơn 0.";
            if (dto.GiaBan < dto.GiaNhap) return "Giá bán không được thấp hơn giá nhập.";
            if (dto.TyLeLai < 0 || dto.TyLeLai > 1000) return "Tỷ lệ lãi phải từ 0 đến 1000 (%).";
            if (dto.SoLuongTon < 0) return "Số lượng tồn không được âm.";

            if (dto.HinhAnh != null && dto.HinhAnh.Trim().Length > 255) return "Tên file hình ảnh không được dài quá 255 ký tự.";
            if (dto.MoTa != null && dto.MoTa.Trim().Length > 500) return "Mô tả không được dài quá 500 ký tự.";
            return null;
        }

        private void ChuanHoa(SanPhamDTO dto)
        {
            dto.MaSanPham = dto.MaSanPham.Trim().ToUpper();
            dto.TenSanPham = dto.TenSanPham.Trim();
            dto.MaNhaCungCap = dto.MaNhaCungCap.Trim();
            dto.HinhAnh = KiemTraDuLieu.ChuanHoaTuyChon(dto.HinhAnh);
            dto.MoTa = KiemTraDuLieu.ChuanHoaTuyChon(dto.MoTa);
        }

        public KetQua Them(SanPhamDTO dto)
        {
            try
            {
                TuTinhGiaBan(dto);
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (dao.TonTaiMa(dto.MaSanPham))
                    return KetQua.Loi("Mã sản phẩm '" + dto.MaSanPham + "' đã tồn tại.");

                dto.NgayTao = DateTime.Now;
                dao.Them(dto);
                return KetQua.Ok("Thêm sản phẩm thành công.", dto.MaSanPham);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        public KetQua Sua(SanPhamDTO dto)
        {
            try
            {
                TuTinhGiaBan(dto);
                string loi = KiemTra(dto);
                if (loi != null) return KetQua.Loi(loi);

                ChuanHoa(dto);
                if (!dao.TonTaiMa(dto.MaSanPham))
                    return KetQua.Loi("Không tìm thấy sản phẩm cần sửa.");

                dao.Sua(dto);
                return KetQua.Ok("Cập nhật sản phẩm thành công.");
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
                if (KiemTraDuLieu.LaTrong(ma)) return KetQua.Loi("Vui lòng chọn sản phẩm cần xóa.");
                if (!dao.TonTaiMa(ma.Trim())) return KetQua.Loi("Không tìm thấy sản phẩm cần xóa.");

                dao.Xoa(ma.Trim());
                return KetQua.Ok("Xóa sản phẩm thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi("Không thể xóa sản phẩm (có thể sản phẩm đã có trong hóa đơn hoặc phiếu nhập). "
                                  + "Bạn có thể chuyển trạng thái sang ngừng kinh doanh thay vì xóa. " + ex.Message);
            }
        }
    }
}