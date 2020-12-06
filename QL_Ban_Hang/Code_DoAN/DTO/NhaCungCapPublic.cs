namespace Public
{
    public class NhaCungCapPublic
    {
        private string Mancc;
        public string MaNCC
        {
            get { return Mancc; }
            set { Mancc = value; }
        }
        private string Tenncc;
        public string TenNCC
        {
            get { return Tenncc; }
            set { Tenncc = value; }
        }
        private string DiaChi;
        public string DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        private string DienThoai;
        public string SDT
        {
            get { return DienThoai; }
            set { DienThoai = value; }
        }
        public NhaCungCapPublic() { }
        public NhaCungCapPublic(string Mancc, string Tenncc, string DiaChi, string DienThoai)
        {
            this.Mancc = Mancc;
            this.Tenncc = Tenncc;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoai;
        }
    }
}
