using System.Data;
using QuanLyThuVien.Entity;

namespace QuanLyThuVien.DAL
{
    public interface IDocGiaDAL
    {
        DataTable LayDanhSach();
        bool Them(DocGia d);
        bool Sua(DocGia d);
        bool Xoa(string ma);
        DataTable TimKiem(string tuKhoa);
    }
}
