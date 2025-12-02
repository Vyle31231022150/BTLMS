using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; } = null!;

        public DateTime NgayLap { get; set; }

        public string? TenKhachHang { get; set; } // Lưu tạm tên KH

        public decimal TongTien { get; set; }

        // Quan hệ 1-N với Chi tiết hóa đơn
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
    }
}