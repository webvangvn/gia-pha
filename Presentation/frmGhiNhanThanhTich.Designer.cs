namespace Presentation
{
    partial class frmGhiNhanThanhTich
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.Button_Them = new System.Windows.Forms.Button();
            this.textBox_MaPhieuThanhTich = new System.Windows.Forms.TextBox();
            this.comboBox_TenThanhVien = new System.Windows.Forms.ComboBox();
            this.comboBox_LoaiThanhTich = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NgayPhatSinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Exit);
            this.groupBox1.Controls.Add(this.Button_Them);
            this.groupBox1.Controls.Add(this.textBox_MaPhieuThanhTich);
            this.groupBox1.Controls.Add(this.comboBox_TenThanhVien);
            this.groupBox1.Controls.Add(this.comboBox_LoaiThanhTich);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayPhatSinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi nhận thành tích";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(232, 232);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 24;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Click_Exit);
            // 
            // Button_Them
            // 
            this.Button_Them.Location = new System.Drawing.Point(91, 232);
            this.Button_Them.Name = "Button_Them";
            this.Button_Them.Size = new System.Drawing.Size(75, 23);
            this.Button_Them.TabIndex = 23;
            this.Button_Them.Text = "Thêm";
            this.Button_Them.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Them.UseVisualStyleBackColor = true;
            this.Button_Them.Click += new System.EventHandler(this.Click_Them);
            // 
            // textBox_MaPhieuThanhTich
            // 
            this.textBox_MaPhieuThanhTich.Location = new System.Drawing.Point(144, 35);
            this.textBox_MaPhieuThanhTich.Name = "textBox_MaPhieuThanhTich";
            this.textBox_MaPhieuThanhTich.Size = new System.Drawing.Size(90, 20);
            this.textBox_MaPhieuThanhTich.TabIndex = 2;
            // 
            // comboBox_TenThanhVien
            // 
            this.comboBox_TenThanhVien.FormattingEnabled = true;
            this.comboBox_TenThanhVien.Location = new System.Drawing.Point(144, 80);
            this.comboBox_TenThanhVien.Name = "comboBox_TenThanhVien";
            this.comboBox_TenThanhVien.Size = new System.Drawing.Size(90, 21);
            this.comboBox_TenThanhVien.TabIndex = 22;
            // 
            // comboBox_LoaiThanhTich
            // 
            this.comboBox_LoaiThanhTich.FormattingEnabled = true;
            this.comboBox_LoaiThanhTich.Location = new System.Drawing.Point(144, 121);
            this.comboBox_LoaiThanhTich.Name = "comboBox_LoaiThanhTich";
            this.comboBox_LoaiThanhTich.Size = new System.Drawing.Size(90, 21);
            this.comboBox_LoaiThanhTich.TabIndex = 21;
            // 
            // dateTimePicker_NgayPhatSinh
            // 
            this.dateTimePicker_NgayPhatSinh.Location = new System.Drawing.Point(144, 171);
            this.dateTimePicker_NgayPhatSinh.Name = "dateTimePicker_NgayPhatSinh";
            this.dateTimePicker_NgayPhatSinh.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker_NgayPhatSinh.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày phát sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại thành tích:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên thành viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã phiếu thành tích:";
            // 
            // frmGhiNhanThanhTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 373);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGhiNhanThanhTich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGhiNhanThanhTich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_TenThanhVien;
        private System.Windows.Forms.ComboBox comboBox_LoaiThanhTich;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayPhatSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaPhieuThanhTich;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button Button_Them;



    }
}