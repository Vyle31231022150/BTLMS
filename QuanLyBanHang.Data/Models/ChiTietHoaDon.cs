using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Data.Models
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
        // Dùng Composite Key (MaHD + MaSP) hoặc ID tự tăng
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string MaHD { get; set; } = null!;
        public string MaSP { get; set; } = null!;

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; } // Lưu giá tại thời điểm bán

        [ForeignKey("MaHD")]
        public virtual HoaDon? HoaDon { get; set; }

        [ForeignKey("MaSP")]
        public virtual SanPham? SanPham { get; set; }
    }
}