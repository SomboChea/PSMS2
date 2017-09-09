using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PSMS.Class;

namespace PSMS
{
    public partial class frmReport : MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        BindingSource binding = new BindingSource();

        private void metroTile1_Click(object sender, EventArgs e)
        {

            //ReportDocument cryRpt = new ReportDocument();
            // cryRpt.Load(@"Z:\Develop Tool\Backup project\Beta\PSMS\PSMS\Reports\CusReport.rpt");
            // crystalReportViewer1.ReportSource = cryRpt;
            // crystalReportViewer1.Refresh();
            
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM Customers;",binding, viewReport);
        }

        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain main = new frmMain();
            //main.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(@"Z:\Develop Tool\Backup project\Beta\PSMS\PSMS\Reports\SuReport.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();

            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewSupplier;", binding, viewReport);

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(@"Z:\Develop Tool\Backup project\Beta\PSMS\PSMS\Reports\ProReport.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();

            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewEmployees;", binding, viewReport);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewPurchase;", binding, viewReport);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewInvoice;", binding, viewReport);
        }
    }
}
