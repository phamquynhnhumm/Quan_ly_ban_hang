using System;
using System.Data;
using System.Data.SqlClient;
using Public;

namespace DAL
{
    public class DonHangDAL : KetNoiDAL
    {
        KetNoiDAL con = new KetNoiDAL();
        SqlCommand cmd = new SqlCommand();

        public object MessengeBox { get; private set; }

        public DataTable getDonHang()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select dh.MaDH, nv.TenNV NhanVien, kh.TenKH KhachHang, NgayBan, nv.MaNV from DON_HANG dh, NHAN_VIEN nv, KHACH_HANG kh where dh.MaNV = nv.MaNV and dh.MaKH = kh.MaKH ";
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
        public DataTable getLichSu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select dh.MaDH, nv.TenNV NhanVien, kh.TenKH KhachHang, NgayBan, sp.TenSP SanPham, ct.GiaSP, ct.SoLuong, ct.SoLuong*ct.GiaSP ThanhTien from DON_HANG dh, NHAN_VIEN nv, KHACH_HANG kh, CT_DON_HANG ct, SAN_PHAM sp where ct.MaSP = sp.MaSP and dh.MaNV = nv.MaNV and dh.MaKH = kh.MaKH and dh.MaDH = ct.MaDH";
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
        public bool themDonHang(DonHangPublic dh)
        {

            cmd.CommandText = "insert into DON_HANG(MaDH, MaNV, MaKH, NgayBan) values ('" + dh.MADH + "', '" + dh.NHANVIEN + "', '" + dh.KHACHHANG + "', '" + dh.NGAYBAN.ToString("MM/dd/yyyy") + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            int row = 0;
            try
            {
                con.OpenConn();
                row = cmd.ExecuteNonQuery();
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
            return Convert.ToBoolean(row);
        }

        public bool xoaLichSu(string Madh)
        {
            cmd.CommandText = "delete from CT_DON_HANG from DON_HANG where DON_HANG.MaDH = CT_DON_HANG.MaDH and DON_HANG.MaDH = '" + Madh + "'";
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
        public DataTable TimKiemLichSu()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select dh.MaDH, nv.TenNV NhanVien, kh.TenKH KhachHang, NgayBan from DON_HANG dh, NHAN_VIEN nv, KHACH_HANG kh where dh.NhanVien = nv.MaNV and dh.KhachHang = kh.MaKH ";
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


    }
}