namespace OrnekDevExpress.Forms
{
    partial class filmekle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.combotur = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxsalon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxseans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxoyuncu = new System.Windows.Forms.ComboBox();
            this.comboBoxsalonid = new System.Windows.Forms.ComboBox();
            this.comboBoxseansid = new System.Windows.Forms.ComboBox();
            this.comboBoxoyuncuid = new System.Windows.Forms.ComboBox();
            this.comboBoxturid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(137, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 27);
            this.textBox1.TabIndex = 0;
            // 
            // combotur
            // 
            this.combotur.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.combotur.FormattingEnabled = true;
            this.combotur.Location = new System.Drawing.Point(137, 182);
            this.combotur.Name = "combotur";
            this.combotur.Size = new System.Drawing.Size(187, 27);
            this.combotur.TabIndex = 1;
            this.combotur.SelectedIndexChanged += new System.EventHandler(this.combotur_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(137, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tür :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yönetmen :";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(408, 328);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(133, 45);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Ekle";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(547, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(408, 294);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(133, 28);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Text = "Afiş Seç";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salon :";
            // 
            // comboBoxsalon
            // 
            this.comboBoxsalon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxsalon.FormattingEnabled = true;
            this.comboBoxsalon.Location = new System.Drawing.Point(137, 116);
            this.comboBoxsalon.Name = "comboBoxsalon";
            this.comboBoxsalon.Size = new System.Drawing.Size(187, 27);
            this.comboBoxsalon.TabIndex = 14;
            this.comboBoxsalon.SelectedIndexChanged += new System.EventHandler(this.comboBoxsalon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seans :";
            // 
            // comboBoxseans
            // 
            this.comboBoxseans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxseans.FormattingEnabled = true;
            this.comboBoxseans.Location = new System.Drawing.Point(137, 149);
            this.comboBoxseans.Name = "comboBoxseans";
            this.comboBoxseans.Size = new System.Drawing.Size(187, 27);
            this.comboBoxseans.TabIndex = 15;
            this.comboBoxseans.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Oyuncu :";
            // 
            // comboBoxoyuncu
            // 
            this.comboBoxoyuncu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxoyuncu.FormattingEnabled = true;
            this.comboBoxoyuncu.Location = new System.Drawing.Point(137, 248);
            this.comboBoxoyuncu.Name = "comboBoxoyuncu";
            this.comboBoxoyuncu.Size = new System.Drawing.Size(187, 27);
            this.comboBoxoyuncu.TabIndex = 17;
            this.comboBoxoyuncu.SelectedIndexChanged += new System.EventHandler(this.comboBoxoyuncu_SelectedIndexChanged);
            // 
            // comboBoxsalonid
            // 
            this.comboBoxsalonid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxsalonid.FormattingEnabled = true;
            this.comboBoxsalonid.Location = new System.Drawing.Point(466, 12);
            this.comboBoxsalonid.Name = "comboBoxsalonid";
            this.comboBoxsalonid.Size = new System.Drawing.Size(38, 27);
            this.comboBoxsalonid.TabIndex = 19;
            // 
            // comboBoxseansid
            // 
            this.comboBoxseansid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxseansid.FormattingEnabled = true;
            this.comboBoxseansid.Location = new System.Drawing.Point(466, 45);
            this.comboBoxseansid.Name = "comboBoxseansid";
            this.comboBoxseansid.Size = new System.Drawing.Size(38, 27);
            this.comboBoxseansid.TabIndex = 20;
            // 
            // comboBoxoyuncuid
            // 
            this.comboBoxoyuncuid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxoyuncuid.FormattingEnabled = true;
            this.comboBoxoyuncuid.Location = new System.Drawing.Point(422, 45);
            this.comboBoxoyuncuid.Name = "comboBoxoyuncuid";
            this.comboBoxoyuncuid.Size = new System.Drawing.Size(38, 27);
            this.comboBoxoyuncuid.TabIndex = 22;
            // 
            // comboBoxturid
            // 
            this.comboBoxturid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxturid.FormattingEnabled = true;
            this.comboBoxturid.Location = new System.Drawing.Point(422, 12);
            this.comboBoxturid.Name = "comboBoxturid";
            this.comboBoxturid.Size = new System.Drawing.Size(38, 27);
            this.comboBoxturid.TabIndex = 21;
            // 
            // filmekle
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 385);
            this.Controls.Add(this.comboBoxoyuncuid);
            this.Controls.Add(this.comboBoxturid);
            this.Controls.Add(this.comboBoxseansid);
            this.Controls.Add(this.comboBoxsalonid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxoyuncu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxseans);
            this.Controls.Add(this.comboBoxsalon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.combotur);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "filmekle";
            this.Text = "filmekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.filmekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox combotur;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxsalon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxseans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxoyuncu;
        private System.Windows.Forms.ComboBox comboBoxsalonid;
        private System.Windows.Forms.ComboBox comboBoxseansid;
        private System.Windows.Forms.ComboBox comboBoxoyuncuid;
        private System.Windows.Forms.ComboBox comboBoxturid;
    }
}