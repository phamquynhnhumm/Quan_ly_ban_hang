using System;
using System.Windows.Forms;
using System.Data;
using Public;
using BUS;

namespace QuanLyBanhang
{
    public partial class KhachHang : Form
    {
        KhachHangPublic khpublic = new KhachHangPublic();
        KhachHangBUS khbus = new KhachHangBUS();
        int flag = 0;
        public KhachHang()
        {
            InitializeComponent();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = khbus.getKhachHang();
            datakhachhang.DataSource = data;
            bingding();
        }
        void bingding()
        {
            tbmakh.DataBindings.Clear();
            tbmakh.DataBindings.Add("Text", datakhachhang.DataSource, "MaKH");
            tbtenkhach.DataBindings.Clear();
            tbtenkhach.DataBindings.Add("Text", datakhachhang.DataSource, "TenKH");
            maskedsdt.DataBindings.Clear();
            maskedsdt.DataBindings.Add("Text", datakhachhang.DataSource, "DienThoai");
            combodiachi.DataBindings.Clear();
            combodiachi.DataBindings.Add("Text", datakhachhang.DataSource, "DiaChi");
        }
        void ganDuLieu(KhachHangPublic khpublic)
        {
            khpublic.MAKH = tbmakh.Text.Trim();
            khpublic.TENKH = tbtenkhach.Text.Trim();
            khpublic.DIENTHOAI = maskedsdt.Text.Trim();
            khpublic.DIACHI = combodiachi.Text.Trim();
        }
        void dis_en(bool e)
        {
            tbtenkhach.Enabled = e;
            combodiachi.Enabled = e;
            maskedsdt.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        void clear()
        {
            tbmakh.Text = "";
            tbtenkhach.Text = "";
            combodiachi.Text = "";
            maskedsdt.Text = "";
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            tbmakh.Enabled = true;
            dis_en(true);
            clear();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            tbmakh.Enabled = false;
            dis_en(true);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khbus.xoaKhachHang(tbmakh.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoa that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            KhachHang_Load(sender, e);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            ganDuLieu(khpublic);
            if (flag == 0)
            {
                //them
                if (tbmakh.Text != "")
                {
                    if (khbus.themKhachHang(khpublic))
                        MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Khong duoc bo trong MaKH", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sua
                if (khbus.suaKhachHang(khpublic))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sua that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KhachHang_Load(sender, e);
            clear();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon huy thao tac dang lam", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KhachHang_Load(sender, e);
                dis_en(false);
            }
            else
                return;
        }
    }
}