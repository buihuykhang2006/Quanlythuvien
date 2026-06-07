using System;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace Quanlythuvien.GUI
{
    public partial class frmDangNhap : Form
    {
        private NhanVienBLL bll = new NhanVienBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                System.Drawing.Color.FromArgb(0, 210, 255), // Xanh nhạt
                System.Drawing.Color.FromArgb(0, 86, 179),  // Xanh đậm
                135F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ketQua = bll.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);

            if (ketQua == "Quản lý" || ketQua == "Nhân viên")
            {
                MessageBox.Show("Đăng nhập thành công! Chào mừng " + ketQua);
                frmMenu fMenu = new frmMenu();
                this.Hide();
                fMenu.Show();
            }
            else
            {
                MessageBox.Show(ketQua);
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}