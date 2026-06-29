using System.Data;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public interface ITheLoaiDAL
    {
        DataTable LayDanhSach();
        bool Them(TheLoai tl);
        bool Sua(TheLoai tl);
        bool Xoa(string ma);
    }
}
