using System.Data;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAL
{
    public class NhanVienDAL
    {
        public string KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            string query = string.Format("SELECT QuyenHan FROM NhanVien WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'", taiKhoan, matKhau);
            DataTable dt = SqlHelper.ExecuteQuery(query);
            if (dt.Rows.Count > 0) return dt.Rows[0]["QuyenHan"].ToString();
            return "";
        }

        public bool KiemTraTrungTaiKhoan(string tenDangNhap)
        {
            string query = string.Format("SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = '{0}'", tenDangNhap);
            DataTable dt = SqlHelper.ExecuteQuery(query);
            return int.Parse(dt.Rows[0][0].ToString()) > 0;
        }

        public bool DangKy(NhanVienDTO nv)
        {
            string query = string.Format("INSERT INTO NhanVien VALUES ('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}')",
                nv.MaNhanVien, nv.HoTen, nv.SoDienThoai, nv.QuyenHan, nv.TenDangNhap, nv.MatKhau);
            return SqlHelper.ExecuteNonQuery(query);
        }
    }
}
