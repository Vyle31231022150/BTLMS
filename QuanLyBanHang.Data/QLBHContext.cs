using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data.Models;

namespace QuanLyBanHang.Data
{
    public class QLBHContext : DbContext
    {
        public DbSet<SanPham> SanPhams { get; set; } = null!;
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public DbSet<HoaDon> HoaDons { get; set; } = null!;
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public DbSet<NhanVien> NhanViens { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QLBH.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>().ToTable("SanPham");
            modelBuilder.Entity<LoaiSanPham>().ToTable("LoaiSanPham");
            modelBuilder.Entity<HoaDon>().ToTable("HoaDon");
            modelBuilder.Entity<ChiTietHoaDon>().ToTable("ChiTietHoaDon");
            modelBuilder.Entity<KhachHang>().ToTable("KhachHang");
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien");

            modelBuilder.Entity<SanPham>().HasKey(s => s.MaSP);
            modelBuilder.Entity<LoaiSanPham>().HasKey(l => l.MaLoai);
            modelBuilder.Entity<HoaDon>().HasKey(h => h.MaHD);
            modelBuilder.Entity<KhachHang>().HasKey(k => k.MaKH);
            modelBuilder.Entity<NhanVien>().HasKey(n => n.MaNV);
            modelBuilder.Entity<ChiTietHoaDon>().HasKey(c => new { c.MaHD, c.MaSP });

            modelBuilder.Entity<SanPham>()
        .HasOne(s => s.LoaiSanPham)
        .WithMany(l => l.SanPhams)
        .HasForeignKey(s => s.MaLoai)
        .HasConstraintName("FK_SanPham_LoaiSanPham");
        }
    }
}