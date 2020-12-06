namespace QuanLyBanhang
{
    partial class QLBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.frmNhacc = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.frmKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.frmNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.frmHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDonhang = new System.Windows.Forms.ToolStripMenuItem();
            this.frmtaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmdoimk = new System.Windows.Forms.ToolStripMenuItem();
            this.frmLichsu = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmDanhmuc,
            this.frmHoadon,
            this.frmtaikhoan,
            this.frmLichsu,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmDanhmuc
            // 
            this.frmDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmNhacc,
            this.frmSanpham,
            this.frmKhachhang,
            this.frmNhanvien});
            this.frmDanhmuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frmDanhmuc.Name = "frmDanhmuc";
            this.frmDanhmuc.Size = new System.Drawing.Size(109, 29);
            this.frmDanhmuc.Text = "&Danh Mục";
            this.frmDanhmuc.Click += new System.EventHandler(this.frmDanhmuc_Click);
            // 
            // frmNhacc
            // 
            this.frmNhacc.Image = global::QuanLyBanhang.Properties.Resources.trangchu;
            this.frmNhacc.Name = "frmNhacc";
            this.frmNhacc.Size = new System.Drawing.Size(229, 34);
            this.frmNhacc.Text = "&Nhà Cung Cấp";
            this.frmNhacc.Click += new System.EventHandler(this.frmNhacc_Click);
            // 
            // frmSanpham
            // 
            this.frmSanpham.Image = global::QuanLyBanhang.Properties.Resources.sanpham;
            this.frmSanpham.Name = "frmSanpham";
            this.frmSanpham.Size = new System.Drawing.Size(229, 34);
            this.frmSanpham.Text = "&Sản Phẩm";
            this.frmSanpham.Click += new System.EventHandler(this.frmSanpham_Click);
            // 
            // frmKhachhang
            // 
            this.frmKhachhang.Image = global::QuanLyBanhang.Properties.Resources.khachhang;
            this.frmKhachhang.Name = "frmKhachhang";
            this.frmKhachhang.Size = new System.Drawing.Size(229, 34);
            this.frmKhachhang.Text = "&Khách Hàng";
            this.frmKhachhang.Click += new System.EventHandler(this.frmKhachhang_Click);
            // 
            // frmNhanvien
            // 
            this.frmNhanvien.Image = global::QuanLyBanhang.Properties.Resources.chu;
            this.frmNhanvien.Name = "frmNhanvien";
            this.frmNhanvien.Size = new System.Drawing.Size(229, 34);
            this.frmNhanvien.Text = "&Nhân Viên";
            this.frmNhanvien.Click += new System.EventHandler(this.frmNhanvien_Click);
            // 
            // frmHoadon
            // 
            this.frmHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmDonhang});
            this.frmHoadon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.frmHoadon.Name = "frmHoadon";
            this.frmHoadon.Size = new System.Drawing.Size(100, 29);
            this.frmHoadon.Text = "&Hóa Đơn";
            // 
            // frmDonhang
            // 
            this.frmDonhang.Image = global::QuanLyBanhang.Properties.Resources.hoadon;
            this.frmDonhang.Name = "frmDonhang";
            this.frmDonhang.Size = new System.Drawing.Size(196, 34);
            this.frmDonhang.Text = "&Đơn Hàng";
            this.frmDonhang.Click += new System.EventHandler(this.frmDonhang_Click);
            // 
            // frmtaikhoan
            // 
            this.frmtaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.frmdoimk});
            this.frmtaikhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frmtaikhoan.Name = "frmtaikhoan";
            this.frmtaikhoan.Size = new System.Drawing.Size(103, 29);
            this.frmtaikhoan.Text = "&Tài Khoản";
            this.frmtaikhoan.Click += new System.EventHandler(this.frmtaikhoan_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tàiKhoảnToolStripMenuItem.Text = "&Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // frmdoimk
            // 
            this.frmdoimk.Name = "frmdoimk";
            this.frmdoimk.Size = new System.Drawing.Size(270, 34);
            this.frmdoimk.Text = "&Đổi Mật Khẩu";
            this.frmdoimk.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // frmLichsu
            // 
            this.frmLichsu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frmLichsu.Name = "frmLichsu";
            this.frmLichsu.Size = new System.Drawing.Size(84, 29);
            this.frmLichsu.Text = "&Lịch Sử";
            this.frmLichsu.Click += new System.EventHandler(this.frmLichsu_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.trợGiúpToolStripMenuItem.Text = "&Trợ Giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // QLBanHang
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::QuanLyBanhang.Properties.Resources._34111331981_80664f28e0_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 458);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLBanHang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Quản Lý Bán Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QLBanHang_FormClosed);
            this.Load += new System.EventHandler(this.QLBanHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem frmNhacc;
        private System.Windows.Forms.ToolStripMenuItem frmSanpham;
        private System.Windows.Forms.ToolStripMenuItem frmKhachhang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmNhanvien;
        private System.Windows.Forms.ToolStripMenuItem frmHoadon;
        private System.Windows.Forms.ToolStripMenuItem frmDonhang;
        private System.Windows.Forms.ToolStripMenuItem frmtaikhoan;
        private System.Windows.Forms.ToolStripMenuItem frmLichsu;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmdoimk;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}