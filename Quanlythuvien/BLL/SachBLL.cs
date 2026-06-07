using System.Data;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BLL
{
    public class SachBLL
    {
        SachDAL dal = new SachDAL();
        public DataTable LayDanhSach() => dal.LayDanhSach();
        public bool Them(SachDTO s) => dal.Them(s);
        public bool Sua(SachDTO s) => dal.Sua(s);
        public bool Xoa(string ma) => dal.Xoa(ma);
    }
}