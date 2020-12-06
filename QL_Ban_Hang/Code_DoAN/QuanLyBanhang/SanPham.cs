using System;
using System.Windows.Forms;
using System.Data;
using Public;
using BUS;

namespace QuanLyBanHang
{
    public partial class SanPham : Form
    {
        SanPhamPublic sppublic = new SanPhamPublic();
        SanPhamBUS spbus = new SanPhamBUS();
        NhaCungCapBUS nccbus = new NhaCungCapBUS();
        int flag = 0;
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = spbus.getSanPham();
            datasanpham.DataSource = data;
            bingding();
        }
        void bingding()
        {
            tbmasp.DataBindings.Clear();
            tbmasp.DataBindings.Add("Text", datasanpham.DataSource, "MaSP");
            tbtensp.DataBindings.Clear();
            tbtensp.DataBindings.Add("Text", datasanpham.DataSource, "TenSP");
            comboncc.DataBindings.Clear();
            comboncc.DataBindings.Add("Text", datasanpham.DataSource, "TenNCC");
            tbgiasp.DataBindings.Clear();
            tbgiasp.DataBindings.Add("Text", datasanpham.DataSource, "GiaSP");
            tbsoluong.DataBindings.Clear();
            tbsoluong.DataBindings.Add("Text", datasanpham.DataSource, "SoLuong");
        }
        void ganDuLieu(SanPhamPublic sppublic)
        {
            sppublic.MASP = tbmasp.Text.Trim();
            sppublic.TENSP = tbtensp.Text.Trim();
            sppublic.TenNCC = comboncc.SelectedValue.ToString();
            sppublic.GIASP = float.Parse(tbgiasp.Text.Trim());
            sppublic.SOLUONG = int.Parse(tbsoluong.Text.Trim());
        }
        void dis_en(bool e)
        {
            comboncc.Enabled = e;
            tbtensp.Enabled = e;
            tbgiasp.Enabled = e;
            tbsoluong.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        void comboNhaCungCap()
        {
            comboncc.DataSource = nccbus.getNhaCungCap();
            comboncc.DisplayMember = "TenNCC";
            comboncc.ValueMember = "MaNCC";
        }
        void clear()
        {
            tbmasp.Text = "";
            comboncc.Text = "";
            tbtensp.Text = "";
            tbsoluong.Text = "";
            tbgiasp.Text = "";
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            tbmasp.Enabled = true;
            dis_en(true);
            comboNhaCungCap();
            clear();

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            tbmasp.Enabled = false;
            dis_en(true);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (spbus.xoaSanPham(tbmasp.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoa that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            SanPham_Load(sender, e);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            ganDuLieu(sppublic);
            if (flag == 0)
            {
                //them
                if (tbmasp.Text != "")
                {
                    if (spbus.themSanPham(sppublic))
                        MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Khong duoc bo trong MaSP", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sua
                if (spbus.suaSanPham(sppublic))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sua that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SanPham_Load(sender, e);
            clear();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon huy thao tac dang lam", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SanPham_Load(sender, e);
                dis_en(false);
            }
            else
                return;
        }
    }
}