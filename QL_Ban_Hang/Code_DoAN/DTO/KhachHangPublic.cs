namespace Public
{
    public class KhachHangPublic
    {
        private string Makh;
        private string Tenkh;
        private string Diachi;
        private string Dienthoai;
        public string MAKH
        {
            get { return Makh; }
            set { Makh = value; }
        }
        public string TENKH
        {
            get { return Tenkh; }
            set { Tenkh = value; }
        }
        public string DIACHI
        {
            get { return Diachi; }
            set { Diachi = value; }
        }
        public string DIENTHOAI
        {
            get { return Dienthoai; }
            set { Dienthoai = value; }
        }
        public KhachHangPublic() { }
        public KhachHangPublic(string Makh, string Tenkh, string Diachi, string Dienthoai)
        {
            this.Makh = Makh;
            this.Tenkh = Tenkh;
            this.Diachi = Diachi;
            this.Dienthoai = Dienthoai;
        }
    }
}