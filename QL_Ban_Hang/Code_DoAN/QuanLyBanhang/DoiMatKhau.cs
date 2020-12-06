using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using BUS;
using Public;

namespace QuanLyBanhang
{
    public partial class DoiMatKhau : Form
    {
        private TaiKhoanBUS TKBUS = new TaiKhoanBUS();

        TaiKhoanPublic User;
        public DoiMatKhau(TaiKhoanPublic User)
        {
            this.User = User;
            InitializeComponent();
        }

        private void btdoi_Click(object sender, EventArgs e)
        {
            User.MATKHAU = tbmatkhaucu.Text;
            if (TKBUS.suaMatKhau(User, tbmatkhaumoi.Text))
            {
                MessageBox.Show("Doi mat khau thanh cong!");
            }
            else
            {
                MessageBox.Show("Doi mat khau that bai!");
            }

        }

    }
}
