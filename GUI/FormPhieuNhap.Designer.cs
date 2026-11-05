namespace QuanLyShopQuanAo.GUI
{
    partial class FormPhieuNhap
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
            this.tabPhieuNhap = new System.Windows.Forms.TabControl();
            this.tabLapPhieu = new System.Windows.Forms.TabPage();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.pnlLapTrai = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChonSanPham = new System.Windows.Forms.Panel();
            this.lblSanPhamChon = new System.Windows.Forms.Label();
            this.lblSoLuongText = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblGiaNhapText = new System.Windows.Forms.Label();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.lblGiaVonDuKien = new System.Windows.Forms.Label();
            this.btnThemVaoPhieu = new System.Windows.Forms.Button();
            this.pnlDauSanPham = new System.Windows.Forms.Panel();
            this.lblTieuDeSanPham = new System.Windows.Forms.Label();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.btnTimKiemSP = new System.Windows.Forms.Button();
            this.lblGoiYSP = new System.Windows.Forms.Label();
            this.pnlLapPhai = new System.Windows.Forms.Panel();
            this.lblTieuDePhieu = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.colNhapTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaHet = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.lblTongTienText = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXacNhanNhap = new System.Windows.Forms.Button();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.pnlLSTrai = new System.Windows.Forms.Panel();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colPNMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPNNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPNNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPNNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPNTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChanLS = new System.Windows.Forms.Panel();
            this.lblTongSoPN = new System.Windows.Forms.Label();
            this.pnlDauLS = new System.Windows.Forms.Panel();
            this.lblTieuDeLS = new System.Windows.Forms.Label();
            this.txtTimKiemPN = new System.Windows.Forms.TextBox();
            this.btnTimKiemPN = new System.Windows.Forms.Button();
            this.lblGoiYPN = new System.Windows.Forms.Label();
            this.lblTuNgayPN = new System.Windows.Forms.Label();
            this.dtpTuNgayPN = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgayPN = new System.Windows.Forms.Label();
            this.dtpDenNgayPN = new System.Windows.Forms.DateTimePicker();
            this.btnBoLocPN = new System.Windows.Forms.Button();
            this.btnXuatDanhSach = new System.Windows.Forms.Button();
            this.pnlLSPhai = new System.Windows.Forms.Panel();
            this.lblTieuDeChiTietPN = new System.Windows.Forms.Label();
            this.lblPNMa = new System.Windows.Forms.Label();
            this.txtPNMaPhieu = new System.Windows.Forms.TextBox();
            this.lblPNNgay = new System.Windows.Forms.Label();
            this.txtPNNgayNhap = new System.Windows.Forms.TextBox();
            this.lblPNNCC = new System.Windows.Forms.Label();
            this.txtPNNhaCungCap = new System.Windows.Forms.TextBox();
            this.lblPNNhanVien = new System.Windows.Forms.Label();
            this.txtPNNhanVien = new System.Windows.Forms.TextBox();
            this.lblPNTong = new System.Windows.Forms.Label();
            this.txtPNTongTien = new System.Windows.Forms.TextBox();
            this.lblPNGhiChu = new System.Windows.Forms.Label();
            this.txtPNGhiChu = new System.Windows.Forms.TextBox();
            this.lblPNChiTiet = new System.Windows.Forms.Label();
            this.dgvChiTietPN = new System.Windows.Forms.DataGridView();
            this.colCTTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnXuatChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).BeginInit();
            this.tabPhieuNhap.SuspendLayout();
            this.tabLapPhieu.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            this.pnlLapTrai.SuspendLayout();
            this.pnlChonSanPham.SuspendLayout();
            this.pnlDauSanPham.SuspendLayout();
            this.pnlLapPhai.SuspendLayout();
            this.pnlLSTrai.SuspendLayout();
            this.pnlChanLS.SuspendLayout();
            this.pnlDauLS.SuspendLayout();
            this.pnlLSPhai.SuspendLayout();
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
            // tabPhieuNhap
            //
            this.tabPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPhieuNhap.ItemSize = new System.Drawing.Size(170, 30);
            this.tabPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.tabPhieuNhap.SelectedIndex = 0;
            this.tabPhieuNhap.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPhieuNhap.Size = new System.Drawing.Size(1070, 666);
            this.tabPhieuNhap.Controls.Add(this.tabLapPhieu);
            this.tabPhieuNhap.Controls.Add(this.tabLichSu);
            this.tabPhieuNhap.Name = "tabPhieuNhap";
            this.tabPhieuNhap.TabIndex = 0;
            this.tabPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.tabPhieuNhap_SelectedIndexChanged);
            //
            // tabLapPhieu
            //
            this.tabLapPhieu.BackColor = System.Drawing.Color.White;
            this.tabLapPhieu.Location = new System.Drawing.Point(4, 34);
            this.tabLapPhieu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tabLapPhieu.Size = new System.Drawing.Size(1062, 628);
            this.tabLapPhieu.Text = "Lập phiếu nhập";
            this.tabLapPhieu.UseVisualStyleBackColor = false;
            this.tabLapPhieu.Controls.Add(this.pnlLapTrai);
            this.tabLapPhieu.Controls.Add(this.pnlLapPhai);
            this.tabLapPhieu.Name = "tabLapPhieu";
            this.tabLapPhieu.TabIndex = 0;
            //
            // tabLichSu
            //
            this.tabLichSu.BackColor = System.Drawing.Color.White;
            this.tabLichSu.Location = new System.Drawing.Point(4, 34);
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tabLichSu.Size = new System.Drawing.Size(1062, 628);
            this.tabLichSu.Text = "Lịch sử phiếu nhập";
            this.tabLichSu.UseVisualStyleBackColor = false;
            this.tabLichSu.Controls.Add(this.pnlLSTrai);
            this.tabLichSu.Controls.Add(this.pnlLSPhai);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.TabIndex = 1;
            //
            // pnlLapTrai
            //
            this.pnlLapTrai.BackColor = System.Drawing.Color.White;
            this.pnlLapTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLapTrai.Location = new System.Drawing.Point(0, 0);
            this.pnlLapTrai.Size = new System.Drawing.Size(582, 628);
            this.pnlLapTrai.Controls.Add(this.dgvSanPham);
            this.pnlLapTrai.Controls.Add(this.pnlChonSanPham);
            this.pnlLapTrai.Controls.Add(this.pnlDauSanPham);
            this.pnlLapTrai.Name = "pnlLapTrai";
            this.pnlLapTrai.TabIndex = 0;
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
            this.dgvSanPham.Size = new System.Drawing.Size(582, 432);
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colMaSanPham,
                        this.colTenSanPham,
                        this.colKichThuoc,
                        this.colMauSac,
                        this.colNhaCungCap,
                        this.colGiaNhap,
                        this.colSoLuongTon});
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            this.dgvSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellDoubleClick);
            //
            // colMaSanPham
            //
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.FillWeight = 15F;
            this.colMaSanPham.HeaderText = "Mã SP";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.Name = "colMaSanPham";
            //
            // colTenSanPham
            //
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.FillWeight = 40F;
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.ReadOnly = true;
            this.colTenSanPham.Name = "colTenSanPham";
            //
            // colKichThuoc
            //
            this.colKichThuoc.DataPropertyName = "TenKichThuoc";
            this.colKichThuoc.DefaultCellStyle = kieuSo;
            this.colKichThuoc.FillWeight = 10F;
            this.colKichThuoc.HeaderText = "Size";
            this.colKichThuoc.ReadOnly = true;
            this.colKichThuoc.Name = "colKichThuoc";
            //
            // colMauSac
            //
            this.colMauSac.DataPropertyName = "TenMauSac";
            this.colMauSac.FillWeight = 16F;
            this.colMauSac.HeaderText = "Màu";
            this.colMauSac.ReadOnly = true;
            this.colMauSac.Name = "colMauSac";
            //
            // colNhaCungCap
            //
            this.colNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.colNhaCungCap.FillWeight = 30F;
            this.colNhaCungCap.HeaderText = "Nhà cung cấp";
            this.colNhaCungCap.ReadOnly = true;
            this.colNhaCungCap.Name = "colNhaCungCap";
            //
            // colGiaNhap
            //
            this.colGiaNhap.DataPropertyName = "GiaNhap";
            this.colGiaNhap.DefaultCellStyle = kieuTien;
            this.colGiaNhap.FillWeight = 20F;
            this.colGiaNhap.HeaderText = "Giá nhập";
            this.colGiaNhap.ReadOnly = true;
            this.colGiaNhap.Name = "colGiaNhap";
            //
            // colSoLuongTon
            //
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.DefaultCellStyle = kieuSo;
            this.colSoLuongTon.FillWeight = 9F;
            this.colSoLuongTon.HeaderText = "Tồn";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Name = "colSoLuongTon";
            //
            // pnlChonSanPham
            //
            this.pnlChonSanPham.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlChonSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChonSanPham.Location = new System.Drawing.Point(0, 500);
            this.pnlChonSanPham.Size = new System.Drawing.Size(582, 128);
            this.pnlChonSanPham.Controls.Add(this.lblSanPhamChon);
            this.pnlChonSanPham.Controls.Add(this.lblSoLuongText);
            this.pnlChonSanPham.Controls.Add(this.nudSoLuong);
            this.pnlChonSanPham.Controls.Add(this.lblGiaNhapText);
            this.pnlChonSanPham.Controls.Add(this.nudGiaNhap);
            this.pnlChonSanPham.Controls.Add(this.lblGiaVonDuKien);
            this.pnlChonSanPham.Controls.Add(this.btnThemVaoPhieu);
            this.pnlChonSanPham.Name = "pnlChonSanPham";
            this.pnlChonSanPham.TabIndex = 1;
            //
            // lblSanPhamChon
            //
            this.lblSanPhamChon.AutoSize = true;
            this.lblSanPhamChon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSanPhamChon.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblSanPhamChon.Location = new System.Drawing.Point(14, 10);
            this.lblSanPhamChon.Text = "Chưa chọn sản phẩm (nhấp đúp để thêm nhanh 1 cái)";
            this.lblSanPhamChon.Name = "lblSanPhamChon";
            this.lblSanPhamChon.TabIndex = 0;
            //
            // lblSoLuongText
            //
            this.lblSoLuongText.AutoSize = true;
            this.lblSoLuongText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuongText.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblSoLuongText.Location = new System.Drawing.Point(14, 42);
            this.lblSoLuongText.Text = "Số lượng nhập";
            this.lblSoLuongText.Name = "lblSoLuongText";
            this.lblSoLuongText.TabIndex = 1;
            //
            // nudSoLuong
            //
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuong.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Location = new System.Drawing.Point(14, 62);
            this.nudSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Size = new System.Drawing.Size(120, 25);
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuong.ThousandsSeparator = true;
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.TabIndex = 2;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            //
            // lblGiaNhapText
            //
            this.lblGiaNhapText.AutoSize = true;
            this.lblGiaNhapText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaNhapText.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblGiaNhapText.Location = new System.Drawing.Point(150, 42);
            this.lblGiaNhapText.Text = "Giá nhập (đ)";
            this.lblGiaNhapText.Name = "lblGiaNhapText";
            this.lblGiaNhapText.TabIndex = 3;
            //
            // nudGiaNhap
            //
            this.nudGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudGiaNhap.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudGiaNhap.Location = new System.Drawing.Point(150, 62);
            this.nudGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudGiaNhap.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudGiaNhap.Size = new System.Drawing.Size(190, 25);
            this.nudGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiaNhap.ThousandsSeparator = true;
            this.nudGiaNhap.Name = "nudGiaNhap";
            this.nudGiaNhap.TabIndex = 4;
            this.nudGiaNhap.ValueChanged += new System.EventHandler(this.nudGiaNhap_ValueChanged);
            //
            // lblGiaVonDuKien
            //
            this.lblGiaVonDuKien.AutoSize = true;
            this.lblGiaVonDuKien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaVonDuKien.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblGiaVonDuKien.Location = new System.Drawing.Point(14, 96);
            this.lblGiaVonDuKien.Text = "";
            this.lblGiaVonDuKien.Name = "lblGiaVonDuKien";
            this.lblGiaVonDuKien.TabIndex = 5;
            //
            // btnThemVaoPhieu
            //
            this.btnThemVaoPhieu.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnThemVaoPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoPhieu.FlatAppearance.BorderSize = 0;
            this.btnThemVaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoPhieu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemVaoPhieu.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoPhieu.Location = new System.Drawing.Point(360, 54);
            this.btnThemVaoPhieu.Size = new System.Drawing.Size(160, 38);
            this.btnThemVaoPhieu.Text = "Thêm vào phiếu";
            this.btnThemVaoPhieu.UseVisualStyleBackColor = false;
            this.btnThemVaoPhieu.Name = "btnThemVaoPhieu";
            this.btnThemVaoPhieu.TabIndex = 6;
            this.btnThemVaoPhieu.Click += new System.EventHandler(this.btnThemVaoPhieu_Click);
            //
            // pnlDauSanPham
            //
            this.pnlDauSanPham.BackColor = System.Drawing.Color.White;
            this.pnlDauSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDauSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlDauSanPham.Size = new System.Drawing.Size(582, 92);
            this.pnlDauSanPham.Controls.Add(this.lblTieuDeSanPham);
            this.pnlDauSanPham.Controls.Add(this.txtTimKiemSP);
            this.pnlDauSanPham.Controls.Add(this.btnTimKiemSP);
            this.pnlDauSanPham.Controls.Add(this.lblGoiYSP);
            this.pnlDauSanPham.Name = "pnlDauSanPham";
            this.pnlDauSanPham.TabIndex = 2;
            //
            // lblTieuDeSanPham
            //
            this.lblTieuDeSanPham.AutoSize = true;
            this.lblTieuDeSanPham.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeSanPham.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeSanPham.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeSanPham.Text = "CHỌN SẢN PHẨM CẦN NHẬP";
            this.lblTieuDeSanPham.Name = "lblTieuDeSanPham";
            this.lblTieuDeSanPham.TabIndex = 0;
            //
            // txtTimKiemSP
            //
            this.txtTimKiemSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemSP.Location = new System.Drawing.Point(14, 42);
            this.txtTimKiemSP.Size = new System.Drawing.Size(300, 27);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.TabIndex = 1;
            this.txtTimKiemSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemSP_KeyDown);
            //
            // btnTimKiemSP
            //
            this.btnTimKiemSP.BackColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.btnTimKiemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemSP.FlatAppearance.BorderSize = 0;
            this.btnTimKiemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemSP.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSP.Location = new System.Drawing.Point(322, 41);
            this.btnTimKiemSP.Size = new System.Drawing.Size(100, 29);
            this.btnTimKiemSP.Text = "Tìm kiếm";
            this.btnTimKiemSP.UseVisualStyleBackColor = false;
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.TabIndex = 2;
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            //
            // lblGoiYSP
            //
            this.lblGoiYSP.AutoSize = true;
            this.lblGoiYSP.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoiYSP.ForeColor = System.Drawing.Color.FromArgb(141, 110, 99);
            this.lblGoiYSP.Location = new System.Drawing.Point(14, 71);
            this.lblGoiYSP.Text = "Tìm theo mã, tên, danh mục hoặc thương hiệu (nhấn Enter để tìm)";
            this.lblGoiYSP.Name = "lblGoiYSP";
            this.lblGoiYSP.TabIndex = 3;
            //
            // pnlLapPhai
            //
            this.pnlLapPhai.AutoScroll = true;
            this.pnlLapPhai.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlLapPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLapPhai.Location = new System.Drawing.Point(582, 0);
            this.pnlLapPhai.Size = new System.Drawing.Size(480, 628);
            this.pnlLapPhai.Controls.Add(this.lblTieuDePhieu);
            this.pnlLapPhai.Controls.Add(this.lblMaPhieu);
            this.pnlLapPhai.Controls.Add(this.lblNhaCungCap);
            this.pnlLapPhai.Controls.Add(this.cboNhaCungCap);
            this.pnlLapPhai.Controls.Add(this.lblNhanVien);
            this.pnlLapPhai.Controls.Add(this.lblNgayNhap);
            this.pnlLapPhai.Controls.Add(this.lblGhiChu);
            this.pnlLapPhai.Controls.Add(this.txtGhiChu);
            this.pnlLapPhai.Controls.Add(this.dgvChiTietNhap);
            this.pnlLapPhai.Controls.Add(this.btnXoaDong);
            this.pnlLapPhai.Controls.Add(this.btnXoaHet);
            this.pnlLapPhai.Controls.Add(this.btnXuatFile);
            this.pnlLapPhai.Controls.Add(this.lblTongTienText);
            this.pnlLapPhai.Controls.Add(this.lblTongTien);
            this.pnlLapPhai.Controls.Add(this.btnXacNhanNhap);
            this.pnlLapPhai.Controls.Add(this.btnHuyPhieu);
            this.pnlLapPhai.Name = "pnlLapPhai";
            this.pnlLapPhai.TabIndex = 1;
            //
            // lblTieuDePhieu
            //
            this.lblTieuDePhieu.AutoSize = true;
            this.lblTieuDePhieu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDePhieu.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDePhieu.Location = new System.Drawing.Point(14, 8);
            this.lblTieuDePhieu.Text = "PHIẾU NHẬP HÀNG";
            this.lblTieuDePhieu.Name = "lblTieuDePhieu";
            this.lblTieuDePhieu.TabIndex = 0;
            //
            // lblMaPhieu
            //
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhieu.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblMaPhieu.Location = new System.Drawing.Point(16, 40);
            this.lblMaPhieu.Text = "Mã phiếu: (tự động tạo khi xác nhận)";
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.TabIndex = 1;
            //
            // lblNhaCungCap
            //
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblNhaCungCap.Location = new System.Drawing.Point(16, 64);
            this.lblNhaCungCap.Text = "Nhà cung cấp";
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.TabIndex = 2;
            //
            // cboNhaCungCap
            //
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(16, 84);
            this.cboNhaCungCap.Size = new System.Drawing.Size(448, 25);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.TabIndex = 3;
            //
            // lblNhanVien
            //
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblNhanVien.Location = new System.Drawing.Point(16, 118);
            this.lblNhanVien.Text = "Nhân viên lập phiếu: ";
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.TabIndex = 4;
            //
            // lblNgayNhap
            //
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNhap.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblNgayNhap.Location = new System.Drawing.Point(16, 140);
            this.lblNgayNhap.Text = "Ngày nhập: ";
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.TabIndex = 5;
            //
            // lblGhiChu
            //
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblGhiChu.Location = new System.Drawing.Point(16, 164);
            this.lblGhiChu.Text = "Ghi chú";
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.TabIndex = 6;
            //
            // txtGhiChu
            //
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(16, 184);
            this.txtGhiChu.MaxLength = 255;
            this.txtGhiChu.Size = new System.Drawing.Size(448, 25);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.TabIndex = 7;
            //
            // dgvChiTietNhap
            //
            this.dgvChiTietNhap.AllowUserToAddRows = false;
            this.dgvChiTietNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietNhap.AllowUserToResizeRows = false;
            this.dgvChiTietNhap.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvChiTietNhap.AutoGenerateColumns = false;
            this.dgvChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvChiTietNhap.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvChiTietNhap.ColumnHeadersHeight = 34;
            this.dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChiTietNhap.DefaultCellStyle = kieuO;
            this.dgvChiTietNhap.EnableHeadersVisualStyles = false;
            this.dgvChiTietNhap.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvChiTietNhap.Location = new System.Drawing.Point(16, 218);
            this.dgvChiTietNhap.MultiSelect = false;
            this.dgvChiTietNhap.ReadOnly = true;
            this.dgvChiTietNhap.RowHeadersVisible = false;
            this.dgvChiTietNhap.RowTemplate.Height = 28;
            this.dgvChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(448, 226);
            this.dgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colNhapTen,
                        this.colNhapSoLuong,
                        this.colNhapGia,
                        this.colNhapThanhTien});
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.TabIndex = 8;
            //
            // colNhapTen
            //
            this.colNhapTen.DataPropertyName = "TenSanPham";
            this.colNhapTen.FillWeight = 40F;
            this.colNhapTen.HeaderText = "Sản phẩm";
            this.colNhapTen.ReadOnly = true;
            this.colNhapTen.Name = "colNhapTen";
            //
            // colNhapSoLuong
            //
            this.colNhapSoLuong.DataPropertyName = "SoLuong";
            this.colNhapSoLuong.DefaultCellStyle = kieuSo;
            this.colNhapSoLuong.FillWeight = 12F;
            this.colNhapSoLuong.HeaderText = "SL";
            this.colNhapSoLuong.ReadOnly = true;
            this.colNhapSoLuong.Name = "colNhapSoLuong";
            //
            // colNhapGia
            //
            this.colNhapGia.DataPropertyName = "GiaNhap";
            this.colNhapGia.DefaultCellStyle = kieuTien;
            this.colNhapGia.FillWeight = 24F;
            this.colNhapGia.HeaderText = "Giá nhập";
            this.colNhapGia.ReadOnly = true;
            this.colNhapGia.Name = "colNhapGia";
            //
            // colNhapThanhTien
            //
            this.colNhapThanhTien.DataPropertyName = "ThanhTien";
            this.colNhapThanhTien.DefaultCellStyle = kieuTien;
            this.colNhapThanhTien.FillWeight = 26F;
            this.colNhapThanhTien.HeaderText = "Thành tiền";
            this.colNhapThanhTien.ReadOnly = true;
            this.colNhapThanhTien.Name = "colNhapThanhTien";
            //
            // btnXoaDong
            //
            this.btnXoaDong.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnXoaDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDong.FlatAppearance.BorderSize = 0;
            this.btnXoaDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaDong.ForeColor = System.Drawing.Color.White;
            this.btnXoaDong.Location = new System.Drawing.Point(16, 452);
            this.btnXoaDong.Size = new System.Drawing.Size(100, 32);
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = false;
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.TabIndex = 9;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            //
            // btnXoaHet
            //
            this.btnXoaHet.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnXoaHet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHet.FlatAppearance.BorderSize = 0;
            this.btnXoaHet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHet.ForeColor = System.Drawing.Color.White;
            this.btnXoaHet.Location = new System.Drawing.Point(124, 452);
            this.btnXoaHet.Size = new System.Drawing.Size(100, 32);
            this.btnXoaHet.Text = "Xóa hết";
            this.btnXoaHet.UseVisualStyleBackColor = false;
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.TabIndex = 10;
            this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
            //
            // btnXuatFile
            //
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(232, 452);
            this.btnXuatFile.Size = new System.Drawing.Size(110, 32);
            this.btnXuatFile.Text = "Xuất Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.TabIndex = 11;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            //
            // lblTongTienText
            //
            this.lblTongTienText.AutoSize = true;
            this.lblTongTienText.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTienText.ForeColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.lblTongTienText.Location = new System.Drawing.Point(16, 508);
            this.lblTongTienText.Text = "TỔNG TIỀN NHẬP";
            this.lblTongTienText.Name = "lblTongTienText";
            this.lblTongTienText.TabIndex = 12;
            //
            // lblTongTien
            //
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.lblTongTien.Location = new System.Drawing.Point(200, 498);
            this.lblTongTien.Size = new System.Drawing.Size(264, 36);
            this.lblTongTien.Text = "0 đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.TabIndex = 13;
            //
            // btnXacNhanNhap
            //
            this.btnXacNhanNhap.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnXacNhanNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanNhap.FlatAppearance.BorderSize = 0;
            this.btnXacNhanNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanNhap.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanNhap.Location = new System.Drawing.Point(16, 548);
            this.btnXacNhanNhap.Size = new System.Drawing.Size(296, 50);
            this.btnXacNhanNhap.Text = "XÁC NHẬN NHẬP HÀNG";
            this.btnXacNhanNhap.UseVisualStyleBackColor = false;
            this.btnXacNhanNhap.Name = "btnXacNhanNhap";
            this.btnXacNhanNhap.TabIndex = 14;
            this.btnXacNhanNhap.Click += new System.EventHandler(this.btnXacNhanNhap_Click);
            //
            // btnHuyPhieu
            //
            this.btnHuyPhieu.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnHuyPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyPhieu.FlatAppearance.BorderSize = 0;
            this.btnHuyPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyPhieu.ForeColor = System.Drawing.Color.White;
            this.btnHuyPhieu.Location = new System.Drawing.Point(320, 548);
            this.btnHuyPhieu.Size = new System.Drawing.Size(144, 50);
            this.btnHuyPhieu.Text = "Hủy phiếu";
            this.btnHuyPhieu.UseVisualStyleBackColor = false;
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.TabIndex = 15;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            //
            // pnlLSTrai
            //
            this.pnlLSTrai.BackColor = System.Drawing.Color.White;
            this.pnlLSTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLSTrai.Location = new System.Drawing.Point(0, 0);
            this.pnlLSTrai.Size = new System.Drawing.Size(622, 628);
            this.pnlLSTrai.Controls.Add(this.dgvPhieuNhap);
            this.pnlLSTrai.Controls.Add(this.pnlChanLS);
            this.pnlLSTrai.Controls.Add(this.pnlDauLS);
            this.pnlLSTrai.Name = "pnlLSTrai";
            this.pnlLSTrai.TabIndex = 0;
            //
            // dgvPhieuNhap
            //
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvPhieuNhap.AutoGenerateColumns = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvPhieuNhap.ColumnHeadersHeight = 36;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuNhap.DefaultCellStyle = kieuO;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvPhieuNhap.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 114);
            this.dgvPhieuNhap.MultiSelect = false;
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.RowTemplate.Height = 28;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(622, 484);
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colPNMa,
                        this.colPNNgay,
                        this.colPNNCC,
                        this.colPNNhanVien,
                        this.colPNTong});
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.SelectionChanged += new System.EventHandler(this.dgvPhieuNhap_SelectionChanged);
            //
            // colPNMa
            //
            this.colPNMa.DataPropertyName = "MaPhieuNhap";
            this.colPNMa.FillWeight = 28F;
            this.colPNMa.HeaderText = "Mã phiếu";
            this.colPNMa.ReadOnly = true;
            this.colPNMa.Name = "colPNMa";
            //
            // colPNNgay
            //
            this.colPNNgay.DataPropertyName = "NgayNhap";
            this.colPNNgay.DefaultCellStyle = kieuNgayGio;
            this.colPNNgay.FillWeight = 24F;
            this.colPNNgay.HeaderText = "Ngày nhập";
            this.colPNNgay.ReadOnly = true;
            this.colPNNgay.Name = "colPNNgay";
            //
            // colPNNCC
            //
            this.colPNNCC.DataPropertyName = "TenNhaCungCap";
            this.colPNNCC.FillWeight = 34F;
            this.colPNNCC.HeaderText = "Nhà cung cấp";
            this.colPNNCC.ReadOnly = true;
            this.colPNNCC.Name = "colPNNCC";
            //
            // colPNNhanVien
            //
            this.colPNNhanVien.DataPropertyName = "TenNhanVien";
            this.colPNNhanVien.FillWeight = 22F;
            this.colPNNhanVien.HeaderText = "Nhân viên";
            this.colPNNhanVien.ReadOnly = true;
            this.colPNNhanVien.Name = "colPNNhanVien";
            //
            // colPNTong
            //
            this.colPNTong.DataPropertyName = "TongTien";
            this.colPNTong.DefaultCellStyle = kieuTien;
            this.colPNTong.FillWeight = 22F;
            this.colPNTong.HeaderText = "Tổng tiền";
            this.colPNTong.ReadOnly = true;
            this.colPNTong.Name = "colPNTong";
            //
            // pnlChanLS
            //
            this.pnlChanLS.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlChanLS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChanLS.Location = new System.Drawing.Point(0, 598);
            this.pnlChanLS.Size = new System.Drawing.Size(622, 30);
            this.pnlChanLS.Controls.Add(this.lblTongSoPN);
            this.pnlChanLS.Name = "pnlChanLS";
            this.pnlChanLS.TabIndex = 1;
            //
            // lblTongSoPN
            //
            this.lblTongSoPN.AutoSize = true;
            this.lblTongSoPN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSoPN.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTongSoPN.Location = new System.Drawing.Point(12, 6);
            this.lblTongSoPN.Text = "Tổng: 0 phiếu nhập";
            this.lblTongSoPN.Name = "lblTongSoPN";
            this.lblTongSoPN.TabIndex = 0;
            //
            // pnlDauLS
            //
            this.pnlDauLS.BackColor = System.Drawing.Color.White;
            this.pnlDauLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDauLS.Location = new System.Drawing.Point(0, 0);
            this.pnlDauLS.Size = new System.Drawing.Size(622, 114);
            this.pnlDauLS.Controls.Add(this.lblTieuDeLS);
            this.pnlDauLS.Controls.Add(this.txtTimKiemPN);
            this.pnlDauLS.Controls.Add(this.btnTimKiemPN);
            this.pnlDauLS.Controls.Add(this.lblGoiYPN);
            this.pnlDauLS.Controls.Add(this.lblTuNgayPN);
            this.pnlDauLS.Controls.Add(this.dtpTuNgayPN);
            this.pnlDauLS.Controls.Add(this.lblDenNgayPN);
            this.pnlDauLS.Controls.Add(this.dtpDenNgayPN);
            this.pnlDauLS.Controls.Add(this.btnBoLocPN);
            this.pnlDauLS.Controls.Add(this.btnXuatDanhSach);
            this.pnlDauLS.Name = "pnlDauLS";
            this.pnlDauLS.TabIndex = 2;
            //
            // lblTieuDeLS
            //
            this.lblTieuDeLS.AutoSize = true;
            this.lblTieuDeLS.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeLS.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeLS.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeLS.Text = "LỊCH SỬ PHIẾU NHẬP";
            this.lblTieuDeLS.Name = "lblTieuDeLS";
            this.lblTieuDeLS.TabIndex = 0;
            //
            // txtTimKiemPN
            //
            this.txtTimKiemPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemPN.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemPN.Location = new System.Drawing.Point(14, 42);
            this.txtTimKiemPN.Size = new System.Drawing.Size(300, 27);
            this.txtTimKiemPN.Name = "txtTimKiemPN";
            this.txtTimKiemPN.TabIndex = 1;
            this.txtTimKiemPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemPN_KeyDown);
            //
            // btnTimKiemPN
            //
            this.btnTimKiemPN.BackColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.btnTimKiemPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemPN.FlatAppearance.BorderSize = 0;
            this.btnTimKiemPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemPN.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemPN.Location = new System.Drawing.Point(322, 41);
            this.btnTimKiemPN.Size = new System.Drawing.Size(100, 29);
            this.btnTimKiemPN.Text = "Tìm kiếm";
            this.btnTimKiemPN.UseVisualStyleBackColor = false;
            this.btnTimKiemPN.Name = "btnTimKiemPN";
            this.btnTimKiemPN.TabIndex = 2;
            this.btnTimKiemPN.Click += new System.EventHandler(this.btnTimKiemPN_Click);
            //
            // lblGoiYPN
            //
            this.lblGoiYPN.AutoSize = true;
            this.lblGoiYPN.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoiYPN.ForeColor = System.Drawing.Color.FromArgb(141, 110, 99);
            this.lblGoiYPN.Location = new System.Drawing.Point(232, 16);
            this.lblGoiYPN.Text = "Tìm theo mã phiếu hoặc tên nhà cung cấp";
            this.lblGoiYPN.Name = "lblGoiYPN";
            this.lblGoiYPN.TabIndex = 3;
            //
            // lblTuNgayPN
            //
            this.lblTuNgayPN.AutoSize = true;
            this.lblTuNgayPN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTuNgayPN.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTuNgayPN.Location = new System.Drawing.Point(14, 82);
            this.lblTuNgayPN.Text = "Từ ngày";
            this.lblTuNgayPN.Name = "lblTuNgayPN";
            this.lblTuNgayPN.TabIndex = 4;
            //
            // dtpTuNgayPN
            //
            this.dtpTuNgayPN.Checked = false;
            this.dtpTuNgayPN.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgayPN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpTuNgayPN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgayPN.Location = new System.Drawing.Point(72, 78);
            this.dtpTuNgayPN.ShowCheckBox = true;
            this.dtpTuNgayPN.Size = new System.Drawing.Size(130, 25);
            this.dtpTuNgayPN.Name = "dtpTuNgayPN";
            this.dtpTuNgayPN.TabIndex = 5;
            //
            // lblDenNgayPN
            //
            this.lblDenNgayPN.AutoSize = true;
            this.lblDenNgayPN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDenNgayPN.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblDenNgayPN.Location = new System.Drawing.Point(218, 82);
            this.lblDenNgayPN.Text = "Đến ngày";
            this.lblDenNgayPN.Name = "lblDenNgayPN";
            this.lblDenNgayPN.TabIndex = 6;
            //
            // dtpDenNgayPN
            //
            this.dtpDenNgayPN.Checked = false;
            this.dtpDenNgayPN.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgayPN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDenNgayPN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgayPN.Location = new System.Drawing.Point(282, 78);
            this.dtpDenNgayPN.ShowCheckBox = true;
            this.dtpDenNgayPN.Size = new System.Drawing.Size(130, 25);
            this.dtpDenNgayPN.Name = "dtpDenNgayPN";
            this.dtpDenNgayPN.TabIndex = 7;
            //
            // btnBoLocPN
            //
            this.btnBoLocPN.BackColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.btnBoLocPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoLocPN.FlatAppearance.BorderSize = 0;
            this.btnBoLocPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoLocPN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoLocPN.ForeColor = System.Drawing.Color.White;
            this.btnBoLocPN.Location = new System.Drawing.Point(430, 77);
            this.btnBoLocPN.Size = new System.Drawing.Size(100, 27);
            this.btnBoLocPN.Text = "Bỏ lọc";
            this.btnBoLocPN.UseVisualStyleBackColor = false;
            this.btnBoLocPN.Name = "btnBoLocPN";
            this.btnBoLocPN.TabIndex = 8;
            this.btnBoLocPN.Click += new System.EventHandler(this.btnBoLocPN_Click);
            //
            // btnXuatDanhSach
            //
            this.btnXuatDanhSach.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnXuatDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatDanhSach.FlatAppearance.BorderSize = 0;
            this.btnXuatDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnXuatDanhSach.Location = new System.Drawing.Point(430, 41);
            this.btnXuatDanhSach.Size = new System.Drawing.Size(140, 29);
            this.btnXuatDanhSach.Text = "Xuất danh sách";
            this.btnXuatDanhSach.UseVisualStyleBackColor = false;
            this.btnXuatDanhSach.Name = "btnXuatDanhSach";
            this.btnXuatDanhSach.TabIndex = 9;
            this.btnXuatDanhSach.Click += new System.EventHandler(this.btnXuatDanhSach_Click);
            //
            // pnlLSPhai
            //
            this.pnlLSPhai.AutoScroll = true;
            this.pnlLSPhai.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.pnlLSPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLSPhai.Location = new System.Drawing.Point(622, 0);
            this.pnlLSPhai.Size = new System.Drawing.Size(440, 628);
            this.pnlLSPhai.Controls.Add(this.lblTieuDeChiTietPN);
            this.pnlLSPhai.Controls.Add(this.lblPNMa);
            this.pnlLSPhai.Controls.Add(this.txtPNMaPhieu);
            this.pnlLSPhai.Controls.Add(this.lblPNNgay);
            this.pnlLSPhai.Controls.Add(this.txtPNNgayNhap);
            this.pnlLSPhai.Controls.Add(this.lblPNNCC);
            this.pnlLSPhai.Controls.Add(this.txtPNNhaCungCap);
            this.pnlLSPhai.Controls.Add(this.lblPNNhanVien);
            this.pnlLSPhai.Controls.Add(this.txtPNNhanVien);
            this.pnlLSPhai.Controls.Add(this.lblPNTong);
            this.pnlLSPhai.Controls.Add(this.txtPNTongTien);
            this.pnlLSPhai.Controls.Add(this.lblPNGhiChu);
            this.pnlLSPhai.Controls.Add(this.txtPNGhiChu);
            this.pnlLSPhai.Controls.Add(this.lblPNChiTiet);
            this.pnlLSPhai.Controls.Add(this.dgvChiTietPN);
            this.pnlLSPhai.Controls.Add(this.btnXoaPhieu);
            this.pnlLSPhai.Controls.Add(this.btnXuatChiTiet);
            this.pnlLSPhai.Name = "pnlLSPhai";
            this.pnlLSPhai.TabIndex = 1;
            //
            // lblTieuDeChiTietPN
            //
            this.lblTieuDeChiTietPN.AutoSize = true;
            this.lblTieuDeChiTietPN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeChiTietPN.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeChiTietPN.Location = new System.Drawing.Point(14, 10);
            this.lblTieuDeChiTietPN.Text = "CHI TIẾT PHIẾU NHẬP";
            this.lblTieuDeChiTietPN.Name = "lblTieuDeChiTietPN";
            this.lblTieuDeChiTietPN.TabIndex = 0;
            //
            // lblPNMa
            //
            this.lblPNMa.AutoSize = true;
            this.lblPNMa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNMa.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNMa.Location = new System.Drawing.Point(16, 46);
            this.lblPNMa.Text = "Mã phiếu";
            this.lblPNMa.Name = "lblPNMa";
            this.lblPNMa.TabIndex = 1;
            //
            // txtPNMaPhieu
            //
            this.txtPNMaPhieu.BackColor = System.Drawing.Color.FromArgb(240, 234, 226);
            this.txtPNMaPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNMaPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPNMaPhieu.Location = new System.Drawing.Point(16, 66);
            this.txtPNMaPhieu.ReadOnly = true;
            this.txtPNMaPhieu.Size = new System.Drawing.Size(198, 25);
            this.txtPNMaPhieu.Name = "txtPNMaPhieu";
            this.txtPNMaPhieu.TabIndex = 2;
            //
            // lblPNNgay
            //
            this.lblPNNgay.AutoSize = true;
            this.lblPNNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNNgay.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNNgay.Location = new System.Drawing.Point(226, 46);
            this.lblPNNgay.Text = "Ngày nhập";
            this.lblPNNgay.Name = "lblPNNgay";
            this.lblPNNgay.TabIndex = 3;
            //
            // txtPNNgayNhap
            //
            this.txtPNNgayNhap.BackColor = System.Drawing.Color.FromArgb(240, 234, 226);
            this.txtPNNgayNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPNNgayNhap.Location = new System.Drawing.Point(226, 66);
            this.txtPNNgayNhap.ReadOnly = true;
            this.txtPNNgayNhap.Size = new System.Drawing.Size(198, 25);
            this.txtPNNgayNhap.Name = "txtPNNgayNhap";
            this.txtPNNgayNhap.TabIndex = 4;
            //
            // lblPNNCC
            //
            this.lblPNNCC.AutoSize = true;
            this.lblPNNCC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNNCC.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNNCC.Location = new System.Drawing.Point(16, 100);
            this.lblPNNCC.Text = "Nhà cung cấp";
            this.lblPNNCC.Name = "lblPNNCC";
            this.lblPNNCC.TabIndex = 5;
            //
            // txtPNNhaCungCap
            //
            this.txtPNNhaCungCap.BackColor = System.Drawing.Color.FromArgb(240, 234, 226);
            this.txtPNNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPNNhaCungCap.Location = new System.Drawing.Point(16, 120);
            this.txtPNNhaCungCap.ReadOnly = true;
            this.txtPNNhaCungCap.Size = new System.Drawing.Size(408, 25);
            this.txtPNNhaCungCap.Name = "txtPNNhaCungCap";
            this.txtPNNhaCungCap.TabIndex = 6;
            //
            // lblPNNhanVien
            //
            this.lblPNNhanVien.AutoSize = true;
            this.lblPNNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNNhanVien.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNNhanVien.Location = new System.Drawing.Point(16, 154);
            this.lblPNNhanVien.Text = "Nhân viên lập phiếu";
            this.lblPNNhanVien.Name = "lblPNNhanVien";
            this.lblPNNhanVien.TabIndex = 7;
            //
            // txtPNNhanVien
            //
            this.txtPNNhanVien.BackColor = System.Drawing.Color.FromArgb(240, 234, 226);
            this.txtPNNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPNNhanVien.Location = new System.Drawing.Point(16, 174);
            this.txtPNNhanVien.ReadOnly = true;
            this.txtPNNhanVien.Size = new System.Drawing.Size(198, 25);
            this.txtPNNhanVien.Name = "txtPNNhanVien";
            this.txtPNNhanVien.TabIndex = 8;
            //
            // lblPNTong
            //
            this.lblPNTong.AutoSize = true;
            this.lblPNTong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNTong.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNTong.Location = new System.Drawing.Point(226, 154);
            this.lblPNTong.Text = "Tổng tiền (đ)";
            this.lblPNTong.Name = "lblPNTong";
            this.lblPNTong.TabIndex = 9;
            //
            // txtPNTongTien
            //
            this.txtPNTongTien.BackColor = System.Drawing.Color.FromArgb(240, 234, 226);
            this.txtPNTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPNTongTien.Location = new System.Drawing.Point(226, 174);
            this.txtPNTongTien.ReadOnly = true;
            this.txtPNTongTien.Size = new System.Drawing.Size(198, 25);
            this.txtPNTongTien.Name = "txtPNTongTien";
            this.txtPNTongTien.TabIndex = 10;
            //
            // lblPNGhiChu
            //
            this.lblPNGhiChu.AutoSize = true;
            this.lblPNGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNGhiChu.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNGhiChu.Location = new System.Drawing.Point(16, 208);
            this.lblPNGhiChu.Text = "Ghi chú";
            this.lblPNGhiChu.Name = "lblPNGhiChu";
            this.lblPNGhiChu.TabIndex = 11;
            //
            // txtPNGhiChu
            //
            this.txtPNGhiChu.BackColor = System.Drawing.Color.FromArgb(240, 234, 226);
            this.txtPNGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPNGhiChu.Location = new System.Drawing.Point(16, 228);
            this.txtPNGhiChu.ReadOnly = true;
            this.txtPNGhiChu.Size = new System.Drawing.Size(408, 25);
            this.txtPNGhiChu.Name = "txtPNGhiChu";
            this.txtPNGhiChu.TabIndex = 12;
            //
            // lblPNChiTiet
            //
            this.lblPNChiTiet.AutoSize = true;
            this.lblPNChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPNChiTiet.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPNChiTiet.Location = new System.Drawing.Point(16, 264);
            this.lblPNChiTiet.Text = "Sản phẩm đã nhập";
            this.lblPNChiTiet.Name = "lblPNChiTiet";
            this.lblPNChiTiet.TabIndex = 13;
            //
            // dgvChiTietPN
            //
            this.dgvChiTietPN.AllowUserToAddRows = false;
            this.dgvChiTietPN.AllowUserToDeleteRows = false;
            this.dgvChiTietPN.AllowUserToResizeRows = false;
            this.dgvChiTietPN.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvChiTietPN.AutoGenerateColumns = false;
            this.dgvChiTietPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPN.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvChiTietPN.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvChiTietPN.ColumnHeadersHeight = 34;
            this.dgvChiTietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChiTietPN.DefaultCellStyle = kieuO;
            this.dgvChiTietPN.EnableHeadersVisualStyles = false;
            this.dgvChiTietPN.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvChiTietPN.Location = new System.Drawing.Point(16, 286);
            this.dgvChiTietPN.MultiSelect = false;
            this.dgvChiTietPN.ReadOnly = true;
            this.dgvChiTietPN.RowHeadersVisible = false;
            this.dgvChiTietPN.RowTemplate.Height = 28;
            this.dgvChiTietPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPN.Size = new System.Drawing.Size(408, 230);
            this.dgvChiTietPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colCTTen,
                        this.colCTSoLuong,
                        this.colCTGia,
                        this.colCTThanhTien});
            this.dgvChiTietPN.Name = "dgvChiTietPN";
            this.dgvChiTietPN.TabIndex = 14;
            //
            // colCTTen
            //
            this.colCTTen.DataPropertyName = "TenSanPham";
            this.colCTTen.FillWeight = 40F;
            this.colCTTen.HeaderText = "Sản phẩm";
            this.colCTTen.ReadOnly = true;
            this.colCTTen.Name = "colCTTen";
            //
            // colCTSoLuong
            //
            this.colCTSoLuong.DataPropertyName = "SoLuong";
            this.colCTSoLuong.DefaultCellStyle = kieuSo;
            this.colCTSoLuong.FillWeight = 12F;
            this.colCTSoLuong.HeaderText = "SL";
            this.colCTSoLuong.ReadOnly = true;
            this.colCTSoLuong.Name = "colCTSoLuong";
            //
            // colCTGia
            //
            this.colCTGia.DataPropertyName = "GiaNhap";
            this.colCTGia.DefaultCellStyle = kieuTien;
            this.colCTGia.FillWeight = 24F;
            this.colCTGia.HeaderText = "Giá nhập";
            this.colCTGia.ReadOnly = true;
            this.colCTGia.Name = "colCTGia";
            //
            // colCTThanhTien
            //
            this.colCTThanhTien.DataPropertyName = "ThanhTien";
            this.colCTThanhTien.DefaultCellStyle = kieuTien;
            this.colCTThanhTien.FillWeight = 26F;
            this.colCTThanhTien.HeaderText = "Thành tiền";
            this.colCTThanhTien.ReadOnly = true;
            this.colCTThanhTien.Name = "colCTThanhTien";
            //
            // btnXoaPhieu
            //
            this.btnXoaPhieu.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnXoaPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhieu.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Location = new System.Drawing.Point(16, 530);
            this.btnXoaPhieu.Size = new System.Drawing.Size(408, 40);
            this.btnXoaPhieu.Text = "Xóa phiếu nhập (trừ lại tồn kho)";
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.TabIndex = 15;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            //
            // btnXuatChiTiet
            //
            this.btnXuatChiTiet.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnXuatChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXuatChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXuatChiTiet.Location = new System.Drawing.Point(16, 578);
            this.btnXuatChiTiet.Size = new System.Drawing.Size(408, 40);
            this.btnXuatChiTiet.Text = "Xuất phiếu đang chọn ra Excel";
            this.btnXuatChiTiet.UseVisualStyleBackColor = false;
            this.btnXuatChiTiet.Name = "btnXuatChiTiet";
            this.btnXuatChiTiet.TabIndex = 16;
            this.btnXuatChiTiet.Click += new System.EventHandler(this.btnXuatChiTiet_Click);
            //
            // FormPhieuNhap
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Text = "Quản lý phiếu nhập";
            this.Controls.Add(this.tabPhieuNhap);
            this.Name = "FormPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.pnlLSPhai.ResumeLayout(false);
            this.pnlDauLS.ResumeLayout(false);
            this.pnlChanLS.ResumeLayout(false);
            this.pnlLSTrai.ResumeLayout(false);
            this.pnlLapPhai.ResumeLayout(false);
            this.pnlDauSanPham.ResumeLayout(false);
            this.pnlChonSanPham.ResumeLayout(false);
            this.pnlLapTrai.ResumeLayout(false);
            this.tabLichSu.ResumeLayout(false);
            this.tabLapPhieu.ResumeLayout(false);
            this.tabPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormPhieuNhap.cs)
        private System.Windows.Forms.TabControl tabPhieuNhap;
        private System.Windows.Forms.TabPage tabLapPhieu;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.Panel pnlLapTrai;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.Panel pnlChonSanPham;
        private System.Windows.Forms.Label lblSanPhamChon;
        private System.Windows.Forms.Label lblSoLuongText;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblGiaNhapText;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.Label lblGiaVonDuKien;
        private System.Windows.Forms.Button btnThemVaoPhieu;
        private System.Windows.Forms.Panel pnlDauSanPham;
        private System.Windows.Forms.Label lblTieuDeSanPham;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.Button btnTimKiemSP;
        private System.Windows.Forms.Label lblGoiYSP;
        private System.Windows.Forms.Panel pnlLapPhai;
        private System.Windows.Forms.Label lblTieuDePhieu;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapThanhTien;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaHet;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXacNhanNhap;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.Panel pnlLSTrai;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPNMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPNNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPNNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPNNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPNTong;
        private System.Windows.Forms.Panel pnlChanLS;
        private System.Windows.Forms.Label lblTongSoPN;
        private System.Windows.Forms.Panel pnlDauLS;
        private System.Windows.Forms.Label lblTieuDeLS;
        private System.Windows.Forms.TextBox txtTimKiemPN;
        private System.Windows.Forms.Button btnTimKiemPN;
        private System.Windows.Forms.Label lblGoiYPN;
        private System.Windows.Forms.Label lblTuNgayPN;
        private System.Windows.Forms.DateTimePicker dtpTuNgayPN;
        private System.Windows.Forms.Label lblDenNgayPN;
        private System.Windows.Forms.DateTimePicker dtpDenNgayPN;
        private System.Windows.Forms.Button btnBoLocPN;
        private System.Windows.Forms.Button btnXuatDanhSach;
        private System.Windows.Forms.Panel pnlLSPhai;
        private System.Windows.Forms.Label lblTieuDeChiTietPN;
        private System.Windows.Forms.Label lblPNMa;
        private System.Windows.Forms.TextBox txtPNMaPhieu;
        private System.Windows.Forms.Label lblPNNgay;
        private System.Windows.Forms.TextBox txtPNNgayNhap;
        private System.Windows.Forms.Label lblPNNCC;
        private System.Windows.Forms.TextBox txtPNNhaCungCap;
        private System.Windows.Forms.Label lblPNNhanVien;
        private System.Windows.Forms.TextBox txtPNNhanVien;
        private System.Windows.Forms.Label lblPNTong;
        private System.Windows.Forms.TextBox txtPNTongTien;
        private System.Windows.Forms.Label lblPNGhiChu;
        private System.Windows.Forms.TextBox txtPNGhiChu;
        private System.Windows.Forms.Label lblPNChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTietPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTThanhTien;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnXuatChiTiet;
    }
}