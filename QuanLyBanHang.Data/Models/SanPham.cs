using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public string MaSP { get; set; } = null!;
        public string TenSP { get; set; } = null!;
        public string? DVTinh { get; set; }
        public decimal DonGia { get; set; }
        public string MaLoai { get; set; } = null!;

        [ForeignKey("MaLoai")]
        public virtual LoaiSanPham? LoaiSanPham { get; set; }
    }
}