using QuanLyBanHang.Services;
using QuanLyBanHang.WinApp.OldForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp
{
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        private readonly WeatherService _weatherService = new WeatherService();

        public FormMain()
        {
            InitializeComponent();
            SetupEvents();
            SetupTimer();
        }

        private void SetupEvents()
        {
            // --- GÁN SỰ KIỆN CHO CÁC NÚT (ĐẦY ĐỦ TẤT CẢ CHỨC NĂNG) ---
            btnSanPham.Click += (s, e) => OpenChildForm<FormProductNTier>();
            btnThoiTiet.Click += (s, e) => OpenChildForm<FormWeather>();
            btnHoaDon.Click += (s, e) => OpenChildForm<FormHoaDon>();

            // Các nút bài tập cũ
            btnMayTinh.Click += (s, e) => OpenChildForm<FormMayTinh>();
            btnListBox.Click += (s, e) => OpenChildForm<FormListBox>();
            btnTreeView.Click += (s, e) => OpenChildForm<FormTreeView>();

            btnAbout.Click += (s, e) => OpenChildForm<FormAbout>();
            btnThoat.Click += (s, e) => Application.Exit();
        }

        private void SetupTimer()
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Khóa các nút chức năng khi vừa mở app
            ToggleButtons(false);

            // Gọi hàm đăng nhập
            PerformLogin();
        }

        private void ToggleButtons(bool enable)
        {
            btnSanPham.Enabled = enable;
            btnThoiTiet.Enabled = enable;
            btnHoaDon.Enabled = enable;
            btnMayTinh.Enabled = enable;
            btnListBox.Enabled = enable;
            btnTreeView.Enabled = enable;

            // Nút About và Thoát luôn mở
            btnAbout.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void PerformLogin()
        {
            // Đóng form con nếu đang mở
            if (activeForm != null) activeForm.Close();

            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                var user = LoginForm.CurrentUser;
                lblUser.Text = $"Nhân viên: {user?.TenNV}";

                // Mở khóa TOÀN BỘ các nút chức năng
                ToggleButtons(true);
            }
            else
            {
                // Nếu tắt form đăng nhập mà không đăng nhập -> Thoát hoặc giữ giao diện khóa
                // Application.Exit(); 
            }
        }

        private void OpenChildForm<T>() where T : Form, new()
        {
            if (activeForm != null)
                activeForm.Close();

            T newForm = new T();
            activeForm = newForm;

            // Cấu hình hiển thị dạng MDI
            newForm.MdiParent = this;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Show();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (DateTime.Now.Second % 30 == 0)
            {
                string temp = await _weatherService.GetTempAsync();
                lblTemp.Text = $"HCM: {temp}°C";
            }
        }
    }
}