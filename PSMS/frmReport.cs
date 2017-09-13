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

        string currentSelected = "";

        public frmReport()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            metroTile1_Click(sender, e);
        }

        BindingSource binding = new BindingSource();

        private void metroTile1_Click(object sender, EventArgs e)
        {

            //ReportDocument cryRpt = new ReportDocument();
            // cryRpt.Load(@"Z:\Develop Tool\Backup project\Beta\PSMS\PSMS\Reports\CusReport.rpt");
            // crystalReportViewer1.ReportSource = cryRpt;
            // crystalReportViewer1.Refresh();
            
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewCustomer;",binding, viewReport);
            currentSelected = "customer";
            
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
            currentSelected = "supplier";

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(@"Z:\Develop Tool\Backup project\Beta\PSMS\PSMS\Reports\ProReport.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();

            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT EmpCode,FullNameEN,Gender,IDCard,Address,Phone,Email,PositionName,Salary,JoinDate FROM viewEmployee;", binding, viewReport);
            currentSelected = "employee";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT PurCode,Date,Payment,Balance,Total FROM Purchase;", binding, viewReport);
            currentSelected = "purchase";
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT InvoiceCode, TotalPrice,Balance,Date FROM Invoice;", binding, viewReport);
            currentSelected = "invoice";
        }

        private void viewStock_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT PCode,PName,PSize,Color,Quantity,Brand,PhoneType,Type,SalePrice,UnitPrice FROM viewStock;", binding, viewReport);
            currentSelected = "stock";
        }

        List<reportCustomer> dataCustomers;
        List<reportEmployee> dataEmployees;
        List<reportInvoice> dataInvoices;
        List<reportProduct> dataProducts;
        List<reportPurchaseRenew> dataPurchases;
        List<reportSupplierRenew> dataSuppliers;
        
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

        private void addCurrentInvoiceToPrint(string code)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewInvoice WHERE InvoiceCode = '" + code + "';");
            DataTable dt = ds.Tables[0];

            dataInvoices = new List<reportInvoice>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportInvoice dataList = new reportInvoice();

                dataList.InvoiceCode = dt.Rows[i]["InvoiceCode"].ToString();
                dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.Price = Convert.ToDouble(dt.Rows[i]["Price"].ToString());
                dataList.Amount = Convert.ToDouble(dt.Rows[i]["Amount"].ToString());
                dataList.Sellby = dt.Rows[i]["Sellby"].ToString();
                dataList.CustomerName = dt.Rows[i]["CustomerName"].ToString();
                dataList.Phone = dt.Rows[i]["Phone"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();

                dataInvoices.Add(dataList);
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

        private void addCurrentPurchaseToPrint(string code)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewPurchase WHERE PurCode = '" + code + "';");
            DataTable dt = ds.Tables[0];

            dataPurchases = new List<reportPurchaseRenew>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportPurchaseRenew dataList = new reportPurchaseRenew();

                dataList.PurCode = dt.Rows[i]["PurCode"].ToString();
                dataList.PurDate = dt.Rows[i]["PurDate"].ToString();
                dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.UnitPrice = Convert.ToDouble(dt.Rows[i]["Unitprice"].ToString());
                dataList.Payment = Convert.ToDouble(dt.Rows[i]["Payment"].ToString());
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());
                dataList.SupName = dt.Rows[i]["SupplierName"].ToString();
                dataList.EmpName = dt.Rows[i]["EmployeeName"].ToString();
                dataList.Total = Convert.ToDouble(dt.Rows[i]["Total"].ToString());

                dataPurchases.Add(dataList);
            }
        }

        private void addCurrentSupplierToPrint()
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewSupplier;");
            DataTable dt = ds.Tables[0];

            dataSuppliers = new List<reportSupplierRenew>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportSupplierRenew dataList = new reportSupplierRenew();

                dataList.SupCode = dt.Rows[i]["SuCode"].ToString();
                dataList.NameEN = dt.Rows[i]["FullNameEN"].ToString();
                dataList.Gender = dt.Rows[i]["Gender"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Phone = dt.Rows[i]["Phone"].ToString();
                dataList.Email = dt.Rows[i]["Email"].ToString();
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());

                dataSuppliers.Add(dataList);
            }
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSelected.Equals("customer"))
                {
                    addCurrentCustomerToPrint();
                    new reportViewer(dataCustomers).ShowDialog();
                }
                else if (currentSelected.Equals("supplier"))
                {
                    addCurrentSupplierToPrint();
                    new reportViewer(dataSuppliers).ShowDialog();
                }
                else if (currentSelected.Equals("employee"))
                {
                    addCurrentEmployeeToPrint();
                    new reportViewer(dataEmployees).ShowDialog();
                }
                else if (currentSelected.Equals("purchase"))
                {
                    if (viewReport.SelectedCells.Count > 0)
                    {
                        string code = viewReport.SelectedRows[0].Cells[0].Value.ToString();
                        addCurrentPurchaseToPrint(code);
                        new reportViewer(dataPurchases).ShowDialog();
                    }
                }
                else if (currentSelected.Equals("invoice"))
                {
                    if(viewReport.SelectedCells.Count > 0)
                    {
                        string code = viewReport.SelectedRows[0].Cells[0].Value.ToString();

                        addCurrentInvoiceToPrint(code);
                        new reportViewer(dataInvoices).ShowDialog();
                    }
                    
                }
                else if (currentSelected.Equals("stock"))
                {
                    addCurrentProductToPrint();
                    new reportViewer(dataProducts).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Something error!!!", "Warning!");
                }
            }
            catch (Exception) { return; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if(currentSelected.Equals("invoice"))
                {
                    
                }
            }
            catch (Exception) { return; }
        }
    }
}
