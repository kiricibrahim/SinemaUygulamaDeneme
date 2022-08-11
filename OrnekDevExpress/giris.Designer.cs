namespace OrnekDevExpress
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.cikis_btn = new Guna.UI2.WinForms.Guna2Button();
            this.giris_btn = new Guna.UI2.WinForms.Guna2Button();
            this.txt_kullaniciadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.cikis_btn.BorderThickness = 1;
            this.cikis_btn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cikis_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cikis_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cikis_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cikis_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cikis_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cikis_btn.FocusedColor = System.Drawing.Color.Red;
            this.cikis_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cikis_btn.ForeColor = System.Drawing.Color.White;
            this.cikis_btn.Location = new System.Drawing.Point(157, 255);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(93, 36);
            this.cikis_btn.TabIndex = 8;
            this.cikis_btn.Text = "Çıkış";
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // giris_btn
            // 
            this.giris_btn.Animated = true;
            this.giris_btn.BackColor = System.Drawing.Color.Transparent;
            this.giris_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.giris_btn.BorderThickness = 1;
            this.giris_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.giris_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.giris_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.giris_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.giris_btn.FillColor = System.Drawing.Color.Silver;
            this.giris_btn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.giris_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.giris_btn.ForeColor = System.Drawing.Color.Black;
            this.giris_btn.Location = new System.Drawing.Point(50, 255);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(101, 36);
            this.giris_btn.TabIndex = 7;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kullaniciadi.DefaultText = "Kullanıcı Adı :";
            this.txt_kullaniciadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_kullaniciadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_kullaniciadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kullaniciadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kullaniciadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kullaniciadi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_kullaniciadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kullaniciadi.Location = new System.Drawing.Point(50, 171);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.PasswordChar = '\0';
            this.txt_kullaniciadi.PlaceholderText = "";
            this.txt_kullaniciadi.SelectedText = "";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(200, 36);
            this.txt_kullaniciadi.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.DefaultText = "Şifre :";
            this.txt_sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sifre.Location = new System.Drawing.Point(50, 213);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '\0';
            this.txt_sifre.PlaceholderText = "";
            this.txt_sifre.SelectedText = "";
            this.txt_sifre.Size = new System.Drawing.Size(200, 36);
            this.txt_sifre.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Lütfen Kullanıcı Adı ve Şifre Giriniz.";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(321, 322);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.giris_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris";
            this.Text = "giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button cikis_btn;
        private Guna.UI2.WinForms.Guna2Button giris_btn;
        private Guna.UI2.WinForms.Guna2TextBox txt_kullaniciadi;
        private Guna.UI2.WinForms.Guna2TextBox txt_sifre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}