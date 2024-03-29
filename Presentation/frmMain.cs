using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit Quản lý gia phả?", "Quan Ly Gia Pha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void TiepNhanThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiepNhanThanhVien frm = new frmTiepNhanThanhVien();
            frm.ShowDialog();
        }

        private void GhiNhanThanhTichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGhiNhanThanhTich frm = new frmGhiNhanThanhTich();
            frm.ShowDialog();
        }

        private void GhiNhanKetThucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGhiNhanKetThuc frm = new frmGhiNhanKetThuc();
            frm.ShowDialog();
        }

        private void DanhSachThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachThanhVien frm = new frmDanhSachThanhVien();
            frm.ShowDialog();
        }

        private void TangGiamThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTangGiamThanhVien frm = new frmTangGiamThanhVien();
            frm.ShowDialog();
        }
        private void ThanhTichThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhTichThanhVien frm = new frmThanhTichThanhVien();
            frm.ShowDialog();
        }

        private void GiupDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiupDo frm = new frmGiupDo();
            frm.ShowDialog();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

    }
}