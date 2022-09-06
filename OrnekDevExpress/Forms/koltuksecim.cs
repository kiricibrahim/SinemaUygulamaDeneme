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
using Dapper;

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
        public static Guna2ComboBox combosalonn;
        public static Guna2Button bttnn;
        public static SqlConnection cmd;
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
        public void Olustur()
        {
            
            if (satis1frm.combosalonn.SelectedIndex==0)//index 1 salon 2 index 2 salon 3 
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    List<koltukTBL> lst = new List<koltukTBL>();
                    string sql = $@"SELECT        dbo.koltukTBL.koltuk_id, dbo.koltukTBL.salon_id, dbo.koltukTBL.koltuk_harf, dbo.koltukTBL.koltuk_sira, dbo.koltukTBL.cinsiyet, dbo.biletTBL.bilet_id, dbo.biletTBL.bilet_adi, dbo.biletTBL.film_id, dbo.biletTBL.koltuk_id AS Expr1, 
                         dbo.biletTBL.salon_id AS Expr2, dbo.biletTBL.seans_id, dbo.biletTBL.musteri_adi, dbo.biletTBL.musteri_yas, dbo.biletTBL.cinsiyet AS Expr3, dbo.biletTBL.ucret
FROM            dbo.koltukTBL LEFT OUTER JOIN
                         dbo.biletTBL ON dbo.koltukTBL.koltuk_id = dbo.biletTBL.koltuk_id
WHERE        (dbo.koltukTBL.salon_id = 1)";

                    using (var connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
                    {
                        lst = connection.Query<koltukTBL>(sql).ToList();
                    }
                    FlowLayoutPanel fpnl = this.flowLayoutPanel1;
                    fpnl.Controls.Clear();
                    int _adet = lst.Count;
                    int _genislik = 80;
                    int _yukseklik = 80;

                    foreach (koltukTBL item in lst)
                    {
                        Guna2Button btn = new Guna2Button();
                        
                        // SqlCommand komutt = new SqlCommand("select Concat(koltujk_harf,koltuk_rakam) from koltukTBL");
                        btn.Name = ("btn_" + item.koltuk_id);
                        btn.Text = (item.koltuk_harf + item.koltuk_sira);
                        //"Numaralı Koltuğu Seçmek İstediğinize Eminmisiniz?";
                        btn.Size = new Size(_genislik, _yukseklik);
                        //baglanti.Open();
                        //da = new SqlDataAdapter("Select cinsiyet from koltukTBL",baglanti);
                        //da.Fill(btn);
                        btn.Margin = new Padding(10);
                        btn.Click += new System.EventHandler(this.btnMakina_Click);
                        fpnl.Controls.Add(btn);
                        btn.BorderRadius = 5;

                        biletTBL blt = new biletTBL();
                     
                        if (item.cinsiyet == 'E')
                        {
                            btn.FillColor = Color.DodgerBlue;
                        }
                        else if (item.cinsiyet == 'K')
                        {
                            btn.FillColor = Color.DeepPink;
                        }
                        else
                        {
                            btn.FillColor = Color.ForestGreen;
                        }

                        btn.ForeColor = Color.BlanchedAlmond;

                        bttnn = btn;
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
            if (satis1frm.combosalonn.SelectedIndex == 1)//index 1 salon 2 index 2 salon 3 
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    List<koltukTBL> lst = new List<koltukTBL>();
                    string sql = $@"SELECT        dbo.koltukTBL.koltuk_id, dbo.koltukTBL.salon_id, dbo.koltukTBL.koltuk_harf, dbo.koltukTBL.koltuk_sira, dbo.koltukTBL.cinsiyet, dbo.biletTBL.bilet_id, dbo.biletTBL.bilet_adi, dbo.biletTBL.film_id, dbo.biletTBL.koltuk_id AS Expr1, 
                         dbo.biletTBL.salon_id AS Expr2, dbo.biletTBL.seans_id, dbo.biletTBL.musteri_adi, dbo.biletTBL.musteri_yas, dbo.biletTBL.cinsiyet AS Expr3, dbo.biletTBL.ucret
FROM            dbo.koltukTBL LEFT OUTER JOIN
                         dbo.biletTBL ON dbo.koltukTBL.koltuk_id = dbo.biletTBL.koltuk_id
WHERE        (dbo.koltukTBL.salon_id = 2)";

                    using (var connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
                    {
                        lst = connection.Query<koltukTBL>(sql).ToList();
                    }
                    FlowLayoutPanel fpnl = this.flowLayoutPanel1;
                    fpnl.Controls.Clear();
                    int _adet = lst.Count;
                    int _genislik = 80;
                    int _yukseklik = 80;

                    foreach (koltukTBL item in lst)
                    {
                        Guna2Button btn = new Guna2Button();
                        // SqlCommand komutt = new SqlCommand("select Concat(koltujk_harf,koltuk_rakam) from koltukTBL");
                        btn.Name = ("btn_" + item.koltuk_id);
                        btn.Text = (item.koltuk_harf + item.koltuk_sira);
                        //"Numaralı Koltuğu Seçmek İstediğinize Eminmisiniz?";
                        btn.Size = new Size(_genislik, _yukseklik);
                        //baglanti.Open();
                        //da = new SqlDataAdapter("Select cinsiyet from koltukTBL",baglanti);
                        //da.Fill(btn);
                        btn.Margin = new Padding(10);
                        btn.Click += new System.EventHandler(this.btnMakina_Click);
                        fpnl.Controls.Add(btn);
                        btn.BorderRadius = 5;

                        if (item.cinsiyet == 'E')
                        {
                            btn.FillColor = Color.DodgerBlue;
                        }
                        else if (item.cinsiyet == 'K')
                        {
                            btn.FillColor = Color.DeepPink;
                        }
                        else
                        {
                            btn.FillColor = Color.Green;
                        }

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
            if (satis1frm.combosalonn.SelectedIndex == 2)//index 1 salon 2 index 2 salon 3 
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    List<koltukTBL> lst = new List<koltukTBL>();
                    string sql = $@"SELECT        dbo.koltukTBL.koltuk_id, dbo.koltukTBL.salon_id, dbo.koltukTBL.koltuk_harf, dbo.koltukTBL.koltuk_sira, dbo.koltukTBL.cinsiyet, dbo.biletTBL.bilet_id, dbo.biletTBL.bilet_adi, dbo.biletTBL.film_id, dbo.biletTBL.koltuk_id AS Expr1, 
                         dbo.biletTBL.salon_id AS Expr2, dbo.biletTBL.seans_id, dbo.biletTBL.musteri_adi, dbo.biletTBL.musteri_yas, dbo.biletTBL.cinsiyet AS Expr3, dbo.biletTBL.ucret
FROM            dbo.koltukTBL LEFT OUTER JOIN
                         dbo.biletTBL ON dbo.koltukTBL.koltuk_id = dbo.biletTBL.koltuk_id
WHERE        (dbo.koltukTBL.salon_id = 3)";

                    using (var connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
                    {
                        lst = connection.Query<koltukTBL>(sql).ToList();
                    }
                    FlowLayoutPanel fpnl = this.flowLayoutPanel1;
                    fpnl.Controls.Clear();
                    int _adet = lst.Count;
                    int _genislik = 80;
                    int _yukseklik = 80;

                    foreach (koltukTBL item in lst)
                    {
                        Guna2Button btn = new Guna2Button();
                        // SqlCommand komutt = new SqlCommand("select Concat(koltujk_harf,koltuk_rakam) from koltukTBL");
                        btn.Name = ("btn_" + item.koltuk_id);
                        btn.Text = (item.koltuk_harf + item.koltuk_sira);
                        //"Numaralı Koltuğu Seçmek İstediğinize Eminmisiniz?";
                        btn.Size = new Size(_genislik, _yukseklik);
                        //baglanti.Open();
                        //da = new SqlDataAdapter("Select cinsiyet from koltukTBL",baglanti);
                        //da.Fill(btn);
                        btn.Margin = new Padding(10);
                        btn.Click += new System.EventHandler(this.btnMakina_Click);
                        fpnl.Controls.Add(btn);
                        btn.BorderRadius = 5;

                        if (item.cinsiyet == 'E')
                        {
                            btn.FillColor = Color.DodgerBlue;
                        }
                        else if (item.cinsiyet == 'K')
                        {
                            btn.FillColor = Color.DeepPink;
                        }
                        else 
                        {
                            btn.FillColor = Color.ForestGreen;
                                
                        }
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
        }
       
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}