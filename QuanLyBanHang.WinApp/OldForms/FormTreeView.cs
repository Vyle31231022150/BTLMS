using QuanLyBanHang.Services; // Gọi tầng Service
using System;
using System.Linq; // Cần dùng Linq nếu muốn xử lý danh sách
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp.OldForms
{
    public partial class FormTreeView : Form
    {
        // Khai báo Service
        private readonly ProductService _service = new ProductService();

        public FormTreeView()
        {
            InitializeComponent();
        }

        private void FormTreeView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTreeViewLoaiSP();
                // Nếu có node nào thì chọn node đầu tiên
                if (trvLoaiSP.Nodes.Count > 0)
                {
                    trvLoaiSP.SelectedNode = trvLoaiSP.Nodes[0];
                    LoadSanPham(trvLoaiSP.SelectedNode.Tag?.ToString() ?? "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        void LoadTreeViewLoaiSP()
        {
            // Lấy danh mục từ Service
            var loaiList = _service.GetCategories();

            trvLoaiSP.Nodes.Clear();
            foreach (var loai in loaiList)
            {
                TreeNode node = new TreeNode
                {
                    Text = loai.TenLoai,
                    Tag = loai.MaLoai // Lưu mã loại vào Tag để dùng sau
                };
                trvLoaiSP.Nodes.Add(node);
            }
        }

        void LoadSanPham(string maLoai)
        {
            // Lấy sản phẩm theo loại từ Service
            var list = _service.GetProductsByCategory(maLoai);
            dgvSanPham.DataSource = list;

            // Ẩn cột object quan hệ nếu cần
            if (dgvSanPham.Columns["LoaiSanPham"] != null)
                dgvSanPham.Columns["LoaiSanPham"].Visible = false;
        }

        private void trvLoaiSP_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Khi chọn Node, lấy mã từ Tag và load lại Grid
            if (e.Node != null && e.Node.Tag != null)
            {
                string maLoai = e.Node.Tag.ToString();
                LoadSanPham(maLoai);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}