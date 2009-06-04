using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
namespace Presentation
{
    public partial class frmDanhSachThanhVien : Form
    {
        public frmDanhSachThanhVien()
        {
            InitializeComponent();
            View_dataGridView();
        }

        private void View_dataGridView()
        {
            ThanhVienBus bus = new ThanhVienBus();
            ArrayList arr = new ArrayList();
            arr = bus.GetDanhSachThanhVien();
            dataGridView_ThanhVien.DataSource = arr;
        }
        private void Click_Insert(object sender, EventArgs e)
        {
            frmTiepNhanThanhVien frm = new frmTiepNhanThanhVien();
            frmDanhSachThanhVien frm1 = new frmDanhSachThanhVien();
            frm.ShowDialog();
            View_dataGridView();
            
        }

        private void Click_Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit Xem danh sách thành viên?", "Quan Ly Gia Pha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void dataGridView_ThanhVien_SelectionChanged(object sender, EventArgs e)
        {
            string str=dataGridView_ThanhVien.CurrentRow.Cells[0].Value.ToString();
            ThanhVienBus bus = new ThanhVienBus();
            bus.GetThanhVien(str);
            //MessageBox.Show(str);
        }
        private void Update_Click(object sender, EventArgs e)
        {
            frmCapNhapThanhVien frm = new frmCapNhapThanhVien();
            frm.ShowDialog();
        }

        private void Click_Delete(object sender, EventArgs e)
        {
            ThanhVienBus bus = new ThanhVienBus();
            ThanhVienDto dto=new ThanhVienDto();
            string str=dataGridView_ThanhVien.CurrentRow.Cells[0].Value.ToString();
            dto=bus.GetThanhVien(str);
            bus.ThanhVien = dto;
            DialogResult result = MessageBox.Show("Do you really want to Delete?", "Quan Ly Gia Pha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                  bus.Delete();
        }

      }
}