using QuanLyBanHang.Data.Models;
using QuanLyBanHang.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp.OldForms // Hoặc namespace QuanLyBanHang.WinApp tùy vị trí bạn đặt file
{
    public partial class FormHoaDon : Form
    {
        // Service xử lý dữ liệu
        private readonly ProductService _productService = new ProductService();
        private readonly OrderService _orderService = new OrderService();

        // Giỏ hàng tạm tính
        private List<ChiTietHoaDon> _cart = new List<ChiTietHoaDon>();

        // Biến lưu tổng tiền tạm tính
        private decimal _tongTien = 0;

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadProducts();
            ResetForm(); // Cài đặt trạng thái ban đầu
        }

        // --- 1. CÁC HÀM HỖ TRỢ ---
        private void LoadProducts()
        {
            try
            {
                dgvSanPham.DataSource = _productService.GetAll();
                // Ẩn cột quan hệ để tránh lỗi hiển thị
                if (dgvSanPham.Columns["LoaiSanPham"] != null)
                    dgvSanPham.Columns["LoaiSanPham"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load sản phẩm: " + ex.Message); }
        }

        private void GenerateMaHD()
        {
            // Tạo mã hóa đơn tự động theo thời gian: HD + yyyyMMddHHmmss
            txtMaHD.Text = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void ResetForm()
        {
            // Xóa dữ liệu
            _cart.Clear();
            txtTenKH.Clear();
            txtMaHD.Clear();
            lblTongTien.Text = "0 VNĐ";
            _tongTien = 0;
            nudSoLuong.Value = 1;

            // Tạo mã mới
            GenerateMaHD();

            // Làm mới Grid
            RefreshCartGrid();

            // Cài đặt trạng thái nút
            btnTaoHD.Enabled = false; // Chưa có hàng thì chưa được tạo
            btnLuu.Enabled = false;   // Chưa tạo thì chưa được lưu
            btnIn.Enabled = false;    // Chưa tạo thì chưa được in
            btnThemSP.Enabled = true; // Luôn cho phép thêm
        }

        private void RefreshCartGrid()
        {
            dgvChiTietHD.Columns.Clear();
            // Định nghĩa cột thủ công để kiểm soát hiển thị
            dgvChiTietHD.Columns.Add("MaSP", "Mã SP");
            dgvChiTietHD.Columns.Add("TenSP", "Tên Sản Phẩm");
            dgvChiTietHD.Columns.Add("SoLuong", "SL");
            dgvChiTietHD.Columns.Add("DonGia", "Đơn Giá");
            dgvChiTietHD.Columns.Add("ThanhTien", "Thành Tiền");

            _tongTien = 0;
            foreach (var item in _cart)
            {
                decimal thanhTien = item.SoLuong * item.DonGia;
                _tongTien += thanhTien;

                dgvChiTietHD.Rows.Add(
                    item.MaSP,
                    item.SanPham?.TenSP, // Lấy tên từ object SanPham
                    item.SoLuong,
                    item.DonGia.ToString("N0"),
                    thanhTien.ToString("N0")
                );
            }
            lblTongTien.Text = $"{_tongTien:N0} VNĐ";
        }

        // --- 2. XỬ LÝ SỰ KIỆN NÚT BẤM ---

        // NÚT THÊM: Đưa sản phẩm vào giỏ -> Bật nút Tạo HD
        private void btnThemSP_Click_1(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm từ danh sách bên trái!");
                return;
            }

            var selectedRow = dgvSanPham.CurrentRow;
            var sp = (SanPham)selectedRow.DataBoundItem;
            int soLuong = (int)nudSoLuong.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong giỏ chưa
            var existingItem = _cart.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (existingItem != null)
            {
                existingItem.SoLuong += soLuong; // Cộng dồn
            }
            else
            {
                _cart.Add(new ChiTietHoaDon
                {
                    MaSP = sp.MaSP,
                    SoLuong = soLuong,
                    DonGia = sp.DonGia,
                    SanPham = sp // Lưu tham chiếu để lấy tên hiển thị
                });
            }

            RefreshCartGrid();

            // FIX: Bật nút "Tạo hóa đơn" sau khi đã có hàng
            btnTaoHD.Enabled = true;
        }

        // NÚT TẠO HÓA ĐƠN: Xác nhận thông tin -> Bật nút Lưu/In
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtTenKH.Focus();
                return;
            }

            // Khóa mã hóa đơn để không sửa đổi lung tung
            txtMaHD.ReadOnly = true;

            MessageBox.Show("Đã xác nhận thông tin hóa đơn.\nBạn có thể Lưu hoặc In ngay bây giờ.", "Thông báo");

            // FIX: Bật các nút chức năng tiếp theo
            btnLuu.Enabled = true;
            btnIn.Enabled = true;

            // Tùy chọn: Khóa nút thêm để chốt đơn
            // btnThemSP.Enabled = false; 
        }

        // NÚT LƯU: Ghi xuống CSDL -> Reset form
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = new HoaDon
                {
                    MaHD = txtMaHD.Text,
                    NgayLap = dtpNgayLap.Value,
                    TenKhachHang = txtTenKH.Text,
                    TongTien = _tongTien
                };

                // Gọi Service lưu DB (Transaction)
                _orderService.CreateOrder(hd, _cart);

                MessageBox.Show("Lưu hóa đơn thành công vào CSDL!", "Thành công");

                // FIX: Reset form để sẵn sàng cho đơn mới
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        // NÚT IN: Xem trước bản in
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in ấn: " + ex.Message);
            }
        }

        // --- 3. XỬ LÝ IN ẤN ---
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 50;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontText = new Font("Arial", 10);

            // Tiêu đề
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", fontTitle, Brushes.Blue, 250, y);
            y += 40;

            // Thông tin chung
            e.Graphics.DrawString($"Mã HĐ: {txtMaHD.Text}", fontText, Brushes.Black, 50, y);
            y += 20;
            e.Graphics.DrawString($"Khách hàng: {txtTenKH.Text}", fontText, Brushes.Black, 50, y);
            y += 20;
            e.Graphics.DrawString($"Ngày lập: {dtpNgayLap.Value:dd/MM/yyyy HH:mm}", fontText, Brushes.Black, 50, y);
            y += 40;

            // Header bảng
            e.Graphics.DrawString("Sản phẩm", fontHeader, Brushes.Black, 50, y);
            e.Graphics.DrawString("SL", fontHeader, Brushes.Black, 300, y);
            e.Graphics.DrawString("Giá", fontHeader, Brushes.Black, 350, y);
            e.Graphics.DrawString("Thành tiền", fontHeader, Brushes.Black, 500, y);
            y += 30;
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 10;

            // Danh sách hàng
            foreach (var item in _cart)
            {
                e.Graphics.DrawString(item.SanPham?.TenSP, fontText, Brushes.Black, 50, y);
                e.Graphics.DrawString(item.SoLuong.ToString(), fontText, Brushes.Black, 300, y);
                e.Graphics.DrawString(item.DonGia.ToString("N0"), fontText, Brushes.Black, 350, y);
                e.Graphics.DrawString((item.SoLuong * item.DonGia).ToString("N0"), fontText, Brushes.Black, 500, y);
                y += 25;
            }

            // Tổng cộng
            y += 20;
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 10;
            e.Graphics.DrawString($"TỔNG CỘNG: {_tongTien:N0} VNĐ", fontHeader, Brushes.Red, 400, y);
        }
    }
}