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
                    ctl.BackgroundImage = Properties.Resources.background;

                    // 2. Chỉnh cách hiển thị ảnh (Stretch: Kéo giãn, Zoom: Giữ tỉ lệ)
                    ctl.BackgroundImageLayout = ImageLayout.Zoom;
                    break; // Tìm thấy rồi thì dừng lại
                }
            }
        }
        private void SetupEvents()
        {
            // --- 1. MENU HỆ THỐNG (Giữ nguyên) ---
            dangNhapToolStripMenuItem.Click += (s, e) => PerformLogin();
            dangXuatToolStripMenuItem.Click += (s, e) => Logout();
            thoatToolStripMenuItem.Click += (s, e) => Application.Exit();

            // --- 2. MENU CHỨC NĂNG (Giữ nguyên) ---
            quanLySanPhamToolStripMenuItem.Click += (s, e) => OpenChildForm<FormProductNTier>();
            traCuuThoiTietToolStripMenuItem.Click += (s, e) => OpenChildForm<FormWeather>();

            // Menu bài tập cũ
            mayTinhToolStripMenuItem.Click += (s, e) => OpenChildForm<FormMayTinh>();
            listBoxDemoToolStripMenuItem.Click += (s, e) => OpenChildForm<FormListBox>();
            treeViewToolStripMenuItem.Click += (s, e) => OpenChildForm<FormTreeView>();
            hoaDonToolStripMenuItem.Click += (s, e) => OpenChildForm<FormHoaDon>();

            // --- 3. XỬ LÝ TOOLBAR (TOOLSTRIP) --- 
            // Đây là phần bạn vừa yêu cầu thêm:

            // Button 3: Giới thiệu (About)
            toolStripButton3.Click += (s, e) => OpenChildForm<FormAbout>();

            // Các nút cũ (Giữ nguyên)
            // Button 5: Thoát
            toolStripButton5.Click += (s, e) => Application.Exit();
            // Button 6: Sản phẩm
            toolStripButton6.Click += (s, e) => OpenChildForm<FormProductNTier>();
            toolStripButton7.Click += (s, e) => OpenChildForm<FormWeather>();
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
            // Đóng tất cả form con đang mở để màn hình gọn gàng
            foreach (var child in MdiChildren) child.Close();

            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                var user = LoginForm.CurrentUser;
                lblUser.Text = $"Nhân viên: {user?.TenNV}";

                // Mở khóa các menu sau khi đăng nhập thành công
                tuHocLMSToolStripMenuItem.Enabled = true;
                baiTapCuToolStripMenuItem.Enabled = true;
            }
            else
            {
                // Nếu người dùng tắt form đăng nhập mà chưa đăng nhập -> Thoát App
                // Application.Exit(); // Bạn có thể bỏ comment dòng này nếu muốn bắt buộc đăng nhập
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