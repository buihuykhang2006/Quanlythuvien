using QuanLyThuVien.Entity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAL
{
    public class DocGiaDAL
    {
        public DataTable LayDanhSach() => SqlHelper.ExecuteQuery("SELECT * FROM DocGia");
        public bool Them(DocGia d)
        {
            string sql = "INSERT INTO DocGia (MaDocGia, HoTen, SoDienThoai, NgayDangKy) VALUES (@ma, @ten, @sdt, @ngay)";
            SqlParameter[] p = {
        new SqlParameter("@ma", d.MaDocGia),
        new SqlParameter("@ten", d.HoTen),
        new SqlParameter("@sdt", d.SoDienThoai),
        new SqlParameter("@ngay", d.NgayDangKy)
    };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public bool Sua(DocGia d)
        {
            string sql = "UPDATE DocGia SET HoTen = @ten, SoDienThoai = @sdt, NgayDangKy = @ngay WHERE MaDocGia = @ma";
            SqlParameter[] p = {
        new SqlParameter("@ma", d.MaDocGia),
        new SqlParameter("@ten", d.HoTen),
        new SqlParameter("@sdt", d.SoDienThoai),
        new SqlParameter("@ngay", d.NgayDangKy)
    };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public bool Xoa(string ma)
        {
            string sql = "DELETE FROM DocGia WHERE MaDocGia = @ma";
            SqlParameter[] p = { new SqlParameter("@ma", ma) };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }
        public DataTable TimKiem(string tuKhoa)
        {
            // Tìm kiếm tương đối theo Mã, Tên hoặc SĐT
            string sql = "SELECT * FROM DocGia WHERE MaDocGia LIKE @tk OR HoTen LIKE @tk OR SoDienThoai LIKE @tk";
            SqlParameter[] p = {
        new SqlParameter("@tk", "%" + tuKhoa + "%")
    };
            return SqlHelper.ExecuteQuery(sql, p);
        }
    }
}


