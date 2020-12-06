using System;
using System.Data;
using System.Windows.Forms;
using Public;
using BUS;
using QuanLyBanHang;

namespace QuanLyBanhang
{
    public partial class DonHang : Form
    {
        public DonHangBUS dhbus = new DonHangBUS();
        public CTDonHangBUS ctdhbus = new CTDonHangBUS();
        public SanPhamBUS spbus = new SanPhamBUS();
        public KhachHangBUS khbus = new KhachHangBUS();
        public NhanVienBUS NVBUS = new NhanVienBUS();

        public DataTable DS_đơn_hàng = new DataTable();
        public DataTable DS_chi_tiết_đơn = new DataTable();
        public DataTable DS_khách_hàng = new DataTable();
        public DataTable DS_sản_phẩm = new DataTable();
        public TaiKhoanPublic Tài_khoản;
        public NhanVienPublic Nhân_viên;

        public DonHang(TaiKhoanPublic Tài_khoản)
        {
            InitializeComponent();
            this.Tài_khoản = Tài_khoản;
            Tải_Dữ_Liệu();

            Liên_Kết();
        }
        private void Tải_Dữ_Liệu()
        {
            Nhân_viên = NVBUS.Lấy_Nhân_Viên_Với_Tên(Tài_khoản.TENTAIKHOAN);
            DS_khách_hàng = khbus.getKhachHang();
            DS_sản_phẩm = spbus.getSanPham();
            DS_đơn_hàng = dhbus.getDonHang();

        }
        private void Liên_Kết()
        {
            DGDonHang.DataSource = DS_đơn_hàng;
            tbmadh.DataBindings.Clear();
            tbmadh.DataBindings.Add("Text", DGDonHang.DataSource, "MaDH");
            textBoxMaNV.DataBindings.Clear();
            textBoxMaNV.DataBindings.Add("Text", DGDonHang.DataSource, "MaNV");
            tbnhanvien.DataBindings.Clear();
            tbnhanvien.DataBindings.Add("Text", DGDonHang.DataSource, "NhanVien");
            combokh.DataBindings.Clear();
            combokh.DataBindings.Add("Text", DGDonHang.DataSource, "KhachHang");
            datengayban.DataBindings.Clear();
            datengayban.DataBindings.Add("Text", DGDonHang.DataSource, "NgayBan");

            combokh.DataSource = DS_khách_hàng;
            combokh.DisplayMember = "TenKH";
            combokh.ValueMember = "MaKH";
            combokh.SelectedIndex = 0;

            combosp.DataSource = DS_sản_phẩm;

            combosp.DisplayMember = "TenSP";
            combosp.ValueMember = "MaSP";
            combosp.SelectedIndex = 0;
            combosp_SelectedIndexChanged(null, null);



        }
        private void tbmadh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DS_chi_tiết_đơn = ctdhbus.getCTDonHang(tbmadh.Text.Trim());
                DGChiTietDonHang.DataSource = DS_chi_tiết_đơn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bttaomoi_Click(object sender, EventArgs e)
        {

            tbmadh.Text = "";
            combokh.Text = "";
            tbnhanvien.Text = "";
            datengayban.Text = DateTime.Now.Date.ToShortDateString();
            tbnhanvien.Text = Nhân_viên.TENNV;
            textBoxMaNV.Text = Nhân_viên.MANV;
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            DonHangPublic dhpublic = new DonHangPublic();
            dhpublic.MADH = tbmadh.Text.Trim();
            dhpublic.NGAYBAN = DateTime.Parse(datengayban.Text.Trim());
            dhpublic.KHACHHANG = combokh.SelectedValue.ToString();
            dhpublic.NHANVIEN = textBoxMaNV.Text.Trim();
            try
            {
                if (dhbus.themDonHang(dhpublic))
                    MessageBox.Show("Thêm đơn hàng thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Them don hang that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DS_đơn_hàng = dhbus.getDonHang();
                DGDonHang.DataSource = DS_đơn_hàng;
            }


        }


        private void btthem_Click(object sender, EventArgs e)
        {
            CTDonHangPublic CT = new CTDonHangPublic();
            CT.MASP = textBoxmasp.Text.Trim();
            CT.GIASP = Convert.ToInt32(tbgiasp.Text);
            CT.MADH = tbmadh.Text.Trim();
            CT.SL = Convert.ToInt32(tbsoluong.Text);

            if (ctdhbus.Tồn_tại(CT))
            {
                ctdhbus.cập_nhật_số_lượng(CT);
            }
            else
            {
                ctdhbus.thêm(CT);
            };
            DS_chi_tiết_đơn = ctdhbus.getCTDonHang(CT.MADH);
            DGChiTietDonHang.DataSource = DS_chi_tiết_đơn;


        }

        private void btbot_Click(object sender, EventArgs e)
        {
            CTDonHangPublic CT = new CTDonHangPublic();
            CT.MASP = textBoxmasp.Text.Trim();
            CT.GIASP = Convert.ToInt32(tbgiasp.Text);
            CT.MADH = tbmadh.Text.Trim();
            CT.SL = Convert.ToInt32(tbsoluong.Text);
            if (ctdhbus.Tồn_tại(CT))
            {
                ctdhbus.bớt(CT);
            }
            DS_chi_tiết_đơn = ctdhbus.getCTDonHang(CT.MADH);
            DGChiTietDonHang.DataSource = DS_chi_tiết_đơn;
        }
        private void combosp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = spbus.getSanPham("and MaSP = '" + combosp.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                float gia = float.Parse(dt.Rows[0][3].ToString());

                tbgiasp.Text = (gia * 1.1).ToString();

                lbthanhtien.Text = (float.Parse(tbgiasp.Text) * int.Parse(tbsoluong.Text)).ToString();
                textBoxmasp.Text = dt.Rows[0][0].ToString();

            }
        }
        private void tbsoluong_TextChanged(object sender, EventArgs e)
        {
            float giasp;
            float.TryParse(tbgiasp.Text, out giasp);
            int soluong;
            Int32.TryParse(tbsoluong.Text, out soluong);
            lbthanhtien.Text = (giasp * soluong).ToString();
        }

        private void datadonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
