using QuanLyBanHang.Data.Models;
using QuanLyBanHang.Services;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp
{
    public partial class FormProductNTier : Form
    {
        private readonly ProductService _service = new ProductService();

        public FormProductNTier()
        {
            InitializeComponent();

            // --- GÁN SỰ KIỆN ---
            this.Load += FormProductNTier_Load;
            this.dgvSanPham.CellClick += DgvSanPham_CellClick;
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnThoat.Click += (s, e) => this.Close();
        }

        private void FormProductNTier_Load(object sender, EventArgs e)
        {
            try
            {
                cbLoaiSP.DataSource = _service.GetCategories();
                cbLoaiSP.DisplayMember = "TenLoai";
                cbLoaiSP.ValueMember = "MaLoai";
                LoadGrid();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load: " + ex.Message); }
        }

        private void LoadGrid()
        {
            dgvSanPham.DataSource = _service.GetAll();
            if (dgvSanPham.Columns["LoaiSanPham"] != null)
                dgvSanPham.Columns["LoaiSanPham"].Visible = false;
        }

        private void DgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtDVT.Text = row.Cells["DVTinh"].Value.ToString();
                cbLoaiSP.SelectedValue = row.Cells["MaLoai"].Value.ToString();
                txtMaSP.Enabled = false; // Khóa mã khi click sửa
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = GetModel();
                _service.Add(sp);
                MessageBox.Show("Thêm thành công!");
                LoadGrid();
                ResetForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = GetModel();
                _service.Update(sp);
                MessageBox.Show("Sửa thành công!");
                LoadGrid();
                ResetForm();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            string ma = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();

            if (MessageBox.Show("Xóa SP này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Delete(ma);
                LoadGrid();
                ResetForm();
            }
        }

        private SanPham GetModel()
        {
            return new SanPham
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                DVTinh = txtDVT.Text,
                DonGia = decimal.Parse(txtDonGia.Text),
                MaLoai = cbLoaiSP.SelectedValue.ToString()
            };
        }

        private void ResetForm()
        {
            txtMaSP.Enabled = true;
            txtMaSP.Clear(); txtTenSP.Clear(); txtDonGia.Clear(); txtDVT.Clear();
        }
    }
}