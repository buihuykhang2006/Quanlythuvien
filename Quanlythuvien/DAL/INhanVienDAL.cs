using System.Data;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public interface INhanVienDAL
    {
        string KiemTraDangNhap(string taiKhoan, string matKhau);
        bool KiemTraTrungTaiKhoan(string tenDangNhap);
        bool DangKy(NhanVien nv);
    }
}
