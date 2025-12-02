namespace QuanLyBanHang.WinApp.OldForms
{
    partial class FormHoaDon
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            panel1 = new Panel();
            dtpNgayLap = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenKH = new TextBox();
            txtMaHD = new TextBox();
            panel2 = new Panel();
            lblTongTien = new Label();
            dgvChiTietHD = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dgvSanPham = new DataGridView();
            panel3 = new Panel();
            label4 = new Label();
            nudSoLuong = new NumericUpDown();
            btnLuu = new Button();
            btnIn = new Button();
            btnTaoHD = new Button();
            btnThemSP = new Button();
            errorProvider1 = new ErrorProvider(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtpNgayLap);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(txtMaHD);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 159);
            panel1.TabIndex = 0;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(195, 112);
            dtpNgayLap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(200, 27);
            dtpNgayLap.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 112);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày lập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 68);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã hóa đơn";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(195, 65);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(200, 27);
            txtTenKH.TabIndex = 2;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(195, 16);
            txtMaHD.Margin = new Padding(3, 4, 3, 4);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(200, 27);
            txtMaHD.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(dgvChiTietHD);
            panel2.Controls.Add(dgvSanPham);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 159);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 379);
            panel2.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = SystemColors.ButtonHighlight;
            lblTongTien.Location = new Point(502, 355);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(78, 20);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Thành tiền";
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvChiTietHD.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5 });
            dgvChiTietHD.Dock = DockStyle.Fill;
            dgvChiTietHD.Location = new Point(500, 0);
            dgvChiTietHD.Margin = new Padding(3, 4, 3, 4);
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvChiTietHD.RowTemplate.Height = 24;
            dgvChiTietHD.Size = new Size(540, 379);
            dgvChiTietHD.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 89;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 57;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thành tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 98;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvSanPham.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Left;
            dgvSanPham.Location = new Point(0, 0);
            dgvSanPham.Margin = new Padding(3, 4, 3, 4);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 24;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(500, 379);
            dgvSanPham.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(nudSoLuong);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnIn);
            panel3.Controls.Add(btnTaoHD);
            panel3.Controls.Add(btnThemSP);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 537);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1040, 161);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 45);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Số lượng";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(15, 70);
            nudSoLuong.Margin = new Padding(3, 4, 3, 4);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(160, 27);
            nudSoLuong.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(224, 224, 224);
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(868, 65);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 36);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu hóa đơn";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(224, 224, 224);
            btnIn.Enabled = false;
            btnIn.Location = new Point(643, 64);
            btnIn.Margin = new Padding(3, 4, 3, 4);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(140, 39);
            btnIn.TabIndex = 2;
            btnIn.Text = "In hóa đơn";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnTaoHD
            // 
            btnTaoHD.BackColor = Color.FromArgb(224, 224, 224);
            btnTaoHD.Enabled = false;
            btnTaoHD.Location = new Point(415, 64);
            btnTaoHD.Margin = new Padding(3, 4, 3, 4);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(140, 39);
            btnTaoHD.TabIndex = 1;
            btnTaoHD.Text = "Tạo hóa đơn";
            btnTaoHD.UseVisualStyleBackColor = false;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // btnThemSP
            // 
            btnThemSP.BackColor = Color.FromArgb(224, 224, 224);
            btnThemSP.Location = new Point(229, 65);
            btnThemSP.Margin = new Padding(3, 4, 3, 4);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(140, 39);
            btnThemSP.TabIndex = 0;
            btnThemSP.Text = "Thêm sản phẩm";
            btnThemSP.UseVisualStyleBackColor = false;
            btnThemSP.Click += btnThemSP_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.PrintToFile = true;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 698);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            WindowState = FormWindowState.Maximized;
            Load += FormHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}