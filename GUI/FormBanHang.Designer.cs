namespace QuanLyShopQuanAo.GUI
{
    partial class FormBanHang
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
            this.pnlGioHang = new System.Windows.Forms.Panel();
            this.lblTieuDeGioHang = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colGioTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.lblTongTienText = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGiaText = new System.Windows.Forms.Label();
            this.nudPhanTram = new System.Windows.Forms.NumericUpDown();
            this.lblPhanTram = new System.Windows.Forms.Label();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.lblDong = new System.Windows.Forms.Label();
            this.lblThanhTienText = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblKhachDuaText = new System.Windows.Forms.Label();
            this.nudKhachDua = new System.Windows.Forms.NumericUpDown();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.chkGhiNo = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlSanPham = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChiTietSanPham = new System.Windows.Forms.Panel();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.lblSizeMau = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.lblSoLuongText = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.pnlDauSanPham = new System.Windows.Forms.Panel();
            this.lblTieuDeSanPham = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblGoiYTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.pnlGioHang.SuspendLayout();
            this.pnlSanPham.SuspendLayout();
            this.pnlChiTietSanPham.SuspendLayout();
            this.pnlDauSanPham.SuspendLayout();
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
            // pnlGioHang
            //
            this.pnlGioHang.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlGioHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGioHang.Location = new System.Drawing.Point(570, 0);
            this.pnlGioHang.Size = new System.Drawing.Size(500, 666);
            this.pnlGioHang.Controls.Add(this.lblTieuDeGioHang);
            this.pnlGioHang.Controls.Add(this.lblKhachHang);
            this.pnlGioHang.Controls.Add(this.cboKhachHang);
            this.pnlGioHang.Controls.Add(this.lblNhanVien);
            this.pnlGioHang.Controls.Add(this.dgvGioHang);
            this.pnlGioHang.Controls.Add(this.btnGiam);
            this.pnlGioHang.Controls.Add(this.btnTang);
            this.pnlGioHang.Controls.Add(this.btnXoaKhoiGio);
            this.pnlGioHang.Controls.Add(this.lblTongTienText);
            this.pnlGioHang.Controls.Add(this.lblTongTien);
            this.pnlGioHang.Controls.Add(this.lblGiamGiaText);
            this.pnlGioHang.Controls.Add(this.nudPhanTram);
            this.pnlGioHang.Controls.Add(this.lblPhanTram);
            this.pnlGioHang.Controls.Add(this.nudGiamGia);
            this.pnlGioHang.Controls.Add(this.lblDong);
            this.pnlGioHang.Controls.Add(this.lblThanhTienText);
            this.pnlGioHang.Controls.Add(this.lblThanhTien);
            this.pnlGioHang.Controls.Add(this.lblKhachDuaText);
            this.pnlGioHang.Controls.Add(this.nudKhachDua);
            this.pnlGioHang.Controls.Add(this.lblTienThua);
            this.pnlGioHang.Controls.Add(this.chkGhiNo);
            this.pnlGioHang.Controls.Add(this.btnThanhToan);
            this.pnlGioHang.Controls.Add(this.btnHuyDon);
            this.pnlGioHang.Controls.Add(this.btnLamMoi);
            this.pnlGioHang.Name = "pnlGioHang";
            this.pnlGioHang.TabIndex = 0;
            //
            // lblTieuDeGioHang
            //
            this.lblTieuDeGioHang.AutoSize = true;
            this.lblTieuDeGioHang.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeGioHang.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeGioHang.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeGioHang.Text = "GIỎ HÀNG";
            this.lblTieuDeGioHang.Name = "lblTieuDeGioHang";
            this.lblTieuDeGioHang.TabIndex = 0;
            //
            // lblKhachHang
            //
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblKhachHang.Location = new System.Drawing.Point(16, 44);
            this.lblKhachHang.Text = "Khách hàng";
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.TabIndex = 1;
            //
            // cboKhachHang
            //
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(16, 64);
            this.cboKhachHang.Size = new System.Drawing.Size(468, 27);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.TabIndex = 2;
            //
            // lblNhanVien
            //
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblNhanVien.Location = new System.Drawing.Point(16, 98);
            this.lblNhanVien.Text = "Nhân viên lập hóa đơn: ";
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.TabIndex = 3;
            //
            // dgvGioHang
            //
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AllowUserToResizeRows = false;
            this.dgvGioHang.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvGioHang.AutoGenerateColumns = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvGioHang.ColumnHeadersHeight = 34;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGioHang.DefaultCellStyle = kieuO;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvGioHang.Location = new System.Drawing.Point(16, 124);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(468, 200);
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colGioTen,
                        this.colGioSize,
                        this.colGioMau,
                        this.colGioSoLuong,
                        this.colGioDonGia,
                        this.colGioThanhTien});
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.TabIndex = 4;
            //
            // colGioTen
            //
            this.colGioTen.DataPropertyName = "TenSanPham";
            this.colGioTen.FillWeight = 40F;
            this.colGioTen.HeaderText = "Sản phẩm";
            this.colGioTen.ReadOnly = true;
            this.colGioTen.Name = "colGioTen";
            //
            // colGioSize
            //
            this.colGioSize.DataPropertyName = "TenKichThuoc";
            this.colGioSize.DefaultCellStyle = kieuSo;
            this.colGioSize.FillWeight = 12F;
            this.colGioSize.HeaderText = "Size";
            this.colGioSize.ReadOnly = true;
            this.colGioSize.Name = "colGioSize";
            //
            // colGioMau
            //
            this.colGioMau.DataPropertyName = "TenMauSac";
            this.colGioMau.FillWeight = 18F;
            this.colGioMau.HeaderText = "Màu";
            this.colGioMau.ReadOnly = true;
            this.colGioMau.Name = "colGioMau";
            //
            // colGioSoLuong
            //
            this.colGioSoLuong.DataPropertyName = "SoLuong";
            this.colGioSoLuong.DefaultCellStyle = kieuSo;
            this.colGioSoLuong.FillWeight = 10F;
            this.colGioSoLuong.HeaderText = "SL";
            this.colGioSoLuong.ReadOnly = true;
            this.colGioSoLuong.Name = "colGioSoLuong";
            //
            // colGioDonGia
            //
            this.colGioDonGia.DataPropertyName = "DonGia";
            this.colGioDonGia.DefaultCellStyle = kieuTien;
            this.colGioDonGia.FillWeight = 22F;
            this.colGioDonGia.HeaderText = "Đơn giá";
            this.colGioDonGia.ReadOnly = true;
            this.colGioDonGia.Name = "colGioDonGia";
            //
            // colGioThanhTien
            //
            this.colGioThanhTien.DataPropertyName = "ThanhTien";
            this.colGioThanhTien.DefaultCellStyle = kieuTien;
            this.colGioThanhTien.FillWeight = 24F;
            this.colGioThanhTien.HeaderText = "Thành tiền";
            this.colGioThanhTien.ReadOnly = true;
            this.colGioThanhTien.Name = "colGioThanhTien";
            //
            // btnGiam
            //
            this.btnGiam.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnGiam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiam.FlatAppearance.BorderSize = 0;
            this.btnGiam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiam.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiam.ForeColor = System.Drawing.Color.White;
            this.btnGiam.Location = new System.Drawing.Point(16, 332);
            this.btnGiam.Size = new System.Drawing.Size(44, 32);
            this.btnGiam.Text = "−";
            this.btnGiam.UseVisualStyleBackColor = false;
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.TabIndex = 5;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            //
            // btnTang
            //
            this.btnTang.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnTang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTang.FlatAppearance.BorderSize = 0;
            this.btnTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTang.ForeColor = System.Drawing.Color.White;
            this.btnTang.Location = new System.Drawing.Point(66, 332);
            this.btnTang.Size = new System.Drawing.Size(44, 32);
            this.btnTang.Text = "+";
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Name = "btnTang";
            this.btnTang.TabIndex = 6;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            //
            // btnXoaKhoiGio
            //
            this.btnXoaKhoiGio.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnXoaKhoiGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoiGio.FlatAppearance.BorderSize = 0;
            this.btnXoaKhoiGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(116, 332);
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(100, 32);
            this.btnXoaKhoiGio.Text = "Xóa dòng";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = false;
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.TabIndex = 7;
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGio_Click);
            //
            // lblTongTienText
            //
            this.lblTongTienText.AutoSize = true;
            this.lblTongTienText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTienText.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTongTienText.Location = new System.Drawing.Point(16, 378);
            this.lblTongTienText.Text = "Tổng tiền hàng";
            this.lblTongTienText.Name = "lblTongTienText";
            this.lblTongTienText.TabIndex = 8;
            //
            // lblTongTien
            //
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblTongTien.Location = new System.Drawing.Point(250, 374);
            this.lblTongTien.Size = new System.Drawing.Size(234, 26);
            this.lblTongTien.Text = "0 đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.TabIndex = 9;
            //
            // lblGiamGiaText
            //
            this.lblGiamGiaText.AutoSize = true;
            this.lblGiamGiaText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiamGiaText.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblGiamGiaText.Location = new System.Drawing.Point(16, 414);
            this.lblGiamGiaText.Text = "Giảm giá";
            this.lblGiamGiaText.Name = "lblGiamGiaText";
            this.lblGiamGiaText.TabIndex = 10;
            //
            // nudPhanTram
            //
            this.nudPhanTram.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudPhanTram.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudPhanTram.Location = new System.Drawing.Point(100, 410);
            this.nudPhanTram.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudPhanTram.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudPhanTram.Size = new System.Drawing.Size(70, 25);
            this.nudPhanTram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPhanTram.ThousandsSeparator = true;
            this.nudPhanTram.Name = "nudPhanTram";
            this.nudPhanTram.TabIndex = 11;
            //
            // lblPhanTram
            //
            this.lblPhanTram.AutoSize = true;
            this.lblPhanTram.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhanTram.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPhanTram.Location = new System.Drawing.Point(174, 414);
            this.lblPhanTram.Text = "%";
            this.lblPhanTram.Name = "lblPhanTram";
            this.lblPhanTram.TabIndex = 12;
            //
            // nudGiamGia
            //
            this.nudGiamGia.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudGiamGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudGiamGia.Location = new System.Drawing.Point(204, 410);
            this.nudGiamGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudGiamGia.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudGiamGia.Size = new System.Drawing.Size(200, 25);
            this.nudGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiamGia.ThousandsSeparator = true;
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.TabIndex = 13;
            //
            // lblDong
            //
            this.lblDong.AutoSize = true;
            this.lblDong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDong.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblDong.Location = new System.Drawing.Point(408, 414);
            this.lblDong.Text = "đ";
            this.lblDong.Name = "lblDong";
            this.lblDong.TabIndex = 14;
            //
            // lblThanhTienText
            //
            this.lblThanhTienText.AutoSize = true;
            this.lblThanhTienText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhTienText.ForeColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.lblThanhTienText.Location = new System.Drawing.Point(16, 456);
            this.lblThanhTienText.Text = "THÀNH TIỀN";
            this.lblThanhTienText.Name = "lblThanhTienText";
            this.lblThanhTienText.TabIndex = 15;
            //
            // lblThanhTien
            //
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.lblThanhTien.Location = new System.Drawing.Point(190, 446);
            this.lblThanhTien.Size = new System.Drawing.Size(294, 38);
            this.lblThanhTien.Text = "0 đ";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.TabIndex = 16;
            //
            // lblKhachDuaText
            //
            this.lblKhachDuaText.AutoSize = true;
            this.lblKhachDuaText.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhachDuaText.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblKhachDuaText.Location = new System.Drawing.Point(16, 498);
            this.lblKhachDuaText.Text = "Khách đưa";
            this.lblKhachDuaText.Name = "lblKhachDuaText";
            this.lblKhachDuaText.TabIndex = 17;
            //
            // nudKhachDua
            //
            this.nudKhachDua.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKhachDua.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudKhachDua.Location = new System.Drawing.Point(110, 494);
            this.nudKhachDua.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudKhachDua.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudKhachDua.Size = new System.Drawing.Size(200, 25);
            this.nudKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKhachDua.ThousandsSeparator = true;
            this.nudKhachDua.Name = "nudKhachDua";
            this.nudKhachDua.TabIndex = 18;
            //
            // lblTienThua
            //
            this.lblTienThua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienThua.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.lblTienThua.Location = new System.Drawing.Point(316, 492);
            this.lblTienThua.Size = new System.Drawing.Size(168, 28);
            this.lblTienThua.Text = "";
            this.lblTienThua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.TabIndex = 19;
            //
            // chkGhiNo
            //
            this.chkGhiNo.AutoSize = true;
            this.chkGhiNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGhiNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkGhiNo.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.chkGhiNo.Location = new System.Drawing.Point(18, 528);
            this.chkGhiNo.Text = "Ghi nợ (chưa thanh toán)";
            this.chkGhiNo.UseVisualStyleBackColor = true;
            this.chkGhiNo.Name = "chkGhiNo";
            this.chkGhiNo.TabIndex = 20;
            //
            // btnThanhToan
            //
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(16, 560);
            this.btnThanhToan.Size = new System.Drawing.Size(224, 50);
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.TabIndex = 21;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            //
            // btnHuyDon
            //
            this.btnHuyDon.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnHuyDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyDon.FlatAppearance.BorderSize = 0;
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(248, 560);
            this.btnHuyDon.Size = new System.Drawing.Size(112, 50);
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.TabIndex = 22;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(368, 560);
            this.btnLamMoi.Size = new System.Drawing.Size(116, 50);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // pnlSanPham
            //
            this.pnlSanPham.BackColor = System.Drawing.Color.White;
            this.pnlSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlSanPham.Size = new System.Drawing.Size(570, 666);
            this.pnlSanPham.Controls.Add(this.dgvSanPham);
            this.pnlSanPham.Controls.Add(this.pnlChiTietSanPham);
            this.pnlSanPham.Controls.Add(this.pnlDauSanPham);
            this.pnlSanPham.Name = "pnlSanPham";
            this.pnlSanPham.TabIndex = 1;
            //
            // dgvSanPham
            //
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvSanPham.ColumnHeadersHeight = 36;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.DefaultCellStyle = kieuO;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvSanPham.Location = new System.Drawing.Point(0, 92);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(570, 398);
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colMaSanPham,
                        this.colTenSanPham,
                        this.colKichThuoc,
                        this.colMauSac,
                        this.colGiaBan,
                        this.colSoLuongTon});
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            this.dgvSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellDoubleClick);
            this.dgvSanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPham_CellFormatting);
            //
            // colMaSanPham
            //
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.FillWeight = 16F;
            this.colMaSanPham.HeaderText = "Mã SP";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.Name = "colMaSanPham";
            //
            // colTenSanPham
            //
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.FillWeight = 46F;
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.ReadOnly = true;
            this.colTenSanPham.Name = "colTenSanPham";
            //
            // colKichThuoc
            //
            this.colKichThuoc.DataPropertyName = "TenKichThuoc";
            this.colKichThuoc.DefaultCellStyle = kieuSo;
            this.colKichThuoc.FillWeight = 11F;
            this.colKichThuoc.HeaderText = "Size";
            this.colKichThuoc.ReadOnly = true;
            this.colKichThuoc.Name = "colKichThuoc";
            //
            // colMauSac
            //
            this.colMauSac.DataPropertyName = "TenMauSac";
            this.colMauSac.FillWeight = 20F;
            this.colMauSac.HeaderText = "Màu sắc";
            this.colMauSac.ReadOnly = true;
            this.colMauSac.Name = "colMauSac";
            //
            // colGiaBan
            //
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.DefaultCellStyle = kieuTien;
            this.colGiaBan.FillWeight = 22F;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.Name = "colGiaBan";
            //
            // colSoLuongTon
            //
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.DefaultCellStyle = kieuSo;
            this.colSoLuongTon.FillWeight = 10F;
            this.colSoLuongTon.HeaderText = "Tồn";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Name = "colSoLuongTon";
            //
            // pnlChiTietSanPham
            //
            this.pnlChiTietSanPham.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlChiTietSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChiTietSanPham.Location = new System.Drawing.Point(0, 490);
            this.pnlChiTietSanPham.Size = new System.Drawing.Size(570, 176);
            this.pnlChiTietSanPham.Controls.Add(this.picSanPham);
            this.pnlChiTietSanPham.Controls.Add(this.lblTenSanPham);
            this.pnlChiTietSanPham.Controls.Add(this.lblMaSanPham);
            this.pnlChiTietSanPham.Controls.Add(this.lblSizeMau);
            this.pnlChiTietSanPham.Controls.Add(this.lblGiaBan);
            this.pnlChiTietSanPham.Controls.Add(this.lblTonKho);
            this.pnlChiTietSanPham.Controls.Add(this.lblSoLuongText);
            this.pnlChiTietSanPham.Controls.Add(this.nudSoLuong);
            this.pnlChiTietSanPham.Controls.Add(this.btnThemVaoGio);
            this.pnlChiTietSanPham.Name = "pnlChiTietSanPham";
            this.pnlChiTietSanPham.TabIndex = 1;
            //
            // picSanPham
            //
            this.picSanPham.BackColor = System.Drawing.Color.White;
            this.picSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSanPham.Location = new System.Drawing.Point(14, 12);
            this.picSanPham.Size = new System.Drawing.Size(150, 150);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabStop = false;
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.TabIndex = 0;
            //
            // lblTenSanPham
            //
            this.lblTenSanPham.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSanPham.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblTenSanPham.Location = new System.Drawing.Point(180, 12);
            this.lblTenSanPham.Size = new System.Drawing.Size(376, 44);
            this.lblTenSanPham.Text = "Chọn một sản phẩm trong danh sách";
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.TabIndex = 1;
            //
            // lblMaSanPham
            //
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSanPham.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblMaSanPham.Location = new System.Drawing.Point(180, 58);
            this.lblMaSanPham.Text = "";
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.TabIndex = 2;
            //
            // lblSizeMau
            //
            this.lblSizeMau.AutoSize = true;
            this.lblSizeMau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSizeMau.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblSizeMau.Location = new System.Drawing.Point(180, 80);
            this.lblSizeMau.Text = "";
            this.lblSizeMau.Name = "lblSizeMau";
            this.lblSizeMau.TabIndex = 3;
            //
            // lblGiaBan
            //
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.lblGiaBan.Location = new System.Drawing.Point(180, 104);
            this.lblGiaBan.Text = "";
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.TabIndex = 4;
            //
            // lblTonKho
            //
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTonKho.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.lblTonKho.Location = new System.Drawing.Point(180, 140);
            this.lblTonKho.Text = "";
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.TabIndex = 5;
            //
            // lblSoLuongText
            //
            this.lblSoLuongText.AutoSize = true;
            this.lblSoLuongText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuongText.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblSoLuongText.Location = new System.Drawing.Point(350, 110);
            this.lblSoLuongText.Text = "Số lượng";
            this.lblSoLuongText.Name = "lblSoLuongText";
            this.lblSoLuongText.TabIndex = 6;
            //
            // nudSoLuong
            //
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuong.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Location = new System.Drawing.Point(350, 132);
            this.nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Size = new System.Drawing.Size(80, 25);
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuong.ThousandsSeparator = true;
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.TabIndex = 7;
            //
            // btnThemVaoGio
            //
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnThemVaoGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoGio.FlatAppearance.BorderSize = 0;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(440, 124);
            this.btnThemVaoGio.Size = new System.Drawing.Size(116, 40);
            this.btnThemVaoGio.Text = "Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.TabIndex = 8;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            //
            // pnlDauSanPham
            //
            this.pnlDauSanPham.BackColor = System.Drawing.Color.White;
            this.pnlDauSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDauSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlDauSanPham.Size = new System.Drawing.Size(570, 92);
            this.pnlDauSanPham.Controls.Add(this.lblTieuDeSanPham);
            this.pnlDauSanPham.Controls.Add(this.txtTimKiem);
            this.pnlDauSanPham.Controls.Add(this.btnTimKiem);
            this.pnlDauSanPham.Controls.Add(this.lblGoiYTimKiem);
            this.pnlDauSanPham.Name = "pnlDauSanPham";
            this.pnlDauSanPham.TabIndex = 2;
            //
            // lblTieuDeSanPham
            //
            this.lblTieuDeSanPham.AutoSize = true;
            this.lblTieuDeSanPham.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeSanPham.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeSanPham.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeSanPham.Text = "CHỌN SẢN PHẨM";
            this.lblTieuDeSanPham.Name = "lblTieuDeSanPham";
            this.lblTieuDeSanPham.TabIndex = 0;
            //
            // txtTimKiem
            //
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(14, 42);
            this.txtTimKiem.Size = new System.Drawing.Size(340, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            //
            // btnTimKiem
            //
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(362, 41);
            this.btnTimKiem.Size = new System.Drawing.Size(100, 29);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            //
            // lblGoiYTimKiem
            //
            this.lblGoiYTimKiem.AutoSize = true;
            this.lblGoiYTimKiem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoiYTimKiem.ForeColor = System.Drawing.Color.FromArgb(141, 110, 99);
            this.lblGoiYTimKiem.Location = new System.Drawing.Point(14, 71);
            this.lblGoiYTimKiem.Text = "Tìm theo mã, tên, danh mục hoặc thương hiệu. Nhấp đúp vào sản phẩm để thêm nhanh 1 cái vào giỏ.";
            this.lblGoiYTimKiem.Name = "lblGoiYTimKiem";
            this.lblGoiYTimKiem.TabIndex = 3;
            //
            // FormBanHang
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Text = "Bán hàng";
            this.Controls.Add(this.pnlSanPham);
            this.Controls.Add(this.pnlGioHang);
            this.Name = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.pnlDauSanPham.ResumeLayout(false);
            this.pnlChiTietSanPham.ResumeLayout(false);
            this.pnlSanPham.ResumeLayout(false);
            this.pnlGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormBanHang.cs)
        private System.Windows.Forms.Panel pnlGioHang;
        private System.Windows.Forms.Label lblTieuDeGioHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioThanhTien;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnXoaKhoiGio;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiamGiaText;
        private System.Windows.Forms.NumericUpDown nudPhanTram;
        private System.Windows.Forms.Label lblPhanTram;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label lblDong;
        private System.Windows.Forms.Label lblThanhTienText;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblKhachDuaText;
        private System.Windows.Forms.NumericUpDown nudKhachDua;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.CheckBox chkGhiNo;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.Panel pnlChiTietSanPham;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.Label lblSizeMau;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Label lblSoLuongText;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Panel pnlDauSanPham;
        private System.Windows.Forms.Label lblTieuDeSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblGoiYTimKiem;
    }
}