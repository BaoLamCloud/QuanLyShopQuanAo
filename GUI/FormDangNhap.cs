using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form đăng nhập có mã xác nhận (captcha). Hiển thị bằng ShowDialog():
    ///   - DialogResult.OK     : đăng nhập thành công (thông tin lưu trong PhienLamViec)
    ///   - DialogResult.Cancel : người dùng bấm Thoát
    /// Giao diện nằm trong FormDangNhap.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormDangNhap : Form
    {
        // Các đối tượng BUS
        private readonly TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private readonly CaptchaBUS captchaBUS = new CaptchaBUS();

        // Mã captcha đang hiển thị
        private string maCaptcha;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        // Khi form mở: tạo captcha đầu tiên và đặt con trỏ vào ô tên đăng nhập
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            TaoCaptchaMoi();
            txtTenDangNhap.Focus();
        }

        // Tích "Hiện mật khẩu" thì hiện chữ, bỏ tích thì che bằng dấu chấm
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        /* ===================== CAPTCHA ===================== */

        // Sinh mã mới, vẽ lại hình và xóa ô nhập mã
        private void TaoCaptchaMoi()
        {
            maCaptcha = captchaBUS.TaoMa(5);

            Image anhCu = picCaptcha.Image;
            picCaptcha.Image = CaptchaHinh.Ve(maCaptcha, picCaptcha.Width, picCaptcha.Height);
            if (anhCu != null) anhCu.Dispose();

            txtCaptcha.Clear();
        }

        // Bấm nút "Đổi mã khác" hoặc bấm vào hình để lấy mã mới
        private void btnLamMoiCaptcha_Click(object sender, EventArgs e)
        {
            TaoCaptchaMoi();
            txtCaptcha.Focus();
        }

        private void picCaptcha_Click(object sender, EventArgs e)
        {
            TaoCaptchaMoi();
            txtCaptcha.Focus();
        }

        /* ===================== ĐĂNG NHẬP / THOÁT ===================== */

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        // Thoát: hỏi xác nhận rồi đóng form với kết quả Cancel
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        // Kiểm tra dữ liệu nhập, kiểm tra captcha, gọi BUS để đăng nhập và xử lý kết quả
        private void ThucHienDangNhap()
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            if (matKhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (txtCaptcha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận hiển thị trong hình.", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaptcha.Focus();
                return;
            }

            // Kiểm tra captcha TRƯỚC khi kiểm tra tài khoản; sai thì phải nhập mã mới
            if (!captchaBUS.KiemTra(maCaptcha, txtCaptcha.Text))
            {
                MessageBox.Show("Mã xác nhận không đúng. Vui lòng nhập lại theo mã mới.", "Sai mã xác nhận",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TaoCaptchaMoi();
                txtCaptcha.Focus();
                return;
            }

            // Hiện con trỏ chờ trong lúc kiểm tra tài khoản trong SQL Server
            Cursor = Cursors.WaitCursor;
            KetQua ketQua;
            try
            {
                ketQua = taiKhoanBUS.DangNhap(tenDangNhap, matKhau);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            if (!ketQua.ThanhCong)
            {
                MessageBox.Show(ketQua.ThongBao, "Đăng nhập thất bại",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Clear();
                TaoCaptchaMoi();      // mỗi lần đăng nhập sai đều đổi captcha
                txtMatKhau.Focus();
                return;
            }

            // Thành công: đóng form đăng nhập, nơi gọi (Program.cs) sẽ mở form trang chủ
            DialogResult = DialogResult.OK;
        }
    }
}