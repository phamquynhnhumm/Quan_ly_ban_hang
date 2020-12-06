using System;
using System.Data;
using System.Data.SqlClient;
using Public;

namespace DAL
{
    public class KhachHangDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();

        public DataTable getKhachHang()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from KHACH_HANG";
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

        public bool themKhachHang(KhachHangPublic kh)
        {
            cmd.CommandText = "insert into KHACH_HANG(MaKH, TenKH, DienThoai, DiaChi) values ('" + kh.MAKH + "', '" + kh.TENKH + "', '" + kh.DIENTHOAI + "', '" + kh.DIACHI + "')";
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

        public bool suaKhachHang(KhachHangPublic kh)
        {
            cmd.CommandText = "update KHACH_HANG set TenKH = '" + kh.TENKH + "', DienThoai = '" + kh.DIENTHOAI + "', DiaChi = '" + kh.DIACHI + "' where MaKH = '" + kh.MAKH + "'";
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

        public bool xoaKhachHang(string Makh)
        {
            cmd.CommandText = "delete KHACH_HANG where MaKH = '" + Makh + "'";
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