namespace QuanLyBanHang.Services
{
    public class WeatherInfo
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public string Time { get; set; }
        public string Condition { get; set; } // Sun, Rain, Cloud...
    }
}