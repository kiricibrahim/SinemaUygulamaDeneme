using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Collections;
using System.Threading;
using System.IO;

namespace OrnekDevExpress.Forms
{
    public partial class satis1frm : DevExpress.XtraEditors.XtraForm
    {
        public satis1frm()
        {
            InitializeComponent();
        }

        SqlConnectionStringBuilder csb;
        SqlDataAdapter da;
        SqlConnection baglanti;
        SqlCommand komut;
        DataTable dt;
        Button butons;
        Button butonb;
        public string film_Adi = "";
        public string salon_Adi = "";
        public string seans = "";
        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();
        int filmID ;
        int salonID ;




        private void backstageViewControl1_Click(object sender, EventArgs e)
        {

        }

        private void satis1frm_Load(object sender, EventArgs e)
        {
            //csb=new SqlConnectionStringBuilder();
            //csb.Server = 'DESKTOP-AGRIQC6\SQLEXPRESS';
            //			connetionString = ""

            baglanti = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True");

            komut = new SqlCommand("select film_id, film_adi from filmlerTBL", baglanti);
            yenilebutonu();
            salonlistele();
            filmlistele();
            seanslistele();
            //AfisGoruntule();
            //tiklananboyansin();
        }

        

        void baglantiKur()//www.gorselprogramlama.com
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        string araGetir(string sql)
        {
            baglantiKur();
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            string deger = oku[0].ToString();
            baglanti.Close();//www.gorselprogramlama.com
            return deger;
        }
        void bilet_ayir()
        {
            baglantiKur();
            string ucret = "";
            if (rdogrenci.Checked) ucret = "6";
            else ucret = "10";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                string ekleme = "INSERT INTO biletTBL(film_id,koltuk_id,salon_id,seans_id,musteri_adi,musteri_yas,cinsiyet,ucret)values(" + ")";

            }
    }

        private void guna2Button100_Click(object sender, EventArgs e)
        {

        }
        void bay_bayansecim()
        {
            


        }
        private void btnkoltuk_click(object sender, EventArgs e)
        {
            if (((Guna2Button)sender).FillColor==Color.Green)
            {
                ((Guna2Button)sender).FillColor = Color.Pink;
                if (!koltuklar.Contains(((Guna2Button)sender).Text)){
                    koltuklar.Add(((Guna2Button)sender).Text); 
                }
                koltukYazdir();

            }
            else if (((Guna2Button)sender).FillColor == Color.Green)
            {
                ((Guna2Button)sender).FillColor = Color.Pink;
                if (!koltuklar.Contains(((Guna2Button)sender).Text))
                {
                    koltuklar.Remove(((Guna2Button)sender).Text);
                }
                koltukYazdir();
            }
            else // kırmızı
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);
                }
                else //www.gorselprogramlama.com
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                }

                string koltuk = "";
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    koltuk += iptalKoltuk[i].ToString() + ",";
                }
                if (iptalKoltuk.Count >= 1)
                {
                    koltuk = koltuk.Remove(koltuk.Length - 1, 1);
                }
                //txtKoltukIptal.Text = koltuk;
            }
        }

        void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";//www.gorselprogramlama.com
            }
            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }
            //txtKoltukNo.Text = koltuk;
        }


        void yenilebutonu()//satılan biletleri listeleme için
        {
            //baglanti.Open();
            //komut = new SqlCommand("select *from biletTBL");
            //da = new SqlDataAdapter(komut);
            //dt = new DataTable();
            //da.Fill(dt);
            ////burada listbox yazıyorum değişebilir
            //listBox1.DataSource = dt;//listboxsun kaynak verilerine dtyi ekliyoruz
            //listBox1.DisplayMember = "bilet_adi";
            //listBox1.ValueMember = "bilet_id";
            //baglanti.Close();
        }

        public void salonlistele()
        {

            komut = new SqlCommand("select * from salonTBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                combosalon.Items.Add(dr["salon_adi"]);

            }
            baglanti.Close();
        }

        public void seanslistele()
        {
            komut = new SqlCommand("select *from seansTBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader drse;
            baglanti.Open();
            drse = komut.ExecuteReader();
            while (drse.Read())
            {
                comboseans.Items.Add(drse["seans_saat"]);
            }

            //if ((bool)comboseans.SelectedItem)
            //{
            //    panel3.Visible = true;
            //}

            baglanti.Close();
        }
        public void filmlistele()
        {
            komut = new SqlCommand("select *from filtblyeni");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader drf;
            baglanti.Open();
            drf = komut.ExecuteReader();
            while (drf.Read())
            {
                combofilm.Items.Add(drf["film_adi"]);
            }
            baglanti.Close();
        }
        public void AfisGoruntule()
        {

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
            {

                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT resimi FROM filtblyeni WHERE film_adi = '" + combofilm.Text + "'", connection));

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        Byte[] data = new byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0]["resimi"]);
                        MemoryStream mem = new MemoryStream(data);
                        pictureBox1.Image = Image.FromStream(mem);

                        //MessageBox.Show("Okuma Başarılı.");
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        MessageBox.Show("Resim Yok");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }

            }
        }
       private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            //listBox1.Visible = true;

            //panel4.Controls.Clear();
            //Forms.koltuksecim frm1 = new Forms.koltuksecim();
            //frm1.TopLevel = false;
            //panel4.Controls.Add(frm1);
            //frm1.Show();
        }
        //salon combobox işlemleri
        private void combosalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panel3.Visible = true;
        }
        private void guna2Button100_Click_1(object sender, EventArgs e)
        {
                             
            //panel4.Visible = true;
        }

       

        public void tiklananboyansin(object sender, EventArgs e)
        {
            Guna2Button btn = (sender as Guna2Button);
            btn.BackColor = Color.AliceBlue;
            Application.DoEvents();//donmayı engellemek için
           // Thread.Sleep(400);




            //return true;
        }

        private void bayanradio_CheckedChanged(object sender, EventArgs e)
        {

            ////Guna2Button butonumuz = (sender as Guna2Button);
            //if (bayanradio.Checked)
            //{
            //    guna2Button1.FillColor = Color.Pink;
            //    //butonumuz.BackColor = Color.Red;
            //}
            //else if (bayradio.Checked)
            //{
            //    guna2Button2.FillColor = Color.Blue;
            //}
        }

       
        private void guna2Button101_Click(object sender, EventArgs e)
        {
            koltuksecim ltk = new koltuksecim();
            ltk.Show();
            this.Hide();
        }

       

        private void comboyas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void comboseans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combofilm_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            AfisGoruntule();
        }
    }
}