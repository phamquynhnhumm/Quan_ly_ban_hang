namespace QuanLyBanhang
{
    partial class NhaCungCap
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
            this.tbtenncc = new System.Windows.Forms.TextBox();
            this.tbmancc = new System.Windows.Forms.TextBox();
            this.labtenncc = new System.Windows.Forms.Label();
            this.labdiachi = new System.Windows.Forms.Label();
            this.labsdt = new System.Windows.Forms.Label();
            this.labmancc = new System.Windows.Forms.Label();
            this.datanhacungcap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.combodiachi = new System.Windows.Forms.ComboBox();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datanhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedsdt
            // 
            this.maskedsdt.Culture = new System.Globalization.CultureInfo("en-TV");
            this.maskedsdt.Enabled = false;
            this.maskedsdt.Location = new System.Drawing.Point(642, 59);
            this.maskedsdt.Mask = "(999) 000-0000";
            this.maskedsdt.Name = "maskedsdt";
            this.maskedsdt.Size = new System.Drawing.Size(205, 26);
            this.maskedsdt.TabIndex = 130;
            // 
            // tbtenncc
            // 
            this.tbtenncc.Enabled = false;
            this.tbtenncc.Location = new System.Drawing.Point(212, 93);
            this.tbtenncc.Name = "tbtenncc";
            this.tbtenncc.Size = new System.Drawing.Size(161, 26);
            this.tbtenncc.TabIndex = 129;
            // 
            // tbmancc
            // 
            this.tbmancc.Enabled = false;
            this.tbmancc.Location = new System.Drawing.Point(212, 59);
            this.tbmancc.Name = "tbmancc";
            this.tbmancc.Size = new System.Drawing.Size(161, 26);
            this.tbmancc.TabIndex = 127;
            // 
            // labtenncc
            // 
            this.labtenncc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtenncc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labtenncc.Location = new System.Drawing.Point(59, 97);
            this.labtenncc.Name = "labtenncc";
            this.labtenncc.Size = new System.Drawing.Size(147, 23);
            this.labtenncc.TabIndex = 126;
            this.labtenncc.Text = "Tên nhà cung cấp";
            // 
            // labdiachi
            // 
            this.labdiachi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdiachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labdiachi.Location = new System.Drawing.Point(511, 93);
            this.labdiachi.Name = "labdiachi";
            this.labdiachi.Size = new System.Drawing.Size(75, 27);
            this.labdiachi.TabIndex = 125;
            this.labdiachi.Text = "Địa chỉ";
            // 
            // labsdt
            // 
            this.labsdt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labsdt.Location = new System.Drawing.Point(507, 59);
            this.labsdt.Name = "labsdt";
            this.labsdt.Size = new System.Drawing.Size(126, 24);
            this.labsdt.TabIndex = 124;
            this.labsdt.Text = "Số điện thoại";
            // 
            // labmancc
            // 
            this.labmancc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmancc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labmancc.Location = new System.Drawing.Point(59, 63);
            this.labmancc.Name = "labmancc";
            this.labmancc.Size = new System.Drawing.Size(147, 23);
            this.labmancc.TabIndex = 123;
            this.labmancc.Text = "Mã nhà cung cấp";
            // 
            // datanhacungcap
            // 
            this.datanhacungcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datanhacungcap.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.datanhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanhacungcap.GridColor = System.Drawing.Color.White;
            this.datanhacungcap.Location = new System.Drawing.Point(-7, 246);
            this.datanhacungcap.Name = "datanhacungcap";
            this.datanhacungcap.RowHeadersWidth = 62;
            this.datanhacungcap.RowTemplate.Height = 28;
            this.datanhacungcap.Size = new System.Drawing.Size(1074, 415);
            this.datanhacungcap.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 33);
            this.label1.TabIndex = 115;
            this.label1.Text = "NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combodiachi
            // 
            this.combodiachi.Enabled = false;
            this.combodiachi.FormattingEnabled = true;
            this.combodiachi.Items.AddRange(new object[] {
            "Hoa Ky",
            "Nhat Ban",
            "Han Quoc",
            "Thai Lan",
            "Viet Nam",
            "Trung Quoc"});
            this.combodiachi.Location = new System.Drawing.Point(642, 95);
            this.combodiachi.Name = "combodiachi";
            this.combodiachi.Size = new System.Drawing.Size(205, 28);
            this.combodiachi.TabIndex = 153;
            // 
            // btsua
            // 
            this.btsua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btsua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Image = global::QuanLyBanhang.Properties.Resources.edit_user;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(304, 164);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(104, 45);
            this.btsua.TabIndex = 156;
            this.btsua.Text = "Sửa";
            this.btsua.UseCompatibleTextRendering = true;
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btxoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btxoa.Image = global::QuanLyBanhang.Properties.Resources.remove_user;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(442, 164);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(104, 45);
            this.btxoa.TabIndex = 155;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // btthem
            // 
            this.btthem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btthem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btthem.Image = global::QuanLyBanhang.Properties.Resources.add_user;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(174, 164);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(104, 45);
            this.btthem.TabIndex = 154;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // bthuy
            // 
            this.bthuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bthuy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Black;
            this.bthuy.Image = global::QuanLyBanhang.Properties.Resources.button1_Image;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(719, 164);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(104, 45);
            this.bthuy.TabIndex = 122;
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
            this.btluu.ForeColor = System.Drawing.Color.Black;
            this.btluu.Image = global::QuanLyBanhang.Properties.Resources.minimize1;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(576, 164);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(104, 45);
            this.btluu.TabIndex = 119;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 661);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.combodiachi);
            this.Controls.Add(this.maskedsdt);
            this.Controls.Add(this.tbtenncc);
            this.Controls.Add(this.tbmancc);
            this.Controls.Add(this.labtenncc);
            this.Controls.Add(this.labdiachi);
            this.Controls.Add(this.labsdt);
            this.Controls.Add(this.labmancc);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.datanhacungcap);
            this.Controls.Add(this.label1);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedsdt;
        private System.Windows.Forms.TextBox tbtenncc;
        private System.Windows.Forms.TextBox tbmancc;
        private System.Windows.Forms.Label labtenncc;
        private System.Windows.Forms.Label labdiachi;
        private System.Windows.Forms.Label labsdt;
        private System.Windows.Forms.Label labmancc;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.DataGridView datanhacungcap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combodiachi;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
    }
}