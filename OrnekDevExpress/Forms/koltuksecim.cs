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
using Guna.UI2.WinForms;


namespace OrnekDevExpress.Forms
{
    public partial class koltuksecim : DevExpress.XtraEditors.XtraForm
    {
        public koltuksecim()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void koltuksecim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaDBDataSet1.koltukTBL' table. You can move, or remove it, as needed.
            this.koltukTBLTableAdapter.Fill(this.sinemaDBDataSet1.koltukTBL);
            loadgrid();
           
        }

        public void loadgrid()
        {
            
            DataGridViewButtonColumn butcol = new DataGridViewButtonColumn();
            Guna2Button btn = new Guna2Button();
            butcol.Width = 20;
            guna2DataGridView1.Columns.Add(butcol);

        }
    }
}