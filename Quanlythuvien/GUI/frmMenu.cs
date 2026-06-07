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
        public Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }
        private void LoadForm(Form frm)
        {
            if (this.pnlBody.Controls.Count > 0)
                this.pnlBody.Controls.RemoveAt(0);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(frm);
            this.pnlBody.Tag = frm;

            frm.BringToFront();
            frm.Show();
        }
        public frmMenu()
        {
            InitializeComponent();
            openChildForm(new frmHome());
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            frmQuanLyDocGia frm = new frmQuanLyDocGia();
            LoadForm(frm);
        }
        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();
            LoadForm(frm);
        }
        private void btnQuanLyTheLoai_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyTheLoai());
            frmQuanLyTheLoai frm = new frmQuanLyTheLoai();
            LoadForm(frm);

        }
        private void btnThongKe_Click(object sender, EventArgs e)
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
