using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using Public;

namespace QuanLyBanhang
{
    public partial class TaiKhoan : Form
    {
        TaiKhoanPublic tkpublic = new TaiKhoanPublic();
        TaiKhoanBUS tkbus = new TaiKhoanBUS();
        int flag = 0;
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = tkbus.getTaiKhoan();
            datataikhoan.DataSource = data;
            bingding();
        }
        void bingding()
        {
            tbtendangnhap.DataBindings.Clear();
            tbtendangnhap.DataBindings.Add("Text", datataikhoan.DataSource, "TenDangNhap");
            tbtentaikhoan.DataBindings.Clear();
            tbtentaikhoan.DataBindings.Add("Text", datataikhoan.DataSource, "TenTaiKhoan");
          
            tbquyen.DataBindings.Clear();
            tbquyen.DataBindings.Add("Text", datataikhoan.DataSource, "Quyen");
        }
        void ganDuLieu(TaiKhoanPublic sppublic)
        {
            sppublic.TENDANGNHAP = tbtendangnhap.Text.Trim();
            sppublic.TENTAIKHOAN = tbtentaikhoan.Text.Trim();
            sppublic.MATKHAU = tbmatkhau.Text.Trim();
            sppublic.QUYEN = tbquyen.Text.Trim();

        }
        void dis_en(bool e)
        {
            tbtentaikhoan.Enabled = e;
            tbquyen.Enabled = e;
            btLuu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btxoa.Enabled = !e;
        }
        void clear()
        {
            tbtendangnhap.Text = "";
            tbtentaikhoan.Text = "";
            tbquyen.Text = "";
            tbmatkhau.Text = "";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            tbtendangnhap.Enabled = true;
            tbmatkhau.Enabled = true;
            flag = 0;
            dis_en(true);
            clear();
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (tkbus.xoaTaiKhoan(tbtendangnhap.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoa that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            TaiKhoan_Load(sender, e);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(tkpublic);
            if (flag == 0)
            {
                //them
                if (tkbus.themTaiKhoan(tkpublic))
                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            TaiKhoan_Load(sender, e);
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon huy thao tac dang lam", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                TaiKhoan_Load(sender, e);
                clear();
               dis_en(false);

            }
            else
                return;
        }
    }
}
