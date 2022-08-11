using DevExpress.XtraEditors;
using OrnekDevExpress.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnekDevExpress
{
    public partial class giris : DevExpress.XtraEditors.XtraForm
    {
        public giris()
        {
            InitializeComponent();
        }

        kullanici_islemleri k = new kullanici_islemleri();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            k.kullanicigiris(txt_kullaniciadi,txt_sifre);
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}