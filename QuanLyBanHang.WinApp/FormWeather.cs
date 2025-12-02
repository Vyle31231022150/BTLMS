using QuanLyBanHang.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp
{
    public partial class FormWeather : Form
    {
        private readonly WeatherService _service = new WeatherService();
        private readonly (string name, double lat, double lon)[] cities = new[]
        {
            ("HCM", 10.76, 106.66),
            ("Hà Nội", 21.02, 105.83),
            ("Đà Nẵng", 16.05, 108.20)
        };

        public FormWeather()
        {
            InitializeComponent();

            // --- GÁN SỰ KIỆN ---
            this.Load += FormWeather_Load;
            this.cmbCity.SelectedIndexChanged += CmbCity_SelectedIndexChanged;
            this.btnUpdate.Click += BtnUpdate_Click;
        }

        private async void FormWeather_Load(object sender, EventArgs e)
        {
            cmbCity.SelectedIndex = 0;
            await FetchData();
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCustom = cmbCity.SelectedItem.ToString() == "Khác";
            txtLat.Enabled = txtLon.Enabled = isCustom;
            if (!isCustom) { txtLat.Text = ""; txtLon.Text = ""; }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            await FetchData();
        }

        private async Task FetchData()
        {
            double lat, lon;
            if (cmbCity.SelectedItem.ToString() == "Khác")
            {
                if (!double.TryParse(txtLat.Text, out lat) || !double.TryParse(txtLon.Text, out lon))
                {
                    MessageBox.Show("Tọa độ sai!"); return;
                }
            }
            else
            {
                var city = cities[cmbCity.SelectedIndex];
                lat = city.lat; lon = city.lon;
            }

            btnUpdate.Enabled = false;
            var info = await _service.GetWeatherDetailAsync(lat, lon);
            btnUpdate.Enabled = true;

            if (info != null)
            {
                lblTemp.Text = $"Nhiệt độ: {info.Temperature}°C";
                lblWind.Text = $"Gió: {info.WindSpeed} km/h";
                lblTime.Text = $"Time: {info.Time}";

                // Set Icon
                switch (info.Condition)
                {
                    case "Sun": picIcon.Image = Properties.Resources.sun; break;
                    case "Rain": picIcon.Image = Properties.Resources.rain; break;
                    case "Wind": picIcon.Image = Properties.Resources.wind; break;
                    // Đảm bảo có ảnh mặc định cho trường hợp khác
                    default: picIcon.Image = Properties.Resources.cloud; break;
                }
            }
        }
    }
}