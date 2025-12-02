namespace QuanLyBanHang.WinApp.OldForms
{
    partial class FormAbout
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
            btnThoat = new Button();
            panelContent = new Panel();
            lblClass = new Label();
            lblMSSV = new Label();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = Color.FromArgb(255, 87, 34);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(536, 725);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.None;
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Controls.Add(lblClass);
            panelContent.Controls.Add(lblMSSV);
            panelContent.Controls.Add(lblName);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Location = new Point(290, 160);
            panelContent.Margin = new Padding(4, 4, 4, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(646, 500);
            panelContent.TabIndex = 6;
            // 
            // lblClass
            // 
            lblClass.Dock = DockStyle.Top;
            lblClass.Font = new Font("Segoe UI", 12F);
            lblClass.Location = new Point(0, 350);
            lblClass.Margin = new Padding(4, 0, 4, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(644, 75);
            lblClass.TabIndex = 3;
            lblClass.Text = "Sinh viên lớp học phần Sáng thứ 4 Desktop";
            lblClass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMSSV
            // 
            lblMSSV.Dock = DockStyle.Top;
            lblMSSV.Font = new Font("Segoe UI", 12F);
            lblMSSV.Location = new Point(0, 275);
            lblMSSV.Margin = new Padding(4, 0, 4, 0);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(644, 75);
            lblMSSV.TabIndex = 2;
            lblMSSV.Text = "MSSV: 31231022150";
            lblMSSV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(51, 51, 76);
            lblName.Location = new Point(0, 200);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(644, 75);
            lblName.TabIndex = 1;
            lblName.Text = "LÊ THANH VY";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.iconNV;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(644, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 150, 136);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1228, 125);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN TÁC GIẢ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1228, 816);
            Controls.Add(panelContent);
            Controls.Add(btnThoat);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            WindowState = FormWindowState.Maximized;
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label lblTitle;
    }
}