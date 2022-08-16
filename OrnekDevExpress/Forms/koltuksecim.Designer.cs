namespace OrnekDevExpress.Forms
{
    partial class koltuksecim
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
            this.koltukTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaDBDataSet1 = new OrnekDevExpress.SinemaDBDataSet1();
            this.sinemaDBDataSet = new OrnekDevExpress.SinemaDBDataSet();
            this.sinemaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.koltukTBLTableAdapter = new OrnekDevExpress.SinemaDBDataSet1TableAdapters.koltukTBLTableAdapter();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.koltukTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // koltukTBLBindingSource
            // 
            this.koltukTBLBindingSource.DataMember = "koltukTBL";
            this.koltukTBLBindingSource.DataSource = this.sinemaDBDataSet1;
            // 
            // sinemaDBDataSet1
            // 
            this.sinemaDBDataSet1.DataSetName = "SinemaDBDataSet1";
            this.sinemaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemaDBDataSet
            // 
            this.sinemaDBDataSet.DataSetName = "SinemaDBDataSet";
            this.sinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemaDBDataSetBindingSource
            // 
            this.sinemaDBDataSetBindingSource.DataSource = this.sinemaDBDataSet;
            this.sinemaDBDataSetBindingSource.Position = 0;
            // 
            // koltukTBLTableAdapter
            // 
            this.koltukTBLTableAdapter.ClearBeforeFill = true;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientTileButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2GradientTileButton1.BorderThickness = 2;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Maroon;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(12, 12);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(689, 79);
            this.guna2GradientTileButton1.TabIndex = 0;
            this.guna2GradientTileButton1.Text = "PERDE";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 489);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // koltuksecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 598);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "koltuksecim";
            this.Text = "koltuksecim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.koltuksecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koltukTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sinemaDBDataSetBindingSource;
        private SinemaDBDataSet sinemaDBDataSet;
        private SinemaDBDataSet1 sinemaDBDataSet1;
        private System.Windows.Forms.BindingSource koltukTBLBindingSource;
        private SinemaDBDataSet1TableAdapters.koltukTBLTableAdapter koltukTBLTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}