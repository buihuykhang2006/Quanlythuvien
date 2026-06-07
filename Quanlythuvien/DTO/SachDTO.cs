using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien.DTO
{
    public class SachDTO
    {
        public string? MaSach { get; set; }
        public string? TenSach { get; set; }
        public string? TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public string? MaTheLoai { get; set; }

        public SachDTO(string ma, string ten, string tacGia, int nam, int sl, string theLoai)
        {
            MaSach = ma; TenSach = ten; TacGia = tacGia; NamXuatBan = nam; SoLuong = sl; MaTheLoai = theLoai;
        }

        public SachDTO()
        {
        }
    }
}
