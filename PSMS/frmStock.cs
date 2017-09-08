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
            comboBox1.SelectedIndex = 0;
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
            comboBox1_SelectedIndexChanged(this, null);
            
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            PSMS.Class.Connection.ExecuteScalar("Delete from Product where PCode=" + listStock.SelectedItems[0].Text);
            listStock.Items.RemoveAt(listStock.SelectedIndices[0]);
        }
    }
}
