using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; } = null!;
        public string TenNV { get; set; } = null!;
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        // Mật khẩu giả lập (vì DB cũ không có cột này)
        [NotMapped]
        public string MatKhau { get; set; } = "123";
    }
}