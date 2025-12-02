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
            menuStrip1 = new MenuStrip();
            hethong = new ToolStripMenuItem();
            dangNhapToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            tuHocLMSToolStripMenuItem = new ToolStripMenuItem();
            quanLySanPhamToolStripMenuItem = new ToolStripMenuItem();
            traCuuThoiTietToolStripMenuItem = new ToolStripMenuItem();
            baiTapCuToolStripMenuItem = new ToolStripMenuItem();
            mayTinhToolStripMenuItem = new ToolStripMenuItem();
            listBoxDemoToolStripMenuItem = new ToolStripMenuItem();
            treeViewToolStripMenuItem = new ToolStripMenuItem();
            hoaDonToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            lblTemp = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hethong, tuHocLMSToolStripMenuItem, baiTapCuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1482, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hethong
            // 
            hethong.DropDownItems.AddRange(new ToolStripItem[] { dangNhapToolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            hethong.Name = "hethong";
            hethong.Size = new Size(85, 24);
            hethong.Text = "Hệ thống";
            // 
            // dangNhapToolStripMenuItem
            // 
            dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            dangNhapToolStripMenuItem.Size = new Size(165, 26);
            dangNhapToolStripMenuItem.Text = "Đăng nhập";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(165, 26);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(165, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            // 
            // tuHocLMSToolStripMenuItem
            // 
            tuHocLMSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quanLySanPhamToolStripMenuItem, traCuuThoiTietToolStripMenuItem });
            tuHocLMSToolStripMenuItem.Name = "tuHocLMSToolStripMenuItem";
            tuHocLMSToolStripMenuItem.Size = new Size(100, 24);
            tuHocLMSToolStripMenuItem.Text = "Tự học LMS";
            // 
            // quanLySanPhamToolStripMenuItem
            // 
            quanLySanPhamToolStripMenuItem.Name = "quanLySanPhamToolStripMenuItem";
            quanLySanPhamToolStripMenuItem.Size = new Size(212, 26);
            quanLySanPhamToolStripMenuItem.Text = "Quản lý Sản phẩm";
            // 
            // traCuuThoiTietToolStripMenuItem
            // 
            traCuuThoiTietToolStripMenuItem.Name = "traCuuThoiTietToolStripMenuItem";
            traCuuThoiTietToolStripMenuItem.Size = new Size(212, 26);
            traCuuThoiTietToolStripMenuItem.Text = "Tra cứu Thời tiết";
            // 
            // baiTapCuToolStripMenuItem
            // 
            baiTapCuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mayTinhToolStripMenuItem, listBoxDemoToolStripMenuItem, treeViewToolStripMenuItem, hoaDonToolStripMenuItem });
            baiTapCuToolStripMenuItem.Name = "baiTapCuToolStripMenuItem";
            baiTapCuToolStripMenuItem.Size = new Size(89, 24);
            baiTapCuToolStripMenuItem.Text = "Bài tập cũ";
            // 
            // mayTinhToolStripMenuItem
            // 
            mayTinhToolStripMenuItem.Name = "mayTinhToolStripMenuItem";
            mayTinhToolStripMenuItem.Size = new Size(184, 26);
            mayTinhToolStripMenuItem.Text = "Máy tính";
            // 
            // listBoxDemoToolStripMenuItem
            // 
            listBoxDemoToolStripMenuItem.Name = "listBoxDemoToolStripMenuItem";
            listBoxDemoToolStripMenuItem.Size = new Size(184, 26);
            listBoxDemoToolStripMenuItem.Text = "ListBox Demo";
            // 
            // treeViewToolStripMenuItem
            // 
            treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            treeViewToolStripMenuItem.Size = new Size(184, 26);
            treeViewToolStripMenuItem.Text = "TreeView";
            // 
            // hoaDonToolStripMenuItem
            // 
            hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            hoaDonToolStripMenuItem.Size = new Size(184, 26);
            hoaDonToolStripMenuItem.Text = "Hóa đơn";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton5, toolStripButton6, toolStripButton7 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1482, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.GT;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "AboutUS";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.T;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 24);
            toolStripButton5.Text = "Thoát";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = Properties.Resources.SP;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 24);
            toolStripButton6.Text = "Sản phẩm";
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = Properties.Resources.sun;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(29, 24);
            toolStripButton7.Text = "Thời tiết";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser, lblTime, lblTemp });
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1482, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(46, 20);
            lblUser.Text = "Guest";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(36, 20);
            lblTime.Text = "--:--";
            // 
            // lblTemp
            // 
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(76, 20);
            lblTemp.Text = "Nhiệt độ...";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hethong;
        private ToolStripMenuItem dangNhapToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem baiTapCuToolStripMenuItem;
        private ToolStripMenuItem tuHocLMSToolStripMenuItem;
        private ToolStripMenuItem quanLySanPhamToolStripMenuItem;
        private ToolStripMenuItem traCuuThoiTietToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblTemp;
        private ToolStripMenuItem mayTinhToolStripMenuItem;
        private ToolStripMenuItem listBoxDemoToolStripMenuItem;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private System.Windows.Forms.Timer timer;
        private ToolStripMenuItem treeViewToolStripMenuItem;
        private ToolStripMenuItem hoaDonToolStripMenuItem;
    }
}
