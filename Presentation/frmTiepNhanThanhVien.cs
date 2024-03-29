using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Presentation
{
    public partial class frmTiepNhanThanhVien : Form
    {
        ThanhVienBus thanhvien = new ThanhVienBus();
        public frmTiepNhanThanhVien()
        {
            InitializeComponent();
            ShowForm_QueQuan();
            ShowForm_LoaiQuanHe();
            ShowForm_NgheNghiep();
        }
        private void button_Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit Tiếp nhận thành viên?", "Quan Ly Gia Pha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void button_Them(object sender, EventArgs e)
        {
            if (textBox_thanhviencu.Text == "" || comboBox_gioitinh.Text=="" || textBox_doi.Text=="" || textBox_chame.Text=="" ||textBox_hovaten.Text=="" || textBox_diachi.Text=="")
                MessageBox.Show("Chưa nhập đủ thông tin cần thiết!");
            else
            {
                thanhvien.ThanhVien = GetForm_TiepNhanThanhVien();
                thanhvien.Insert();
                MessageBox.Show("Insert du lieu thanh cong");
                ResetForm();
            }
            
        }
        private ThanhVienDto GetForm_TiepNhanThanhVien()
        {
            ThanhVienDto tv = new ThanhVienDto();
            tv.MaThanhVien = textBox_mathanhvien.Text;
            tv.ThanhVienCu = textBox_thanhviencu.Text;
            tv.NgayPhatSinh = System.Convert.ToDateTime(dateTimePicker_ngayphatsinh.Text);
            tv.GioiTinh = comboBox_gioitinh.Text;
            tv.MaQueQuan = (string)comboBox_maquequan.SelectedValue;
            tv.Doi = textBox_doi.Text;
            tv.ChaMe = textBox_chame.Text;
            tv.MaLoaiQuanHe = (string)comboBox_maloaiquanhe.SelectedValue;
            tv.HoVaTen = textBox_hovaten.Text;
            tv.NgayGioSinh = System.Convert.ToDateTime(dateTimePicker_ngaysinh.Text);
            tv.MaNgheNghiep =(string)comboBox_manghenghiep.SelectedValue;
            tv.DiaChi = textBox_diachi.Text;
            return tv;
        }
        private void ShowForm_QueQuan()
        {
            QueQuanBus bus = new QueQuanBus();
            ArrayList arr=new ArrayList();
            arr = bus.GetDanhSachQueQuan();
            comboBox_maquequan.DisplayMember = "TenQueQuan";
            comboBox_maquequan.ValueMember = "MaQueQuan";
            comboBox_maquequan.DataSource = arr;
        }
        private void ShowForm_LoaiQuanHe()
        {
            ArrayList arr = new ArrayList();
            LoaiQuanHeBus bus = new LoaiQuanHeBus();
            arr = bus.GetDanhSachLoaiQuanHe();
            comboBox_maloaiquanhe.DisplayMember = "TenLoaiQuanHe";
            comboBox_maloaiquanhe.ValueMember = "MaLoaiQuanHe";
            comboBox_maloaiquanhe.DataSource = arr;
        }
        private void ShowForm_NgheNghiep()
        {
            ArrayList arr = new ArrayList();
            NgheNghiepBus bus = new NgheNghiepBus();
            arr = bus.GetDanhSachNgheNghiep();
            comboBox_manghenghiep.DisplayMember = "TenNgheNghiep";
            comboBox_manghenghiep.ValueMember = "MaNgheNghiep";
            comboBox_manghenghiep.DataSource = arr;
        }
        private void ResetForm()
        {
            if (textBox_mathanhvien.Text == "")
                return;
            textBox_mathanhvien.Text = "";
            textBox_thanhviencu.Text = "";
            textBox_doi.Text = "";
            textBox_chame.Text = "";
            textBox_hovaten.Text = "";
            textBox_diachi.Text = "";
        }
    }
}