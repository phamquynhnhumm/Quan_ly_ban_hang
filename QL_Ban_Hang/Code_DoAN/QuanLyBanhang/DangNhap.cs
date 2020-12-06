using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using Public;

namespace QuanLyBanhang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            TaiKhoanPublic UserA = null;

            try
            {
                TaiKhoanPublic UserB = new TaiKhoanPublic();
                UserB.TENDANGNHAP = tbtendangnhap.Text;
                UserB.MATKHAU = tbmatkhau.Text;
                TaiKhoanBUS User = new TaiKhoanBUS();

                UserA = User.DangNhap(UserB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (UserA.TENTAIKHOAN != null)
                {
                    QLBanHang FQL = new QLBanHang(UserA, this.Show);
                    FQL.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau");
                }
            }

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
