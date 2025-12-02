using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;
using QuanLyBanHang.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyBanHang.Services
{
    public class OrderService
    {
        private readonly QLBHContext _context;

        public OrderService()
        {
            _context = new QLBHContext();
        }

        // Lưu hóa đơn và các chi tiết
        public void CreateOrder(HoaDon hd, List<ChiTietHoaDon> details)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // 1. Lưu Hóa Đơn
                    _context.HoaDons.Add(hd);
                    _context.SaveChanges(); // Để lấy MaHD nếu cần

                    // 2. Lưu Chi Tiết & Trừ Tồn Kho
                    foreach (var item in details)
                    {
                        item.MaHD = hd.MaHD; // Gán mã hóa đơn cho chi tiết
                        _context.ChiTietHoaDons.Add(item);

                        // Trừ tồn kho (Logic mở rộng: Giả sử SanPham có cột SoLuongTon)
                        // var sp = _context.SanPhams.Find(item.MaSP);
                        // if(sp != null) sp.SoLuongTon -= item.SoLuong;
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}