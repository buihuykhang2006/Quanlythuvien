using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Bắt lỗi SQL
using QuanLyThuVien.DAL;
using QuanLyThuVien.Entity;

namespace Quanlythuvien.GUI // Nhớ đổi tên namespace cho khớp với project của ông nếu cần
{
    public partial class frmQuanLyTheLoai : Form
    {
        TheLoaiDAL tlDAL = new TheLoaiDAL();

        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void frmQuanLyTheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm tải dữ liệu và đếm tổng số
        private void LoadData()
        {
            dgvTheLoai.AutoGenerateColumns = false; // Tắt tự sinh cột
            dgvTheLoai.DataSource = tlDAL.LayDanhSach();

            // Cập nhật cái nhãn Tổng số lượng
            lblTongSo.Text = "Tổng số loại: " + dgvTheLoai.Rows.Count.ToString();
        }

        // Click vào bảng nhảy dữ liệu lên TextBox
        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTheLoai.Rows[e.RowIndex];
                txtMaTheLoai.Text = row.Cells["MaTheLoai"].Value?.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString();
            }
        }

        // Nút Thêm Mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (string.IsNullOrWhiteSpace(txtMaTheLoai.Text))
                {
                    MessageBox.Show("Mã thể loại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TheLoai tl = new TheLoai();
                tl.MaTheLoai = txtMaTheLoai.Text.Trim();
                tl.TenTheLoai = txtTenTheLoai.Text.Trim();

                if (tlDAL.Them(tl))
                {
                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                    MessageBox.Show("Mã thể loại này đã tồn tại! Vui lòng nhập mã khác.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Lỗi Database: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (string.IsNullOrWhiteSpace(txtMaTheLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn một thể loại từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TheLoai tl = new TheLoai();
                tl.MaTheLoai = txtMaTheLoai.Text.Trim();
                tl.TenTheLoai = txtTenTheLoai.Text.Trim();

                if (tlDAL.Sua(tl))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (string.IsNullOrWhiteSpace(txtMaTheLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn thể loại cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show("Ông có chắc chắn muốn xóa thể loại này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (tlDAL.Xoa(txtMaTheLoai.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xóa trắng 2 ô TextBox thay vì gọi nút Làm mới
                        txtMaTheLoai.Clear();
                        txtTenTheLoai.Clear();

                        LoadData();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Bắt lỗi khóa ngoại (Foreign Key) nếu thể loại này đã có sách
                if (sqlEx.Number == 547)
                    MessageBox.Show("Không thể xóa vì đang có sách thuộc thể loại này!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Lỗi Database: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaTheLoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





