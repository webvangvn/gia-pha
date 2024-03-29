using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
namespace Presentation
{
    public partial class frmGhiNhanThanhTich : Form
    {
        private ThanhTichBus bus = new ThanhTichBus();
        public frmGhiNhanThanhTich()
        {
            InitializeComponent();
            ShowForm_ThanhVien();
            ShowForm_ThanhTich();
        }

        private void Click_Them(object sender, EventArgs e)
        {
            if (textBox_MaPhieuThanhTich.Text == "")
                MessageBox.Show("Chưa nhập đủ thông tin cần thiết");
            else
            {
                bus.ThanhTich = Get_Form();
                bus.Insert();
                MessageBox.Show("Insert thành công");
                Reset_Form();
            }
        }
        private void Click_Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit Ghi nhận thành tích?", "Quan Ly Gia Pha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void Reset_Form()
        {
            if (textBox_MaPhieuThanhTich.Text == "")
                return;
            textBox_MaPhieuThanhTich.Text = "";
        }
        private ThanhTichDto Get_Form()
        {
            ThanhTichDto dto = new ThanhTichDto();
            dto.MaPhieuThanhTich = textBox_MaPhieuThanhTich.Text;
            dto.MaThanhVien = (string)comboBox_TenThanhVien.SelectedValue;
            dto.MaLoaiThanhTich = (string)comboBox_LoaiThanhTich.SelectedValue;
            dto.NgayPhatSinh = System.Convert.ToDateTime(dateTimePicker_NgayPhatSinh.Text);
            return dto;

        }
        private void ShowForm_ThanhVien()
        {
            
            ThanhVienBus bus = new ThanhVienBus();
            ArrayList arr = new ArrayList();
            arr = bus.GetDanhSachThanhVien();
            comboBox_TenThanhVien.DisplayMember = "HoVaTen";
            comboBox_TenThanhVien.ValueMember = "MaThanhVien";
            comboBox_TenThanhVien.DataSource = arr;
        }
        private void ShowForm_ThanhTich()
        {
            LoaiThanhTichBus bus = new LoaiThanhTichBus();
            ArrayList arr = new ArrayList();
            arr = bus.GetDanhSachLoaiThanhTich();
            comboBox_LoaiThanhTich.DisplayMember = "TenLoaiThanhTich";
            comboBox_LoaiThanhTich.ValueMember = "MaLoaiThanhTich";
            comboBox_LoaiThanhTich.DataSource = arr;
        }
    }
}