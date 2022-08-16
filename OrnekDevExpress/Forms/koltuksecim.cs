using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace OrnekDevExpress.Forms
{
    public partial class koltuksecim : DevExpress.XtraEditors.XtraForm
    {
        public koltuksecim()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlConnection baglanti;
        SqlCommand komut;
        public static Guna2RadioButton rdbtn;
        private void koltuksecim_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True");

            Olustur();
            // TODO: This line of code loads data into the 'sinemaDBDataSet1.koltukTBL' table. You can move, or remove it, as needed.
            //this.koltukTBLTableAdapter.Fill(this.sinemaDBDataSet1.koltukTBL);
        }
        private void Renkk()
        {
            // rdbtn = bayanradio;

        }
        private void btnMakina_Click(object sender, EventArgs e)
        {
            //veritabanından kkoltuk isimlerini çekme kodu
            //komut = new SqlCommand("select * from koltukTBL");
            //komut.Connection = baglanti;
            //komut.CommandType = CommandType.Text;
            //SqlDataReader dr;
            //baglanti.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    //btn.Text = (dr["koltujk_harf"]);
            //    //btn.Text.Insert(dr["koltujk_harf"]);
            //}
            //baglanti.Close();
            
            Guna2Button btn = (Guna2Button)sender;
            MessageBox.Show(btn.Text);
            if (satis1frm.rdbtn.Checked)
            {
                btn.FillColor = Color.LightPink;
            }
            else if (satis1frm.rdbtn2.Checked)
            {
                btn.FillColor = Color.DodgerBlue;
            }
        }
        private void Olustur()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                FlowLayoutPanel fpnl = this.flowLayoutPanel1;
                fpnl.Controls.Clear();

                int _adet = 90;
                int _genislik = 75;
                int yukseklik = 75;
                string[] harf = { "A", "B", "C", "D", "E", "F", "G", "H" };

                for (int i = 1; i < _adet; i++)
                {
                    Guna2Button btn = new Guna2Button();
                   // SqlCommand komutt = new SqlCommand("select Concat(koltujk_harf,koltuk_rakam) from koltukTBL");
                    btn.Name = ("btn_"+i.ToString());
                    btn.Text = (i.ToString());
                    //"Numaralı Koltuğu Seçmek İstediğinize Eminmisiniz?";
                    btn.Size = new Size(_genislik, yukseklik);
                    //baglanti.Open();
                    //da = new SqlDataAdapter("Select cinsiyet from koltukTBL",baglanti);
                    //da.Fill(btn);
                    btn.Margin = new Padding(10);
                    btn.Click += new System.EventHandler(this.btnMakina_Click);
                    fpnl.Controls.Add(btn);
                    btn.BorderRadius = 5;
                    btn.FillColor = Color.Green;
                    btn.ForeColor = Color.BlanchedAlmond;
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
                return;
            }
            this.Cursor = Cursors.Default;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        //private void guna2CircleButton1_Click(object sender, EventArgs e)
        //{
        //    DialogResult sonuc = MessageBox.Show("Verileri kaydetmek ister misiniz?", "Çıkış yapmak üzeresiniz...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        //    if (sonuc == DialogResult.Yes)
        //    {
        //        Close();
        //    }
        //    else if (sonuc == DialogResult.No)
        //    {
        //        Close();
        //    }
        //    else
        //    {
        //    }
        //}
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}