using System;

namespace Public
{
    public class NhanVienPublic
    {
        private string Manv;
        private string Tennv;
        private string Gioitinh;
        private string Diachi;
        private string Dienthoai;
        private DateTime Ngaysinh;

        public string MANV
        {
            get { return Manv; }
            set { Manv = value; }
        }
        public string TENNV
        {
            get { return Tennv; }
            set { Tennv = value; }
        }
        public string GIOITINH
        {
            get { return Gioitinh; }
            set { Gioitinh = value; }
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
        public DateTime NGAYSINH
        {
            get { return Ngaysinh; }
            set { Ngaysinh = value; }
        }
        public NhanVienPublic() { }
        public NhanVienPublic(string Manv, string Tennv, string Gioitinh, string Dienthoai, DateTime Ngaysinh, string Diachi)
        {
            this.Manv = Manv;
            this.Tennv = Tennv;
            this.Gioitinh = Gioitinh;
            this.Dienthoai = Dienthoai;
            this.Ngaysinh = Ngaysinh;
            this.Diachi = Diachi;
        }
    }
}