namespace QuanLyBanHang.WinApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSidebar = new Panel();
            btnThoat = new Button();
            btnAbout = new Button();
            btnHoaDon = new Button();
            btnThoiTiet = new Button();
            btnSanPham = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelHeader = new Panel();
            lblTitle = new Label();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            lblTemp = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(51, 51, 76);
            panelSidebar.Controls.Add(btnThoat);
            panelSidebar.Controls.Add(btnAbout);
            panelSidebar.Controls.Add(btnHoaDon);
            panelSidebar.Controls.Add(btnThoiTiet);
            panelSidebar.Controls.Add(btnSanPham);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4, 4, 4, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(275, 941);
            panelSidebar.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Bottom;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.ForeColor = Color.Gainsboro;
            btnThoat.Image = Properties.Resources.T;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(0, 866);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(15, 0, 0, 0);
            btnThoat.Size = new Size(275, 75);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "  Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 10F);
            btnAbout.ForeColor = Color.Gainsboro;
            btnAbout.Image = Properties.Resources.GT;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 499);
            btnAbout.Margin = new Padding(4, 4, 4, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(15, 0, 0, 0);
            btnAbout.Size = new Size(275, 122);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "  Giới thiệu (About)";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 10F);
            btnHoaDon.ForeColor = Color.Gainsboro;
            btnHoaDon.Image = Properties.Resources.HD;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 362);
            btnHoaDon.Margin = new Padding(4, 4, 4, 4);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(15, 0, 0, 0);
            btnHoaDon.Size = new Size(275, 137);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "  Lập Hóa Đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoiTiet
            // 
            btnThoiTiet.Dock = DockStyle.Top;
            btnThoiTiet.FlatAppearance.BorderSize = 0;
            btnThoiTiet.FlatStyle = FlatStyle.Flat;
            btnThoiTiet.Font = new Font("Segoe UI", 10F);
            btnThoiTiet.ForeColor = Color.Gainsboro;
            btnThoiTiet.Image = Properties.Resources.sun;
            btnThoiTiet.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoiTiet.Location = new Point(0, 237);
            btnThoiTiet.Margin = new Padding(4, 4, 4, 4);
            btnThoiTiet.Name = "btnThoiTiet";
            btnThoiTiet.Padding = new Padding(15, 0, 0, 0);
            btnThoiTiet.Size = new Size(275, 125);
            btnThoiTiet.TabIndex = 2;
            btnThoiTiet.Text = "  Tra cứu Thời tiết";
            btnThoiTiet.TextAlign = ContentAlignment.MiddleLeft;
            btnThoiTiet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoiTiet.UseVisualStyleBackColor = true;
            // 
            // btnSanPham
            // 
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 10F);
            btnSanPham.ForeColor = Color.Gainsboro;
            btnSanPham.Image = Properties.Resources.SP;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 100);
            btnSanPham.Margin = new Padding(4, 4, 4, 4);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(15, 0, 0, 0);
            btnSanPham.Size = new Size(275, 137);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "  Quản lý Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 4, 4, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(275, 100);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogo.ForeColor = Color.LightGray;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(275, 100);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "QUẢN LÝ\r\nBÁN HÀNG";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(275, 0);
            panelHeader.Margin = new Padding(4, 4, 4, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1577, 100);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1577, 100);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANG CHỦ HỆ THỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser, lblTime, lblTemp });
            statusStrip1.Location = new Point(275, 909);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1577, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.Transparent;
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(57, 25);
            lblUser.Text = "Guest";
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.Transparent;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(44, 25);
            lblTime.Text = "--:--";
            // 
            // lblTemp
            // 
            lblTemp.BackColor = Color.Transparent;
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(93, 25);
            lblTemp.Text = "Nhiệt độ...";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 941);
            Controls.Add(statusStrip1);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            IsMdiContainer = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản Lý Bán Hàng - Modern UI";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnThoiTiet;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblTemp;
        private System.Windows.Forms.Timer timer;
    }
}