using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrnekDevExpress
{
    public partial class Anasayfa : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            pnlanasayfa.Controls.Clear();
            Forms.FirsatlarDunyasi frm1 = new Forms.FirsatlarDunyasi();
            frm1.TopLevel = false;
            pnlanasayfa.Controls.Add(frm1);
            frm1.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            pnlanasayfa.Controls.Clear();
            Forms.Firmalar frm2 = new Forms.Firmalar();
            frm2.TopLevel = false;
            pnlanasayfa.Controls.Add(frm2);
            frm2.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlanasayfa.Controls.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pnlanasayfa.Controls.Clear();
        }
    }
}
