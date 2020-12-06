namespace QuanLyBanhang
{
    partial class DangNhap
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
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.tbtendangnhap = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(32, 134);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(164, 27);
            this.lbTenDangNhap.TabIndex = 3;
            this.lbTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(87, 200);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(109, 27);
            this.lbmatkhau.TabIndex = 4;
            this.lbmatkhau.Text = "Mật Khẩu";
            // 
            // tbtendangnhap
            // 
            this.tbtendangnhap.Location = new System.Drawing.Point(214, 123);
            this.tbtendangnhap.Multiline = true;
            this.tbtendangnhap.Name = "tbtendangnhap";
            this.tbtendangnhap.Size = new System.Drawing.Size(237, 38);
            this.tbtendangnhap.TabIndex = 5;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(214, 191);
            this.tbmatkhau.Multiline = true;
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.PasswordChar = '*';
            this.tbmatkhau.Size = new System.Drawing.Size(237, 40);
            this.tbmatkhau.TabIndex = 7;
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.ForeColor = System.Drawing.Color.Black;
            this.lbdangnhap.Image = global::QuanLyBanhang.Properties.Resources._1269515091_keepassx1;
            this.lbdangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbdangnhap.Location = new System.Drawing.Point(158, 24);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(283, 64);
            this.lbdangnhap.TabIndex = 2;
            this.lbdangnhap.Text = "Đăng Nhập";
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btexit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Image = global::QuanLyBanhang.Properties.Resources._1;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(348, 274);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(109, 52);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btlogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Image = global::QuanLyBanhang.Properties.Resources.ccc;
            this.btlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlogin.Location = new System.Drawing.Point(121, 274);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(116, 52);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(566, 395);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtendangnhap);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.lbdangnhap);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btlogin);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox tbtendangnhap;
        private System.Windows.Forms.TextBox tbmatkhau;
    }
}

