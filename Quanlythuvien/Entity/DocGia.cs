using System;

namespace QuanLyThuVien.Entity
{
    public class DocGia
    {
        public string? MaDocGia { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public DateTime NgayDangKy { get; set; }

        public DocGia()
        {
        }

        public DocGia(string ma, string ten, string sdt, DateTime ngayDangKy)
        {
            MaDocGia = ma;
            HoTen = ten;
            SoDienThoai = sdt;
            NgayDangKy = ngayDangKy;
        }
    }
}
