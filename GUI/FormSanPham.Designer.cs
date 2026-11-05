namespace QuanLyShopQuanAo.GUI
{
    partial class FormSanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle kieuTieuDe = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuO = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuXen = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuTien = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuSo = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuLai = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblTieuDeThongTin = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.chkDangKinhDoanh = new System.Windows.Forms.CheckBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.cboThuongHieu = new System.Windows.Forms.ComboBox();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.cboKichThuoc = new System.Windows.Forms.ComboBox();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.cboMauSac = new System.Windows.Forms.ComboBox();
            this.lblChatLieu = new System.Windows.Forms.Label();
            this.cboChatLieu = new System.Windows.Forms.ComboBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.lblTyLeLai = new System.Windows.Forms.Label();
            this.nudTyLeLai = new System.Windows.Forms.NumericUpDown();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.nudSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.ttGoiY = new System.Windows.Forms.ToolTip(this.components);
            this.ofdChonAnh = new System.Windows.Forms.OpenFileDialog();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTyLeLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChanDanhSach = new System.Windows.Forms.Panel();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.pnlDauDanhSach = new System.Windows.Forms.Panel();
            this.lblTieuDeDanhSach = new System.Windows.Forms.Label();
            this.lblChiXem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblGoiYTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlThongTin.SuspendLayout();
            this.pnlDanhSach.SuspendLayout();
            this.pnlChanDanhSach.SuspendLayout();
            this.pnlDauDanhSach.SuspendLayout();
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
            kieuLai.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            kieuLai.Format = "0.##";
            kieuLai.NullValue = null;
            //
            // pnlThongTin
            //
            this.pnlThongTin.AutoScroll = true;
            this.pnlThongTin.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThongTin.Location = new System.Drawing.Point(630, 0);
            this.pnlThongTin.Size = new System.Drawing.Size(440, 666);
            this.pnlThongTin.Controls.Add(this.lblTieuDeThongTin);
            this.pnlThongTin.Controls.Add(this.lblMaSanPham);
            this.pnlThongTin.Controls.Add(this.txtMaSanPham);
            this.pnlThongTin.Controls.Add(this.chkDangKinhDoanh);
            this.pnlThongTin.Controls.Add(this.lblTenSanPham);
            this.pnlThongTin.Controls.Add(this.txtTenSanPham);
            this.pnlThongTin.Controls.Add(this.lblDanhMuc);
            this.pnlThongTin.Controls.Add(this.cboDanhMuc);
            this.pnlThongTin.Controls.Add(this.lblThuongHieu);
            this.pnlThongTin.Controls.Add(this.cboThuongHieu);
            this.pnlThongTin.Controls.Add(this.lblKichThuoc);
            this.pnlThongTin.Controls.Add(this.cboKichThuoc);
            this.pnlThongTin.Controls.Add(this.lblMauSac);
            this.pnlThongTin.Controls.Add(this.cboMauSac);
            this.pnlThongTin.Controls.Add(this.lblChatLieu);
            this.pnlThongTin.Controls.Add(this.cboChatLieu);
            this.pnlThongTin.Controls.Add(this.lblNhaCungCap);
            this.pnlThongTin.Controls.Add(this.cboNhaCungCap);
            this.pnlThongTin.Controls.Add(this.lblGiaNhap);
            this.pnlThongTin.Controls.Add(this.nudGiaNhap);
            this.pnlThongTin.Controls.Add(this.lblTyLeLai);
            this.pnlThongTin.Controls.Add(this.nudTyLeLai);
            this.pnlThongTin.Controls.Add(this.lblGiaBan);
            this.pnlThongTin.Controls.Add(this.nudGiaBan);
            this.pnlThongTin.Controls.Add(this.lblSoLuongTon);
            this.pnlThongTin.Controls.Add(this.nudSoLuongTon);
            this.pnlThongTin.Controls.Add(this.lblMoTa);
            this.pnlThongTin.Controls.Add(this.txtMoTa);
            this.pnlThongTin.Controls.Add(this.lblHinhAnh);
            this.pnlThongTin.Controls.Add(this.picHinhAnh);
            this.pnlThongTin.Controls.Add(this.btnChonAnh);
            this.pnlThongTin.Controls.Add(this.btnThem);
            this.pnlThongTin.Controls.Add(this.btnSua);
            this.pnlThongTin.Controls.Add(this.btnXoa);
            this.pnlThongTin.Controls.Add(this.btnLamMoi);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.TabIndex = 0;
            //
            // lblTieuDeThongTin
            //
            this.lblTieuDeThongTin.AutoSize = true;
            this.lblTieuDeThongTin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeThongTin.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeThongTin.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeThongTin.Text = "THÔNG TIN SẢN PHẨM";
            this.lblTieuDeThongTin.Name = "lblTieuDeThongTin";
            this.lblTieuDeThongTin.TabIndex = 0;
            //
            // lblMaSanPham
            //
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSanPham.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblMaSanPham.Location = new System.Drawing.Point(16, 46);
            this.lblMaSanPham.Text = "Mã sản phẩm";
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.TabIndex = 1;
            //
            // txtMaSanPham
            //
            this.txtMaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(16, 66);
            this.txtMaSanPham.Size = new System.Drawing.Size(198, 25);
            this.txtMaSanPham.MaxLength = 10;
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.TabIndex = 2;
            //
            // chkDangKinhDoanh
            //
            this.chkDangKinhDoanh.AutoSize = true;
            this.chkDangKinhDoanh.Checked = true;
            this.chkDangKinhDoanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDangKinhDoanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDangKinhDoanh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkDangKinhDoanh.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.chkDangKinhDoanh.Location = new System.Drawing.Point(228, 68);
            this.chkDangKinhDoanh.Text = "Đang kinh doanh";
            this.chkDangKinhDoanh.UseVisualStyleBackColor = true;
            this.chkDangKinhDoanh.Name = "chkDangKinhDoanh";
            this.chkDangKinhDoanh.TabIndex = 3;
            //
            // lblTenSanPham
            //
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSanPham.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTenSanPham.Location = new System.Drawing.Point(16, 100);
            this.lblTenSanPham.Text = "Tên sản phẩm";
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.TabIndex = 4;
            //
            // txtTenSanPham
            //
            this.txtTenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSanPham.Location = new System.Drawing.Point(16, 120);
            this.txtTenSanPham.Size = new System.Drawing.Size(408, 25);
            this.txtTenSanPham.MaxLength = 150;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.TabIndex = 5;
            //
            // lblDanhMuc
            //
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhMuc.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblDanhMuc.Location = new System.Drawing.Point(16, 154);
            this.lblDanhMuc.Text = "Danh mục";
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.TabIndex = 6;
            //
            // cboDanhMuc
            //
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(16, 174);
            this.cboDanhMuc.Size = new System.Drawing.Size(198, 25);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.TabIndex = 7;
            //
            // lblThuongHieu
            //
            this.lblThuongHieu.AutoSize = true;
            this.lblThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThuongHieu.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblThuongHieu.Location = new System.Drawing.Point(226, 154);
            this.lblThuongHieu.Text = "Thương hiệu";
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.TabIndex = 8;
            //
            // cboThuongHieu
            //
            this.cboThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuongHieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThuongHieu.FormattingEnabled = true;
            this.cboThuongHieu.Location = new System.Drawing.Point(226, 174);
            this.cboThuongHieu.Size = new System.Drawing.Size(198, 25);
            this.cboThuongHieu.Name = "cboThuongHieu";
            this.cboThuongHieu.TabIndex = 9;
            //
            // lblKichThuoc
            //
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKichThuoc.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblKichThuoc.Location = new System.Drawing.Point(16, 208);
            this.lblKichThuoc.Text = "Kích thước";
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.TabIndex = 10;
            //
            // cboKichThuoc
            //
            this.cboKichThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKichThuoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKichThuoc.FormattingEnabled = true;
            this.cboKichThuoc.Location = new System.Drawing.Point(16, 228);
            this.cboKichThuoc.Size = new System.Drawing.Size(198, 25);
            this.cboKichThuoc.Name = "cboKichThuoc";
            this.cboKichThuoc.TabIndex = 11;
            //
            // lblMauSac
            //
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMauSac.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblMauSac.Location = new System.Drawing.Point(226, 208);
            this.lblMauSac.Text = "Màu sắc";
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.TabIndex = 12;
            //
            // cboMauSac
            //
            this.cboMauSac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMauSac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMauSac.FormattingEnabled = true;
            this.cboMauSac.Location = new System.Drawing.Point(226, 228);
            this.cboMauSac.Size = new System.Drawing.Size(198, 25);
            this.cboMauSac.Name = "cboMauSac";
            this.cboMauSac.TabIndex = 13;
            //
            // lblChatLieu
            //
            this.lblChatLieu.AutoSize = true;
            this.lblChatLieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChatLieu.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblChatLieu.Location = new System.Drawing.Point(16, 262);
            this.lblChatLieu.Text = "Chất liệu";
            this.lblChatLieu.Name = "lblChatLieu";
            this.lblChatLieu.TabIndex = 14;
            //
            // cboChatLieu
            //
            this.cboChatLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChatLieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboChatLieu.FormattingEnabled = true;
            this.cboChatLieu.Location = new System.Drawing.Point(16, 282);
            this.cboChatLieu.Size = new System.Drawing.Size(198, 25);
            this.cboChatLieu.Name = "cboChatLieu";
            this.cboChatLieu.TabIndex = 15;
            //
            // lblNhaCungCap
            //
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblNhaCungCap.Location = new System.Drawing.Point(226, 262);
            this.lblNhaCungCap.Text = "Nhà cung cấp";
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.TabIndex = 16;
            //
            // cboNhaCungCap
            //
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(226, 282);
            this.cboNhaCungCap.Size = new System.Drawing.Size(198, 25);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.TabIndex = 17;
            //
            // lblGiaNhap
            //
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaNhap.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblGiaNhap.Location = new System.Drawing.Point(16, 316);
            this.lblGiaNhap.Text = "Giá nhập / giá vốn (đ)";
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.TabIndex = 18;
            //
            // nudGiaNhap
            //
            this.nudGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudGiaNhap.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudGiaNhap.Location = new System.Drawing.Point(16, 336);
            this.nudGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudGiaNhap.Size = new System.Drawing.Size(198, 25);
            this.nudGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiaNhap.ThousandsSeparator = true;
            this.nudGiaNhap.Name = "nudGiaNhap";
            this.nudGiaNhap.TabIndex = 19;
            this.nudGiaNhap.ValueChanged += new System.EventHandler(this.nudGiaNhap_ValueChanged);
            //
            // lblTyLeLai
            //
            this.lblTyLeLai.AutoSize = true;
            this.lblTyLeLai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTyLeLai.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTyLeLai.Location = new System.Drawing.Point(226, 316);
            this.lblTyLeLai.Text = "Tỷ lệ lãi (%)";
            this.lblTyLeLai.Name = "lblTyLeLai";
            this.lblTyLeLai.TabIndex = 20;
            //
            // nudTyLeLai
            //
            this.nudTyLeLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTyLeLai.Location = new System.Drawing.Point(226, 336);
            this.nudTyLeLai.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudTyLeLai.Size = new System.Drawing.Size(198, 25);
            this.nudTyLeLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTyLeLai.ThousandsSeparator = true;
            this.nudTyLeLai.DecimalPlaces = 2;
            this.nudTyLeLai.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudTyLeLai.Name = "nudTyLeLai";
            this.nudTyLeLai.TabIndex = 21;
            this.nudTyLeLai.ValueChanged += new System.EventHandler(this.nudTyLeLai_ValueChanged);
            //
            // lblGiaBan
            //
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblGiaBan.Location = new System.Drawing.Point(16, 370);
            this.lblGiaBan.Text = "Giá bán (đ)";
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.TabIndex = 22;
            //
            // nudGiaBan
            //
            this.nudGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudGiaBan.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudGiaBan.Location = new System.Drawing.Point(16, 390);
            this.nudGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudGiaBan.Size = new System.Drawing.Size(198, 25);
            this.nudGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiaBan.ThousandsSeparator = true;
            this.nudGiaBan.Name = "nudGiaBan";
            this.nudGiaBan.TabIndex = 23;
            //
            // lblSoLuongTon
            //
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuongTon.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblSoLuongTon.Location = new System.Drawing.Point(226, 370);
            this.lblSoLuongTon.Text = "Số lượng tồn";
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.TabIndex = 24;
            //
            // nudSoLuongTon
            //
            this.nudSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongTon.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongTon.Location = new System.Drawing.Point(226, 390);
            this.nudSoLuongTon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudSoLuongTon.Size = new System.Drawing.Size(198, 25);
            this.nudSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuongTon.ThousandsSeparator = true;
            this.nudSoLuongTon.Name = "nudSoLuongTon";
            this.nudSoLuongTon.TabIndex = 25;
            //
            // lblMoTa
            //
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblMoTa.Location = new System.Drawing.Point(16, 424);
            this.lblMoTa.Text = "Mô tả";
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.TabIndex = 26;
            //
            // txtMoTa
            //
            this.txtMoTa.Multiline = true;
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMoTa.Location = new System.Drawing.Point(16, 444);
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.MaxLength = 500;
            this.txtMoTa.Size = new System.Drawing.Size(198, 70);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.TabIndex = 27;
            //
            // lblHinhAnh
            //
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHinhAnh.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblHinhAnh.Location = new System.Drawing.Point(226, 424);
            this.lblHinhAnh.Text = "Hình ảnh";
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.TabIndex = 28;
            //
            // picHinhAnh
            //
            this.picHinhAnh.BackColor = System.Drawing.Color.White;
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(226, 444);
            this.picHinhAnh.Size = new System.Drawing.Size(198, 96);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabStop = false;
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.TabIndex = 29;
            //
            // btnChonAnh
            //
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(226, 544);
            this.btnChonAnh.Size = new System.Drawing.Size(198, 26);
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.TabIndex = 30;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            //
            // btnThem
            //
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(16, 582);
            this.btnThem.Size = new System.Drawing.Size(96, 40);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Name = "btnThem";
            this.btnThem.TabIndex = 31;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(120, 582);
            this.btnSua.Size = new System.Drawing.Size(96, 40);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Name = "btnSua";
            this.btnSua.TabIndex = 32;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(224, 582);
            this.btnXoa.Size = new System.Drawing.Size(96, 40);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(328, 582);
            this.btnLamMoi.Size = new System.Drawing.Size(96, 40);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.TabIndex = 34;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // ttGoiY
            //
            this.ttGoiY.AutoPopDelay = 12000;
            this.ttGoiY.InitialDelay = 300;
            this.ttGoiY.ReshowDelay = 100;
            this.ttGoiY.SetToolTip(this.nudTyLeLai, "Giá bán = giá nhập x (1 + tỷ lệ lãi / 100).\nVí dụ: giá vốn 90.000, lãi 40% -> giá bán 126.000.\nĐể 0 nếu muốn tự nhập giá bán.");
            this.ttGoiY.SetToolTip(this.nudGiaBan, "Khi có tỷ lệ lãi (> 0), giá bán được tính tự động từ giá nhập.");
            //
            // ofdChonAnh
            //
            this.ofdChonAnh.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả các tệp (*.*)|*.*";
            this.ofdChonAnh.Title = "Chọn hình ảnh sản phẩm";
            //
            // pnlDanhSach
            //
            this.pnlDanhSach.BackColor = System.Drawing.Color.White;
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSach.Size = new System.Drawing.Size(630, 666);
            this.pnlDanhSach.Controls.Add(this.dgvSanPham);
            this.pnlDanhSach.Controls.Add(this.pnlChanDanhSach);
            this.pnlDanhSach.Controls.Add(this.pnlDauDanhSach);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.TabIndex = 1;
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
            this.dgvSanPham.RowTemplate.Height = 30;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(630, 544);
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colMaSanPham,
                        this.colTenSanPham,
                        this.colDanhMuc,
                        this.colThuongHieu,
                        this.colKichThuoc,
                        this.colMauSac,
                        this.colGiaBan,
                        this.colTyLeLai,
                        this.colSoLuongTon,
                        this.colTrangThai});
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            this.dgvSanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPham_CellFormatting);
            //
            // colMaSanPham
            //
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.FillWeight = 18F;
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
            // colDanhMuc
            //
            this.colDanhMuc.DataPropertyName = "TenDanhMuc";
            this.colDanhMuc.FillWeight = 24F;
            this.colDanhMuc.HeaderText = "Danh mục";
            this.colDanhMuc.ReadOnly = true;
            this.colDanhMuc.Name = "colDanhMuc";
            //
            // colThuongHieu
            //
            this.colThuongHieu.DataPropertyName = "TenThuongHieu";
            this.colThuongHieu.FillWeight = 26F;
            this.colThuongHieu.HeaderText = "Thương hiệu";
            this.colThuongHieu.ReadOnly = true;
            this.colThuongHieu.Name = "colThuongHieu";
            //
            // colKichThuoc
            //
            this.colKichThuoc.DataPropertyName = "TenKichThuoc";
            this.colKichThuoc.DefaultCellStyle = kieuSo;
            this.colKichThuoc.FillWeight = 12F;
            this.colKichThuoc.HeaderText = "Size";
            this.colKichThuoc.ReadOnly = true;
            this.colKichThuoc.Name = "colKichThuoc";
            //
            // colMauSac
            //
            this.colMauSac.DataPropertyName = "TenMauSac";
            this.colMauSac.FillWeight = 22F;
            this.colMauSac.HeaderText = "Màu sắc";
            this.colMauSac.ReadOnly = true;
            this.colMauSac.Name = "colMauSac";
            //
            // colGiaBan
            //
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.DefaultCellStyle = kieuTien;
            this.colGiaBan.FillWeight = 24F;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.ReadOnly = true;
            this.colGiaBan.Name = "colGiaBan";
            //
            // colTyLeLai
            //
            this.colTyLeLai.DataPropertyName = "TyLeLai";
            this.colTyLeLai.DefaultCellStyle = kieuLai;
            this.colTyLeLai.FillWeight = 12F;
            this.colTyLeLai.HeaderText = "Lãi (%)";
            this.colTyLeLai.ReadOnly = true;
            this.colTyLeLai.Name = "colTyLeLai";
            //
            // colSoLuongTon
            //
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.DefaultCellStyle = kieuSo;
            this.colSoLuongTon.FillWeight = 12F;
            this.colSoLuongTon.HeaderText = "Tồn";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Name = "colSoLuongTon";
            //
            // colTrangThai
            //
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 28F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Name = "colTrangThai";
            //
            // pnlChanDanhSach
            //
            this.pnlChanDanhSach.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlChanDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChanDanhSach.Location = new System.Drawing.Point(0, 636);
            this.pnlChanDanhSach.Size = new System.Drawing.Size(630, 30);
            this.pnlChanDanhSach.Controls.Add(this.lblTongSo);
            this.pnlChanDanhSach.Name = "pnlChanDanhSach";
            this.pnlChanDanhSach.TabIndex = 1;
            //
            // lblTongSo
            //
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSo.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTongSo.Location = new System.Drawing.Point(12, 6);
            this.lblTongSo.Text = "Tổng: 0 sản phẩm";
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.TabIndex = 0;
            //
            // pnlDauDanhSach
            //
            this.pnlDauDanhSach.BackColor = System.Drawing.Color.White;
            this.pnlDauDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDauDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDauDanhSach.Size = new System.Drawing.Size(630, 92);
            this.pnlDauDanhSach.Controls.Add(this.lblTieuDeDanhSach);
            this.pnlDauDanhSach.Controls.Add(this.lblChiXem);
            this.pnlDauDanhSach.Controls.Add(this.txtTimKiem);
            this.pnlDauDanhSach.Controls.Add(this.btnTimKiem);
            this.pnlDauDanhSach.Controls.Add(this.lblGoiYTimKiem);
            this.pnlDauDanhSach.Name = "pnlDauDanhSach";
            this.pnlDauDanhSach.TabIndex = 2;
            //
            // lblTieuDeDanhSach
            //
            this.lblTieuDeDanhSach.AutoSize = true;
            this.lblTieuDeDanhSach.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeDanhSach.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeDanhSach.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeDanhSach.Text = "DANH SÁCH SẢN PHẨM";
            this.lblTieuDeDanhSach.Name = "lblTieuDeDanhSach";
            this.lblTieuDeDanhSach.TabIndex = 0;
            //
            // lblChiXem
            //
            this.lblChiXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiXem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChiXem.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblChiXem.Location = new System.Drawing.Point(300, 14);
            this.lblChiXem.Size = new System.Drawing.Size(316, 20);
            this.lblChiXem.Text = "Chế độ chỉ xem (cần quyền quản trị để sửa)";
            this.lblChiXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChiXem.Visible = false;
            this.lblChiXem.Name = "lblChiXem";
            this.lblChiXem.TabIndex = 1;
            //
            // txtTimKiem
            //
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(14, 42);
            this.txtTimKiem.Size = new System.Drawing.Size(340, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TabIndex = 2;
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
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            //
            // lblGoiYTimKiem
            //
            this.lblGoiYTimKiem.AutoSize = true;
            this.lblGoiYTimKiem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoiYTimKiem.ForeColor = System.Drawing.Color.FromArgb(141, 110, 99);
            this.lblGoiYTimKiem.Location = new System.Drawing.Point(14, 71);
            this.lblGoiYTimKiem.Text = "Tìm theo mã, tên, danh mục hoặc thương hiệu (nhấn Enter để tìm)";
            this.lblGoiYTimKiem.Name = "lblGoiYTimKiem";
            this.lblGoiYTimKiem.TabIndex = 4;
            //
            // FormSanPham
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Text = "Quản lý sản phẩm";
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlThongTin);
            this.Name = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.pnlDauDanhSach.ResumeLayout(false);
            this.pnlChanDanhSach.ResumeLayout(false);
            this.pnlDanhSach.ResumeLayout(false);
            this.pnlThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormSanPham.cs)
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblTieuDeThongTin;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.CheckBox chkDangKinhDoanh;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.ComboBox cboThuongHieu;
        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.ComboBox cboKichThuoc;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.ComboBox cboMauSac;
        private System.Windows.Forms.Label lblChatLieu;
        private System.Windows.Forms.ComboBox cboChatLieu;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.Label lblTyLeLai;
        private System.Windows.Forms.NumericUpDown nudTyLeLai;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ToolTip ttGoiY;
        private System.Windows.Forms.OpenFileDialog ofdChonAnh;
        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyLeLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlChanDanhSach;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Panel pnlDauDanhSach;
        private System.Windows.Forms.Label lblTieuDeDanhSach;
        private System.Windows.Forms.Label lblChiXem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblGoiYTimKiem;
    }
}