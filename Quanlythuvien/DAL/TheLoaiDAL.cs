using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public class TheLoaiDAL : ITheLoaiDAL
    {
        public DataTable LayDanhSach() => SqlHelper.ExecuteQuery("SELECT * FROM TheLoai");

        public bool Them(TheLoai tl)
        {
            string sql = "INSERT INTO TheLoai (MaTheLoai, TenTheLoai) VALUES (@ma, @ten)";
            SqlParameter[] p = {
                new SqlParameter("@ma", tl.MaTheLoai),
                new SqlParameter("@ten", tl.TenTheLoai)
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public bool Sua(TheLoai tl)
        {
            string sql = "UPDATE TheLoai SET TenTheLoai = @ten WHERE MaTheLoai = @ma";
            SqlParameter[] p = {
                new SqlParameter("@ma", tl.MaTheLoai),
                new SqlParameter("@ten", tl.TenTheLoai)
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public bool Xoa(string ma)
        {
            string sql = "DELETE FROM TheLoai WHERE MaTheLoai = @ma";
            SqlParameter[] p = { new SqlParameter("@ma", ma) };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }
    }
}
