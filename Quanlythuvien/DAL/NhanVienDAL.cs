using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public class NhanVienDAL : INhanVienDAL
    {
        public string KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT QuyenHan FROM NhanVien WHERE TenDangNhap = @tk AND MatKhau = @mk";
            SqlParameter[] p = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau)
            };

            DataTable dt = SqlHelper.ExecuteQuery(query, p);
            if (dt.Rows.Count > 0) return dt.Rows[0]["QuyenHan"].ToString();
            return "";
        }

        public bool KiemTraTrungTaiKhoan(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @tk";
            SqlParameter[] p = { new SqlParameter("@tk", tenDangNhap) };

            DataTable dt = SqlHelper.ExecuteQuery(query, p);
            return int.Parse(dt.Rows[0][0].ToString()) > 0;
        }

        public bool DangKy(NhanVien nv)
        {
            string query = @"INSERT INTO NhanVien (MaNhanVien, HoTen, SoDienThoai, QuyenHan, TenDangNhap, MatKhau) 
                             VALUES (@ma, @ten, @sdt, @quyen, @tk, @mk)";

            SqlParameter[] p = {
                new SqlParameter("@ma", nv.MaNhanVien),
                new SqlParameter("@ten", nv.HoTen),
                new SqlParameter("@sdt", nv.SoDienThoai),
                new SqlParameter("@quyen", nv.QuyenHan),
                new SqlParameter("@tk", nv.TenDangNhap),
                new SqlParameter("@mk", nv.MatKhau)
            };

            return SqlHelper.ExecuteNonQuery(query, p);
        }
    }
}
