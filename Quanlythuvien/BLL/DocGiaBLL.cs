using System.Data;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BLL
{
    public class DocGiaBLL

    {
        DocGiaDAL dal = new DocGiaDAL();
        public DataTable TimKiemDocGia(string tuKhoa) => dal.TimKiem(tuKhoa);
        public DataTable LayDanhSach() => dal.LayDanhSach();
        public bool Them(DocGiaDTO d) => dal.Them(d);
        public bool Sua(DocGiaDTO d) => dal.Sua(d);
        public bool Xoa(string ma) => dal.Xoa(ma);

        internal bool ThemDocGia(DocGiaDTO d)
        {
            throw new NotImplementedException();
        }
    }

}