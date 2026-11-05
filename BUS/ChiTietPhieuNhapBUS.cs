using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ chi tiết phiếu nhập.</summary>
    public class ChiTietPhieuNhapBUS
    {
        private readonly ChiTietPhieuNhapDAO dao = new ChiTietPhieuNhapDAO();

        /// <summary>Lấy chi tiết của một phiếu nhập (có tên sản phẩm).</summary>
        public List<ChiTietPhieuNhapDTO> LayTheoPhieuNhap(string maPhieuNhap)
        {
            if (KiemTraDuLieu.LaTrong(maPhieuNhap)) return new List<ChiTietPhieuNhapDTO>();
            return dao.LayTheoPhieuNhap(maPhieuNhap.Trim());
        }

        /// <summary>Thành tiền của một dòng = số lượng x giá nhập.</summary>
        public decimal TinhThanhTien(int soLuong, decimal giaNhap)
        {
            return soLuong * giaNhap;
        }

        /// <summary>
        /// Giá nhập (giá vốn) của sản phẩm nếu nhập thêm soLuongThem cái với giá giaThem:
        ///     (tổng số lượng x giá của các lần nhập cũ + soLuongThem x giaThem) / (tổng số lượng cũ + soLuongThem)
        /// Ví dụ: đã nhập 10 cái giá 80.000 và 10 cái giá 90.000 -> giá nhập hiện tại 85.000.
        /// Truyền soLuongThem = 0 để lấy giá nhập hiện tại từ lịch sử (0 nếu chưa nhập lần nào).
        /// </summary>
        public decimal TinhGiaNhapBinhQuan(string maSanPham, int soLuongThem, decimal giaThem)
        {
            int tongSoLuong;
            decimal tongGiaTri;
            dao.LayTongNhap(maSanPham, out tongSoLuong, out tongGiaTri);

            tongSoLuong += soLuongThem;
            tongGiaTri += soLuongThem * giaThem;
            if (tongSoLuong <= 0) return 0;
            return Math.Round(tongGiaTri / tongSoLuong, 0, MidpointRounding.AwayFromZero);
        }
    }
}