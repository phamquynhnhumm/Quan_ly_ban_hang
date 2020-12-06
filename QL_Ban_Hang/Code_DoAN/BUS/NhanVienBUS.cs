using System.Data;
using DAL;
using Public;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL nvdal = new NhanVienDAL();
        public NhanVienPublic Lấy_Nhân_Viên_Với_Tên(string Tên)
        {
            NhanVienPublic Kết_Quả = new NhanVienPublic();
            DataTable Bảng = nvdal.Lấy_Nhân_Viên_Bởi_Tên(Tên);
            Kết_Quả.MANV = Bảng.Rows[0].Field<string>("MaNV");
            Kết_Quả.TENNV = Bảng.Rows[0].Field<string>("TenNV");
            return Kết_Quả;
        }
        public DataTable getNhanVien()
        {
            return nvdal.getNhanVien();
        }
        public bool themNhanVien(NhanVienPublic nv)
        {
            return nvdal.themNhanVien(nv);
        }
        public bool suaNhanVien(NhanVienPublic nv)
        {
            return nvdal.suaNhanVien(nv);
        }
        public bool xoaNhanVien(string Manv)
        {
            return nvdal.xoaNhanVien(Manv);
        }
    }
}