using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Public;
using BUS;

namespace QuanLyBanHang
{
    public partial class NhanVien : Form
    {
        NhanVienBUS nvbus = new NhanVienBUS();
        NhanVienPublic nvpublic = new NhanVienPublic();
        int flag = 0;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = nvbus.getNhanVien();
            datanhanvien.DataSource = data;
            bingding();
        }
        void bingding()
        {
            tbmanv.DataBindings.Clear();
            tbmanv.DataBindings.Add("Text", datanhanvien.DataSource, "MaNV");
            tbtennv.DataBindings.Clear();
            tbtennv.DataBindings.Add("Text", datanhanvien.DataSource, "TenNV");
            cbbgioitinh.DataBindings.Clear();
            cbbgioitinh.DataBindings.Add("Text", datanhanvien.DataSource, "GioiTinh");
            maskedsdt.DataBindings.Clear();
            maskedsdt.DataBindings.Add("Text", datanhanvien.DataSource, "DienThoai");
            datengaysinh.DataBindings.Clear();
            datengaysinh.DataBindings.Add("Text", datanhanvien.DataSource, "NgaySinh");
            combodiachi.DataBindings.Clear();
            combodiachi.DataBindings.Add("Text", datanhanvien.DataSource, "DiaChi");
        }
        void dis_en(bool e)
        {
            tbtennv.Enabled = e;
            cbbgioitinh.Enabled = e;
            maskedsdt.Enabled = e;
            datengaysinh.Enabled = e;
            combodiachi.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        void clear()
        {
            tbmanv.Text = "";
            tbtennv.Text = "";
            maskedsdt.Text = "";
            combodiachi.Text = "";
        }
        void ganDuLieu(NhanVienPublic nvpublic)
        {
            nvpublic.MANV = tbmanv.Text.Trim();
            nvpublic.TENNV = tbtennv.Text.Trim();
            nvpublic.GIOITINH = cbbgioitinh.Text.Trim();
            nvpublic.DIENTHOAI = maskedsdt.Text.Trim();
            nvpublic.NGAYSINH = DateTime.Parse(datengaysinh.Text.Trim());
            nvpublic.DIACHI = combodiachi.Text.Trim();
        }
       
    
        private void btthem_Click(object sender, EventArgs e)
        {
            {
                flag = 0;
                tbmanv.Enabled = true;
                dis_en(true);
                clear();
                datengaysinh.Text = DateTime.Now.Date.ToShortDateString();
            }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            tbmanv.Enabled = false;
            dis_en(true);
            datengaysinh.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xoa
                if (nvbus.xoaNhanVien(tbmanv.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoa that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            NhanVien_Load(sender, e);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nvpublic);
            if (flag == 0)
            {
                //them
                if (tbmanv.Text != "")
                {
                    if (nvbus.themNhanVien(nvpublic))
                        MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Them that bai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Khong duoc bo trong MaNV", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sua
                if (nvbus.suaNhanVien(nvpublic))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sua that bai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NhanVien_Load(sender, e);
            clear();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon huy thao tac dang lam", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                NhanVien_Load(sender, e);
                dis_en(false);
            }
            else
                return;
        }

       
    }
}