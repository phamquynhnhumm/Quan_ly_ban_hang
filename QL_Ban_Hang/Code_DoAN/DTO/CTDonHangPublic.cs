namespace Public
{
    public class CTDonHangPublic
    {
        private string Madh, Masp;
        private float GiaSP;
        private int sl;
        public string MADH
        {
            get { return Madh; }
            set { Madh = value; }
        }
        public string MASP
        {
            get { return Masp; }
            set { Masp = value; }
        }
        public float GIASP
        {
            get { return GiaSP; }
            set { GiaSP = value; }
        }
        public int SL
        {
            get { return sl; }
            set { sl = value; }
        }
        public CTDonHangPublic() { }
        public CTDonHangPublic(string Madh, string Masp, float GiaSP, int sl)
        {
            this.Madh = Madh;
            this.Masp = Masp;
            this.GiaSP = GiaSP;
            this.sl = sl;
        }
    }
}