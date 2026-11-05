namespace QuanLyShopQuanAo.GUI
{
    partial class FormThongKe
    {
        /// <summary>
        /// Biến thiết kế bắt buộc.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dọn dẹp các tài nguyên đang sử dụng.
        /// </summary>
        /// <param name="disposing">true nếu cần giải phóng tài nguyên managed; ngược lại false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Phương thức hỗ trợ trình thiết kế - không sửa nội dung bằng trình soạn thảo mã.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle kieuTieuDe = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuO = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuXen = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuTien = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuSo = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuNgayGio = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.lblKhoangNhanh = new System.Windows.Forms.Label();
            this.cboKhoangNhanh = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblKieuThongKe = new System.Windows.Forms.Label();
            this.cboKieuThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.tlpChinh = new System.Windows.Forms.TableLayoutPanel();
            this.tlpThe = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTheDoanhThu = new System.Windows.Forms.Panel();
            this.lblTieuDeTheDoanhThu = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.pnlVachDoanhThu = new System.Windows.Forms.Panel();
            this.pnlTheSoHoaDon = new System.Windows.Forms.Panel();
            this.lblTieuDeTheSoHoaDon = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.pnlVachSoHoaDon = new System.Windows.Forms.Panel();
            this.pnlTheSoSanPham = new System.Windows.Forms.Panel();
            this.lblTieuDeTheSoSanPham = new System.Windows.Forms.Label();
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.pnlVachSoSanPham = new System.Windows.Forms.Panel();
            this.pnlTheKhachHang = new System.Windows.Forms.Panel();
            this.lblTieuDeTheKhachHang = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.pnlVachKhachHang = new System.Windows.Forms.Panel();
            this.pnlTheTienNhap = new System.Windows.Forms.Panel();
            this.lblTieuDeTheTienNhap = new System.Windows.Forms.Label();
            this.lblTienNhap = new System.Windows.Forms.Label();
            this.pnlVachTienNhap = new System.Windows.Forms.Panel();
            this.tlpBang = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTieuDeBieuDo = new System.Windows.Forms.Label();
            this.pnlBangDoanhThu = new System.Windows.Forms.Panel();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.colKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDeBangDoanhThu = new System.Windows.Forms.Label();
            this.pnlBanChay = new System.Windows.Forms.Panel();
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            this.colBCMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDeBanChay = new System.Windows.Forms.Label();
            this.pnlTonThap = new System.Windows.Forms.Panel();
            this.dgvTonThap = new System.Windows.Forms.DataGridView();
            this.colTTMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDeTonThap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonThap)).BeginInit();
            this.pnlLoc.SuspendLayout();
            this.pnlNoiDung.SuspendLayout();
            this.tlpChinh.SuspendLayout();
            this.tlpThe.SuspendLayout();
            this.pnlTheDoanhThu.SuspendLayout();
            this.pnlVachDoanhThu.SuspendLayout();
            this.pnlTheSoHoaDon.SuspendLayout();
            this.pnlVachSoHoaDon.SuspendLayout();
            this.pnlTheSoSanPham.SuspendLayout();
            this.pnlVachSoSanPham.SuspendLayout();
            this.pnlTheKhachHang.SuspendLayout();
            this.pnlVachKhachHang.SuspendLayout();
            this.pnlTheTienNhap.SuspendLayout();
            this.pnlVachTienNhap.SuspendLayout();
            this.tlpBang.SuspendLayout();
            this.pnlBieuDo.SuspendLayout();
            this.pnlBangDoanhThu.SuspendLayout();
            this.pnlBanChay.SuspendLayout();
            this.pnlTonThap.SuspendLayout();
            this.SuspendLayout();
            kieuTieuDe.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            kieuTieuDe.BackColor = System.Drawing.Color.FromArgb(93, 64, 55);
            kieuTieuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kieuTieuDe.ForeColor = System.Drawing.Color.White;
            kieuTieuDe.SelectionBackColor = System.Drawing.Color.FromArgb(93, 64, 55);
            kieuTieuDe.SelectionForeColor = System.Drawing.Color.White;
            kieuTieuDe.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            kieuO.BackColor = System.Drawing.Color.White;
            kieuO.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kieuO.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            kieuO.SelectionBackColor = System.Drawing.Color.FromArgb(245, 222, 179);
            kieuO.SelectionForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            kieuXen.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            kieuTien.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            kieuTien.Format = "N0";
            kieuTien.NullValue = null;
            kieuSo.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            kieuNgayGio.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            kieuNgayGio.Format = "dd/MM/yyyy HH:mm";
            kieuNgayGio.NullValue = null;
            //
            // pnlLoc
            //
            this.pnlLoc.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(0, 0);
            this.pnlLoc.Size = new System.Drawing.Size(1070, 70);
            this.pnlLoc.Controls.Add(this.lblKhoangNhanh);
            this.pnlLoc.Controls.Add(this.cboKhoangNhanh);
            this.pnlLoc.Controls.Add(this.lblTuNgay);
            this.pnlLoc.Controls.Add(this.dtpTuNgay);
            this.pnlLoc.Controls.Add(this.lblDenNgay);
            this.pnlLoc.Controls.Add(this.dtpDenNgay);
            this.pnlLoc.Controls.Add(this.lblKieuThongKe);
            this.pnlLoc.Controls.Add(this.cboKieuThongKe);
            this.pnlLoc.Controls.Add(this.btnThongKe);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.TabIndex = 0;
            //
            // lblKhoangNhanh
            //
            this.lblKhoangNhanh.AutoSize = true;
            this.lblKhoangNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhoangNhanh.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblKhoangNhanh.Location = new System.Drawing.Point(14, 8);
            this.lblKhoangNhanh.Text = "Khoảng thời gian";
            this.lblKhoangNhanh.Name = "lblKhoangNhanh";
            this.lblKhoangNhanh.TabIndex = 0;
            //
            // cboKhoangNhanh
            //
            this.cboKhoangNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoangNhanh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKhoangNhanh.FormattingEnabled = true;
            this.cboKhoangNhanh.Location = new System.Drawing.Point(14, 30);
            this.cboKhoangNhanh.Size = new System.Drawing.Size(150, 25);
            this.cboKhoangNhanh.Items.AddRange(new object[] {
                        "Hôm nay",
                        "7 ngày qua",
                        "30 ngày qua",
                        "Tháng này",
                        "Tháng trước",
                        "Năm nay",
                        "Tùy chọn"});
            this.cboKhoangNhanh.Name = "cboKhoangNhanh";
            this.cboKhoangNhanh.TabIndex = 1;
            this.cboKhoangNhanh.SelectedIndexChanged += new System.EventHandler(this.cboKhoangNhanh_SelectedIndexChanged);
            //
            // lblTuNgay
            //
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTuNgay.Location = new System.Drawing.Point(182, 8);
            this.lblTuNgay.Text = "Từ ngày";
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.TabIndex = 2;
            //
            // dtpTuNgay
            //
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(182, 30);
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 25);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.TabIndex = 3;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            //
            // lblDenNgay
            //
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblDenNgay.Location = new System.Drawing.Point(314, 8);
            this.lblDenNgay.Text = "Đến ngày";
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.TabIndex = 4;
            //
            // dtpDenNgay
            //
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(314, 30);
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 25);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.TabIndex = 5;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            //
            // lblKieuThongKe
            //
            this.lblKieuThongKe.AutoSize = true;
            this.lblKieuThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKieuThongKe.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblKieuThongKe.Location = new System.Drawing.Point(446, 8);
            this.lblKieuThongKe.Text = "Thống kê doanh thu theo";
            this.lblKieuThongKe.Name = "lblKieuThongKe";
            this.lblKieuThongKe.TabIndex = 6;
            //
            // cboKieuThongKe
            //
            this.cboKieuThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKieuThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKieuThongKe.FormattingEnabled = true;
            this.cboKieuThongKe.Location = new System.Drawing.Point(446, 30);
            this.cboKieuThongKe.Size = new System.Drawing.Size(150, 25);
            this.cboKieuThongKe.Items.AddRange(new object[] {
                        "Ngày",
                        "Tháng",
                        "Năm"});
            this.cboKieuThongKe.Name = "cboKieuThongKe";
            this.cboKieuThongKe.TabIndex = 7;
            this.cboKieuThongKe.SelectedIndexChanged += new System.EventHandler(this.cboKieuThongKe_SelectedIndexChanged);
            //
            // btnThongKe
            //
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(616, 27);
            this.btnThongKe.Size = new System.Drawing.Size(140, 32);
            this.btnThongKe.Text = "Xem thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            //
            // pnlNoiDung
            //
            this.pnlNoiDung.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(0, 70);
            this.pnlNoiDung.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlNoiDung.Size = new System.Drawing.Size(1070, 596);
            this.pnlNoiDung.Controls.Add(this.tlpChinh);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.TabIndex = 1;
            //
            // tlpChinh
            //
            this.tlpChinh.ColumnCount = 1;
            this.tlpChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChinh.Location = new System.Drawing.Point(12, 12);
            this.tlpChinh.RowCount = 2;
            this.tlpChinh.Size = new System.Drawing.Size(1046, 572);
            this.tlpChinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpChinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChinh.Controls.Add(this.tlpThe, 0, 0);
            this.tlpChinh.Controls.Add(this.tlpBang, 0, 1);
            this.tlpChinh.Name = "tlpChinh";
            this.tlpChinh.TabIndex = 0;
            //
            // tlpThe
            //
            this.tlpThe.ColumnCount = 5;
            this.tlpThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThe.Location = new System.Drawing.Point(0, 0);
            this.tlpThe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpThe.RowCount = 1;
            this.tlpThe.Size = new System.Drawing.Size(1046, 92);
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpThe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThe.Controls.Add(this.pnlTheDoanhThu, 0, 0);
            this.tlpThe.Controls.Add(this.pnlTheSoHoaDon, 1, 0);
            this.tlpThe.Controls.Add(this.pnlTheSoSanPham, 2, 0);
            this.tlpThe.Controls.Add(this.pnlTheKhachHang, 3, 0);
            this.tlpThe.Controls.Add(this.pnlTheTienNhap, 4, 0);
            this.tlpThe.Name = "tlpThe";
            this.tlpThe.TabIndex = 0;
            //
            // pnlTheDoanhThu
            //
            this.pnlTheDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlTheDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlTheDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlTheDoanhThu.Size = new System.Drawing.Size(200, 84);
            this.pnlTheDoanhThu.Controls.Add(this.lblTieuDeTheDoanhThu);
            this.pnlTheDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlTheDoanhThu.Controls.Add(this.pnlVachDoanhThu);
            this.pnlTheDoanhThu.Name = "pnlTheDoanhThu";
            this.pnlTheDoanhThu.TabIndex = 0;
            //
            // lblTieuDeTheDoanhThu
            //
            this.lblTieuDeTheDoanhThu.AutoSize = true;
            this.lblTieuDeTheDoanhThu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheDoanhThu.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheDoanhThu.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDeTheDoanhThu.Text = "DOANH THU";
            this.lblTieuDeTheDoanhThu.Name = "lblTieuDeTheDoanhThu";
            this.lblTieuDeTheDoanhThu.TabIndex = 0;
            //
            // lblDoanhThu
            //
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(173, 20, 87);
            this.lblDoanhThu.Location = new System.Drawing.Point(16, 36);
            this.lblDoanhThu.Text = "0";
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.TabIndex = 1;
            //
            // pnlVachDoanhThu
            //
            this.pnlVachDoanhThu.BackColor = System.Drawing.Color.FromArgb(173, 20, 87);
            this.pnlVachDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlVachDoanhThu.Size = new System.Drawing.Size(7, 84);
            this.pnlVachDoanhThu.Name = "pnlVachDoanhThu";
            this.pnlVachDoanhThu.TabIndex = 2;
            //
            // pnlTheSoHoaDon
            //
            this.pnlTheSoHoaDon.BackColor = System.Drawing.Color.White;
            this.pnlTheSoHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheSoHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnlTheSoHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlTheSoHoaDon.Size = new System.Drawing.Size(200, 84);
            this.pnlTheSoHoaDon.Controls.Add(this.lblTieuDeTheSoHoaDon);
            this.pnlTheSoHoaDon.Controls.Add(this.lblSoHoaDon);
            this.pnlTheSoHoaDon.Controls.Add(this.pnlVachSoHoaDon);
            this.pnlTheSoHoaDon.Name = "pnlTheSoHoaDon";
            this.pnlTheSoHoaDon.TabIndex = 1;
            //
            // lblTieuDeTheSoHoaDon
            //
            this.lblTieuDeTheSoHoaDon.AutoSize = true;
            this.lblTieuDeTheSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheSoHoaDon.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDeTheSoHoaDon.Text = "SỐ HÓA ĐƠN";
            this.lblTieuDeTheSoHoaDon.Name = "lblTieuDeTheSoHoaDon";
            this.lblTieuDeTheSoHoaDon.TabIndex = 0;
            //
            // lblSoHoaDon
            //
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.lblSoHoaDon.Location = new System.Drawing.Point(16, 36);
            this.lblSoHoaDon.Text = "0";
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.TabIndex = 1;
            //
            // pnlVachSoHoaDon
            //
            this.pnlVachSoHoaDon.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.pnlVachSoHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachSoHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnlVachSoHoaDon.Size = new System.Drawing.Size(7, 84);
            this.pnlVachSoHoaDon.Name = "pnlVachSoHoaDon";
            this.pnlVachSoHoaDon.TabIndex = 2;
            //
            // pnlTheSoSanPham
            //
            this.pnlTheSoSanPham.BackColor = System.Drawing.Color.White;
            this.pnlTheSoSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheSoSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlTheSoSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlTheSoSanPham.Size = new System.Drawing.Size(200, 84);
            this.pnlTheSoSanPham.Controls.Add(this.lblTieuDeTheSoSanPham);
            this.pnlTheSoSanPham.Controls.Add(this.lblSoSanPham);
            this.pnlTheSoSanPham.Controls.Add(this.pnlVachSoSanPham);
            this.pnlTheSoSanPham.Name = "pnlTheSoSanPham";
            this.pnlTheSoSanPham.TabIndex = 2;
            //
            // lblTieuDeTheSoSanPham
            //
            this.lblTieuDeTheSoSanPham.AutoSize = true;
            this.lblTieuDeTheSoSanPham.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheSoSanPham.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheSoSanPham.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDeTheSoSanPham.Text = "TỔNG SẢN PHẨM";
            this.lblTieuDeTheSoSanPham.Name = "lblTieuDeTheSoSanPham";
            this.lblTieuDeTheSoSanPham.TabIndex = 0;
            //
            // lblSoSanPham
            //
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoSanPham.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblSoSanPham.Location = new System.Drawing.Point(16, 36);
            this.lblSoSanPham.Text = "0";
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.TabIndex = 1;
            //
            // pnlVachSoSanPham
            //
            this.pnlVachSoSanPham.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.pnlVachSoSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachSoSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlVachSoSanPham.Size = new System.Drawing.Size(7, 84);
            this.pnlVachSoSanPham.Name = "pnlVachSoSanPham";
            this.pnlVachSoSanPham.TabIndex = 2;
            //
            // pnlTheKhachHang
            //
            this.pnlTheKhachHang.BackColor = System.Drawing.Color.White;
            this.pnlTheKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlTheKhachHang.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlTheKhachHang.Size = new System.Drawing.Size(200, 84);
            this.pnlTheKhachHang.Controls.Add(this.lblTieuDeTheKhachHang);
            this.pnlTheKhachHang.Controls.Add(this.lblKhachHang);
            this.pnlTheKhachHang.Controls.Add(this.pnlVachKhachHang);
            this.pnlTheKhachHang.Name = "pnlTheKhachHang";
            this.pnlTheKhachHang.TabIndex = 3;
            //
            // lblTieuDeTheKhachHang
            //
            this.lblTieuDeTheKhachHang.AutoSize = true;
            this.lblTieuDeTheKhachHang.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheKhachHang.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheKhachHang.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDeTheKhachHang.Text = "KHÁCH ĐÃ MUA / TỔNG";
            this.lblTieuDeTheKhachHang.Name = "lblTieuDeTheKhachHang";
            this.lblTieuDeTheKhachHang.TabIndex = 0;
            //
            // lblKhachHang
            //
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.lblKhachHang.Location = new System.Drawing.Point(16, 36);
            this.lblKhachHang.Text = "0";
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.TabIndex = 1;
            //
            // pnlVachKhachHang
            //
            this.pnlVachKhachHang.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.pnlVachKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlVachKhachHang.Size = new System.Drawing.Size(7, 84);
            this.pnlVachKhachHang.Name = "pnlVachKhachHang";
            this.pnlVachKhachHang.TabIndex = 2;
            //
            // pnlTheTienNhap
            //
            this.pnlTheTienNhap.BackColor = System.Drawing.Color.White;
            this.pnlTheTienNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheTienNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlTheTienNhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlTheTienNhap.Size = new System.Drawing.Size(200, 84);
            this.pnlTheTienNhap.Controls.Add(this.lblTieuDeTheTienNhap);
            this.pnlTheTienNhap.Controls.Add(this.lblTienNhap);
            this.pnlTheTienNhap.Controls.Add(this.pnlVachTienNhap);
            this.pnlTheTienNhap.Name = "pnlTheTienNhap";
            this.pnlTheTienNhap.TabIndex = 4;
            //
            // lblTieuDeTheTienNhap
            //
            this.lblTieuDeTheTienNhap.AutoSize = true;
            this.lblTieuDeTheTienNhap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheTienNhap.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheTienNhap.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDeTheTienNhap.Text = "TIỀN NHẬP HÀNG";
            this.lblTieuDeTheTienNhap.Name = "lblTieuDeTheTienNhap";
            this.lblTieuDeTheTienNhap.TabIndex = 0;
            //
            // lblTienNhap
            //
            this.lblTienNhap.AutoSize = true;
            this.lblTienNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienNhap.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTienNhap.Location = new System.Drawing.Point(16, 36);
            this.lblTienNhap.Text = "0";
            this.lblTienNhap.Name = "lblTienNhap";
            this.lblTienNhap.TabIndex = 1;
            //
            // pnlVachTienNhap
            //
            this.pnlVachTienNhap.BackColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.pnlVachTienNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachTienNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlVachTienNhap.Size = new System.Drawing.Size(7, 84);
            this.pnlVachTienNhap.Name = "pnlVachTienNhap";
            this.pnlVachTienNhap.TabIndex = 2;
            //
            // tlpBang
            //
            this.tlpBang.ColumnCount = 2;
            this.tlpBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBang.Location = new System.Drawing.Point(0, 92);
            this.tlpBang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpBang.RowCount = 2;
            this.tlpBang.Size = new System.Drawing.Size(1046, 480);
            this.tlpBang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tlpBang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlpBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBang.Controls.Add(this.pnlBieuDo, 0, 0);
            this.tlpBang.Controls.Add(this.pnlBangDoanhThu, 0, 1);
            this.tlpBang.Controls.Add(this.pnlBanChay, 1, 0);
            this.tlpBang.Controls.Add(this.pnlTonThap, 1, 1);
            this.tlpBang.Name = "tlpBang";
            this.tlpBang.TabIndex = 1;
            //
            // pnlBieuDo
            //
            this.pnlBieuDo.BackColor = System.Drawing.Color.White;
            this.pnlBieuDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBieuDo.Location = new System.Drawing.Point(0, 0);
            this.pnlBieuDo.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlBieuDo.Size = new System.Drawing.Size(580, 230);
            this.pnlBieuDo.Controls.Add(this.chartDoanhThu);
            this.pnlBieuDo.Controls.Add(this.lblTieuDeBieuDo);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.TabIndex = 0;
            //
            // chartDoanhThu
            //
            this.chartDoanhThu.BackColor = System.Drawing.Color.White;
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 30);
            this.chartDoanhThu.Size = new System.Drawing.Size(580, 200);
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Format = "#,##0";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.FromArgb(184, 87, 26);
            series1.Name = "DoanhThu";
            series1.ToolTip = "#VALX: #VAL{N0} đ";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.TabIndex = 0;
            //
            // lblTieuDeBieuDo
            //
            this.lblTieuDeBieuDo.BackColor = System.Drawing.Color.White;
            this.lblTieuDeBieuDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeBieuDo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeBieuDo.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeBieuDo.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeBieuDo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTieuDeBieuDo.Size = new System.Drawing.Size(580, 30);
            this.lblTieuDeBieuDo.Text = "Biểu đồ doanh thu";
            this.lblTieuDeBieuDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeBieuDo.Name = "lblTieuDeBieuDo";
            this.lblTieuDeBieuDo.TabIndex = 1;
            //
            // pnlBangDoanhThu
            //
            this.pnlBangDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlBangDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlBangDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlBangDoanhThu.Size = new System.Drawing.Size(580, 230);
            this.pnlBangDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.pnlBangDoanhThu.Controls.Add(this.lblTieuDeBangDoanhThu);
            this.pnlBangDoanhThu.Name = "pnlBangDoanhThu";
            this.pnlBangDoanhThu.TabIndex = 1;
            //
            // dgvDoanhThu
            //
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AllowUserToResizeRows = false;
            this.dgvDoanhThu.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvDoanhThu.AutoGenerateColumns = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvDoanhThu.ColumnHeadersHeight = 34;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoanhThu.DefaultCellStyle = kieuO;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.EnableHeadersVisualStyles = false;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 30);
            this.dgvDoanhThu.MultiSelect = false;
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowTemplate.Height = 28;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(580, 200);
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colKy,
                        this.colSoHoaDon,
                        this.colDoanhThu});
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.TabIndex = 0;
            //
            // colKy
            //
            this.colKy.DataPropertyName = "Ky";
            this.colKy.DefaultCellStyle = kieuSo;
            this.colKy.FillWeight = 36F;
            this.colKy.HeaderText = "Kỳ";
            this.colKy.ReadOnly = true;
            this.colKy.Name = "colKy";
            //
            // colSoHoaDon
            //
            this.colSoHoaDon.DataPropertyName = "SoHoaDon";
            this.colSoHoaDon.DefaultCellStyle = kieuSo;
            this.colSoHoaDon.FillWeight = 24F;
            this.colSoHoaDon.HeaderText = "Số hóa đơn";
            this.colSoHoaDon.ReadOnly = true;
            this.colSoHoaDon.Name = "colSoHoaDon";
            //
            // colDoanhThu
            //
            this.colDoanhThu.DataPropertyName = "DoanhThu";
            this.colDoanhThu.DefaultCellStyle = kieuTien;
            this.colDoanhThu.FillWeight = 40F;
            this.colDoanhThu.HeaderText = "Doanh thu (đ)";
            this.colDoanhThu.ReadOnly = true;
            this.colDoanhThu.Name = "colDoanhThu";
            //
            // lblTieuDeBangDoanhThu
            //
            this.lblTieuDeBangDoanhThu.BackColor = System.Drawing.Color.White;
            this.lblTieuDeBangDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeBangDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeBangDoanhThu.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeBangDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeBangDoanhThu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTieuDeBangDoanhThu.Size = new System.Drawing.Size(580, 30);
            this.lblTieuDeBangDoanhThu.Text = "Bảng doanh thu theo kỳ";
            this.lblTieuDeBangDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeBangDoanhThu.Name = "lblTieuDeBangDoanhThu";
            this.lblTieuDeBangDoanhThu.TabIndex = 1;
            //
            // pnlBanChay
            //
            this.pnlBanChay.BackColor = System.Drawing.Color.White;
            this.pnlBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanChay.Location = new System.Drawing.Point(0, 0);
            this.pnlBanChay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlBanChay.Size = new System.Drawing.Size(580, 230);
            this.pnlBanChay.Controls.Add(this.dgvBanChay);
            this.pnlBanChay.Controls.Add(this.lblTieuDeBanChay);
            this.pnlBanChay.Name = "pnlBanChay";
            this.pnlBanChay.TabIndex = 2;
            //
            // dgvBanChay
            //
            this.dgvBanChay.AllowUserToAddRows = false;
            this.dgvBanChay.AllowUserToDeleteRows = false;
            this.dgvBanChay.AllowUserToResizeRows = false;
            this.dgvBanChay.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvBanChay.AutoGenerateColumns = false;
            this.dgvBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanChay.BackgroundColor = System.Drawing.Color.White;
            this.dgvBanChay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBanChay.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvBanChay.ColumnHeadersHeight = 34;
            this.dgvBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBanChay.DefaultCellStyle = kieuO;
            this.dgvBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanChay.EnableHeadersVisualStyles = false;
            this.dgvBanChay.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvBanChay.Location = new System.Drawing.Point(0, 30);
            this.dgvBanChay.MultiSelect = false;
            this.dgvBanChay.ReadOnly = true;
            this.dgvBanChay.RowHeadersVisible = false;
            this.dgvBanChay.RowTemplate.Height = 28;
            this.dgvBanChay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanChay.Size = new System.Drawing.Size(460, 200);
            this.dgvBanChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colBCMa,
                        this.colBCTen,
                        this.colBCSoLuong,
                        this.colBCDoanhThu});
            this.dgvBanChay.Name = "dgvBanChay";
            this.dgvBanChay.TabIndex = 0;
            //
            // colBCMa
            //
            this.colBCMa.DataPropertyName = "MaSanPham";
            this.colBCMa.FillWeight = 18F;
            this.colBCMa.HeaderText = "Mã SP";
            this.colBCMa.ReadOnly = true;
            this.colBCMa.Name = "colBCMa";
            //
            // colBCTen
            //
            this.colBCTen.DataPropertyName = "TenSanPham";
            this.colBCTen.FillWeight = 42F;
            this.colBCTen.HeaderText = "Tên sản phẩm";
            this.colBCTen.ReadOnly = true;
            this.colBCTen.Name = "colBCTen";
            //
            // colBCSoLuong
            //
            this.colBCSoLuong.DataPropertyName = "TongSoLuong";
            this.colBCSoLuong.DefaultCellStyle = kieuSo;
            this.colBCSoLuong.FillWeight = 16F;
            this.colBCSoLuong.HeaderText = "Đã bán";
            this.colBCSoLuong.ReadOnly = true;
            this.colBCSoLuong.Name = "colBCSoLuong";
            //
            // colBCDoanhThu
            //
            this.colBCDoanhThu.DataPropertyName = "DoanhThu";
            this.colBCDoanhThu.DefaultCellStyle = kieuTien;
            this.colBCDoanhThu.FillWeight = 24F;
            this.colBCDoanhThu.HeaderText = "Doanh thu";
            this.colBCDoanhThu.ReadOnly = true;
            this.colBCDoanhThu.Name = "colBCDoanhThu";
            //
            // lblTieuDeBanChay
            //
            this.lblTieuDeBanChay.BackColor = System.Drawing.Color.White;
            this.lblTieuDeBanChay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeBanChay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeBanChay.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeBanChay.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeBanChay.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTieuDeBanChay.Size = new System.Drawing.Size(580, 30);
            this.lblTieuDeBanChay.Text = "Sản phẩm bán chạy (top 10)";
            this.lblTieuDeBanChay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeBanChay.Name = "lblTieuDeBanChay";
            this.lblTieuDeBanChay.TabIndex = 1;
            //
            // pnlTonThap
            //
            this.pnlTonThap.BackColor = System.Drawing.Color.White;
            this.pnlTonThap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTonThap.Location = new System.Drawing.Point(0, 0);
            this.pnlTonThap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlTonThap.Size = new System.Drawing.Size(580, 230);
            this.pnlTonThap.Controls.Add(this.dgvTonThap);
            this.pnlTonThap.Controls.Add(this.lblTieuDeTonThap);
            this.pnlTonThap.Name = "pnlTonThap";
            this.pnlTonThap.TabIndex = 3;
            //
            // dgvTonThap
            //
            this.dgvTonThap.AllowUserToAddRows = false;
            this.dgvTonThap.AllowUserToDeleteRows = false;
            this.dgvTonThap.AllowUserToResizeRows = false;
            this.dgvTonThap.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvTonThap.AutoGenerateColumns = false;
            this.dgvTonThap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonThap.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonThap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTonThap.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvTonThap.ColumnHeadersHeight = 34;
            this.dgvTonThap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTonThap.DefaultCellStyle = kieuO;
            this.dgvTonThap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonThap.EnableHeadersVisualStyles = false;
            this.dgvTonThap.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvTonThap.Location = new System.Drawing.Point(0, 30);
            this.dgvTonThap.MultiSelect = false;
            this.dgvTonThap.ReadOnly = true;
            this.dgvTonThap.RowHeadersVisible = false;
            this.dgvTonThap.RowTemplate.Height = 28;
            this.dgvTonThap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonThap.Size = new System.Drawing.Size(460, 200);
            this.dgvTonThap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colTTMa,
                        this.colTTTen,
                        this.colTTSize,
                        this.colTTMau,
                        this.colTTTon});
            this.dgvTonThap.Name = "dgvTonThap";
            this.dgvTonThap.TabIndex = 0;
            //
            // colTTMa
            //
            this.colTTMa.DataPropertyName = "MaSanPham";
            this.colTTMa.FillWeight = 18F;
            this.colTTMa.HeaderText = "Mã SP";
            this.colTTMa.ReadOnly = true;
            this.colTTMa.Name = "colTTMa";
            //
            // colTTTen
            //
            this.colTTTen.DataPropertyName = "TenSanPham";
            this.colTTTen.FillWeight = 42F;
            this.colTTTen.HeaderText = "Tên sản phẩm";
            this.colTTTen.ReadOnly = true;
            this.colTTTen.Name = "colTTTen";
            //
            // colTTSize
            //
            this.colTTSize.DataPropertyName = "TenKichThuoc";
            this.colTTSize.DefaultCellStyle = kieuSo;
            this.colTTSize.FillWeight = 12F;
            this.colTTSize.HeaderText = "Size";
            this.colTTSize.ReadOnly = true;
            this.colTTSize.Name = "colTTSize";
            //
            // colTTMau
            //
            this.colTTMau.DataPropertyName = "TenMauSac";
            this.colTTMau.FillWeight = 16F;
            this.colTTMau.HeaderText = "Màu";
            this.colTTMau.ReadOnly = true;
            this.colTTMau.Name = "colTTMau";
            //
            // colTTTon
            //
            this.colTTTon.DataPropertyName = "SoLuongTon";
            this.colTTTon.DefaultCellStyle = kieuSo;
            this.colTTTon.FillWeight = 12F;
            this.colTTTon.HeaderText = "Tồn";
            this.colTTTon.ReadOnly = true;
            this.colTTTon.Name = "colTTTon";
            //
            // lblTieuDeTonThap
            //
            this.lblTieuDeTonThap.BackColor = System.Drawing.Color.White;
            this.lblTieuDeTonThap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeTonThap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTonThap.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeTonThap.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeTonThap.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTieuDeTonThap.Size = new System.Drawing.Size(580, 30);
            this.lblTieuDeTonThap.Text = "Sản phẩm tồn kho thấp";
            this.lblTieuDeTonThap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeTonThap.Name = "lblTieuDeTonThap";
            this.lblTieuDeTonThap.TabIndex = 1;
            //
            // FormThongKe
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Text = "Thống kê";
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlLoc);
            this.Name = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.pnlTonThap.ResumeLayout(false);
            this.pnlBanChay.ResumeLayout(false);
            this.pnlBangDoanhThu.ResumeLayout(false);
            this.pnlBieuDo.ResumeLayout(false);
            this.tlpBang.ResumeLayout(false);
            this.pnlVachTienNhap.ResumeLayout(false);
            this.pnlTheTienNhap.ResumeLayout(false);
            this.pnlVachKhachHang.ResumeLayout(false);
            this.pnlTheKhachHang.ResumeLayout(false);
            this.pnlVachSoSanPham.ResumeLayout(false);
            this.pnlTheSoSanPham.ResumeLayout(false);
            this.pnlVachSoHoaDon.ResumeLayout(false);
            this.pnlTheSoHoaDon.ResumeLayout(false);
            this.pnlVachDoanhThu.ResumeLayout(false);
            this.pnlTheDoanhThu.ResumeLayout(false);
            this.tlpThe.ResumeLayout(false);
            this.tlpChinh.ResumeLayout(false);
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonThap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormThongKe.cs)
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label lblKhoangNhanh;
        private System.Windows.Forms.ComboBox cboKhoangNhanh;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblKieuThongKe;
        private System.Windows.Forms.ComboBox cboKieuThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.TableLayoutPanel tlpChinh;
        private System.Windows.Forms.TableLayoutPanel tlpThe;
        private System.Windows.Forms.Panel pnlTheDoanhThu;
        private System.Windows.Forms.Label lblTieuDeTheDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Panel pnlVachDoanhThu;
        private System.Windows.Forms.Panel pnlTheSoHoaDon;
        private System.Windows.Forms.Label lblTieuDeTheSoHoaDon;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Panel pnlVachSoHoaDon;
        private System.Windows.Forms.Panel pnlTheSoSanPham;
        private System.Windows.Forms.Label lblTieuDeTheSoSanPham;
        private System.Windows.Forms.Label lblSoSanPham;
        private System.Windows.Forms.Panel pnlVachSoSanPham;
        private System.Windows.Forms.Panel pnlTheKhachHang;
        private System.Windows.Forms.Label lblTieuDeTheKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Panel pnlVachKhachHang;
        private System.Windows.Forms.Panel pnlTheTienNhap;
        private System.Windows.Forms.Label lblTieuDeTheTienNhap;
        private System.Windows.Forms.Label lblTienNhap;
        private System.Windows.Forms.Panel pnlVachTienNhap;
        private System.Windows.Forms.TableLayoutPanel tlpBang;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Label lblTieuDeBieuDo;
        private System.Windows.Forms.Panel pnlBangDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.Windows.Forms.Label lblTieuDeBangDoanhThu;
        private System.Windows.Forms.Panel pnlBanChay;
        private System.Windows.Forms.DataGridView dgvBanChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCDoanhThu;
        private System.Windows.Forms.Label lblTieuDeBanChay;
        private System.Windows.Forms.Panel pnlTonThap;
        private System.Windows.Forms.DataGridView dgvTonThap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTTon;
        private System.Windows.Forms.Label lblTieuDeTonThap;
    }
}