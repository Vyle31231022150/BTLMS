using QuanLyBanHang.Services;
using QuanLyBanHang.WinApp.OldForms; // Đừng quên dòng này để gọi FormAbout
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp
{
    public partial class FormMain : Form
    {
        private readonly WeatherService _weatherService = new WeatherService();
        private Form activeForm = null;
        public FormMain()
        {
            InitializeComponent();
            SetupEvents(); // Gán sự kiện thủ công để đảm bảo nút chạy 100%
            SetupTimer();
            SetMdiBackground();
        }
        private void SetMdiBackground()
        {
            // Duyệt qua tất cả các control con của FormMain
            foreach (Control ctl in this.Controls)
            {
                // Tìm control có kiểu là MdiClient (chính là vùng xám xám)
                if (ctl is MdiClient)
                {
                    // 1. Gán ảnh từ Resources (Thay 'background' bằng tên ảnh của bạn)
                    // Nếu bạn chưa có ảnh thì dòng này sẽ lỗi đỏ -> Hãy làm Bước 1 trước
                    ctl.BackgroundImage = Properties.Resources.ThanhVy;

                    // 2. Chỉnh cách hiển thị ảnh (Stretch: Kéo giãn, Zoom: Giữ tỉ lệ)
                    ctl.BackgroundImageLayout = ImageLayout.Zoom;
                    break; // Tìm thấy rồi thì dừng lại
                }
            }
        }
        private void SetupEvents()
        {
            // Bind sự kiện cho các nút mới
            btnSanPham.Click += (s, e) => OpenChildForm<FormProductNTier>();
            btnThoiTiet.Click += (s, e) => OpenChildForm<FormWeather>();
            btnHoaDon.Click += (s, e) => OpenChildForm<FormHoaDon>();
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
            PerformLogin();
        }

        // Hàm xử lý đăng nhập
        private void PerformLogin()
        {
            // 1. Đóng form con nếu đang mở
            if (activeForm != null) activeForm.Close();

            // 2. Hiện form đăng nhập
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                var user = LoginForm.CurrentUser;
                lblUser.Text = $"Nhân viên: {user?.TenNV}";

                // --- SỬA LỖI TẠI ĐÂY ---
                // Thay vì bật Menu cũ, ta bật các Nút bấm mới
                btnSanPham.Enabled = true;
                btnThoiTiet.Enabled = true;
                btnHoaDon.Enabled = true;

                // Nếu muốn nút About luôn mở thì không cần chỉnh
                // btnAbout.Enabled = true; 
            }
            else
            {
                // Nếu không đăng nhập mà tắt form -> Thoát
                // Application.Exit(); 
            }
        }

        private void Logout()
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PerformLogin();
            }
        }

        // Hàm mở Form con chuẩn MDI (Tránh mở trùng lặp)
        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is T) { f.Activate(); return; }
            }
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (DateTime.Now.Second % 30 == 0)
            {
                string temp = await _weatherService.GetTempAsync();
                lblTemp.Text = $"HCM: {temp}°C";

                if (double.TryParse(temp, out double t) && t > 35)
                    statusStrip1.BackColor = Color.OrangeRed;
                else
                    statusStrip1.BackColor = SystemColors.Control;
            }
        }
    }
}