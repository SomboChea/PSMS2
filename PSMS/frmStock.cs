using CrystalDecisions.CrystalReports.Engine;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmStock : MetroForm
    {
        public frmStock()
        {
            InitializeComponent();
        }
        
        private void frmStock_Load(object sender, EventArgs e)
        {
            ImageList imglist = new ImageList();
            foreach (ListViewItem item in Class.Helper.getListStock(ref imglist))
            {
                listStock.Items.Add(item);
                listStock.LargeImageList = imglist;
                listStock.Items[item.Index].ImageIndex = item.Index;
            }
            comboBox1.SelectedIndex = 0;
            
            //for (int i = 0; i < listStock.Items.Count; i++)
            //{
            //    listStock.Items[i].ImageIndex = i;
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            View view = comboBox1.SelectedIndex == 0 ? View.Details : View.LargeIcon;
            listStock.View = view;
            
        }
    }
}
