namespace QuanLyBanHang
{
    partial class NhanVien
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
            this.maskedsdt = new System.Windows.Forms.MaskedTextBox();
            this.datanhanvien = new System.Windows.Forms.DataGridView();
            this.tbtennv = new System.Windows.Forms.TextBox();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.cbbgioitinh = new System.Windows.Forms.ComboBox();
            this.labgioitinh = new System.Windows.Forms.Label();
            this.labdiachi = new System.Windows.Forms.Label();
            this.labsdt = new System.Windows.Forms.Label();
            this.labngaysinh = new System.Windows.Forms.Label();
            this.labtennv = new System.Windows.Forms.Label();
            this.labmanv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.combodiachi = new System.Windows.Forms.ComboBox();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datanhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedsdt
            // 
            this.maskedsdt.Culture = new System.Globalization.CultureInfo("en-TV");
            this.maskedsdt.Enabled = false;
            this.maskedsdt.Location = new System.Drawing.Point(824, 58);
            this.maskedsdt.Mask = "(999) 000-0000";
            this.maskedsdt.Name = "maskedsdt";
            this.maskedsdt.Size = new System.Drawing.Size(205, 26);
            this.maskedsdt.TabIndex = 148;
            // 
            // datanhanvien
            // 
            this.datanhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datanhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datanhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanhanvien.GridColor = System.Drawing.Color.White;
            this.datanhanvien.Location = new System.Drawing.Point(-4, 237);
            this.datanhanvien.Name = "datanhanvien";
            this.datanhanvien.RowHeadersWidth = 62;
            this.datanhanvien.RowTemplate.Height = 28;
            this.datanhanvien.Size = new System.Drawing.Size(1074, 456);
            this.datanhanvien.TabIndex = 141;
            // 
            // tbtennv
            // 
            this.tbtennv.AllowDrop = true;
            this.tbtennv.Enabled = false;
            this.tbtennv.Location = new System.Drawing.Point(457, 56);
            this.tbtennv.Name = "tbtennv";
            this.tbtennv.Size = new System.Drawing.Size(187, 26);
            this.tbtennv.TabIndex = 138;
            // 
            // tbmanv
            // 
            this.tbmanv.Enabled = false;
            this.tbmanv.Location = new System.Drawing.Point(144, 56);
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(184, 26);
            this.tbmanv.TabIndex = 137;
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.Enabled = false;
            this.cbbgioitinh.FormattingEnabled = true;
            this.cbbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbgioitinh.Location = new System.Drawing.Point(144, 96);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Size = new System.Drawing.Size(184, 28);
            this.cbbgioitinh.TabIndex = 136;
            // 
            // labgioitinh
            // 
            this.labgioitinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labgioitinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labgioitinh.Location = new System.Drawing.Point(26, 99);
            this.labgioitinh.Name = "labgioitinh";
            this.labgioitinh.Size = new System.Drawing.Size(92, 23);
            this.labgioitinh.TabIndex = 135;
            this.labgioitinh.Text = "Giới tính";
            // 
            // labdiachi
            // 
            this.labdiachi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdiachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labdiachi.Location = new System.Drawing.Point(688, 92);
            this.labdiachi.Name = "labdiachi";
            this.labdiachi.Size = new System.Drawing.Size(75, 22);
            this.labdiachi.TabIndex = 134;
            this.labdiachi.Text = "Địa chỉ";
            // 
            // labsdt
            // 
            this.labsdt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labsdt.Location = new System.Drawing.Point(688, 54);
            this.labsdt.Name = "labsdt";
            this.labsdt.Size = new System.Drawing.Size(133, 26);
            this.labsdt.TabIndex = 133;
            this.labsdt.Text = "Số điện thoại";
            // 
            // labngaysinh
            // 
            this.labngaysinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labngaysinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labngaysinh.Location = new System.Drawing.Point(335, 100);
            this.labngaysinh.Name = "labngaysinh";
            this.labngaysinh.Size = new System.Drawing.Size(98, 23);
            this.labngaysinh.TabIndex = 132;
            this.labngaysinh.Text = "Ngày sinh";
            // 
            // labtennv
            // 
            this.labtennv.AllowDrop = true;
            this.labtennv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtennv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labtennv.Location = new System.Drawing.Point(335, 58);
            this.labtennv.Name = "labtennv";
            this.labtennv.Size = new System.Drawing.Size(132, 26);
            this.labtennv.TabIndex = 131;
            this.labtennv.Text = "Tên nhân viên";
            // 
            // labmanv
            // 
            this.labmanv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmanv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labmanv.Location = new System.Drawing.Point(26, 56);
            this.labmanv.Name = "labmanv";
            this.labmanv.Size = new System.Drawing.Size(126, 26);
            this.labmanv.TabIndex = 130;
            this.labmanv.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 33);
            this.label1.TabIndex = 129;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Enabled = false;
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(457, 96);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(187, 26);
            this.datengaysinh.TabIndex = 150;
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
            this.combodiachi.Location = new System.Drawing.Point(824, 96);
            this.combodiachi.Name = "combodiachi";
            this.combodiachi.Size = new System.Drawing.Size(205, 28);
            this.combodiachi.TabIndex = 152;
            // 
            // bthuy
            // 
            this.bthuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bthuy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bthuy.Image = global::QuanLyBanhang.Properties.Resources.button1_Image;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(785, 159);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(104, 45);
            this.bthuy.TabIndex = 151;
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
            this.btluu.Image = global::QuanLyBanhang.Properties.Resources.minimize1;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(644, 159);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(104, 45);
            this.btluu.TabIndex = 147;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btsua
            // 
            this.btsua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btsua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Image = global::QuanLyBanhang.Properties.Resources.edit_user;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(363, 159);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(104, 45);
            this.btsua.TabIndex = 146;
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
            this.btxoa.Image = global::QuanLyBanhang.Properties.Resources.remove_user;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(501, 159);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(104, 45);
            this.btxoa.TabIndex = 145;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btthem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btthem.Image = global::QuanLyBanhang.Properties.Resources.add_user;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(224, 159);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(104, 45);
            this.btthem.TabIndex = 143;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1076, 691);
            this.Controls.Add(this.combodiachi);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.maskedsdt);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.datanhanvien);
            this.Controls.Add(this.tbtennv);
            this.Controls.Add(this.tbmanv);
            this.Controls.Add(this.cbbgioitinh);
            this.Controls.Add(this.labgioitinh);
            this.Controls.Add(this.labdiachi);
            this.Controls.Add(this.labsdt);
            this.Controls.Add(this.labngaysinh);
            this.Controls.Add(this.labtennv);
            this.Controls.Add(this.labmanv);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedsdt;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView datanhanvien;
        private System.Windows.Forms.TextBox tbtennv;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.ComboBox cbbgioitinh;
        private System.Windows.Forms.Label labgioitinh;
        private System.Windows.Forms.Label labdiachi;
        private System.Windows.Forms.Label labsdt;
        private System.Windows.Forms.Label labngaysinh;
        private System.Windows.Forms.Label labtennv;
        private System.Windows.Forms.Label labmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.ComboBox combodiachi;
    }
}