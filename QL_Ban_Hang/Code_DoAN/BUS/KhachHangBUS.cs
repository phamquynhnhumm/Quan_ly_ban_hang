using Public;
using DAL;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAL khdal = new KhachHangDAL();
        public DataTable getKhachHang()
        {
            return khdal.getKhachHang();
        }
        public bool themKhachHang(KhachHangPublic kh)
        {
            return khdal.themKhachHang(kh);
        }
        public bool suaKhachHang(KhachHangPublic kh)
        {
            return khdal.suaKhachHang(kh);
        }
        public bool xoaKhachHang(string Makh)
        {
            return khdal.xoaKhachHang(Makh);
        }
    }
}