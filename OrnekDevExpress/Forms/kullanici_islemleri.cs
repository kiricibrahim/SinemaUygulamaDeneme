using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace OrnekDevExpress.Forms
{
    internal class kullanici_islemleri
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;

        public SqlDataReader kullanicigiris(Guna2TextBox kullaniciadi, Guna2TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText= "select *from kullanicilarTBL where kul_ad= '"+ kullaniciadi.Text+"'";
            read=komut.ExecuteReader();
            if (read.Read()==true)
            {
                if (sifre.Text == read["password"].ToString())
                {
                    RibbonForm1 gitt = new RibbonForm1();
                    gitt.Show();   
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol ediniz.", "Hata 1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz ","Hata 2");
            }
            baglanti.Close();
            return read;
        }

        
    }
}
