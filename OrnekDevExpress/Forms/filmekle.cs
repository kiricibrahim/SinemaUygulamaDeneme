using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;//www.gorselprogramlama.com
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace OrnekDevExpress.Forms
{
    public partial class filmekle : DevExpress.XtraEditors.XtraForm
    {
        public filmekle()
        {
            InitializeComponent();
        }

        SqlConnectionStringBuilder csb;
        SqlDataAdapter da;
        SqlConnection baglanti;
        SqlCommand komut;
        //DataTable dt;
        Button butons;
        Button butonb;
        string resimPath;
        string dosyayolu;

        private void filmekle_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True");
            oyunculistele();
            turlistele();
            salonlistele();
            seanslistele();

            

        }

        public void turlistele()
        {
            komut = new SqlCommand("select *from tur_TBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader drse;
            baglanti.Open();
            drse = komut.ExecuteReader();
            while (drse.Read())
            {
                combotur.Items.Add(drse["tur_id"].ToString());
                combotur.Items.Add(drse["tur_adi"].ToString());

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
                comboBoxseans.Items.Add(drse["seans_id"].ToString());
                comboBoxseans.Items.Add(drse["seans_saat"].ToString());

            }

            baglanti.Close();
        }

        public void salonlistele()
        {
            komut = new SqlCommand("select *from salonTBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader drse;
            baglanti.Open();
            drse = komut.ExecuteReader();
            while (drse.Read())
            {
                comboBoxsalon.Items.Add(drse["salon_id"].ToString());
                comboBoxsalon.Items.Add(drse["salon_adi"].ToString());


            }

            baglanti.Close();
        }

        public void oyunculistele()
        {
            komut = new SqlCommand("select *from oyuncuTBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader drsee;
            baglanti.Open();
            drsee = komut.ExecuteReader();
            while (drsee.Read())
            {
                comboBoxoyuncu.Items.Add(drsee["oyuncu_id"]);
                comboBoxoyuncu.Items.Add(drsee["oyuncu_adi"]);
            }
            //DataTable dt = new DataTable();

            //combooyuncu.DataSource = dt.DefaultView;
            //combooyuncu.DisplayMember = "oyuncu_adi";
            //combooyuncu.ValueMember = "oyuncu_id";

            //if ((bool)comboseans.SelectedItem)
            //{
            //    panel3.Visible = true;
            //}

            baglanti.Close();
        }
       
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in openFileDialog1.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { resimPath = i; }
                    else if (i.Contains(".png")) { resimPath = i; }
                    else { dosyayolu += i + "\\"; }
                }
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Dosya Girmediniz!");
            }




            //openFileDialog1.Title = "Resim Aç";
            ////openFileDialog1 dosya = new openFileDialog1();
            //openFileDialog1.Filter = "Resim Dosyası | *.jpg; *.nef; *.png | Tüm Dosyalar | *.* ";
            //string dosyayolu = openFileDialog1.FileName;
            ////textBox3.Text = dosyayolu;
            //pictureBox1.ImageLocation = dosyayolu;

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //    resimPath = openFileDialog1.FileName.ToString();

            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            //BinaryReader rd = new BinaryReader(fs);

            //byte[] resim = rd.ReadBytes((int)fs.Length);
            //rd.Close();
            //fs.Close();

            //baglanti.Open();

            //komut = new SqlCommand("insert into filmlerTBL (resimi) values (@resimi)",baglanti);
            //komut.Parameters.Add("@resimi",SqlDbType.Image,resim.Length).Value=resim;




            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into filmlerTBL(film_adi,film_tur_id,film_yonetmeni,resimi,film_oyuncuid,seans_id,salon_id) values('"+textBox1.Text+"','"+combotur.Text+ "','"+textBox2.Text+ "','"+resimPath+ "','"+comboBoxoyuncu+ "','"+comboBoxseans+ "','"+comboBoxsalon+ "')" ,baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                MessageBox.Show("Kayıt İşlemi Başarılı.");
                if (resimPath != "") File.WriteAllBytes(resimPath, File.ReadAllBytes(openFileDialog1.FileName));
                MessageBox.Show("KAyıt işlemi başarıyla gerçekleşti", "İşlem Sonucu",MessageBoxButtons.OK,MessageBoxIcon.Information);
                baglanti.Close();



                //if (baglanti.State == ConnectionState.Closed)
                //baglanti.Open();
                //komut.ExecuteNonQuery();
                //baglanti.Close();
                //MessageBox.Show("işlem başarılı");

                //string kkayitekle = "insert into filmlerTBL(film_adi,film_tur_id,film_yonetmeni,film_oyuncular_id,resimi) values (@film_id,@film_adi,@film_tur_id,@film_yonetmeni,@film_oyuncular_id,@resimi)";
                //SqlCommand komutt = new SqlCommand(kkayitekle,baglanti);



                //komutt.Parameters.AddWithValue("@film_adi", textBox1.Text);
                //komutt.Parameters.AddWithValue("@film_tur_id", combotur.SelectedValue);
                //komutt.Parameters.AddWithValue("@film_yonetmeni", textBox2.Text);
                //komutt.Parameters.AddWithValue("@film_oyuncular_id", combooyuncu.SelectedValue);
                //komutt.Parameters.AddWithValue("@resimi", textBox3.Text);

                //komut = new SqlCommand("insert into filmlerTBL(film_adi,film_tur_id,film_yonetmeni,film_oyuncular_id,resimi)values(@film_adi,@film_tur_id,@film_yonetmeni,@film_oyuncular_id,@resimi)", baglanti);
                //komut.Parameters.AddWithValue("@film_adi", textBox1.Text);
                //komut.Parameters.AddWithValue("@film_tur_id", combotur.SelectedValue);
                //komut.Parameters.AddWithValue("@film_yonetmeni", textBox2.Text);
                //komut.Parameters.AddWithValue("@film_oyuncular_id", combooyuncu.SelectedValue);
                //komut.Parameters.AddWithValue("@resimi", textBox3.Text);
                // komut.Parameters.Add("@resimi", SqlDbType.Image, resim.Length).Value = resim;
                //komut.ExecuteNonQuery();

                //MessageBox.Show("Kayıt İşlemi Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kayıt yapılırken bir hayatla karşılaşıldı" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxseansid.SelectedValue = comboBoxseans.SelectedIndex;
        }

        private void comboBoxsalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxsalonid.SelectedValue = comboBoxsalon.SelectedIndex;
        }

        private void combotur_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxturid.SelectedValue = combotur.SelectedIndex;
        }

        private void comboBoxoyuncu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxoyuncuid.SelectedValue = comboBoxoyuncu.SelectedIndex;
        }
    }
}