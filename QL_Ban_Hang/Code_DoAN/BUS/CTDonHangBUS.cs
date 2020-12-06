using DAL;
using System.Data;
using Public;
using System;

namespace BUS
{
    public class CTDonHangBUS
    {
        public CTDonHangDAL dhdal = new CTDonHangDAL();

        public SanPhamBUS spbus = new SanPhamBUS();
        public DataTable getCTDonHang(string madh)
        {
            return dhdal.getCTDonHang(madh);
        }
        public bool Tồn_tại(CTDonHangPublic Chi_tiết)
        {
            return Convert.ToBoolean(dhdal.lấy_chi_tiết(Chi_tiết).Rows.Count);
        }
        public bool cập_nhật_số_lượng(CTDonHangPublic Chi_tiết)
        {
            DataTable CTDT = dhdal.lấy_chi_tiết(Chi_tiết);
            int luongCu = CTDT.Rows[0].Field<int>("SoLuong");
            int luongThem = Chi_tiết.SL;
            Chi_tiết.SL = luongCu + luongThem;


            SanPhamPublic SP = new SanPhamPublic();
            SP.MASP = Chi_tiết.MASP;

            SP = spbus.LaySanPham(SP);

            if (SP.SOLUONG > luongCu)
            {
                dhdal.cập_nhật(Chi_tiết);
                //
                //
                //
                SP.SOLUONG -= luongThem;
                spbus.capnhatsoluong(SP);
                return true;
            }
            else return false;
        }
        public bool bớt(CTDonHangPublic Chi_tiết)
        {
            DataTable DT = dhdal.lấy_chi_tiết(Chi_tiết);
            int luongTra = Chi_tiết.SL;
            int luongCu = DT.Rows[0].Field<int>("SoLuong");
            Chi_tiết.SL = luongCu - luongTra;

            SanPhamPublic SP = new SanPhamPublic();
            SP.MASP = Chi_tiết.MASP;

            SP = spbus.LaySanPham(SP);
            if (Chi_tiết.SL >= luongTra)
            {
                dhdal.cập_nhật(Chi_tiết);

                //
                //
                //

                SP.SOLUONG += luongTra;
                spbus.capnhatsoluong(SP);

            }

            return true;
        }
        public bool thêm(CTDonHangPublic Chi_tiết)
        {
            dhdal.thêm(Chi_tiết);
            return true;
        }
        public bool themCTDonHang(string dhpublic, DataTable dt)
        {
            return dhdal.themCTDonHang(dhpublic, dt);
        }

        public bool botCTDonHang(string masp)
        {
            return dhdal.botCTDonHang(masp);
        }

    }
}