namespace QuanLyBanHang.WinApp

{
    partial class FormWeather
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
            lblTemp = new Label();
            lblWind = new Label();
            lblTime = new Label();
            cmbCity = new ComboBox();
            txtLat = new TextBox();
            txtLon = new TextBox();
            btnUpdate = new Button();
            picIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(366, 161);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(70, 20);
            lblTemp.TabIndex = 0;
            lblTemp.Text = "Nhiệt độ:";
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Location = new Point(366, 214);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(35, 20);
            lblWind.TabIndex = 1;
            lblWind.Text = "Gió:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(366, 265);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(94, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "Cập nhật lúc:";
            // 
            // cmbCity
            // 
            cmbCity.BackColor = Color.FromArgb(224, 224, 224);
            cmbCity.FormattingEnabled = true;
            cmbCity.Items.AddRange(new object[] { "HCM", "Hà Nội", "Đà Nẵng", "Khác" });
            cmbCity.Location = new Point(124, 161);
            cmbCity.Margin = new Padding(3, 4, 3, 4);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(149, 28);
            cmbCity.TabIndex = 3;
            // 
            // txtLat
            // 
            txtLat.BackColor = Color.FromArgb(224, 224, 224);
            txtLat.Location = new Point(124, 225);
            txtLat.Margin = new Padding(3, 4, 3, 4);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(149, 27);
            txtLat.TabIndex = 4;
            // 
            // txtLon
            // 
            txtLon.BackColor = Color.FromArgb(224, 224, 224);
            txtLon.Location = new Point(124, 281);
            txtLon.Margin = new Padding(3, 4, 3, 4);
            txtLon.Name = "txtLon";
            txtLon.Size = new Size(149, 27);
            txtLon.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Location = new Point(122, 350);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật lại dữ liệu";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // picIcon
            // 
            picIcon.Location = new Point(596, 147);
            picIcon.Margin = new Padding(3, 4, 3, 4);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(283, 312);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 7;
            picIcon.TabStop = false;
            // 
            // FormWeather
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(picIcon);
            Controls.Add(btnUpdate);
            Controls.Add(txtLon);
            Controls.Add(txtLat);
            Controls.Add(cmbCity);
            Controls.Add(lblTime);
            Controls.Add(lblWind);
            Controls.Add(lblTemp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormWeather";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tra cứu thời tiết";
            WindowState = FormWindowState.Maximized;
            Load += FormWeather_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblTemp;
        private Label lblWind;
        private Label lblTime;
        private ComboBox cmbCity;
        private TextBox txtLat;
        private TextBox txtLon;
        private Button btnUpdate;
        private PictureBox picIcon;
    }
}

