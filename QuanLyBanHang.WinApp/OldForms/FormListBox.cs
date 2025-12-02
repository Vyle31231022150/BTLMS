using QuanLyBanHang.Services; // Gọi tầng Service
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp.OldForms
{
    public partial class FormListBox : Form
    {
        // Thay vì QLBHContext, ta dùng ProductService
        private readonly ProductService _service = new ProductService();

        public FormListBox()
        {
            InitializeComponent();
        }

        private void FormListBox_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi hàm GetAll từ Service
                var list = _service.GetAll();

                lstSanPham.DataSource = list;
                lstSanPham.DisplayMember = "TenSP";
                lstSanPham.ValueMember = "MaSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}