using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrnekDevExpress.Forms
{
    public partial class resimeklemedeneme : DevExpress.XtraEditors.XtraForm
    {
        SqlCommand komut;
        SqlConnectionStringBuilder csb;
        SqlDataAdapter da;
        SqlConnection baglanti;
        public resimeklemedeneme()
        {
            InitializeComponent();
        }
        private void resimeklemedeneme_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True");
            turlistele();
            oyunculistele();
            seanslistele();
            salonlistele();
        }
        //resim seç
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = openFileDialog1.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            foreach (string s in openFileDialog1.FileNames)
                            {
                                pictureBox1.ImageLocation = s;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya Okunmadı!" + ex.Message);
                }
            }
        }
        //resim kaydet
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation.ToString() != "")
            {
                byte[] ImageByteArray = File.ReadAllBytes(pictureBox1.ImageLocation.ToString());

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
                {
                    using (SqlCommand komut = new SqlCommand())
                    {
                        komut.Connection = connection;
                        komut.CommandText = "INSERT INTO filtblyeni (film_adi,film_tur_id,film_yonetmeni,resimi,film_oyuncuid,seans_id,salon_id) VALUES (@film_adi,@film_tur_id,@film_yonetmeni,@resimi,@film_oyuncuid,@seans_id,@salon_id)";
                        komut.Parameters.AddWithValue("@film_adi", txtfilm.Text);
                        komut.Parameters.AddWithValue("@film_tur_id", comboturr.Text);
                        komut.Parameters.AddWithValue("@film_yonetmeni", txtyonetmen.Text);
                        komut.Parameters.AddWithValue("@film_oyuncuid", combooyuncu.Text);
                        komut.Parameters.AddWithValue("@seans_id", comboseans.Text);
                        komut.Parameters.AddWithValue("@salon_id", combosalon.Text);
                        komut.Parameters.AddWithValue("@resimi", ImageByteArray);
                        try
                        {
                            connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarılı.");
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Resim Seç");
            }
        }

        //okuma butonu
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
            {

                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter= new SqlDataAdapter(new SqlCommand("SELECT resimi FROM filtblyeni WHERE film_adi = '" + txtfilm.Text+"'", connection));

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count==1)
                    {
                        Byte[] data = new byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0]["resimi"]);
                        MemoryStream mem=new MemoryStream(data);
                        pictureBox1.Image=Image.FromStream(mem);

                        MessageBox.Show("Okuma Başarılı.");
                    }
                    else
                    {
                        pictureBox1.Image=null;
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
        public void oyunculistele()
        {
            komut = new SqlCommand("select * from oyuncuTBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combooyuncu.Items.Add(dr["oyuncu_adi"]);
            }
            baglanti.Close();
        }
        public void turlistele()
        {
            komut = new SqlCommand("select * from tur_TBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboturr.Items.Add(dr["tur_adi"]);
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
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}