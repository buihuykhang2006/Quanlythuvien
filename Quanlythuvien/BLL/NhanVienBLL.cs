using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dalNhanVien = new NhanVienDAL();

        public string DangNhap(string tk, string mk)
        {
            if (tk == "" || mk == "") return "Vui lòng nhập đủ thông tin!";
            string quyen = dalNhanVien.KiemTraDangNhap(tk, mk);
            if (quyen != "") return quyen;
            return "Sai tài khoản hoặc mật khẩu!";
        }

        public string DangKy(NhanVienDTO nv)
        {
            if (nv.MaNhanVien == "" || nv.TenDangNhap == "") return "Không được bỏ trống mã và tài khoản!";
            if (dalNhanVien.KiemTraTrungTaiKhoan(nv.TenDangNhap)) return "Tài khoản đã tồn tại!";
            if (dalNhanVien.DangKy(nv)) return "OK";
            return "Lỗi hệ thống!";
        }
    }
}
