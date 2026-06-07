using System.Data;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BLL
{
    public class TheLoaiBLL
    {
        TheLoaiDAL dal = new TheLoaiDAL();
        public DataTable LayDanhSach() => dal.LayDanhSach();
        public bool Them(TheLoaiDTO t) => dal.Them(t);
        public bool Sua(TheLoaiDTO t) => dal.Sua(t);
        public bool Xoa(string ma) => dal.Xoa(ma);
        TheLoaiDTO tl = new TheLoaiDTO(ma, ten);
        private static string ma;
        private static string ten;
    }
}