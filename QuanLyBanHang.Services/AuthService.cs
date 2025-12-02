using QuanLyBanHang.Data;
using QuanLyBanHang.Data.Models;
using System.Linq;

namespace QuanLyBanHang.Services
{
    public class AuthService
    {
        private readonly QLBHContext _context;

        public AuthService()
        {
            _context = new QLBHContext();
            _context.Database.EnsureCreated();
        }

        // CHÚ Ý: Kiểu trả về là NhanVien? (có thể null) chứ không phải bool
        public NhanVien? Login(string username, string password)
        {
            // 1. Backdoor Admin (Test nhanh)
            if (username == "admin" && password == "123")
            {
                return new NhanVien { MaNV = "ADMIN", TenNV = "Quản Trị Viên" };
            }

            // 2. Kiểm tra trong CSDL
            var nv = _context.NhanViens.FirstOrDefault(x => x.MaNV == username);

            // Giả lập check pass (vì DB chưa có pass, mặc định là 123)
            if (nv != null && password == "123")
            {
                return nv; // Trả về đối tượng Nhân Viên tìm thấy
            }

            return null; // Trả về null nếu sai
        }
    }
}