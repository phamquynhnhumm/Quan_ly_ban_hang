using System;
using System.Data;
using System.Data.SqlClient;
using Public;

namespace DAL
{
    public class NhaCungCapDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();

        public DataTable getNhaCungCap()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NHA_CUNG_CAP";
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

        public bool themNhaCungCap(NhaCungCapPublic ncc)
        {
            cmd.CommandText = "insert into NHA_CUNG_CAP(MaNCC, TenNCC, DienThoai, DiaChi) values ('" + ncc.MaNCC + "', '" + ncc.TenNCC + "', '" + ncc.SDT + "', '" + ncc.DIACHI + "')";
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

        public bool suaNhaCungCap(NhaCungCapPublic ncc)
        {
            cmd.CommandText = "update NHA_CUNG_CAP set TenNCC = '" + ncc.TenNCC + "', DienThoai = '" + ncc.SDT + "',  DiaChi = '" + ncc.DIACHI + "' where MaNCC = '" + ncc.MaNCC + "'";
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

        public bool xoaNhaCungCap(string Mancc)
        {
            cmd.CommandText = "delete NHA_CUNG_CAP where MaNCC = '" + Mancc + "'";
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