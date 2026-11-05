namespace QuanLyShopQuanAo.GUI
{
    partial class FormDangNhap
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
            this.pnlTrai = new System.Windows.Forms.Panel();
            this.lblBieuTuong = new System.Windows.Forms.Label();
            this.lblTenPhanMem = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pnlGachNgang = new System.Windows.Forms.Panel();
            this.pnlPhai = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblChaoMung = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaXacNhan = new System.Windows.Forms.Label();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.btnLamMoiCaptcha = new System.Windows.Forms.Button();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.pnlTrai.SuspendLayout();
            this.pnlPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTrai
            // 
            this.pnlTrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlTrai.Controls.Add(this.lblBieuTuong);
            this.pnlTrai.Controls.Add(this.lblTenPhanMem);
            this.pnlTrai.Controls.Add(this.lblSlogan);
            this.pnlTrai.Controls.Add(this.pnlGachNgang);
            this.pnlTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTrai.Location = new System.Drawing.Point(0, 0);
            this.pnlTrai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTrai.Name = "pnlTrai";
            this.pnlTrai.Size = new System.Drawing.Size(480, 726);
            this.pnlTrai.TabIndex = 5;
            // 
            // lblBieuTuong
            // 
            this.lblBieuTuong.Font = new System.Drawing.Font("Segoe UI Emoji", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBieuTuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.lblBieuTuong.Location = new System.Drawing.Point(0, 98);
            this.lblBieuTuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBieuTuong.Name = "lblBieuTuong";
            this.lblBieuTuong.Size = new System.Drawing.Size(480, 148);
            this.lblBieuTuong.TabIndex = 0;
            this.lblBieuTuong.Text = "👔";
            this.lblBieuTuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenPhanMem
            // 
            this.lblTenPhanMem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenPhanMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(179)))));
            this.lblTenPhanMem.Location = new System.Drawing.Point(0, 265);
            this.lblTenPhanMem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenPhanMem.Name = "lblTenPhanMem";
            this.lblTenPhanMem.Size = new System.Drawing.Size(480, 111);
            this.lblTenPhanMem.TabIndex = 1;
            this.lblTenPhanMem.Text = "QUẢN LÝ\r\nSHOP QUẦN ÁO";
            this.lblTenPhanMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.lblSlogan.Location = new System.Drawing.Point(27, 388);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(427, 62);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Phong cách riêng – Quản lý dễ dàng";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGachNgang
            // 
            this.pnlGachNgang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(170)))), ((int)(((byte)(164)))));
            this.pnlGachNgang.Location = new System.Drawing.Point(173, 462);
            this.pnlGachNgang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGachNgang.Name = "pnlGachNgang";
            this.pnlGachNgang.Size = new System.Drawing.Size(133, 2);
            this.pnlGachNgang.TabIndex = 3;
            // 
            // pnlPhai
            // 
            this.pnlPhai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.pnlPhai.Controls.Add(this.lblTieuDe);
            this.pnlPhai.Controls.Add(this.lblChaoMung);
            this.pnlPhai.Controls.Add(this.lblTenDangNhap);
            this.pnlPhai.Controls.Add(this.txtTenDangNhap);
            this.pnlPhai.Controls.Add(this.lblMatKhau);
            this.pnlPhai.Controls.Add(this.txtMatKhau);
            this.pnlPhai.Controls.Add(this.chkHienMatKhau);
            this.pnlPhai.Controls.Add(this.btnDangNhap);
            this.pnlPhai.Controls.Add(this.btnThoat);
            this.pnlPhai.Controls.Add(this.lblMaXacNhan);
            this.pnlPhai.Controls.Add(this.picCaptcha);
            this.pnlPhai.Controls.Add(this.btnLamMoiCaptcha);
            this.pnlPhai.Controls.Add(this.txtCaptcha);
            this.pnlPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhai.Location = new System.Drawing.Point(480, 0);
            this.pnlPhai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPhai.Name = "pnlPhai";
            this.pnlPhai.Size = new System.Drawing.Size(613, 726);
            this.pnlPhai.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTieuDe.Location = new System.Drawing.Point(61, 49);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(268, 54);
            this.lblTieuDe.TabIndex = 6;
            this.lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // lblChaoMung
            // 
            this.lblChaoMung.AutoSize = true;
            this.lblChaoMung.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChaoMung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.lblChaoMung.Location = new System.Drawing.Point(67, 117);
            this.lblChaoMung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChaoMung.Name = "lblChaoMung";
            this.lblChaoMung.Size = new System.Drawing.Size(252, 25);
            this.lblChaoMung.TabIndex = 7;
            this.lblChaoMung.Text = "Chào mừng bạn quay trở lại!";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(67, 170);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(138, 25);
            this.lblTenDangNhap.TabIndex = 8;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(67, 197);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(479, 36);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMatKhau.Location = new System.Drawing.Point(67, 254);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lblMatKhau.TabIndex = 9;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(67, 281);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(479, 36);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.chkHienMatKhau.Location = new System.Drawing.Point(69, 330);
            this.chkHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(144, 27);
            this.chkHienMatKhau.TabIndex = 2;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(87)))), ((int)(((byte)(26)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(67, 542);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(480, 57);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.btnThoat.Location = new System.Drawing.Point(67, 608);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(480, 49);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaXacNhan
            // 
            this.lblMaXacNhan.AutoSize = true;
            this.lblMaXacNhan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblMaXacNhan.Location = new System.Drawing.Point(67, 369);
            this.lblMaXacNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaXacNhan.Name = "lblMaXacNhan";
            this.lblMaXacNhan.Size = new System.Drawing.Size(207, 25);
            this.lblMaXacNhan.TabIndex = 11;
            this.lblMaXacNhan.Text = "Mã xác nhận (captcha)";
            // 
            // picCaptcha
            // 
            this.picCaptcha.BackColor = System.Drawing.Color.White;
            this.picCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCaptcha.Location = new System.Drawing.Point(67, 410);
            this.picCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(293, 58);
            this.picCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptcha.TabIndex = 12;
            this.picCaptcha.TabStop = false;
            this.picCaptcha.Click += new System.EventHandler(this.picCaptcha_Click);
            // 
            // btnLamMoiCaptcha
            // 
            this.btnLamMoiCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.btnLamMoiCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiCaptcha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnLamMoiCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiCaptcha.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoiCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.btnLamMoiCaptcha.Location = new System.Drawing.Point(373, 410);
            this.btnLamMoiCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoiCaptcha.Name = "btnLamMoiCaptcha";
            this.btnLamMoiCaptcha.Size = new System.Drawing.Size(173, 58);
            this.btnLamMoiCaptcha.TabIndex = 4;
            this.btnLamMoiCaptcha.TabStop = false;
            this.btnLamMoiCaptcha.Text = "Đổi mã khác";
            this.btnLamMoiCaptcha.UseVisualStyleBackColor = false;
            this.btnLamMoiCaptcha.Click += new System.EventHandler(this.btnLamMoiCaptcha_Click);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptcha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaptcha.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCaptcha.Location = new System.Drawing.Point(67, 480);
            this.txtCaptcha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCaptcha.MaxLength = 10;
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(479, 36);
            this.txtCaptcha.TabIndex = 3;
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1093, 726);
            this.Controls.Add(this.pnlPhai);
            this.Controls.Add(this.pnlTrai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Quản Lý Shop Quần Áo";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlTrai.ResumeLayout(false);
            this.pnlPhai.ResumeLayout(false);
            this.pnlPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormDangNhap.cs)
        private System.Windows.Forms.Panel pnlTrai;
        private System.Windows.Forms.Label lblBieuTuong;
        private System.Windows.Forms.Label lblTenPhanMem;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel pnlGachNgang;
        private System.Windows.Forms.Panel pnlPhai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblChaoMung;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaXacNhan;
        private System.Windows.Forms.PictureBox picCaptcha;
        private System.Windows.Forms.Button btnLamMoiCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
    }
}