namespace Presentation
{
    partial class frmGhiNhanKetThuc
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
            this.comboBox_TenThanhVien = new System.Windows.Forms.ComboBox();
            this.textBox_MaPhieuKetThuc = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.dateTimePicker_NgayGioMat = new System.Windows.Forms.DateTimePicker();
            this.comboBox_NguyenNhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_TenThanhVien);
            this.groupBox1.Controls.Add(this.textBox_MaPhieuKetThuc);
            this.groupBox1.Controls.Add(this.button_Exit);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayGioMat);
            this.groupBox1.Controls.Add(this.comboBox_NguyenNhan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu kết thúc";
            // 
            // comboBox_TenThanhVien
            // 
            this.comboBox_TenThanhVien.FormattingEnabled = true;
            this.comboBox_TenThanhVien.Location = new System.Drawing.Point(154, 96);
            this.comboBox_TenThanhVien.Name = "comboBox_TenThanhVien";
            this.comboBox_TenThanhVien.Size = new System.Drawing.Size(186, 21);
            this.comboBox_TenThanhVien.TabIndex = 12;
            // 
            // textBox_MaPhieuKetThuc
            // 
            this.textBox_MaPhieuKetThuc.Location = new System.Drawing.Point(154, 57);
            this.textBox_MaPhieuKetThuc.Name = "textBox_MaPhieuKetThuc";
            this.textBox_MaPhieuKetThuc.Size = new System.Drawing.Size(109, 20);
            this.textBox_MaPhieuKetThuc.TabIndex = 11;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(215, 235);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 9;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Click_Exit);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(78, 235);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.Click_Them);
            // 
            // dateTimePicker_NgayGioMat
            // 
            this.dateTimePicker_NgayGioMat.Location = new System.Drawing.Point(154, 131);
            this.dateTimePicker_NgayGioMat.Name = "dateTimePicker_NgayGioMat";
            this.dateTimePicker_NgayGioMat.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker_NgayGioMat.TabIndex = 7;
            // 
            // comboBox_NguyenNhan
            // 
            this.comboBox_NguyenNhan.FormattingEnabled = true;
            this.comboBox_NguyenNhan.Location = new System.Drawing.Point(154, 169);
            this.comboBox_NguyenNhan.Name = "comboBox_NguyenNhan";
            this.comboBox_NguyenNhan.Size = new System.Drawing.Size(109, 21);
            this.comboBox_NguyenNhan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nguyên nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày giờ mất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thành viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu kết thúc:";
            // 
            // frmGhiNhanKetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGhiNhanKetThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGhiNhanKetThuc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayGioMat;
        private System.Windows.Forms.ComboBox comboBox_NguyenNhan;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_MaPhieuKetThuc;
        private System.Windows.Forms.ComboBox comboBox_TenThanhVien;


    }
}