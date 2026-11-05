namespace QuanLyShopQuanAo.GUI
{
    partial class FormTaiKhoan
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
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.chkHoatDong = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDatLaiMatKhau = new System.Windows.Forms.Button();
            this.lblGhiChuQuyen = new System.Windows.Forms.Label();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.pnlDoiMatKhau = new System.Windows.Forms.Panel();
            this.lblTieuDeDoiMatKhau = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblGoiYMatKhau = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.pnlDauDanhSach = new System.Windows.Forms.Panel();
            this.lblTieuDeDanhSach = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlThongTin.SuspendLayout();
            this.pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.pnlDoiMatKhau.SuspendLayout();
            this.pnlDauDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.AutoScroll = true;
            this.pnlThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.pnlThongTin.Controls.Add(this.lblTieuDeThongTin);
            this.pnlThongTin.Controls.Add(this.lblTenDangNhap);
            this.pnlThongTin.Controls.Add(this.txtTenDangNhap);
            this.pnlThongTin.Controls.Add(this.lblMatKhau);
            this.pnlThongTin.Controls.Add(this.txtMatKhau);
            this.pnlThongTin.Controls.Add(this.lblVaiTro);
            this.pnlThongTin.Controls.Add(this.cboVaiTro);
            this.pnlThongTin.Controls.Add(this.lblNhanVien);
            this.pnlThongTin.Controls.Add(this.cboNhanVien);
            this.pnlThongTin.Controls.Add(this.chkHoatDong);
            this.pnlThongTin.Controls.Add(this.btnThem);
            this.pnlThongTin.Controls.Add(this.btnSua);
            this.pnlThongTin.Controls.Add(this.btnXoa);
            this.pnlThongTin.Controls.Add(this.btnLamMoi);
            this.pnlThongTin.Controls.Add(this.btnDatLaiMatKhau);
            this.pnlThongTin.Controls.Add(this.lblGhiChuQuyen);
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
            this.lblTieuDeThongTin.Size = new System.Drawing.Size(262, 30);
            this.lblTieuDeThongTin.TabIndex = 0;
            this.lblTieuDeThongTin.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(21, 57);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(123, 21);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(21, 81);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(463, 30);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMatKhau.Location = new System.Drawing.Point(21, 123);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(336, 21);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật khẩu (nhập khi thêm mới hoặc đặt lại)";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(21, 148);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(463, 30);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblVaiTro.Location = new System.Drawing.Point(21, 190);
            this.lblVaiTro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(60, 21);
            this.lblVaiTro.TabIndex = 5;
            this.lblVaiTro.Text = "Vai trò";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Items.AddRange(new object[] {
            "Quản trị viên",
            "Nhân viên bán hàng"});
            this.cboVaiTro.Location = new System.Drawing.Point(21, 214);
            this.cboVaiTro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(463, 31);
            this.cboVaiTro.TabIndex = 6;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblNhanVien.Location = new System.Drawing.Point(21, 256);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(150, 21);
            this.lblNhanVien.TabIndex = 7;
            this.lblNhanVien.Text = "Nhân viên liên kết";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(21, 281);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(463, 31);
            this.cboNhanVien.TabIndex = 8;
            this.cboNhanVien.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboNhanVien_Format);
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.AutoSize = true;
            this.chkHoatDong.Checked = true;
            this.chkHoatDong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHoatDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHoatDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHoatDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.chkHoatDong.Location = new System.Drawing.Point(24, 327);
            this.chkHoatDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Size = new System.Drawing.Size(233, 27);
            this.chkHoatDong.TabIndex = 9;
            this.chkHoatDong.Text = "Tài khoản đang hoạt động";
            this.chkHoatDong.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(21, 374);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 49);
            this.btnThem.TabIndex = 10;
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
            this.btnSua.Location = new System.Drawing.Point(140, 374);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 49);
            this.btnSua.TabIndex = 11;
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
            this.btnXoa.Location = new System.Drawing.Point(259, 374);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 12;
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
            this.btnLamMoi.Location = new System.Drawing.Point(377, 374);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(108, 49);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(87)))), ((int)(((byte)(26)))));
            this.btnDatLaiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(21, 436);
            this.btnDatLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(464, 49);
            this.btnDatLaiMatKhau.TabIndex = 14;
            this.btnDatLaiMatKhau.Text = "Đặt lại mật khẩu (theo ô mật khẩu ở trên)";
            this.btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // lblGhiChuQuyen
            // 
            this.lblGhiChuQuyen.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChuQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.lblGhiChuQuyen.Location = new System.Drawing.Point(21, 497);
            this.lblGhiChuQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChuQuyen.Name = "lblGhiChuQuyen";
            this.lblGhiChuQuyen.Size = new System.Drawing.Size(464, 59);
            this.lblGhiChuQuyen.TabIndex = 15;
            this.lblGhiChuQuyen.Text = "Lưu ý: không thể xóa hoặc khóa tài khoản đang đăng nhập, cũng như quản trị viên h" +
    "oạt động cuối cùng.";
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.BackColor = System.Drawing.Color.White;
            this.pnlDanhSach.Controls.Add(this.dgvTaiKhoan);
            this.pnlDanhSach.Controls.Add(this.pnlDoiMatKhau);
            this.pnlDanhSach.Controls.Add(this.pnlDauDanhSach);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(920, 820);
            this.pnlDanhSach.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.ColumnHeadersHeight = 36;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 113);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(920, 522);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTaiKhoan_CellFormatting);
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
            // 
            // pnlDoiMatKhau
            // 
            this.pnlDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.pnlDoiMatKhau.Controls.Add(this.lblTieuDeDoiMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.lblMatKhauCu);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.pnlDoiMatKhau.Controls.Add(this.lblMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.lblXacNhanMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.txtXacNhanMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.chkHienMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.lblGoiYMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.btnDoiMatKhau);
            this.pnlDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDoiMatKhau.Location = new System.Drawing.Point(0, 635);
            this.pnlDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDoiMatKhau.Name = "pnlDoiMatKhau";
            this.pnlDoiMatKhau.Size = new System.Drawing.Size(920, 185);
            this.pnlDoiMatKhau.TabIndex = 1;
            // 
            // lblTieuDeDoiMatKhau
            // 
            this.lblTieuDeDoiMatKhau.AutoSize = true;
            this.lblTieuDeDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTieuDeDoiMatKhau.Location = new System.Drawing.Point(19, 10);
            this.lblTieuDeDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDeDoiMatKhau.Name = "lblTieuDeDoiMatKhau";
            this.lblTieuDeDoiMatKhau.Size = new System.Drawing.Size(256, 28);
            this.lblTieuDeDoiMatKhau.TabIndex = 0;
            this.lblTieuDeDoiMatKhau.Text = "ĐỔI MẬT KHẨU CỦA BẠN";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMatKhauCu.Location = new System.Drawing.Point(21, 49);
            this.lblMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(144, 21);
            this.lblMatKhauCu.TabIndex = 1;
            this.lblMatKhauCu.Text = "Mật khẩu hiện tại";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(21, 74);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhauCu.MaxLength = 50;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(213, 30);
            this.txtMatKhauCu.TabIndex = 2;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(253, 49);
            this.lblMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(116, 21);
            this.lblMatKhauMoi.TabIndex = 3;
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(253, 74);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhauMoi.MaxLength = 50;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(213, 30);
            this.txtMatKhauMoi.TabIndex = 4;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(485, 49);
            this.lblXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(185, 21);
            this.lblXacNhanMatKhau.TabIndex = 5;
            this.lblXacNhanMatKhau.Text = "Nhập lại mật khẩu mới";
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(485, 74);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXacNhanMatKhau.MaxLength = 50;
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(213, 30);
            this.txtXacNhanMatKhau.TabIndex = 6;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.chkHienMatKhau.Location = new System.Drawing.Point(24, 116);
            this.chkHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(133, 25);
            this.chkHienMatKhau.TabIndex = 7;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            // 
            // lblGoiYMatKhau
            // 
            this.lblGoiYMatKhau.AutoSize = true;
            this.lblGoiYMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoiYMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.lblGoiYMatKhau.Location = new System.Drawing.Point(21, 148);
            this.lblGoiYMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoiYMatKhau.Name = "lblGoiYMatKhau";
            this.lblGoiYMatKhau.Size = new System.Drawing.Size(408, 20);
            this.lblGoiYMatKhau.TabIndex = 8;
            this.lblGoiYMatKhau.Text = "Mật khẩu mới tối thiểu 6 ký tự và phải khác mật khẩu hiện tại.";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(720, 64);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(179, 47);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
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
            this.lblTieuDeDanhSach.Size = new System.Drawing.Size(268, 30);
            this.lblTieuDeDanhSach.TabIndex = 0;
            this.lblTieuDeDanhSach.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(19, 52);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(399, 31);
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
            this.btnTimKiem.Location = new System.Drawing.Point(429, 50);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(133, 36);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1427, 820);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.pnlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.pnlDoiMatKhau.ResumeLayout(false);
            this.pnlDoiMatKhau.PerformLayout();
            this.pnlDauDanhSach.ResumeLayout(false);
            this.pnlDauDanhSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormTaiKhoan.cs)
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblTieuDeThongTin;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.CheckBox chkHoatDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDatLaiMatKhau;
        private System.Windows.Forms.Label lblGhiChuQuyen;
        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlDoiMatKhau;
        private System.Windows.Forms.Label lblTieuDeDoiMatKhau;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Label lblGoiYMatKhau;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Panel pnlDauDanhSach;
        private System.Windows.Forms.Label lblTieuDeDanhSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}