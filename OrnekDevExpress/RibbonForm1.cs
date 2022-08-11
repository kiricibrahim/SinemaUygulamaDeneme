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

namespace OrnekDevExpress
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Forms.satis1frm formsatis = new Forms.satis1frm();
            formsatis.TopLevel = false;
            panel1.Controls.Add(formsatis);
            formsatis.Show();

        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Anasayfa frm1 = new Anasayfa();
            frm1.TopLevel = false;
            panel1.Controls.Add(frm1);
            frm1.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Forms.resimeklemedeneme eklefilm = new Forms.resimeklemedeneme();
            eklefilm.TopLevel = false;
            panel1.Controls.Add(eklefilm);
            eklefilm.Show();
        }
    }
}