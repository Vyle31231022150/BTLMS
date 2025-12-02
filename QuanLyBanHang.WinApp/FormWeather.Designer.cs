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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTemp.Location = new System.Drawing.Point(400, 320);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(193, 54);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Nhiệt độ: --";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWind.ForeColor = System.Drawing.Color.DimGray;
            this.lblWind.Location = new System.Drawing.Point(408, 380);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(94, 32);
            this.lblWind.TabIndex = 1;
            this.lblWind.Text = "Gió: --";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(410, 420);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(129, 23);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Cập nhật lúc: --";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "HCM",
            "Hà Nội",
            "Đà Nẵng",
            "Khác"});
            this.cmbCity.Location = new System.Drawing.Point(50, 50);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(280, 36);
            this.cmbCity.TabIndex = 3;
            this.cmbCity.Text = "Chọn thành phố...";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.Color.White;
            this.txtLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLat.Location = new System.Drawing.Point(50, 110);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLat.Name = "txtLat";
            this.txtLat.PlaceholderText = "Latitude";
            this.txtLat.Size = new System.Drawing.Size(130, 34);
            this.txtLat.TabIndex = 4;
            // 
            // txtLon
            // 
            this.txtLon.BackColor = System.Drawing.Color.White;
            this.txtLon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLon.Location = new System.Drawing.Point(200, 110);
            this.txtLon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLon.Name = "txtLon";
            this.txtLon.PlaceholderText = "Longitude";
            this.txtLon.Size = new System.Drawing.Size(130, 34);
            this.txtLon.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(50, 170);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(280, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật dữ liệu";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(400, 50);
            this.picIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(250, 250);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLon);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblTemp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thời tiết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormWeather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox picIcon;
    }
}