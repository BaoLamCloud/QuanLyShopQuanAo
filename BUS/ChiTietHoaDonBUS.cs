using System.Collections.Generic;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BUS
{
    /// <summary>Xử lý nghiệp vụ chi tiết hóa đơn.</summary>
    public class ChiTietHoaDonBUS
    {
        private readonly ChiTietHoaDonDAO dao = new ChiTietHoaDonDAO();

        /// <summary>Lấy chi tiết của một hóa đơn (có tên sản phẩm, kích thước, màu sắc).</summary>
        public List<ChiTietHoaDonDTO> LayTheoHoaDon(string maHoaDon)
        {
            if (KiemTraDuLieu.LaTrong(maHoaDon)) return new List<ChiTietHoaDonDTO>();
            return dao.LayTheoHoaDon(maHoaDon.Trim());
        }

        /// <summary>Thành tiền của một dòng = số lượng x đơn giá.</summary>
        public decimal TinhThanhTien(int soLuong, decimal donGia)
        {
            return soLuong * donGia;
        }
    }
}
