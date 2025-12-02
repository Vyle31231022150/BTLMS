namespace QuanLyBanHang.WinApp.OldForms
{
    partial class FormTreeView
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
            trvLoaiSP = new TreeView();
            dgvSanPham = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // trvLoaiSP
            // 
            trvLoaiSP.BackColor = Color.FromArgb(224, 224, 224);
            trvLoaiSP.Location = new Point(81, 101);
            trvLoaiSP.Margin = new Padding(3, 4, 3, 4);
            trvLoaiSP.Name = "trvLoaiSP";
            trvLoaiSP.Size = new Size(249, 460);
            trvLoaiSP.TabIndex = 0;
            trvLoaiSP.AfterSelect += trvLoaiSP_AfterSelect;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(365, 101);
            dgvSanPham.Margin = new Padding(3, 4, 3, 4);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 24;
            dgvSanPham.Size = new Size(548, 461);
            dgvSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 55);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Kết quả";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(224, 224, 224);
            btnThoat.Location = new Point(384, 594);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // FormTreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSanPham);
            Controls.Add(trvLoaiSP);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTreeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TreeView và DataGridView";
            WindowState = FormWindowState.Maximized;
            Load += FormTreeView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvLoaiSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
    }
}