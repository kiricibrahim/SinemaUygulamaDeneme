using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data;

namespace OrnekDevExpress.Forms
{
    internal class dbIslemleri
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AGRIQC6\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;

        public static Guna2ComboBox seanscombo;


        public void seanslistele()
        {
            Forms.satis1frm satisfrm = new satis1frm();
            komut = new SqlCommand("select *from seansTBL");
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader drse;
            baglanti.Open();
            drse = komut.ExecuteReader();
            while (drse.Read())
            {
                seanscombo.Items.Add(drse["seans_saat"]);
            }
            //if ((bool)comboseans.SelectedItem)
            //{
            //    panel3.Visible = true;
            //}
            baglanti.Close();
        }
    }
}
