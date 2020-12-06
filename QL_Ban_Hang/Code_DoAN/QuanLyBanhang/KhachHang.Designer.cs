namespace QuanLyBanhang
{
    partial class KhachHang
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
            this.datakhachhang = new System.Windows.Forms.DataGridView();
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.labtenkhach = new System.Windows.Forms.Label();
            this.labdiachi = new System.Windows.Forms.Label();
            this.labsdt = new System.Windows.Forms.Label();
            this.labmakh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtenkhach = new System.Windows.Forms.TextBox();
            this.maskedsdt = new System.Windows.Forms.MaskedTextBox();
            this.combodiachi = new System.Windows.Forms.ComboBox();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datakhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // datakhachhang
            // 
            this.datakhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datakhachhang.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.datakhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakhachhang.GridColor = System.Drawing.Color.White;
            this.datakhachhang.Location = new System.Drawing.Point(1, 232);
            this.datakhachhang.Name = "datakhachhang";
            this.datakhachhang.RowHeadersWidth = 62;
            this.datakhachhang.RowTemplate.Height = 28;
            this.datakhachhang.Size = new System.Drawing.Size(1055, 440);
            this.datakhachhang.TabIndex = 76;
            // 
            // tbmakh
            // 
            this.tbmakh.Enabled = false;
            this.tbmakh.Location = new System.Drawing.Point(121, 62);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.Size = new System.Drawing.Size(212, 26);
            this.tbmakh.TabIndex = 71;
            // 
            // labtenkhach
            // 
            this.labtenkhach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtenkhach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labtenkhach.Location = new System.Drawing.Point(23, 98);
            this.labtenkhach.Name = "labtenkhach";
            this.labtenkhach.Size = new System.Drawing.Size(92, 23);
            this.labtenkhach.TabIndex = 69;
            this.labtenkhach.Text = "Tên khách";
            // 
            // labdiachi
            // 
            this.labdiachi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdiachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labdiachi.Location = new System.Drawing.Point(475, 94);
            this.labdiachi.Name = "labdiachi";
            this.labdiachi.Size = new System.Drawing.Size(75, 27);
            this.labdiachi.TabIndex = 68;
            this.labdiachi.Text = "Địa chỉ";
            // 
            // labsdt
            // 
            this.labsdt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labsdt.Location = new System.Drawing.Point(471, 60);
            this.labsdt.Name = "labsdt";
            this.labsdt.Size = new System.Drawing.Size(126, 24);
            this.labsdt.TabIndex = 67;
            this.labsdt.Text = "Số điện thoại";
            // 
            // labmakh
            // 
            this.labmakh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmakh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labmakh.Location = new System.Drawing.Point(23, 64);
            this.labmakh.Name = "labmakh";
            this.labmakh.Size = new System.Drawing.Size(92, 23);
            this.labmakh.TabIndex = 64;
            this.labmakh.Text = "Mã khách";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 33);
            this.label1.TabIndex = 63;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbtenkhach
            // 
            this.tbtenkhach.Enabled = false;
            this.tbtenkhach.Location = new System.Drawing.Point(121, 96);
            this.tbtenkhach.Name = "tbtenkhach";
            this.tbtenkhach.Size = new System.Drawing.Size(212, 26);
            this.tbtenkhach.TabIndex = 84;
            // 
            // maskedsdt
            // 
            this.maskedsdt.Culture = new System.Globalization.CultureInfo("en-TV");
            this.maskedsdt.Enabled = false;
            this.maskedsdt.Location = new System.Drawing.Point(606, 60);
            this.maskedsdt.Mask = "(999) 000-0000";
            this.maskedsdt.Name = "maskedsdt";
            this.maskedsdt.Size = new System.Drawing.Size(205, 26);
            this.maskedsdt.TabIndex = 85;
            // 
            // combodiachi
            // 
            this.combodiachi.Enabled = false;
            this.combodiachi.FormattingEnabled = true;
            this.combodiachi.Items.AddRange(new object[] {
            "Thanh Hoa",
            "Da Nang",
            "Ha Noi",
            "Ho Chi Minh",
            "Quang Nam",
            "Ha Tinh",
            "Nghe An",
            "Quang Ngai",
            "Dak Lak",
            "Gia Lai",
            "Hue"});
            this.combodiachi.Location = new System.Drawing.Point(606, 93);
            this.combodiachi.Name = "combodiachi";
            this.combodiachi.Size = new System.Drawing.Size(205, 28);
            this.combodiachi.TabIndex = 153;
            // 
            // bthuy
            // 
            this.bthuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bthuy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bthuy.Image = global::QuanLyBanhang.Properties.Resources.button11;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(752, 157);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(104, 45);
            this.bthuy.TabIndex = 86;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btluu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btluu.Enabled = false;
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btluu.Image = global::QuanLyBanhang.Properties.Resources.minimize12;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(607, 157);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(104, 45);
            this.btluu.TabIndex = 83;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btsua
            // 
            this.btsua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btsua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btsua.Image = global::QuanLyBanhang.Properties.Resources.edit_user1;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(326, 157);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(104, 45);
            this.btsua.TabIndex = 82;
            this.btsua.Text = "Sửa";
            this.btsua.UseCompatibleTextRendering = true;
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btxoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btxoa.Image = global::QuanLyBanhang.Properties.Resources.remove_user1;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(464, 157);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(104, 45);
            this.btxoa.TabIndex = 81;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btthem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthem.Image = global::QuanLyBanhang.Properties.Resources.add_user1;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(186, 157);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(104, 45);
            this.btthem.TabIndex = 78;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1056, 672);
            this.Controls.Add(this.combodiachi);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.maskedsdt);
            this.Controls.Add(this.tbtenkhach);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.datakhachhang);
            this.Controls.Add(this.tbmakh);
            this.Controls.Add(this.labtenkhach);
            this.Controls.Add(this.labdiachi);
            this.Controls.Add(this.labsdt);
            this.Controls.Add(this.labmakh);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datakhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView datakhachhang;
        private System.Windows.Forms.TextBox tbmakh;
        private System.Windows.Forms.Label labtenkhach;
        private System.Windows.Forms.Label labdiachi;
        private System.Windows.Forms.Label labsdt;
        private System.Windows.Forms.Label labmakh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtenkhach;
        private System.Windows.Forms.MaskedTextBox maskedsdt;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.ComboBox combodiachi;
    }
}