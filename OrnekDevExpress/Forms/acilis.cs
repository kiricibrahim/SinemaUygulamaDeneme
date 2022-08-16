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
using System.Data.SqlClient;
using System.IO;

namespace OrnekDevExpress.Forms
{
    public partial class acilis : DevExpress.XtraEditors.XtraForm
    {
        SqlCommand komut;
        SqlConnectionStringBuilder csb;
        SqlDataAdapter da;
        SqlConnection baglanti;
        public acilis()
        {
            InitializeComponent();
        }



        private void guna2Button1_Click(object sender, EventArgs e)
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
        //kaydet
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation.ToString() != "")
            {
                byte[] ImageByteArray = File.ReadAllBytes(pictureBox1.ImageLocation.ToString());

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
                {
                    using (SqlCommand komut = new SqlCommand())
                    {
                        komut.Connection = connection;
                        komut.CommandText = "INSERT INTO acilistablosu (resim)VALUES(@resim)";
                        
                        komut.Parameters.AddWithValue("@resim", ImageByteArray);
                        try
                        {
                            connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarılı.");
                            //baglanti.Close();
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
    }
}