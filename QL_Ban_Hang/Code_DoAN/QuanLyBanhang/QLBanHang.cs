using Public;
using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanhang
{
    public partial class QLBanHang : Form
    {
        private TaiKhoanPublic User;
        public delegate void HienThiDangNhap();
        HienThiDangNhap HamHienThiDangNhap;
        public QLBanHang(TaiKhoanPublic User, HienThiDangNhap ConTroHam)
        {
            this.User = User;
            HamHienThiDangNhap = ConTroHam;
            InitializeComponent();
        }
        private void frmNhacc_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu" || User.QUYEN == "Nhan Vien")
            {
                NhaCungCap frm = new NhaCungCap();
                frm.Show();
            }
            else
            {
                frmNhacc.Enabled = false;
            }
        }

        private void frmSanpham_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu" || User.QUYEN == "Nhan Vien")
            {

                SanPham frm = new SanPham();
                frm.Show();

            }
            else
            {
                frmSanpham.Enabled = false;
            }
        }

        private void frmDonhang_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu" || User.QUYEN == "Nhan Vien")
            {
                DonHang frm = new DonHang(User);
                frm.Show();
            }
            else
            {
                frmDonhang.Enabled = false;
            }
        }

        private void frmLichsu_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu" || User.QUYEN == "Nhan Vien")
            {
                LichSu frm = new LichSu();
                frm.Show();
            }
            else
            {
                frmLichsu.Enabled = false;
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu")
            {

                TaiKhoan frm = new TaiKhoan();
                frm.Show();
            }
            else
            {

                tàiKhoảnToolStripMenuItem.Enabled = false;
            }
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu" || User.QUYEN == "Nhan Vien")
            {
                DoiMatKhau frm = new DoiMatKhau(User);

                frm.Show();
            }
            else
            {
                frmdoimk.Enabled = false;
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TroGiup frm = new TroGiup();
            frm.Show();
        }

        private void frmDanhmuc_Click(object sender, EventArgs e)
        {

        }

        private void QLBanHang_Load(object sender, EventArgs e)
        {

        }

        private void frmKhachhang_Click(object sender, EventArgs e)
        {
            if (User.QUYEN == "Chu" || User.QUYEN == "Nhan Vien")
            {

                KhachHang frm = new KhachHang();
                frm.Show();
            }
            else
            {
                frmKhachhang.Enabled = true;
            }
        }

        private void frmNhanvien_Click(object sender, EventArgs e)
        {


            if (User.QUYEN == "Chu")
            {

                NhanVien frm = new NhanVien();
                frm.Show();
            }
            else
            {
                frmNhanvien.Enabled = false;
            }
        }

        private void QLBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            HamHienThiDangNhap();
        }

        private void frmtaikhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
