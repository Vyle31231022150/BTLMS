using System;
using System.Windows.Forms;

namespace QuanLyBanHang.WinApp.OldForms
{
    public partial class FormMayTinh : Form
    {
        public FormMayTinh()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtInput.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar =='-' && txtInput.SelectionStart !=0)
            {
                e.Handled= true;
            }
        }

        private void txtInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtInput1.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && txtInput1.SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtInput1.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!", "Thông báo");
                return;
            }
            try
            {
                double so1 = double.Parse(txtInput.Text);
                double so2 = double.Parse(txtInput1.Text);

                double ketQua = so1 + so2;

                txtResult.Text = ketQua.ToString();
            }
            catch 
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }

        }

        private void tnTru_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtInput1.Text)) 
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!", "Thông báo");
                return;
            }
            try
            {
                double so1 = double.Parse(txtInput.Text);
                double so2 = double.Parse(txtInput1.Text);
                double ketQua = so1 - so2;
                txtResult.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty (txtInput1.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!", "Thông báo");
            }
            try
            {
                double so1 = double.Parse(txtInput.Text);
                double so2 = double.Parse(txtInput1.Text);
                double ketQua = so1 * so2;
                txtResult.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtInput1.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!", "Thông báo");
            }
            try
            {
                double so1 = double.Parse(txtInput.Text);
                double so2 = double.Parse(txtInput1.Text);

                if (so2 ==0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi");
                    return;
                }
                double ketQua = so1 / so2;
                txtResult.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput1.Clear();
            txtResult.Clear();

            txtInput.Focus();
        }
    }
}
