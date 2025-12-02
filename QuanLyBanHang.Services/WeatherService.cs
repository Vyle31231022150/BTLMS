using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuanLyBanHang.Services
{
    public class WeatherService
    {
        private readonly HttpClient _client = new HttpClient();

        // Hàm lấy dữ liệu đầy đủ cho Form Thời Tiết
        public async Task<WeatherInfo?> GetWeatherDetailAsync(double lat, double lon)
        {
            try
            {
                string url = $" https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current_weather=true";
           
                var json = await _client.GetStringAsync(url);
                dynamic data = JsonConvert.DeserializeObject(json);

                double temp = data.current_weather.temperature;
                double wind = data.current_weather.windspeed;
                string time = data.current_weather.time;

                // Logic xác định trạng thái (để Form chọn icon)
                string condition = "Cloud";
                if (temp > 35) condition = "Sun";
                else if (temp < 20) condition = "Rain";
                if (wind > 30) condition = "Wind";

                return new WeatherInfo
                {
                    Temperature = temp,
                    WindSpeed = wind,
                    Time = time,
                    Condition = condition
                };
            }
            catch
            {
                return null;
            }
        }

        // Hàm rút gọn cho StatusStrip (dùng ở FormMain)
        public async Task<string> GetTempAsync()
        {
            var info = await GetWeatherDetailAsync(10.76, 106.66); // Mặc định HCM
            return info != null ? info.Temperature.ToString() : "N/A";
        }
    }
}