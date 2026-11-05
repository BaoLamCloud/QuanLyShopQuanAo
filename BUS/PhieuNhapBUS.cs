using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>
    /// Xử lý nghiệp vụ phiếu nhập: danh sách hàng nhập tạm, kiểm tra, nhập hàng (cộng tồn kho), xóa phiếu.
    /// Danh sách hàng nhập tạm là List&lt;ChiTietPhieuNhapDTO&gt; do form phiếu nhập giữ.
    /// </summary>
    public class PhieuNhapBUS
    {
        private readonly PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        private readonly SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private readonly NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        private readonly NhanVienDAO nhanVienDAO = new NhanVienDAO();
        private readonly ChiTietPhieuNhapBUS chiTietBUS = new ChiTietPhieuNhapBUS();

        /* ===================== TRUY VẤN ===================== */

        public List<PhieuNhapDTO> LayTatCa()
        {
            return phieuNhapDAO.LayTatCa();
        }

        public PhieuNhapDTO LayTheoMa(string ma)
        {
            return phieuNhapDAO.LayTheoMa(ma);
        }

        public List<ChiTietPhieuNhapDTO> LayChiTiet(string maPhieuNhap)
        {
            return chiTietBUS.LayTheoPhieuNhap(maPhieuNhap);
        }

        /// <summary>Tìm theo mã phiếu hoặc tên nhà cung cấp, lọc theo khoảng ngày (null = không giới hạn).</summary>
        public List<PhieuNhapDTO> TimKiem(string tuKhoa, DateTime? tuNgay, DateTime? denNgay)
        {
            if (tuNgay.HasValue && denNgay.HasValue && tuNgay.Value.Date > denNgay.Value.Date)
                throw new Exception("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            return phieuNhapDAO.TimKiem(tuKhoa == null ? "" : tuKhoa.Trim(), tuNgay, denNgay);
        }

        public decimal TongTienNhap(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay.Date > denNgay.Date)
                throw new Exception("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            return phieuNhapDAO.TongTienNhap(tuNgay, denNgay);
        }

        /// <summary>
        /// Giá nhập (giá vốn) sau khi nhập thêm: trung bình các lần nhập, có trọng số theo số lượng
        /// (xem ChiTietPhieuNhapBUS.TinhGiaNhapBinhQuan).
        /// </summary>
        public decimal TinhGiaVonSauKhiNhap(string maSanPham, int soLuong, decimal giaNhap)
        {
            return chiTietBUS.TinhGiaNhapBinhQuan(maSanPham, soLuong, giaNhap);
        }

        /* ===================== DANH SÁCH HÀNG NHẬP TẠM ===================== */

        /// <summary>Thêm một dòng hàng nhập (cộng dồn số lượng nếu đã có, lấy giá nhập mới nhất).</summary>
        public KetQua ThemDong(List<ChiTietPhieuNhapDTO> danhSach, SanPhamDTO sanPham, int soLuong, decimal giaNhap)
        {
            if (danhSach == null || sanPham == null) return KetQua.Loi("Vui lòng chọn sản phẩm cần nhập.");
            if (soLuong <= 0) return KetQua.Loi("Số lượng nhập phải lớn hơn 0.");
            if (giaNhap < 0) return KetQua.Loi("Giá nhập không được âm.");

            ChiTietPhieuNhapDTO dong = danhSach.FirstOrDefault(x => x.MaSanPham == sanPham.MaSanPham);
            if (dong != null)
            {
                dong.SoLuong += soLuong;
                dong.GiaNhap = giaNhap;
                dong.ThanhTien = dong.SoLuong * dong.GiaNhap;
            }
            else
            {
                dong = new ChiTietPhieuNhapDTO();
                dong.MaSanPham = sanPham.MaSanPham;
                dong.TenSanPham = sanPham.TenSanPham;
                dong.SoLuong = soLuong;
                dong.GiaNhap = giaNhap;
                dong.ThanhTien = soLuong * giaNhap;
                danhSach.Add(dong);
            }
            return KetQua.Ok("Đã thêm vào danh sách nhập.");
        }

        /// <summary>Xóa một dòng khỏi danh sách nhập tạm.</summary>
        public KetQua XoaDong(List<ChiTietPhieuNhapDTO> danhSach, string maSanPham)
        {
            if (danhSach == null) return KetQua.Loi("Danh sách nhập không hợp lệ.");
            ChiTietPhieuNhapDTO dong = danhSach.FirstOrDefault(x => x.MaSanPham == maSanPham);
            if (dong == null) return KetQua.Loi("Không tìm thấy sản phẩm trong danh sách nhập.");
            danhSach.Remove(dong);
            return KetQua.Ok("Đã xóa sản phẩm khỏi danh sách nhập.");
        }

        /// <summary>Tổng tiền nhập của danh sách.</summary>
        public decimal TinhTongTien(List<ChiTietPhieuNhapDTO> danhSach)
        {
            if (danhSach == null) return 0;
            return danhSach.Sum(x => x.ThanhTien);
        }

        /* ===================== NHẬP HÀNG / XÓA PHIẾU ===================== */

        /// <summary>
        /// Xác nhận nhập hàng: kiểm tra rồi gọi DAO lưu phiếu + chi tiết + cộng tồn kho trong một transaction.
        /// </summary>
        public KetQua NhapHang(string maNhaCungCap, string maNhanVien, string ghiChu, List<ChiTietPhieuNhapDTO> danhSach)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(maNhaCungCap)) return KetQua.Loi("Vui lòng chọn nhà cung cấp.");
                if (danhSach == null || danhSach.Count == 0) return KetQua.Loi("Danh sách hàng nhập đang trống.");
                if (KiemTraDuLieu.LaTrong(maNhanVien)) return KetQua.Loi("Chưa xác định được nhân viên lập phiếu.");
                if (ghiChu != null && ghiChu.Trim().Length > 255) return KetQua.Loi("Ghi chú không được dài quá 255 ký tự.");

                if (nhaCungCapDAO.LayTheoMa(maNhaCungCap.Trim()) == null) return KetQua.Loi("Nhà cung cấp không tồn tại.");

                NhanVienDTO nv = nhanVienDAO.LayTheoMa(maNhanVien.Trim());
                if (nv == null || !nv.TrangThai) return KetQua.Loi("Nhân viên lập phiếu không hợp lệ hoặc đã nghỉ việc.");

                // Gộp dòng trùng sản phẩm và tính lại thành tiền từ số lượng x giá nhập
                List<ChiTietPhieuNhapDTO> dsChiTiet = new List<ChiTietPhieuNhapDTO>();
                foreach (var nhom in danhSach.GroupBy(x => x.MaSanPham))
                {
                    ChiTietPhieuNhapDTO dongCuoi = nhom.Last();
                    int soLuong = nhom.Sum(x => x.SoLuong);

                    if (soLuong <= 0) return KetQua.Loi("Số lượng nhập của sản phẩm " + nhom.Key + " không hợp lệ.");
                    if (dongCuoi.GiaNhap < 0) return KetQua.Loi("Giá nhập của sản phẩm " + nhom.Key + " không được âm.");
                    if (sanPhamDAO.LayTheoMa(nhom.Key) == null) return KetQua.Loi("Sản phẩm " + nhom.Key + " không tồn tại.");

                    ChiTietPhieuNhapDTO ct = new ChiTietPhieuNhapDTO();
                    ct.MaSanPham = nhom.Key;
                    ct.SoLuong = soLuong;
                    ct.GiaNhap = dongCuoi.GiaNhap;
                    ct.ThanhTien = soLuong * dongCuoi.GiaNhap;
                    dsChiTiet.Add(ct);
                }

                PhieuNhapDTO phieu = new PhieuNhapDTO();
                phieu.MaNhaCungCap = maNhaCungCap.Trim();
                phieu.MaNhanVien = nv.MaNhanVien;
                phieu.NgayNhap = DateTime.Now;
                phieu.TongTien = dsChiTiet.Sum(x => x.ThanhTien);
                phieu.GhiChu = KiemTraDuLieu.ChuanHoaTuyChon(ghiChu);

                string maPhieu = phieuNhapDAO.NhapHang(phieu, dsChiTiet);
                return KetQua.Ok("Nhập hàng thành công. Mã phiếu nhập: " + maPhieu, maPhieu);
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }

        /// <summary>Xóa phiếu nhập (trừ lại tồn kho; báo lỗi nếu hàng đã bán bớt nên không đủ để trừ).</summary>
        public KetQua Xoa(string maPhieuNhap)
        {
            try
            {
                if (KiemTraDuLieu.LaTrong(maPhieuNhap)) return KetQua.Loi("Vui lòng chọn phiếu nhập cần xóa.");
                if (phieuNhapDAO.LayTheoMa(maPhieuNhap.Trim()) == null) return KetQua.Loi("Không tìm thấy phiếu nhập cần xóa.");

                phieuNhapDAO.Xoa(maPhieuNhap.Trim());
                return KetQua.Ok("Xóa phiếu nhập thành công.");
            }
            catch (Exception ex)
            {
                return KetQua.Loi(ex.Message);
            }
        }
    }
}