using MetroFramework;
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
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MetroCus_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCustomer cus = new frmCustomer();
            cus.ShowDialog();
        }

        private void MetroStock_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
        }

        private void MetroPro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmProduct pro = new frmProduct();
            pro.ShowDialog();
        }

        private void MetroSup_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmSupplier su = new frmSupplier();
            su.ShowDialog();
        }

        private void MetroEmps_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmEmployees emp = new frmEmployees();
            emp.ShowDialog();
        }

        private void MetroUser_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmUser user = new frmUser();
            user.ShowDialog();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
             DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want sign out", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
            else if (dia == DialogResult.No)
            {
                
            }
               
        }

   

        private void MetroSale_Click(object sender, EventArgs e)
        {

            frmInvoice2 inv = new frmInvoice2();
            inv.ShowDialog();
        }

        private void MetroPur_Click(object sender, EventArgs e)
        {
            
            frmPurchase pur1 = new frmPurchase();
            pur1.ShowDialog();
        }

        private void metroTileItem7_Click(object sender, EventArgs e)
        {
            frmReport rt = new frmReport();
            rt.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = MetroMessageBox.Show(this, "Are you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            else if (dia == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
  }

