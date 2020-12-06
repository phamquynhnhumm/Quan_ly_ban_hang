using System;
using System.Data;
using System.Data.SqlClient;
using Public;

namespace DAL
{
    public class CTDonHangDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();

        public DataTable getCTDonHang(string madh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select sp.TenSP SanPham, ct.GiaSP, ct.SoLuong, ct.SoLuong*ct.GiaSP ThanhTien from CT_DON_HANG ct, SAN_PHAM sp where ct.MaSP = sp.MaSP and MaDH = '" + madh + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable lấy_chi_tiết(CTDonHangPublic Chi_tiết)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = $"select * from CT_DON_HANG where MaDH ='{Chi_tiết.MADH}' and MaSP  = '{Chi_tiết.MASP}'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool themCTDonHang(string dhpublic, DataTable dt)
        {
            int row = 0;
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = $"insert into CT_DON_HANG(MaDH, MaSP, GiaSP, SoLuong) values ('{ dhpublic }', '{ dt.Rows[i][0].ToString()}', '{ dt.Rows[i][1].ToString() }', '{ dt.Rows[i][2].ToString()}')";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Connection;
                    con.OpenConn();
                    row = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToBoolean(row);
        }
        public bool cập_nhật(CTDonHangPublic Chi_tiết)
        {
            int row = 0;
            try
            {
                cmd.CommandText = $"update CT_DON_HANG set SoLuong = '{Chi_tiết.SL}' where MaDH ='{Chi_tiết.MADH}' and MaSP  = '{Chi_tiết.MASP}'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Connection;
                con.OpenConn();
                row = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToBoolean(row);
        }
        public bool thêm(CTDonHangPublic Chi_tiết)
        {
            int row = 0;
            try
            {
                cmd.CommandText = $"insert into CT_DON_HANG(MaDH, MaSP, GiaSP, SoLuong) values ('{ Chi_tiết.MADH }', '{ Chi_tiết.MASP}', '{ Chi_tiết.GIASP }', '{ Chi_tiết.SL}')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Connection;
                con.OpenConn();
                row = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToBoolean(row);
        }

        public bool botCTDonHang(string Masp)
        {
            cmd.CommandText = "delete CT_DON_HANG where MaSP = '" + Masp + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }


    }
}