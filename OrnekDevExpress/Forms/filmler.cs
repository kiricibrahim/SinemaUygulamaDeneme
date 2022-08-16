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
    public partial class filmler : DevExpress.XtraEditors.XtraForm
    {
        public filmler()
        {
            InitializeComponent();
            AfisGoruntule();
        }
        private void filmler_Load(object sender, EventArgs e)
        {
            AfisGoruntule();
        }

        public void AfisGoruntule()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT resim FROM acilistablosu where id=2" , connection));
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        Byte[] data = new byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0]["resim"]);
                        MemoryStream mem = new MemoryStream(data);
                        pcafis.Image = Image.FromStream(mem);
                        //MessageBox.Show("Okuma Başarılı.");
                    }
                    else
                    {
                        pcafis.Image = null;
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
        public void AfisGoruntule2()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT resim FROM acilistablosu where id=1", connection));
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        Byte[] data = new byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0]["resim"]);
                        MemoryStream mem = new MemoryStream(data);
                        pcafis.Image = Image.FromStream(mem);
                        //MessageBox.Show("Okuma Başarılı.");
                    }
                    else
                    {
                        pcafis.Image = null;
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
        public void AfisGoruntule3()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT resim FROM acilistablosu where id=3", connection));
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count == 1)
                    {
                        Byte[] data = new byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0]["resim"]);
                        MemoryStream mem = new MemoryStream(data);
                        pcafis.Image = Image.FromStream(mem);
                        //MessageBox.Show("Okuma Başarılı.");
                    }
                    else
                    {
                        pcafis.Image = null;
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

        private void gosterrbtn_1_Click(object sender, EventArgs e)
        {
            AfisGoruntule2();
        }

        private void gosterrbtn_3_Click(object sender, EventArgs e)
        {
            AfisGoruntule3();
        }

        private void gosterrbtn_2_Click(object sender, EventArgs e)
        {
            AfisGoruntule();
        }
    }
}