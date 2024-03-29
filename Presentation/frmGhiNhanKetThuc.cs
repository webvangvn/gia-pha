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
    public partial class frmGhiNhanKetThuc : Form
    {
        private KetThucBus bus = new KetThucBus();
        public frmGhiNhanKetThuc()
        {
            InitializeComponent();
            ShowForm_NguyenNhan();
            ShowForm_ThanhVien();
        }
        private void Click_Them(object sender, EventArgs e)
        {
            if (textBox_MaPhieuKetThuc.Text == "" || comboBox_TenThanhVien.Text == "")
                MessageBox.Show("Bạn không nhập đủ thông tin cần thiết");
            else
            {
                bus.KetThuc = Get_Form();
                bus.Insert();
                MessageBox.Show("Insert thành công");
                Reset_Form();
            }
        }
        private void Click_Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit Ghi nhận kết thúc?", "Quan Ly Gia Pha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private KetThucDto Get_Form()
        {
            KetThucDto dto = new KetThucDto();
            dto.MaPhieuKetThuc = textBox_MaPhieuKetThuc.Text;
            dto.MaThanhVien = (string)comboBox_TenThanhVien.SelectedValue;
            dto.NgayGioMat = System.Convert.ToDateTime(dateTimePicker_NgayGioMat.Text);
            dto.MaNguyenNhan = (string)comboBox_NguyenNhan.SelectedValue;
            return dto;
        }
        private void Reset_Form()
        {
            if(textBox_MaPhieuKetThuc.Text=="")
                return;
            textBox_MaPhieuKetThuc.Text="";
            comboBox_TenThanhVien.Text="";
        }
        private void ShowForm_NguyenNhan()
        {
            NguyenNhanBus bus= new NguyenNhanBus();
            ArrayList arr = new ArrayList();
            arr = bus.GetDanhSachNguyenNhan();
            comboBox_NguyenNhan.DisplayMember = "TenNguyenNhan";
            comboBox_NguyenNhan.ValueMember = "MaNguyenNhan";
            comboBox_NguyenNhan.DataSource = arr;
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
    }
}