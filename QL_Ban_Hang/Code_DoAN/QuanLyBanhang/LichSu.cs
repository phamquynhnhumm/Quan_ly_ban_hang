using System;
using System.Data;
using System.Windows.Forms;
using Public;
using BUS;


namespace QuanLyBanhang
{
    public partial class LichSu : Form
    {
        DataTable da = new System.Data.DataTable();

        DonHangBUS dhbus = new DonHangBUS();
        public LichSu()
        {
            InitializeComponent();

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac muon xoa", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //xoa
                if (dhbus.xoaLichSu(datalichsu.CurrentRow.Cells[0].Value.ToString()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoa that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            LichSu_Load(sender, e);
        }

        private void LichSu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDataSet.DON_HANG' table. You can move, or remove it, as needed.
            this.dON_HANGTableAdapter.Fill(this.banHangDataSet.DON_HANG);
            // TODO: This line of code loads data into the 'banHangDataSet.CT_DON_HANG' table. You can move, or remove it, as needed.
            this.cT_DON_HANGTableAdapter.Fill(this.banHangDataSet.CT_DON_HANG);
            da = dhbus.getLichSu();
            datalichsu.DataSource = da;
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                datalichsu.DataSource = da.Select($"convert({ComboBoxSearch.Text}, 'System.String') Like '%{textBoxSearch.Text}%' ").CopyToDataTable();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy kết quả!");
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cT_DON_HANGTableAdapter.Fill(this.banHangDataSet.CT_DON_HANG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
