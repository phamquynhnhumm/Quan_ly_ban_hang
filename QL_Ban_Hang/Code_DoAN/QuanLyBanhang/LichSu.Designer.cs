namespace QuanLyBanhang
{
    partial class LichSu
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
            this.datalichsu = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.dONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDataSet = new QuanLyBanhang.BanHangDataSet1xsd();
            this.cTDONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_DON_HANGTableAdapter = new QuanLyBanhang.BanHangDataSet1xsdTableAdapters.CT_DON_HANGTableAdapter();
            this.dON_HANGTableAdapter = new QuanLyBanhang.BanHangDataSet1xsdTableAdapters.DON_HANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datalichsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDONHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datalichsu
            // 
            this.datalichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datalichsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalichsu.Location = new System.Drawing.Point(13, 12);
            this.datalichsu.Name = "datalichsu";
            this.datalichsu.RowHeadersWidth = 62;
            this.datalichsu.RowTemplate.Height = 28;
            this.datalichsu.Size = new System.Drawing.Size(914, 369);
            this.datalichsu.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch.Location = new System.Drawing.Point(271, 497);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(337, 26);
            this.textBoxSearch.TabIndex = 7;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttimkiem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimkiem.Location = new System.Drawing.Point(145, 453);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(94, 60);
            this.bttimkiem.TabIndex = 6;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = false;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btxoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(21, 453);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(94, 60);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Items.AddRange(new object[] {
            "MaDH",
            "NhanVien",
            "KhachHang",
            "NgayBan",
            "Sanpham",
            "GiaSP",
            "SoLuong",
            "ThanhTien"});
            this.ComboBoxSearch.Location = new System.Drawing.Point(271, 442);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(232, 28);
            this.ComboBoxSearch.TabIndex = 9;
            // 
            // dONHANGBindingSource
            // 
            this.dONHANGBindingSource.DataMember = "DON_HANG";
            this.dONHANGBindingSource.DataSource = this.banHangDataSet;
            // 
            // banHangDataSet
            // 
            this.banHangDataSet.DataSetName = "BanHangDataSet";
            this.banHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTDONHANGBindingSource
            // 
            this.cTDONHANGBindingSource.DataMember = "CT_DON_HANG";
            this.cTDONHANGBindingSource.DataSource = this.banHangDataSet;
            // 
            // cT_DON_HANGTableAdapter
            // 
            this.cT_DON_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // dON_HANGTableAdapter
            // 
            this.dON_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(941, 550);
            this.Controls.Add(this.ComboBoxSearch);
            this.Controls.Add(this.datalichsu);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.btxoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LichSu";
            this.Text = "Lịch Sử";
            this.Load += new System.EventHandler(this.LichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalichsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDONHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datalichsu;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.ComboBox ComboBoxSearch;
        private BanHangDataSet1xsd banHangDataSet;
        private System.Windows.Forms.BindingSource cTDONHANGBindingSource;
        private BanHangDataSet1xsdTableAdapters.CT_DON_HANGTableAdapter cT_DON_HANGTableAdapter;
        private System.Windows.Forms.BindingSource dONHANGBindingSource;
        private BanHangDataSet1xsdTableAdapters.DON_HANGTableAdapter dON_HANGTableAdapter;

    }
}