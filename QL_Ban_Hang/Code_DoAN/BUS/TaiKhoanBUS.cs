using DAL;
using Public;
using System;
using System.Data;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL tkdal = new TaiKhoanDAL();
        public TaiKhoanPublic DangNhap(TaiKhoanPublic User)
        {
            TaiKhoanPublic UserA = new TaiKhoanPublic();
            
            try
            {
                DataTable DT = tkdal.DangNhap(User);
                if (DT.Rows.Count > 0)
                {
                    try
                    {
                        UserA.TENDANGNHAP = DT.Rows[0].Field<string>("TenDangNhap");
                        UserA.QUYEN = DT.Rows[0].Field<string>("Quyen");
                        UserA.TENTAIKHOAN = DT.Rows[0].Field<string>("TenTaiKhoan");
                    }
                    catch (Exception ex)
                    {
                        throw ex;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return UserA;
        }
        public DataTable getTaiKhoan()
        {
            return tkdal.getTaiKhoan();
        }
        public bool themTaiKhoan(TaiKhoanPublic tk)
        {
            return tkdal.themTaiKhoan(tk);
        }
        public bool suaTaiKhoan(TaiKhoanPublic tk)
        {
            return tkdal.suaTaiKhoan(tk);
        }
        public bool suaMatKhau(TaiKhoanPublic tk, string MatKhauMoi)
        {
            return tkdal.suaMatKhau(tk, MatKhauMoi);
        }
        public bool xoaTaiKhoan(string TENDANGNHAP)
        {
            return tkdal.xoaTaiKhoan(TENDANGNHAP);
        }
    }
}