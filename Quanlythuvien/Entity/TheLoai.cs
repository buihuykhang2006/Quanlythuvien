namespace QuanLyThuVien.Entity
{
    public class TheLoai
    {
        public string? MaTheLoai { get; set; }
        public string? TenTheLoai { get; set; }

        public TheLoai()
        {
        }

        public TheLoai(string ma, string ten)
        {
            MaTheLoai = ma;
            TenTheLoai = ten;
        }
    }
}
