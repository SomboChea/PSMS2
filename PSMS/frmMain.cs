﻿using MetroFramework;
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
using PSMS.Class;
namespace PSMS
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public frmMain(User user)
        {
            InitializeComponent();
            FullMode.Fullscreen(this);
            this.ControlBox = false;

            Text = "Welcome - " + user.Name;
        }

        private void MetroCus_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCustomer cus = new frmCustomer();
            Helper.Defaultform(cus);
            cus.ShowDialog();
        }

        private void MetroStock_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            Helper.Defaultform(stock);
            stock.ShowDialog();
        }

        private void MetroPro_Click(object sender, EventArgs e)
        {
            frmProduct pro = new frmProduct();
            Helper.Defaultform(pro);
            pro.ShowDialog();
        }

        private void MetroSup_Click(object sender, EventArgs e)
        {
            frmSupplier su = new frmSupplier();
            Helper.Defaultform(su);
            su.ShowDialog();
        }

        private void MetroEmps_Click(object sender, EventArgs e)
        {
            frmEmployees emp = new frmEmployees();
            Helper.Defaultform(emp);
            emp.ShowDialog();
        }

        private void MetroUser_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            Helper.Defaultform(user);
            user.ShowDialog();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
             DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want sign out", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Dispose();
                new Login().Show();
            }
        }

        private void MetroSale_Click(object sender, EventArgs e)
        {
            frmInvoice2 inv = new frmInvoice2();
            Helper.Defaultform(inv);
            inv.ShowDialog();
        }

        private void MetroPur_Click(object sender, EventArgs e)
        {
            
            frmPurchase pur1 = new frmPurchase();
            //Helper.Defaultform(pur1);
            pur1.ShowDialog();
        }

        private void metroTileItem7_Click(object sender, EventArgs e)
        {
            //try
            //{
               frmReport frm= new frmReport();
               Helper.Defaultform(frm);
               frm.ShowDialog();

            //}
            //catch (Exception) { }
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
                this.Dispose();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDataSet.Employee);
            
        }

        private void MetroDown_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.con.Close();
                Application.ExitThread();
            } catch(Exception) {
                return;
            }
        }
    }
  }

