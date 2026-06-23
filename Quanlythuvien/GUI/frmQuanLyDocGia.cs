using System;
using System.Windows.Forms;
using QuanLyThuVien.DAL;
using QuanLyThuVien.Entity;
using System.Data.SqlClient;
namespace Quanlythuvien.GUI;

public partial class frmQuanLyDocGia : Form
{
    DocGiaDAL dgDAL = new DocGiaDAL();

    public frmQuanLyDocGia()
    {
        InitializeComponent();
    }

    private void frmQuanLyDocGia_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        // Tắt chế độ tự sinh cột rác
        dgvDocGia.AutoGenerateColumns = false;
        dgvDocGia.DataSource = dgDAL.LayDanhSach();
    }

    private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];

            // Tên trong ngoặc vuông [] PHẢI KHỚP với tên DataPropertyName ông đã set
            txtMaDocGia.Text = row.Cells["MaDocGia"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();

            if (row.Cells["NgayDangKy"].Value != DBNull.Value && row.Cells["NgayDangKy"].Value != null)
            {
                dtpNgayDangKy.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);
            }
        }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Mã độc giả không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DocGia d = new DocGia();
            d.MaDocGia = txtMaDocGia.Text.Trim();
            d.HoTen = txtHoTen.Text.Trim();
            d.SoDienThoai = txtSoDienThoai.Text.Trim();
            d.NgayDangKy = dtpNgayDangKy.Value;

            if (dgDAL.Them(d))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }
        catch (SqlException sqlex)
        {
            if (sqlex.Number == 2627)
                MessageBox.Show("Mã độc giả này đã tồn tại! Vui lòng nhập mã khác.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Lỗi Database: " + sqlex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DocGia d = new DocGia();
            d.MaDocGia = txtMaDocGia.Text.Trim();
            d.HoTen = txtHoTen.Text.Trim();
            d.SoDienThoai = txtSoDienThoai.Text.Trim();
            d.NgayDangKy = dtpNgayDangKy.Value;

            if (dgDAL.Sua(d))
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi sửa: " + ex.Message);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Ông có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (dr == DialogResult.Yes)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (dgDAL.Xoa(txtMaDocGia.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        // Lấy từ khóa từ ô TextBox tìm kiếm (giả sử tên là txtTuKhoa)
        string tuKhoa = txtTuKhoa.Text.Trim();
        dgvDocGia.DataSource = dgDAL.TimKiem(tuKhoa);
    }

    private void txtMaDocGia_TextChanged(object sender, EventArgs e)
    {

    }
}







