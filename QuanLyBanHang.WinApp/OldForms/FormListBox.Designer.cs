namespace QuanLyBanHang.WinApp.OldForms
{
    partial class FormListBox
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
            lstSanPham = new ListBox();
            btnThoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstSanPham
            // 
            lstSanPham.FormattingEnabled = true;
            lstSanPham.Location = new Point(73, 99);
            lstSanPham.Margin = new Padding(3, 4, 3, 4);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(706, 444);
            lstSanPham.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(224, 224, 224);
            btnThoat.Location = new Point(372, 585);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(73, 57);
            label1.Name = "label1";
            label1.Size = new Size(169, 16);
            label1.TabIndex = 2;
            label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // FormListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(lstSanPham);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đưa dữ liệu lên ListBox";
            Load += FormListBox_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSanPham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}