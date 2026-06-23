namespace QuanLyThuVien.Entity
{
    public class NhanVien
    {
        public string? MaNhanVien { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string? QuyenHan { get; set; }
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string ma, string ten, string sdt, string quyen, string tk, string mk)
        {
            MaNhanVien = ma;
            HoTen = ten;
            SoDienThoai = sdt;
            QuyenHan = quyen;
            TenDangNhap = tk;
            MatKhau = mk;
        }
    }
}
