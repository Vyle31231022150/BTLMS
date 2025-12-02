using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data.Models
{
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; } = null!;
        public string TenKH { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
    }
}
