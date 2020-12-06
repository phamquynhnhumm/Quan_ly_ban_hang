namespace Public
{
    public class SanPhamPublic : NhaCungCapPublic
    {
        private string Masp;
        private string Tensp;
        private int Soluong;
        private float Giasp;
        public string MASP
        {
            get { return Masp; }
            set { Masp = value; }
        }
        public string TENSP
        {
            get { return Tensp; }
            set { Tensp = value; }
        }
        public int SOLUONG
        {
            get { return Soluong; }
            set { Soluong = value; }
        }
        public float GIASP
        {
            get { return Giasp; }
            set { Giasp = value; }
        }
        public SanPhamPublic() { }
        public SanPhamPublic(string Masp, string Tensp, int Soluong, float Giasp)
        {
            this.Masp = Masp;
            this.Tensp = Tensp;
            this.Soluong = Soluong;
            this.Giasp = Giasp;
        }
    }
}
