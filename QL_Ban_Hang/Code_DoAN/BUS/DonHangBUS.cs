using Public;
using DAL;
using System.Data;
using System;

namespace BUS
{
    public class DonHangBUS
    {
        DonHangDAL dhdal = new DonHangDAL();
        public DataTable getDonHang()
        {
            return dhdal.getDonHang();
        }
        public DataTable getLichSu()
        {
            return dhdal.getLichSu();
        }
        public bool themDonHang(DonHangPublic dh)
        {
            try
            {
                return dhdal.themDonHang(dh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool xoaLichSu(string Madh)
        {
            return dhdal.xoaLichSu(Madh);
        }
    }
}