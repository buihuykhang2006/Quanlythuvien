using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlythuvien.GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            frmQuanLyDocGia frm = new frmQuanLyDocGia();
            frm.ShowDialog();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();
            frm.ShowDialog();
        }

        private void btnQuanLyTheLoai_Click(object sender, EventArgs e)
        {
            frmQuanLyTheLoai frm = new frmQuanLyTheLoai();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
