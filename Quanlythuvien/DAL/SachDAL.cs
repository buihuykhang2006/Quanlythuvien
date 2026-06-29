using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public class SachDAL : ISachDAL
    {
        public DataTable LayDanhSach() => SqlHelper.ExecuteQuery("SELECT * FROM Sach");

        public bool Them(Sach s)
        {
            string sql = "INSERT INTO Sach (MaSach, TenSach, TacGia, NamXuatBan, SoLuong, MaTheLoai) VALUES (@ma, @ten, @tg, @nam, @sl, @matl)";
            SqlParameter[] p = {
                new SqlParameter("@ma", s.MaSach),
                new SqlParameter("@ten", s.TenSach),
                new SqlParameter("@tg", s.TacGia),
                new SqlParameter("@nam", s.NamXuatBan),
                new SqlParameter("@sl", s.SoLuong),
                new SqlParameter("@matl", s.MaTheLoai)
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public bool Sua(Sach s)
        {
            string sql = "UPDATE Sach SET TenSach = @ten, TacGia = @tg, NamXuatBan = @nam, SoLuong = @sl, MaTheLoai = @matl WHERE MaSach = @ma";
            SqlParameter[] p = {
                new SqlParameter("@ma", s.MaSach),
                new SqlParameter("@ten", s.TenSach),
                new SqlParameter("@tg", s.TacGia),
                new SqlParameter("@nam", s.NamXuatBan),
                new SqlParameter("@sl", s.SoLuong),
                new SqlParameter("@matl", s.MaTheLoai)
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public bool Xoa(string ma)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = @ma";
            SqlParameter[] p = { new SqlParameter("@ma", ma) };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }
    }
}
