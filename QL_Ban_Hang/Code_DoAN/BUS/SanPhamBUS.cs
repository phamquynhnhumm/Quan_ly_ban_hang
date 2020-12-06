using Public;
using DAL;
using System.Data;
using System;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAL spdal = new SanPhamDAL();
        public DataTable getSanPham()
        {
            return spdal.getSanPham();
        }
        public SanPhamPublic LaySanPham(SanPhamPublic SPB)
        {
            SanPhamPublic SP = new SanPhamPublic();
            DataTable DT = spdal.getSanPhamBangID(SPB.MASP);
            SP.SOLUONG = DT.Rows[0].Field<int>("SoLuong");
            SP.MASP = DT.Rows[0].Field<string>("MaSP");
            return SP;
        }
        public void capnhatsoluong(SanPhamPublic SPB)
        {
            spdal.capnhatsoluong(SPB);
        }
        public DataTable getSanPham(string dieukien)
        {
            return spdal.getSanPham(dieukien);
        }
        public bool themSanPham(SanPhamPublic sp)
        {
            return spdal.themSanPham(sp);
        }
        public bool suaSanPham(SanPhamPublic sp)
        {
            return spdal.suaSanPham(sp);
        }
        public bool suaSL(DataTable dtChiTietDonHang)
        {
            foreach (DataRow CTDonHang in dtChiTietDonHang.Rows)
            {
                SanPhamPublic SP = new SanPhamPublic();
                SanPhamBUS spbus = new SanPhamBUS();
                try
                {
                    SP.MASP = CTDonHang.Field<string>("MaSP");

                    int slcu = spbus.LaySanPham(SP).SOLUONG;
                    int slt = CTDonHang.Field<int>("SoLuong");
                    SP.SOLUONG = slcu - slt;
                    spbus.capnhatsoluong(SP);
                }
                catch (Exception ex)
                {
                    throw ex;

                }



            }
            return true;
        }
        public bool xoaSanPham(string Masp)
        {
            return spdal.xoaSanPham(Masp);
        }
    }
}