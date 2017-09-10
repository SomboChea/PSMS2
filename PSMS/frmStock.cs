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
                
                if(Class.Helper.checkStock(item.Text) <=0)
                {
                    /*
                    DialogResult confirm = MessageBox.Show("Do you want to add this item?","Confirm Action",MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (confirm == DialogResult.Yes)
                        new frmProduct().ShowDialog();
                    */

                    MetroFramework.MetroMessageBox.Show(this, "This item is of out stock?", "Warning : Item Code " + item.Text);

                }
                
               
                listStock.Items.Add(item);

                listStock.LargeImageList = imglist;
                listStock.Items[item.Index].ImageIndex = item.Index;

                
            }
            comboBox1_SelectedIndexChanged(this, null);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            View view = comboBox1.SelectedIndex == 0 ? View.Details : View.LargeIcon;
            listStock.View = view;
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            PSMS.Class.Connection.ExecuteScalar("Delete from Product where [PCode]='" + listStock.SelectedItems[0].Text + "'");
            listStock.Items.RemoveAt(listStock.SelectedIndices[0]);
        }

        private void listStock_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnRemove.Enabled = listStock.SelectedIndices.Count > 0 ? true : false;
           
            if(listStock.SelectedIndices.Count > 0)
            {
                int qty = Convert.ToInt32(listStock.SelectedItems[0].SubItems[4].Text);
                double cost = Convert.ToDouble(listStock.SelectedItems[0].SubItems[9].Text);
                double saleprice = Convert.ToDouble(listStock.SelectedItems[0].SubItems[8].Text);

                txtQty.Text = qty + "";
                txtCost.Text = "$" + (qty*cost);
                txtSalePrice.Text = "$" + (qty *saleprice);
                
            }

        }
    }
}
