namespace QuanLyShopQuanAo.GUI
{
    partial class FormDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblTieuDeThongTin = new System.Windows.Forms.Label();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.pnlChanDanhSach = new System.Windows.Forms.Panel();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.pnlDauDanhSach = new System.Windows.Forms.Panel();
            this.lblTieuDeDanhSach = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlThongTin.SuspendLayout();
            this.pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.pnlChanDanhSach.SuspendLayout();
            this.pnlDauDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.AutoScroll = true;
            this.pnlThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.pnlThongTin.Controls.Add(this.lblTieuDeThongTin);
            this.pnlThongTin.Controls.Add(this.lblMaDanhMuc);
            this.pnlThongTin.Controls.Add(this.txtMaDanhMuc);
            this.pnlThongTin.Controls.Add(this.lblTenDanhMuc);
            this.pnlThongTin.Controls.Add(this.txtTenDanhMuc);
            this.pnlThongTin.Controls.Add(this.lblMoTa);
            this.pnlThongTin.Controls.Add(this.txtMoTa);
            this.pnlThongTin.Controls.Add(this.btnThem);
            this.pnlThongTin.Controls.Add(this.btnSua);
            this.pnlThongTin.Controls.Add(this.btnXoa);
            this.pnlThongTin.Controls.Add(this.btnLamMoi);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThongTin.Location = new System.Drawing.Point(920, 0);
            this.pnlThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(507, 820);
            this.pnlThongTin.TabIndex = 0;
            // 
            // lblTieuDeThongTin
            // 
            this.lblTieuDeThongTin.AutoSize = true;
            this.lblTieuDeThongTin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTieuDeThongTin.Location = new System.Drawing.Point(19, 12);
            this.lblTieuDeThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDeThongTin.Name = "lblTieuDeThongTin";
            this.lblTieuDeThongTin.Size = new System.Drawing.Size(264, 30);
            this.lblTieuDeThongTin.TabIndex = 0;
            this.lblTieuDeThongTin.Text = "THÔNG TIN DANH MỤC";
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMaDanhMuc.Location = new System.Drawing.Point(21, 57);
            this.lblMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(114, 21);
            this.lblMaDanhMuc.TabIndex = 1;
            this.lblMaDanhMuc.Text = "Mã danh mục";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.txtMaDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(21, 81);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(463, 30);
            this.txtMaDanhMuc.TabIndex = 2;
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTenDanhMuc.Location = new System.Drawing.Point(21, 123);
            this.lblTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(117, 21);
            this.lblTenDanhMuc.TabIndex = 3;
            this.lblTenDanhMuc.Text = "Tên danh mục";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(21, 148);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDanhMuc.MaxLength = 100;
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(463, 30);
            this.txtTenDanhMuc.TabIndex = 4;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMoTa.Location = new System.Drawing.Point(21, 190);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(54, 21);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMoTa.Location = new System.Drawing.Point(21, 214);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoTa.MaxLength = 255;
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(463, 135);
            this.txtMoTa.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(21, 372);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 49);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(140, 372);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 49);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(259, 372);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(377, 372);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(108, 49);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.BackColor = System.Drawing.Color.White;
            this.pnlDanhSach.Controls.Add(this.dgvDanhMuc);
            this.pnlDanhSach.Controls.Add(this.pnlChanDanhSach);
            this.pnlDanhSach.Controls.Add(this.pnlDauDanhSach);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(920, 820);
            this.pnlDanhSach.TabIndex = 1;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhMuc.ColumnHeadersHeight = 36;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.EnableHeadersVisualStyles = false;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 113);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 30;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(920, 670);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.SelectionChanged += new System.EventHandler(this.dgvDanhMuc_SelectionChanged);
            // 
            // pnlChanDanhSach
            // 
            this.pnlChanDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.pnlChanDanhSach.Controls.Add(this.lblTongSo);
            this.pnlChanDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChanDanhSach.Location = new System.Drawing.Point(0, 783);
            this.pnlChanDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChanDanhSach.Name = "pnlChanDanhSach";
            this.pnlChanDanhSach.Size = new System.Drawing.Size(920, 37);
            this.pnlChanDanhSach.TabIndex = 1;
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.lblTongSo.Location = new System.Drawing.Point(16, 7);
            this.lblTongSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(135, 21);
            this.lblTongSo.TabIndex = 0;
            this.lblTongSo.Text = "Tổng: 0 danh mục";
            // 
            // pnlDauDanhSach
            // 
            this.pnlDauDanhSach.BackColor = System.Drawing.Color.White;
            this.pnlDauDanhSach.Controls.Add(this.lblTieuDeDanhSach);
            this.pnlDauDanhSach.Controls.Add(this.txtTimKiem);
            this.pnlDauDanhSach.Controls.Add(this.btnTimKiem);
            this.pnlDauDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDauDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDauDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDauDanhSach.Name = "pnlDauDanhSach";
            this.pnlDauDanhSach.Size = new System.Drawing.Size(920, 113);
            this.pnlDauDanhSach.TabIndex = 2;
            // 
            // lblTieuDeDanhSach
            // 
            this.lblTieuDeDanhSach.AutoSize = true;
            this.lblTieuDeDanhSach.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTieuDeDanhSach.Location = new System.Drawing.Point(19, 12);
            this.lblTieuDeDanhSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDeDanhSach.Name = "lblTieuDeDanhSach";
            this.lblTieuDeDanhSach.Size = new System.Drawing.Size(270, 30);
            this.lblTieuDeDanhSach.TabIndex = 0;
            this.lblTieuDeDanhSach.Text = "DANH SÁCH DANH MỤC";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(19, 52);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(453, 31);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(87)))), ((int)(((byte)(26)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(483, 50);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(133, 36);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1427, 820);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDanhMuc";
            this.Text = "Quản lý danh mục";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.pnlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.pnlChanDanhSach.ResumeLayout(false);
            this.pnlChanDanhSach.PerformLayout();
            this.pnlDauDanhSach.ResumeLayout(false);
            this.pnlDauDanhSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormDanhMuc.cs)
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblTieuDeThongTin;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Label lblTenDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.Panel pnlChanDanhSach;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Panel pnlDauDanhSach;
        private System.Windows.Forms.Label lblTieuDeDanhSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}