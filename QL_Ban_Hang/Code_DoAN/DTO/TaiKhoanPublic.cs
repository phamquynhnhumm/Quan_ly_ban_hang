namespace Public
{
    public class TaiKhoanPublic
    {
        private string TenDangNhap;
        private string TenTaiKhoan;
        private string MatKhau;
        private string Quyen;

        public string TENDANGNHAP { get => TenDangNhap; set => TenDangNhap = value; }
        public string TENTAIKHOAN { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MATKHAU { get => MatKhau; set => MatKhau = value; }
        public string QUYEN { get => Quyen; set => Quyen = value; }
        public TaiKhoanPublic()
        {
        }
        public TaiKhoanPublic(string TenDangNhap, string TenTaiKhoan, string MatKhau, string Quyen)
        {
            this.TenDangNhap = TenDangNhap;
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;

        }
    }
}