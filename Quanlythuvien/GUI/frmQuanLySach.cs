using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DTO;

namespace Quanlythuvien.GUI // Nhớ đổi tên namespace cho khớp với dự án của ông
{
    public partial class frmQuanLySach : Form
    {
        SachBLL sBLL = new SachBLL();
        TheLoaiBLL tlBLL = new TheLoaiBLL(); // Gọi BLL Thể loại để nạp vào ComboBox

        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }

        // Tuyệt chiêu nạp dữ liệu vào ComboBox
        private void LoadComboBox()
        {
            cboMaTheLoai.DataSource = tlBLL.LayDanhSach();
            cboMaTheLoai.DisplayMember = "TenTheLoai"; // Chữ hiển thị cho người dùng xem
            cboMaTheLoai.ValueMember = "MaTheLoai";    // Giá trị thật (Mã) ẩn bên dưới để lưu vào DB
        }

        private void LoadData()
        {
            dgvDanhSachSach.AutoGenerateColumns = false;
            dgvDanhSachSach.DataSource = sBLL.LayDanhSach();
            lblTongSo.Text = "Tổng số sách: " + dgvDanhSachSach.Rows.Count.ToString();
        }

        // Bắt sự kiện Click vào DataGridView
        private void dgvDanhSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value?.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value?.ToString();

                // Ép kiểu cho NumericUpDown (vì dữ liệu từ DB lên là object)
                if (row.Cells["NamXuatBan"].Value != DBNull.Value)
                    nudNamXB.Value = Convert.ToDecimal(row.Cells["NamXuatBan"].Value);
                if (row.Cells["SoLuong"].Value != DBNull.Value)
                    nudSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);

                // Gán đúng Mã thể loại cho ComboBox để nó tự nhảy sang tên tương ứng
                cboMaTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSach.Text))
                {
                    MessageBox.Show("Mã sách không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SachDTO s = new SachDTO();
                s.MaSach = txtMaSach.Text.Trim();
                s.TenSach = txtTenSach.Text.Trim();
                s.TacGia = txtTacGia.Text.Trim();
                s.NamXuatBan = (int)nudNamXB.Value; // Lấy giá trị int từ NumericUpDown
                s.SoLuong = (int)nudSoLuong.Value;

                // Lấy cái "Mã ẩn" bên dưới ComboBox
                if (cboMaTheLoai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Mã thể loại trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại, không chạy lệnh thêm/sửa bên dưới nữa
                }

                // Nếu đã có giá trị thì mới an toàn lấy dữ liệu
                s.MaTheLoai = cboMaTheLoai.SelectedValue.ToString();

                if (sBLL.Them(s))
                {
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                    MessageBox.Show("Mã sách này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Lỗi Database: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng chọn sách cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SachDTO s = new SachDTO();
                s.MaSach = txtMaSach.Text.Trim();
                s.TenSach = txtTenSach.Text.Trim();
                s.TacGia = txtTacGia.Text.Trim();
                s.NamXuatBan = (int)nudNamXB.Value;
                s.SoLuong = (int)nudSoLuong.Value;
                s.MaTheLoai = cboMaTheLoai.SelectedValue.ToString();

                if (sBLL.Sua(s))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSach.Text)) return;

                if (MessageBox.Show("Bạn có chắc muốn xóa cuốn sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (sBLL.Xoa(txtMaSach.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tự động dọn dẹp các ô nhập liệu sau khi xóa (Thay cho nút Làm mới)
                        txtMaSach.Clear();
                        txtTenSach.Clear();
                        txtTacGia.Clear();
                        nudNamXB.Value = DateTime.Now.Year;
                        nudSoLuong.Value = 0;
                        if (cboMaTheLoai.Items.Count > 0) cboMaTheLoai.SelectedIndex = 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Lỗi 547 chính là mã lỗi dính khóa ngoại (Foreign Key) trong SQL Server
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("Không thể xóa cuốn sách này vì nó đã có dữ liệu trong Phiếu Mượn!\nVui lòng xóa các phiếu mượn liên quan trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi Database: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}