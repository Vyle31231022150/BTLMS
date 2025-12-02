using QuanLyBanHang.Data.Models;
using QuanLyBanHang.Services;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        public static NhanVien? CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

            // --- GÁN SỰ KIỆN THỦ CÔNG (FIX LỖI MẤT EVENT) ---
            this.btnLogin.Click += new EventHandler(btnLogin_Click);
            this.btnExit.Click += new EventHandler(btnExit_Click);

            this.AcceptButton = btnLogin; // Bấm Enter là đăng nhập
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text.Trim();
            string p = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            var user = _authService.Login(u, p);

            if (user != null)
            {
                CurrentUser = user;
                MessageBox.Show($"Đăng nhập thành công!\nXin chào: {user.TenNV}", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}