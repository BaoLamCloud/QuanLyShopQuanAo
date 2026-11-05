using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Xuất dữ liệu ra file Excel (.xlsx) mà không cần cài thư viện ngoài.
    /// File .xlsx thực chất là một file zip chứa các file XML; lớp này tự ghi các file XML đó bằng ZipArchive.
    /// Dùng chung cho các form (phiếu nhập, ...). Chỉ ghi dữ liệu có sẵn, không truy cập CSDL.
    /// </summary>
    public static class XuatFile
    {
        private static readonly CultureInfo invariant = CultureInfo.InvariantCulture;

        /* ===== Các file XML cố định bên trong .xlsx ===== */

        private const string NoiDungContentTypes = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Types xmlns=""http://schemas.openxmlformats.org/package/2006/content-types"">
<Default Extension=""rels"" ContentType=""application/vnd.openxmlformats-package.relationships+xml""/>
<Default Extension=""xml"" ContentType=""application/xml""/>
<Override PartName=""/xl/workbook.xml"" ContentType=""application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml""/>
<Override PartName=""/xl/worksheets/sheet1.xml"" ContentType=""application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml""/>
<Override PartName=""/xl/styles.xml"" ContentType=""application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml""/>
</Types>";

        private const string NoiDungRels = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
<Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument"" Target=""xl/workbook.xml""/>
</Relationships>";

        private const string NoiDungWorkbook = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<workbook xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"" xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"">
<sheets><sheet name=""Sheet1"" sheetId=""1"" r:id=""rId1""/></sheets>
</workbook>";

        private const string NoiDungWorkbookRels = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
<Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet"" Target=""worksheets/sheet1.xml""/>
<Relationship Id=""rId2"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles"" Target=""styles.xml""/>
</Relationships>";

        // Các kiểu ô (chỉ số cellXfs): 0 mặc định | 1 tiêu đề cột | 2 số có dấu phân cách nghìn | 3 tiêu đề lớn
        //                              4 nhãn đậm | 5 chữ có viền | 6 số đậm có viền (dòng tổng) | 7 chữ đậm có viền (dòng tổng)
        private const int KieuMacDinh = 0, KieuTieuDeCot = 1, KieuSo = 2, KieuTieuDeLon = 3, KieuNhan = 4, KieuChu = 5, KieuSoTong = 6, KieuChuTong = 7;

        private const string NoiDungStyles = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<styleSheet xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">
<fonts count=""4"">
<font><sz val=""11""/><name val=""Calibri""/></font>
<font><b/><sz val=""11""/><color rgb=""FFFFFFFF""/><name val=""Calibri""/></font>
<font><b/><sz val=""14""/><name val=""Calibri""/></font>
<font><b/><sz val=""11""/><name val=""Calibri""/></font>
</fonts>
<fills count=""3"">
<fill><patternFill patternType=""none""/></fill>
<fill><patternFill patternType=""gray125""/></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FF5D4037""/><bgColor indexed=""64""/></patternFill></fill>
</fills>
<borders count=""2"">
<border><left/><right/><top/><bottom/><diagonal/></border>
<border><left style=""thin""><color auto=""1""/></left><right style=""thin""><color auto=""1""/></right><top style=""thin""><color auto=""1""/></top><bottom style=""thin""><color auto=""1""/></bottom><diagonal/></border>
</borders>
<cellStyleXfs count=""1""><xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""0""/></cellStyleXfs>
<cellXfs count=""8"">
<xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""0"" xfId=""0""/>
<xf numFmtId=""0"" fontId=""1"" fillId=""2"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""center"" vertical=""center""/></xf>
<xf numFmtId=""3"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyBorder=""1""/>
<xf numFmtId=""0"" fontId=""2"" fillId=""0"" borderId=""0"" xfId=""0"" applyFont=""1""/>
<xf numFmtId=""0"" fontId=""3"" fillId=""0"" borderId=""0"" xfId=""0"" applyFont=""1""/>
<xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyBorder=""1""/>
<xf numFmtId=""3"" fontId=""3"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyBorder=""1""/>
<xf numFmtId=""0"" fontId=""3"" fillId=""0"" borderId=""1"" xfId=""0"" applyFont=""1"" applyBorder=""1""/>
</cellXfs>
<cellStyles count=""1""><cellStyle name=""Normal"" xfId=""0"" builtinId=""0""/></cellStyles>
</styleSheet>";

        
        public static void XuatExcel(IWin32Window chuSoHuu, string tenFileGoiY, string tieuDe,
                                     List<string[]> thongTin, string[] cacCot, List<object[]> cacDong, object[] dongTong)
        {
            try
            {
                using (SaveFileDialog hopThoai = new SaveFileDialog())
                {
                    hopThoai.Title = "Xuất file Excel";
                    hopThoai.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                    hopThoai.DefaultExt = "xlsx";
                    hopThoai.AddExtension = true;
                    hopThoai.OverwritePrompt = true;
                    hopThoai.FileName = LamSachTenFile(tenFileGoiY) + ".xlsx";
                    if (hopThoai.ShowDialog(chuSoHuu) != DialogResult.OK) return;

                    GhiFileXlsx(hopThoai.FileName, tieuDe, thongTin, cacCot, cacDong, dongTong);

                    DialogResult hoi = MessageBox.Show("Đã xuất file thành công:\n" + hopThoai.FileName + "\n\nBạn có muốn mở file ngay không?",
                                                       "Xuất file", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (hoi == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo(hopThoai.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Không ghi được file. Nếu file đang mở trong Excel, hãy đóng lại rồi thử lần nữa.",
                                "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Không có quyền ghi vào vị trí đã chọn. Vui lòng chọn thư mục khác (ví dụ Documents hoặc Desktop).",
                                "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xuất được file.\n" + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* ===== Ghi file .xlsx ===== */

        private static void GhiFileXlsx(string duongDan, string tieuDe, List<string[]> thongTin,
                                        string[] cacCot, List<object[]> cacDong, object[] dongTong)
        {
            if (File.Exists(duongDan)) File.Delete(duongDan);

            using (FileStream luong = new FileStream(duongDan, FileMode.Create))
            using (ZipArchive zip = new ZipArchive(luong, ZipArchiveMode.Create))
            {
                GhiTep(zip, "[Content_Types].xml", NoiDungContentTypes);
                GhiTep(zip, "_rels/.rels", NoiDungRels);
                GhiTep(zip, "xl/workbook.xml", NoiDungWorkbook);
                GhiTep(zip, "xl/_rels/workbook.xml.rels", NoiDungWorkbookRels);
                GhiTep(zip, "xl/styles.xml", NoiDungStyles);
                GhiTep(zip, "xl/worksheets/sheet1.xml", TaoSheet(tieuDe, thongTin, cacCot, cacDong, dongTong));
            }
        }

        private static void GhiTep(ZipArchive zip, string tenTep, string noiDung)
        {
            ZipArchiveEntry tep = zip.CreateEntry(tenTep);
            using (Stream luong = tep.Open())
            using (StreamWriter ghi = new StreamWriter(luong, new UTF8Encoding(false)))
            {
                ghi.Write(noiDung);
            }
        }

        // Tạo nội dung bảng tính: tiêu đề, thông tin, dòng tiêu đề cột, dữ liệu, dòng tổng
        private static string TaoSheet(string tieuDe, List<string[]> thongTin, string[] cacCot,
                                       List<object[]> cacDong, object[] dongTong)
        {
            int soCot = cacCot.Length;
            int[] doRong = new int[soCot];
            for (int i = 0; i < soCot; i++) doRong[i] = (cacCot[i] ?? "").Length;

            StringBuilder dong = new StringBuilder();
            int soDong = 1;

            // Tiêu đề lớn
            dong.Append("<row r=\"" + soDong + "\">").Append(OChu(0, soDong, tieuDe, KieuTieuDeLon)).Append("</row>");
            soDong += 2;   // chừa một dòng trống

            // Các dòng thông tin (nhãn ở cột A, giá trị ở cột B)
            if (thongTin != null)
            {
                foreach (string[] cap in thongTin)
                {
                    dong.Append("<row r=\"" + soDong + "\">")
                        .Append(OChu(0, soDong, cap[0], KieuNhan))
                        .Append(OChu(1, soDong, cap.Length > 1 ? cap[1] : "", KieuMacDinh))
                        .Append("</row>");
                    soDong++;
                }
                soDong++;   // dòng trống trước bảng
            }

            // Dòng tiêu đề cột
            dong.Append("<row r=\"" + soDong + "\">");
            for (int c = 0; c < soCot; c++) dong.Append(OChu(c, soDong, cacCot[c], KieuTieuDeCot));
            dong.Append("</row>");
            soDong++;

            // Dữ liệu
            foreach (object[] hang in cacDong)
            {
                dong.Append("<row r=\"" + soDong + "\">");
                for (int c = 0; c < soCot; c++)
                {
                    object giaTri = c < hang.Length ? hang[c] : null;
                    dong.Append(OBatKy(c, soDong, giaTri, KieuSo, KieuChu, doRong));
                }
                dong.Append("</row>");
                soDong++;
            }

            // Dòng tổng
            if (dongTong != null)
            {
                dong.Append("<row r=\"" + soDong + "\">");
                for (int c = 0; c < soCot; c++)
                {
                    object giaTri = c < dongTong.Length ? dongTong[c] : null;
                    dong.Append(OBatKy(c, soDong, giaTri, KieuSoTong, KieuChuTong, doRong));
                }
                dong.Append("</row>");
            }

            StringBuilder xml = new StringBuilder();
            xml.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            xml.Append("<worksheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">");
            xml.Append("<cols>");
            for (int c = 0; c < soCot; c++)
            {
                int rong = Math.Min(Math.Max(doRong[c] + 3, 10), 50);
                xml.Append("<col min=\"" + (c + 1) + "\" max=\"" + (c + 1) + "\" width=\"" + rong + "\" customWidth=\"1\"/>");
            }
            xml.Append("</cols>");
            xml.Append("<sheetData>").Append(dong.ToString()).Append("</sheetData>");
            xml.Append("</worksheet>");
            return xml.ToString();
        }

        // Ô chữ (inline string)
        private static string OChu(int cot, int dong, string chu, int kieu)
        {
            return "<c r=\"" + TenCot(cot) + dong + "\" t=\"inlineStr\" s=\"" + kieu + "\"><is><t xml:space=\"preserve\">"
                   + LamSachXml(chu) + "</t></is></c>";
        }

        // Ô số
        private static string OSo(int cot, int dong, string soChuoi, int kieu)
        {
            return "<c r=\"" + TenCot(cot) + dong + "\" s=\"" + kieu + "\"><v>" + soChuoi + "</v></c>";
        }

        // Ô tùy kiểu dữ liệu: số -> ô số; còn lại -> ô chữ (ngày giờ được ghi thành chữ dd/MM/yyyy HH:mm)
        private static string OBatKy(int cot, int dong, object giaTri, int kieuSo, int kieuChu, int[] doRong)
        {
            if (giaTri == null) return OChu(cot, dong, "", kieuChu);

            if (giaTri is int || giaTri is long || giaTri is short || giaTri is decimal || giaTri is double || giaTri is float)
            {
                string soChuoi = Convert.ToString(giaTri, invariant);
                doRong[cot] = Math.Max(doRong[cot], string.Format(invariant, "{0:N0}", giaTri).Length);
                return OSo(cot, dong, soChuoi, kieuSo);
            }

            string chu = giaTri is DateTime
                ? ((DateTime)giaTri).ToString("dd/MM/yyyy HH:mm", invariant)
                : Convert.ToString(giaTri, invariant);
            doRong[cot] = Math.Max(doRong[cot], chu.Length);
            return OChu(cot, dong, chu, kieuChu);
        }

        // Đổi số thứ tự cột (0 = A, 1 = B, ..., 26 = AA)
        private static string TenCot(int cot)
        {
            string ten = "";
            cot++;
            while (cot > 0)
            {
                int du = (cot - 1) % 26;
                ten = (char)('A' + du) + ten;
                cot = (cot - 1) / 26;
            }
            return ten;
        }

        // Bỏ ký tự điều khiển không hợp lệ trong XML rồi mã hóa các ký tự đặc biệt (&, <, >, ...)
        private static string LamSachXml(string chu)
        {
            if (string.IsNullOrEmpty(chu)) return "";

            StringBuilder sach = new StringBuilder(chu.Length);
            foreach (char ky in chu)
            {
                if (ky == '\t' || ky == '\n' || ky == '\r' || ky >= ' ') sach.Append(ky);
            }
            return SecurityElement.Escape(sach.ToString());
        }

        // Thay ký tự không được dùng trong tên file bằng dấu gạch dưới
        private static string LamSachTenFile(string ten)
        {
            if (string.IsNullOrWhiteSpace(ten)) return "XuatFile";
            foreach (char ky in Path.GetInvalidFileNameChars()) ten = ten.Replace(ky, '_');
            return ten.Trim();
        }
    }
}