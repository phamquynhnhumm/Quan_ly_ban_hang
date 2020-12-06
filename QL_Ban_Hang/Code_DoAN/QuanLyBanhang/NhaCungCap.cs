using System;
using System.Data;
using System.Windows.Forms;
using Public;
using BUS;

namespace QuanLyBanhang
{
    public partial class NhaCungCap : Form
    {
        NhaCungCapBUS nccbus = new NhaCungCapBUS();
        NhaCungCapPublic nccpublic = new NhaCungCapPublic();
        int flag = 0;
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = nccbus.getNhaCungCap();
            datanhacungcap.DataSource = data;
            bingding();
        }
        void bingding()
        {
            tbmancc.DataBindings.Clear();
            tbmancc.DataBindings.Add("Text", datanhacungcap.DataSource, "MaNCC");
            tbtenncc.DataBindings.Clear();
            tbtenncc.DataBindings.Add("Text", datanhacungcap.DataSource, "TenNCC");
            maskedsdt.DataBindings.Clear();
            maskedsdt.DataBindings.Add("Text", datanhacungcap.DataSource, "DienThoai");
            combodiachi.DataBindings.Clear();
            combodiachi.DataBindings.Add("Text", datanhacungcap.DataSource, "DiaChi");
        }
        void dis_en(bool e)
        {
            tbtenncc.Enabled = e;
            combodiachi.Enabled = e;
            maskedsdt.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        void clear()
        {
            tbmancc.Text = "";
            tbtenncc.Text = "";
            combodiachi.Text = "";
            maskedsdt.Text = "";
        }
        void ganDuLieu(NhaCungCapPublic nccpublic)
        {
            nccpublic.MaNCC = tbmancc.Text.Trim();
            nccpublic.TenNCC = tbtenncc.Text.Trim();
            nccpublic.SDT = maskedsdt.Text.Trim();
            nccpublic.DIACHI = combodiachi.Text.Trim();
        }
       

        private void btluu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nccpublic);
            if (flag == 0)
            {
                //them
                if (tbmancc.Text != "")
                {
                    if (nccbus.themNhaCungCap(nccpublic))
                        MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Khong duoc de trong MaNCC", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sua
                if (nccbus.suaNhaCungCap(nccpublic))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sua that bai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NhaCungCap_Load(sender, e);
            clear();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon huy thao tac dang lam", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                NhaCungCap_Load(sender, e);
                dis_en(false);
            }
            else
                return;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            tbmancc.Enabled = true;
            dis_en(true);
            clear();
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            tbmancc.Enabled = false;
            dis_en(true);
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xoa
                if (nccbus.xoaNhaCungCap(tbmancc.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoa that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            NhaCungCap_Load(sender, e);
        }
    }
}
