using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data.Models
{
    [Table("LoaiSanPham")]
    public class LoaiSanPham
    {
        [Key]
        public string MaLoai { get; set; } = null!;
        public string TenLoai { get; set; } = null!;
        public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
    }
}