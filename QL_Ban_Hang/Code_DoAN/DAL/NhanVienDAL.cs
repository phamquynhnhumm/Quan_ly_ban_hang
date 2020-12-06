using Public;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();

        public DataTable getNhanVien()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NHAN_VIEN";
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

        public DataTable Lấy_Nhân_Viên_Bởi_Tên(String Tên)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = $"select * from NHAN_VIEN where TenNV = '{Tên}'";
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

        public bool themNhanVien(NhanVienPublic nv)
        {
            cmd.CommandText = "insert into NHAN_VIEN(MaNV, TenNV, GioiTinh, DienThoai, NgaySinh, DiaChi) values ('" + nv.MANV + "', '" + nv.TENNV + "', '" + nv.GIOITINH + "', '" + nv.DIENTHOAI + "', '" + nv.NGAYSINH + "', '" + nv.DIACHI + "')";
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

        public bool suaNhanVien(NhanVienPublic nv)
        {
            cmd.CommandText = "update NHAN_VIEN set TenNV = '" + nv.TENNV + "', GioiTinh = '" + nv.GIOITINH + "', DienThoai = '" + nv.DIENTHOAI + "', NgaySinh = '" + nv.NGAYSINH + "', DiaChi = '" + nv.DIACHI + "' where MaNV = '" + nv.MANV + "'";
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

        public bool xoaNhanVien(string Manv)
        {
            cmd.CommandText = "delete NHAN_VIEN where MaNV = '" + Manv + "'";
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