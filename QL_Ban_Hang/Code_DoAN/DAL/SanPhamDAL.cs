using System;
using System.Data;
using System.Data.SqlClient;
using Public;

namespace DAL
{
    public class SanPhamDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();

        public DataTable getSanPham()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select sp.MaSP, TenSP, ncc.TenNCC, GiaSP, Soluong from SAN_PHAM sp, NHA_CUNG_CAP ncc where sp.MaNCC = ncc.MaNCC";
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
        public DataTable getSanPhamBangID(string ID)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = $"select * from SAN_PHAM where MaSP ='{ID}'";
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
        public void  capnhatsoluong(SanPhamPublic sp)
        {
            cmd.CommandText = $"update SAN_PHAM set SoLuong = { sp.SOLUONG} where MaSP = '{ sp.MASP}'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
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
        }
        public DataTable getSanPham(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select sp.MaSP, TenSP, ncc.TenNCC, GiaSP, Soluong from SAN_PHAM sp, NHA_CUNG_CAP ncc where sp.MaNCC = ncc.MaNCC " + dieukien;
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

        public bool themSanPham(SanPhamPublic sp)
        {
            cmd.CommandText = "insert into SAN_PHAM(MaSP, TenSP, MaNCC, GiaSP, Soluong) values ('" + sp.MASP + "','" + sp.TENSP + "','" + sp.TenNCC + "', '" + sp.GIASP + "', '" + sp.SOLUONG + "')";
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
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
        }

        public bool suaSanPham(SanPhamPublic sp)
        {
            cmd.CommandText = "update SAN_PHAM set TenSP = '" + sp.TENSP + "', MaNCC = '" + sp.TenNCC + "', GiaSP = '" + sp.GIASP + "', SoLuong = '" + sp.SOLUONG + "' where MaSP = '" + sp.MASP + "'";
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
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
        }

        public bool suaSL(string masp, int sl)
        {
            cmd.CommandText = "update SAN_PHAM set SoLuong = '" + sl + "' where MaSP = '" + masp + "'";
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
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool xoaSanPham(string Masp)
        {
            cmd.CommandText = "delete SAN_PHAM where MaSP = '" + Masp + "'";
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
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.CloseConn();
            }
        }

    }
}