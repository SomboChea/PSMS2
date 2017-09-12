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

        private void viewStock_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewStock;", binding, viewReport);
        }

        List<reportCustomer> dataCustomers;
        List<reportEmployee> dataEmployees;
        List<reportInvoice> dataInvoices;
        List<reportProduct> dataProducts;
        List<reportPurchase> dataPurchases;
        List<reportSupplier> dataSuppliers;
        
        private void addCurrentCustomerToPrint()
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewCustomer;");
            DataTable dt = ds.Tables[0];
            dataCustomers = new List<reportCustomer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportCustomer dataList = new reportCustomer();

                dataList.CCode = dt.Rows[i]["CCode"].ToString();
                dataList.NameEN = dt.Rows[i]["FullNameEN"].ToString();
                dataList.Gender = dt.Rows[i]["Gender"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Phone = dt.Rows[i]["Phone"].ToString();
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());
                dataList.Status = dt.Rows[i]["Status"].ToString();
                dataList.EmpName = dt.Rows[i]["EmployeeName"].ToString();
                dataList.OpenDate = dt.Rows[i]["OpenDate"].ToString();

                dataCustomers.Add(dataList);
            }
        }

        private void addCurrentEmployeeToPrint()
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewEmployee;");
            DataTable dt = ds.Tables[0];

            dataEmployees = new List<reportEmployee>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportEmployee dataList = new reportEmployee();

                dataList.EmpCode = dt.Rows[i]["EmpCode"].ToString();
                dataList.NameEN = dt.Rows[i]["FullNameEN"].ToString();
                dataList.Gender = dt.Rows[i]["Gender"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Email = dt.Rows[i]["Email"].ToString();
                dataList.Position = dt.Rows[i]["PositionName"].ToString();
                dataList.Salary = Convert.ToDouble(dt.Rows[i]["Salary"].ToString());
                dataList.JoinDate = dt.Rows[i]["JoinDate"].ToString();

                dataEmployees.Add(dataList);
            }
        }

        private void addCurrentProductToPrint()
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewStock;");
            DataTable dt = ds.Tables[0];

            dataProducts = new List<reportProduct>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportProduct dataList = new reportProduct();

                dataList.Code = dt.Rows[i]["PCode"].ToString();
                dataList.Name = dt.Rows[i]["PName"].ToString();
                dataList.Size = dt.Rows[i]["PSize"].ToString();
                dataList.Color = dt.Rows[i]["Color"].ToString();
                dataList.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.Brand = dt.Rows[i]["Brand"].ToString();
                dataList.PType = dt.Rows[i]["PhoneType"].ToString();
                dataList.Type = dt.Rows[i]["Type"].ToString();
                dataList.SalePrice = Convert.ToDouble(dt.Rows[i]["SalePrice"].ToString());
                dataList.UnitPrice = Convert.ToDouble(dt.Rows[i]["UnitPrice"].ToString());

                dataProducts.Add(dataList);
            }
        }

        private void addCurrentPurchaseToPrint()
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewPurchase;");
            DataTable dt = ds.Tables[0];

            dataPurchases = new List<reportPurchase>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportPurchase dataList = new reportPurchase();

                dataList.PurCode = dt.Rows[i]["PurCode"].ToString();
                dataList.PurDate = dt.Rows[i]["PurDate"].ToString();
                dataList.Payment = Convert.ToDouble(dt.Rows[i]["Payment"].ToString());
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());
                dataList.SupName = dt.Rows[i]["SupplierName"].ToString();
                dataList.EmpName = dt.Rows[i]["EmployeeName"].ToString();
                dataList.Total = Convert.ToDouble(dt.Rows[i]["Total"].ToString());

                dataPurchases.Add(dataList);
            }
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            //addCurrentCustomerToPrint();
            addCurrentEmployeeToPrint();
            new reportViewer(dataEmployees).ShowDialog();
        }
    }
}
