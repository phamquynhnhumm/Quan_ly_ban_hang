namespace QuanLyBanhang
{
    partial class DoiMatKhau
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
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.tbmatkhaucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbmatkhaumoi = new System.Windows.Forms.TextBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btdoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.ForeColor = System.Drawing.Color.Black;
            this.lbdangnhap.Location = new System.Drawing.Point(167, 24);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(375, 63);
            this.lbdangnhap.TabIndex = 2;
            this.lbdangnhap.Text = "Đổi Mật Khẩu";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(56, 114);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(143, 27);
            this.lbmatkhau.TabIndex = 4;
            this.lbmatkhau.Text = "Mật Khẩu Cũ";
            // 
            // tbmatkhaucu
            // 
            this.tbmatkhaucu.AllowDrop = true;
            this.tbmatkhaucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmatkhaucu.Location = new System.Drawing.Point(226, 103);
            this.tbmatkhaucu.Multiline = true;
            this.tbmatkhaucu.Name = "tbmatkhaucu";
            this.tbmatkhaucu.PasswordChar = '*';
            this.tbmatkhaucu.Size = new System.Drawing.Size(237, 38);
            this.tbmatkhaucu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật Khẩu Mới";
            // 
            // tbmatkhaumoi
            // 
            this.tbmatkhaumoi.AllowDrop = true;
            this.tbmatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmatkhaumoi.Location = new System.Drawing.Point(226, 191);
            this.tbmatkhaumoi.Multiline = true;
            this.tbmatkhaumoi.Name = "tbmatkhaumoi";
            this.tbmatkhaumoi.PasswordChar = '*';
            this.tbmatkhaumoi.Size = new System.Drawing.Size(237, 38);
            this.tbmatkhaumoi.TabIndex = 8;
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btexit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Image = global::QuanLyBanhang.Properties.Resources.button3_Image;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(399, 275);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(109, 40);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "Hủy";
            this.btexit.UseVisualStyleBackColor = false;
            // 
            // btdoi
            // 
            this.btdoi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btdoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdoi.ForeColor = System.Drawing.Color.Black;
            this.btdoi.Image = global::QuanLyBanhang.Properties.Resources.BAOCAO;
            this.btdoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdoi.Location = new System.Drawing.Point(132, 275);
            this.btdoi.Name = "btdoi";
            this.btdoi.Size = new System.Drawing.Size(111, 40);
            this.btdoi.TabIndex = 0;
            this.btdoi.Text = "Đổi";
            this.btdoi.UseVisualStyleBackColor = false;
            this.btdoi.Click += new System.EventHandler(this.btdoi_Click);
            // 
            // DoiMatKhau
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(626, 395);
            this.Controls.Add(this.tbmatkhaumoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbmatkhaucu);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbdangnhap);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btdoi);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btdoi;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox tbmatkhaucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmatkhaumoi;
    }
}