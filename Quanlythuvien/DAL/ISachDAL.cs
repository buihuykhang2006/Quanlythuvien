using System.Data;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public interface ISachDAL
    {
        DataTable LayDanhSach();
        bool Them(Sach s);
        bool Sua(Sach s);
        bool Xoa(string ma);
    }
}
