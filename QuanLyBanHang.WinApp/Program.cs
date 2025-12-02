using QuanLyBanHang.Data;
using QuanLyBanHang.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // --- BƯỚC KHỞI TẠO DỮ LIỆU MẪU (DATA SEEDING) ---
            // Phần này giúp nạp dữ liệu giả lập ngay khi chạy App lần đầu
            SeedData();

            Application.Run(new FormMain());
        }

        private static void SeedData()
        {
            try
            {
                using (var context = new QLBHContext())
                {
                    // 1. Đảm bảo DB đã được tạo
                    context.Database.EnsureCreated();

                    // 2. Kiểm tra nếu chưa có Loại sản phẩm thì thêm mới
                    if (!context.LoaiSanPhams.Any())
                    {
                        var loais = new List<LoaiSanPham>
                        {
                            new LoaiSanPham { MaLoai = "L01", TenLoai = "Điện thoại" },
                            new LoaiSanPham { MaLoai = "L02", TenLoai = "Laptop" },
                            new LoaiSanPham { MaLoai = "L03", TenLoai = "Phụ kiện" }
                        };
                        context.LoaiSanPhams.AddRange(loais);
                        context.SaveChanges();
                    }

                    // 3. Kiểm tra nếu chưa có Sản phẩm thì thêm mới
                    if (!context.SanPhams.Any())
                    {
                        var sps = new List<SanPham>
                        {
                            new SanPham { MaSP = "SP01", TenSP = "iPhone 15", DonGia = 25000000, DVTinh = "Cái", MaLoai = "L01" },
                            new SanPham { MaSP = "SP02", TenSP = "Samsung S24", DonGia = 20000000, DVTinh = "Cái", MaLoai = "L01" },
                            new SanPham { MaSP = "SP03", TenSP = "Dell XPS 13", DonGia = 35000000, DVTinh = "Cái", MaLoai = "L02" },
                            new SanPham { MaSP = "SP04", TenSP = "Chuột Logitech", DonGia = 500000, DVTinh = "Cái", MaLoai = "L03" }
                        };
                        context.SanPhams.AddRange(sps);
                        context.SaveChanges();
                    }

                    // 4. Kiểm tra nếu chưa có Nhân viên thì thêm mới
                    if (!context.NhanViens.Any())
                    {
                        var nvs = new List<NhanVien>
                        {
                            new NhanVien { MaNV = "NV01", TenNV = "Nguyễn Văn A", MatKhau = "123" },
                            new NhanVien { MaNV = "NV02", TenNV = "Trần Thị B", MatKhau = "123" }
                        };
                        context.NhanViens.AddRange(nvs);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo dữ liệu: " + ex.Message);
            }
        }
    }
}