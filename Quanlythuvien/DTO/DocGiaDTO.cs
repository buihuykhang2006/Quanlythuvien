using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien.DTO
{
    public class DocGiaDTO
    {
        public string? MaDocGia { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DocGiaDTO(string ma, string ten, string sdt, DateTime ngayDangKy)
        {
            MaDocGia = ma; HoTen = ten; SoDienThoai = sdt; NgayDangKy = ngayDangKy;
        }

        public DocGiaDTO()
        {
        }
    }
}
