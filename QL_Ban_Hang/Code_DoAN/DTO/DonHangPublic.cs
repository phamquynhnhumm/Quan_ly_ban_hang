using System;

namespace Public
{
    public class DonHangPublic 
    {
        private string Madh;
        private string Tennv;
        private string Tenkh;
        private DateTime Ngayban;
        public string MADH
        {
            get { return Madh; }
            set { Madh = value; }
        }
        public string NHANVIEN
        {
            get { return Tennv; }
            set { Tennv = value; }
        }
        public string KHACHHANG
        {
            get { return Tenkh; }
            set { Tenkh = value; }
        }
        public DateTime NGAYBAN
        {
            get { return Ngayban; }
            set { Ngayban = value; }
        }
        public DonHangPublic() { }
        public DonHangPublic(string Madh, string Tennv, string Tenkh, DateTime Ngayban)
        {
            this.Madh = Madh;
            this.Tennv = Tennv;
            this.Tenkh = Tenkh;
            this.Ngayban = Ngayban;
        }
    }
}