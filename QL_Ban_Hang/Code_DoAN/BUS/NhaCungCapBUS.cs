using DAL;
using Public;
using System.Data;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAL nccdal = new NhaCungCapDAL();
        public DataTable getNhaCungCap()
        {
            return nccdal.getNhaCungCap();
        }
        public bool themNhaCungCap(NhaCungCapPublic ncc)
        {
            return nccdal.themNhaCungCap(ncc);
        }
        public bool suaNhaCungCap(NhaCungCapPublic ncc)
        {
            return nccdal.suaNhaCungCap(ncc);
        }
        public bool xoaNhaCungCap(string Mancc)
        {
            return nccdal.xoaNhaCungCap(Mancc);
        }
    }
}