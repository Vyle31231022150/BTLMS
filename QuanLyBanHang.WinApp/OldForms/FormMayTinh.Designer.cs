namespace QuanLyBanHang.WinApp.OldForms
{
    partial class FormMayTinh
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
            label1 = new Label();
            label2 = new Label();
            txtInput = new TextBox();
            txtResult = new TextBox();
            label3 = new Label();
            btnCong = new Button();
            tnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnDel = new Button();
            txtInput1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 52);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 101);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(224, 224, 224);
            txtInput.Location = new Point(148, 48);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(221, 27);
            txtInput.TabIndex = 2;
            txtInput.TextAlign = HorizontalAlignment.Right;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(224, 224, 224);
            txtResult.Location = new Point(148, 216);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(221, 27);
            txtResult.TabIndex = 4;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 219);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // btnCong
            // 
            btnCong.Location = new Point(41, 154);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(33, 29);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // tnTru
            // 
            tnTru.Location = new Point(98, 154);
            tnTru.Name = "tnTru";
            tnTru.Size = new Size(33, 29);
            tnTru.TabIndex = 7;
            tnTru.Text = "-";
            tnTru.UseVisualStyleBackColor = true;
            tnTru.Click += tnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(160, 154);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(33, 29);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(223, 154);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(33, 29);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(289, 154);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(78, 29);
            btnDel.TabIndex = 10;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txtInput1
            // 
            txtInput1.BackColor = Color.FromArgb(224, 224, 224);
            txtInput1.Location = new Point(148, 94);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(221, 27);
            txtInput1.TabIndex = 11;
            txtInput1.TextAlign = HorizontalAlignment.Right;
            txtInput1.KeyPress += txtInput1_KeyPress;
            // 
            // FormMayTinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 327);
            Controls.Add(txtInput1);
            Controls.Add(btnDel);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(tnTru);
            Controls.Add(btnCong);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMayTinh";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính bỏ túi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInput;
        private TextBox txtResult;
        private Label label3;
        private Button btnCong;
        private Button tnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnDel;
        private TextBox txtInput1;
    }
}
