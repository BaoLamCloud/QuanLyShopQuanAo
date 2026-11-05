namespace QuanLyShopQuanAo.GUI
{
    partial class FormCanhBaoTonKho
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.dgvTonThap = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonThap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTieuDe.Location = new System.Drawing.Point(21, 15);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(325, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "SẢN PHẨM SẮP HẾT HÀNG";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.lblMoTa.Location = new System.Drawing.Point(24, 57);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(320, 21);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Sản phẩm đang kinh doanh có tồn kho thấp.";
            // 
            // dgvTonThap
            // 
            this.dgvTonThap.AllowUserToAddRows = false;
            this.dgvTonThap.AllowUserToDeleteRows = false;
            this.dgvTonThap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.dgvTonThap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTonThap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonThap.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTonThap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTonThap.ColumnHeadersHeight = 34;
            this.dgvTonThap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTonThap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTonThap.EnableHeadersVisualStyles = false;
            this.dgvTonThap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvTonThap.Location = new System.Drawing.Point(21, 94);
            this.dgvTonThap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTonThap.MultiSelect = false;
            this.dgvTonThap.Name = "dgvTonThap";
            this.dgvTonThap.ReadOnly = true;
            this.dgvTonThap.RowHeadersVisible = false;
            this.dgvTonThap.RowHeadersWidth = 51;
            this.dgvTonThap.RowTemplate.Height = 28;
            this.dgvTonThap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonThap.Size = new System.Drawing.Size(1082, 406);
            this.dgvTonThap.TabIndex = 2;
            this.dgvTonThap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTonThap_CellFormatting);
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.lblTongSo.Location = new System.Drawing.Point(24, 512);
            this.lblTongSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(134, 21);
            this.lblTongSo.TabIndex = 3;
            this.lblTongSo.Text = "Tổng: 0 sản phẩm";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(539, 549);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(160, 47);
            this.btnNhapHang.TabIndex = 4;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(709, 549);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(144, 47);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(864, 549);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(133, 47);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormCanhBaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(1116, 615);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.dgvTonThap);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCanhBaoTonKho";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cảnh báo tồn kho";
            this.Load += new System.EventHandler(this.FormCanhBaoTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonThap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormCanhBaoTonKho.cs)
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.DataGridView dgvTonThap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTon;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnDong;
    }
}