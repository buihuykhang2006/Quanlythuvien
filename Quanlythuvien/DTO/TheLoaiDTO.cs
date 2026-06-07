using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien.DTO
{
    public class TheLoaiDTO
    {
        public string? MaTheLoai { get; set; }
        public string? TenTheLoai { get; set; }
        public TheLoaiDTO(string ma, string ten)
        {
            MaTheLoai = ma; TenTheLoai = ten;
        }

        public TheLoaiDTO()
        {
        }
    }
}
