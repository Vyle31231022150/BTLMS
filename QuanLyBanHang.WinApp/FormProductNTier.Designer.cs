namespace QuanLyBanHang.WinApp
{
    partial class FormProductNTier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSanPham = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtDonGia = new TextBox();
            txtDVT = new TextBox();
            cbLoaiSP = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(36, 307);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(914, 321);
            dgvSanPham.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 75);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 130);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 189);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 4;
            label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 248);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 5;
            label5.Text = "Loại sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.BackColor = Color.FromArgb(224, 224, 224);
            txtMaSP.Location = new Point(317, 23);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(196, 27);
            txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            txtTenSP.BackColor = Color.FromArgb(224, 224, 224);
            txtTenSP.Location = new Point(317, 75);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(196, 27);
            txtTenSP.TabIndex = 7;
            // 
            // txtDonGia
            // 
            txtDonGia.BackColor = Color.FromArgb(224, 224, 224);
            txtDonGia.Location = new Point(317, 127);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(196, 27);
            txtDonGia.TabIndex = 8;
            // 
            // txtDVT
            // 
            txtDVT.BackColor = Color.FromArgb(224, 224, 224);
            txtDVT.Location = new Point(317, 189);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(196, 27);
            txtDVT.TabIndex = 9;
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.BackColor = Color.FromArgb(224, 224, 224);
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(316, 249);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(197, 28);
            cbLoaiSP.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(224, 224, 224);
            btnThem.Location = new Point(611, 52);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(224, 224, 224);
            btnSua.Location = new Point(611, 112);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.Location = new Point(611, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(224, 224, 224);
            btnThoat.Location = new Point(611, 239);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // FormProductNTier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbLoaiSP);
            Controls.Add(txtDVT);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSanPham);
            Name = "FormProductNTier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSanPham;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtDonGia;
        private TextBox txtDVT;
        private ComboBox cbLoaiSP;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}