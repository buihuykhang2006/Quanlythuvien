using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien.DTO
{
    public class NhanVienDTO
    {
        public string? MaNhanVien { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string? QuyenHan { get; set; }
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }

        public NhanVienDTO(string ma, string ten, string sdt, string quyen, string tk, string mk)
        {
            MaNhanVien = ma; HoTen = ten; SoDienThoai = sdt; QuyenHan = quyen; TenDangNhap = tk; MatKhau = mk;
        }
    }
}
