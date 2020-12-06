using System;
using System.Data;
using System.Data.SqlClient;
using Public;

namespace DAL
{
    public class TaiKhoanDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();
        public DataTable DangNhap(TaiKhoanPublic User)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = $"select * from TAI_KHOAN where TenDangNhap = '{User.TENDANGNHAP}'and MatKhau = '{User.MATKHAU}'";
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
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;

        }
        public DataTable getTaiKhoan()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select TenDangNhap, TenTaiKhoan ,Quyen from TAI_KHOAN";
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
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool themTaiKhoan(TaiKhoanPublic tk)
        {
            cmd.CommandText = "insert into TAI_KHOAN(TenDangNhap, TenTaiKhoan, MatKhau, Quyen) values ('" + tk.TENDANGNHAP + "','" + tk.TENTAIKHOAN + "','" + tk.MATKHAU + "','" + tk.QUYEN + "')";
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
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool suaTaiKhoan(TaiKhoanPublic tk)
        {
            cmd.CommandText = "update TAI_KHOAN set TenTaiKhoan = '" + tk.TENTAIKHOAN + "', MatKhau = '" + tk.MATKHAU + "', Quyen = '" + tk.QUYEN + "' where TenDangNhap= '" + tk.TENDANGNHAP + "'";
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
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool suaMatKhau(TaiKhoanPublic tk, string MatKhauMoi)
        {
            cmd.CommandText = $"update TAI_KHOAN set MatKhau = '{MatKhauMoi }' where TenDangNhap= '{ tk.TENDANGNHAP }' and MatKhau = '{ tk.MATKHAU}'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            int numbersOfRow = 0;
            try
            {
                con.OpenConn();
                numbersOfRow = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return Convert.ToBoolean(numbersOfRow);
        }
        public bool xoaTaiKhoan(string Tentk)
        {
            cmd.CommandText = "delete TAI_KHOAN where TenDangNhap = '" + Tentk + "'";
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
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}