using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;
using QuanLyBanHang.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyBanHang.Services
{
    public class ProductService
    {
        private readonly QLBHContext _context;
        public ProductService()
        {
            _context = new QLBHContext();
            _context.Database.EnsureCreated(); // Đảm bảo DB tồn tại
        }

        // 1. Lấy tất cả sản phẩm (Cho FormListBox, FormProductNTier)
        public List<SanPham> GetAll()
        {
            return _context.SanPhams.Include(s => s.LoaiSanPham).ToList();
        }

        // 2. Lấy danh sách Loại (Cho ComboBox, TreeView)
        public List<LoaiSanPham> GetCategories()
        {
            return _context.LoaiSanPhams.ToList();
        }

        // 3. Lấy sản phẩm theo Mã Loại (Dùng cho FormTreeView khi click vào node)
        public List<SanPham> GetProductsByCategory(string maLoai)
        {
            return _context.SanPhams
                           .Where(p => p.MaLoai == maLoai)
                           .OrderBy(p => p.TenSP)
                           .ToList();
        }

        // 4. Thêm
        public void Add(SanPham sp)
        {
            if (_context.SanPhams.Any(p => p.MaSP == sp.MaSP))
                throw new Exception("Mã sản phẩm đã tồn tại!");
            _context.SanPhams.Add(sp);
            _context.SaveChanges();
        }

        // 5. Sửa
        public void Update(SanPham sp)
        {
            var existing = _context.SanPhams.Find(sp.MaSP);
            if (existing != null)
            {
                existing.TenSP = sp.TenSP;
                existing.DonGia = sp.DonGia;
                existing.DVTinh = sp.DVTinh;
                existing.MaLoai = sp.MaLoai;
                _context.SaveChanges();
            }
        }

        // 6. Xóa
        public void Delete(string maSP)
        {
            var sp = _context.SanPhams.Find(maSP);
            if (sp != null)
            {
                _context.SanPhams.Remove(sp);
                _context.SaveChanges();
            }
        }
    }
}