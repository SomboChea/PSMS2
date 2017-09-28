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
using PSMS.Reports;
using PSMS.ReportNew;

namespace PSMS
{
    public partial class frmReport : MetroForm
    {

        string currentSelected = "";
        BindingSource binding = new BindingSource();

        public frmReport()
        {
            InitializeComponent();
            ControlBox = false;
            cbSearchBy.SelectedIndex = 0;
            //Binding data to DataGridiew
            viewReport.DataSource = binding;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
                //Select the Customers first
                metroTile1_Click(sender, e);
        }

        //For filter selection
        private void dateEnable(bool enble)
        {
            if (enble)
            {
                dateStart.Enabled = true;
                dateEnd.Enabled = true;
                btnFilter.Enabled = true;
                cbSortby.Enabled = true;
             
            }
            else
            {
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
                btnFilter.Enabled = false;
                cbSortby.Enabled=false;
            }
        }
        
        //View Customers
        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            Helper.BindGridView("SELECT * FROM viewCustomer;",binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "customer";

            this.Text = "Report Customer";

            this.Refresh();

            visiableEmployeeby(false);
            visiableFilterStock(false);
            visiableFilterDate(false);
            visiableShowby(false);
        }

        //View Suppliers
        private void metroTile5_Click(object sender, EventArgs e)
        {
            Helper.BindGridView("SELECT * FROM viewSupplier;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "supplier";

            this.Text = "Report Supplier";

            this.Refresh();

            visiableEmployeeby(false);
            visiableFilterStock(false);
            visiableFilterDate(false);
            visiableShowby(false);
        }

        //View Employees
        private void metroTile4_Click(object sender, EventArgs e)
        {
            Helper.BindGridView("SELECT * FROM viewEmployee;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "employee";

            this.Text = "Report Employee";
            this.Refresh();

            cbEmployeeby.SelectedIndex = 0;
            visiableEmployeeby();
            visiableFilterStock(false);
            visiableFilterDate(false);
            visiableShowby(false);

        }

        private void visiableEmployeeby(bool tf=true)
        {
            cbEmployeeby.Visible = tf?true:false;
            lbEmp.Visible = tf ? true : false;
        }

        //View Purchases
        private void metroTile2_Click(object sender, EventArgs e)
        {
            cbSortby.SelectedIndex = 4;
            Helper.BindGridView("SELECT * FROM viewPurchase3;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "purchase";

            this.Text = "Report Purchase";
            this.Refresh();

            visiableEmployeeby(false);
            visiableFilterStock(false);
            visiableFilterDate();
            visiableShowby();
        }

        //View Invoices
        private void metroTile3_Click(object sender, EventArgs e)
        {
            cbSortby.SelectedIndex = 4;

            Helper.BindGridView("SELECT * FROM viewInvoice4; ", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "invoice";

            this.Text = "Report Invoice";
            this.Refresh();

            visiableEmployeeby(false);
            visiableFilterStock(false);
            visiableFilterDate();
            visiableShowby();

        }

        //View Stocks
        private void viewStock_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT * FROM viewStock;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "stock";

            this.Text = "Report Stock";
            this.Refresh();

            cbFilter.SelectedIndex = 0;

            visiableFilterStock(true);
            visiableFilterDate(false);
            visiableShowby(false);

        }

        private void visiableFilterStock(bool tf=true)
        {
            if (tf)
            {
                cbFilter.Visible = tf;
                cbFilter2.Visible = tf;
                lbFilter.Visible = tf;
            }
            else
            {
                cbFilter.Visible = tf;
                cbFilter2.Visible = tf;
                lbFilter.Visible = tf;
            }
        }

        //Defines for Reports DATA
        List<reportCustomer> dataCustomers;
        List<reportEmployee> dataEmployees;
        List<reportInvoice> dataInvoices;
        List<reportProduct> dataProducts;
        List<reportPurchaseRenew> dataPurchases;
        List<reportSupplierRenew> dataSuppliers;

        //Details for DATA
        List<customerListReports> dataCustomerAllReports;
        List<employeeListReportsInvoice> dataEmployeeAllReportsInvoice;
        List<employeeListReportsPurchase> dataEmployeeAllReportsPurchase;
        List<supplierListReports> dataSupplierAllReports;

        List<reportRevenueWeekly> dataRevenueweekly;
        
        private void addCurrentCustomerListReport(string customerCode)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewCustomerReports2 WHERE CusCode = '"+ customerCode + "';");
            DataTable dt = ds.Tables[0];

            dataCustomerAllReports = new List<customerListReports>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                customerListReports dataList = new customerListReports();
                
                dataList.InvCode = dt.Rows[i]["Code"].ToString();
                dataList.Code = dt.Rows[i]["CusCode"].ToString();
                dataList.Name = dt.Rows[i]["CustomerName"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Tel = dt.Rows[i]["Phone"].ToString();
                //dataList.ProQty = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                //dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                //dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();
                dataList.Profits = Convert.ToDouble(dt.Rows[i]["Profits"].ToString());
                dataList.Amount = Convert.ToDouble(dt.Rows[i]["Amount"].ToString());

                dataCustomerAllReports.Add(dataList);
            }
        }

        private void addCurrentEmployeeListReportInvoice(string EmpCode)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewEmployeeReportInvoice WHERE EmpCode = '" + EmpCode + "';");
            DataTable dt = ds.Tables[0];

            dataEmployeeAllReportsInvoice = new List<employeeListReportsInvoice>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                employeeListReportsInvoice dataList = new employeeListReportsInvoice();

                dataList.Code = dt.Rows[i]["Code"].ToString();
                dataList.EmpCode = dt.Rows[i]["EmpCode"].ToString();
                dataList.EmployeeName = dt.Rows[i]["EmployeeName"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Tel = dt.Rows[i]["Phone"].ToString();
                dataList.Email = dt.Rows[i]["Email"].ToString();
                dataList.ProQty = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();
                dataList.Price = Convert.ToDouble(dt.Rows[i]["Price"].ToString());
                dataList.CustomerName = dt.Rows[i]["CustomerName"].ToString();

                dataEmployeeAllReportsInvoice.Add(dataList);
            }
        }

        private void addCurrentEmployeeListReportPurchase(string EmpCode)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewEmployeeReportPurchase WHERE EmpCode = '" + EmpCode + "';");
            DataTable dt = ds.Tables[0];

            dataEmployeeAllReportsPurchase = new List<employeeListReportsPurchase>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                employeeListReportsPurchase dataList = new employeeListReportsPurchase();

                dataList.Code = dt.Rows[i]["Code"].ToString();
                dataList.EmpCode = dt.Rows[i]["EmpCode"].ToString();
                dataList.EmployeeName = dt.Rows[i]["EmployeeName"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Tel = dt.Rows[i]["Phone"].ToString();
                dataList.Email = dt.Rows[i]["Email"].ToString();
                dataList.ProQty = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());

                dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();
                dataList.Price = Convert.ToDouble(dt.Rows[i]["UnitPrice"].ToString());
                dataList.CustomerName = dt.Rows[i]["SupplierName"].ToString();
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());
                dataList.Paid = Convert.ToDouble(dt.Rows[i]["Paid"].ToString());


                dataEmployeeAllReportsPurchase.Add(dataList);
            }
        }

        private void addCurrentSupplierListReport(string SuCode)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewSupplierReports WHERE SuCode = '" + SuCode + "';");
            DataTable dt = ds.Tables[0];

            dataSupplierAllReports = new List<supplierListReports>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                supplierListReports dataList = new supplierListReports();

                dataList.Code = dt.Rows[i]["Code"].ToString();
                dataList.EmpCode = dt.Rows[i]["SuCode"].ToString();
                dataList.EmployeeName = dt.Rows[i]["SupplierName"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Tel = dt.Rows[i]["Phone"].ToString();
                dataList.Email = dt.Rows[i]["Email"].ToString();
                dataList.CustomerName = dt.Rows[i]["EmployeeName"].ToString();
                //dataList.ProQty = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                //dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                //dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();
                dataList.Total = Convert.ToDouble(dt.Rows[i]["Total"].ToString());
                dataList.Paid = Convert.ToDouble(dt.Rows[i]["Paid"].ToString());
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());

                dataSupplierAllReports.Add(dataList);
            }
        }

        private void addCurrentCustomerToPrint()
        {
            //DataSet ds = Helper.getDataSet("SELECT * FROM viewCustomer;");
            //DataTable dt = ds.Tables[0];
            DataTable dt = (DataTable)binding.DataSource;

            dataCustomers = new List<reportCustomer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportCustomer dataList = new reportCustomer();

                dataList.CCode = dt.Rows[i]["Code"].ToString();
                dataList.NameEN = dt.Rows[i]["CustomerName"].ToString();
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
            //DataSet ds = Helper.getDataSet("SELECT * FROM viewEmployee;");
            //DataTable dt = ds.Tables[0];
            DataTable dt = (DataTable)binding.DataSource;

            dataEmployees = new List<reportEmployee>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportEmployee dataList = new reportEmployee();

                dataList.EmpCode = dt.Rows[i]["Code"].ToString();
                dataList.NameEN = dt.Rows[i]["EmployeeName"].ToString();
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
            DataSet ds = Helper.getDataSet("SELECT * FROM viewInvoice3 WHERE Code = '" + code + "';");
            DataTable dt = ds.Tables[0];

            dataInvoices = new List<reportInvoice>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportInvoice dataList = new reportInvoice();

                dataList.InvoiceCode = dt.Rows[i]["Code"].ToString();
                dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                dataList.ProName = dt.Rows[i]["ProductName"].ToString();
                dataList.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.Price = Convert.ToDouble(dt.Rows[i]["Price"].ToString());
                dataList.Amount = Convert.ToDouble(dt.Rows[i]["Amount"].ToString());
                dataList.Sellby = dt.Rows[i]["EmployeeName"].ToString();
                dataList.CustomerName = dt.Rows[i]["CustomerName"].ToString();
                dataList.Phone = dt.Rows[i]["Phone"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();

                dataInvoices.Add(dataList);
            }
        }

        
        Function func;
        private void addCurrentProductToPrint()
        {
            //DataSet ds = Helper.getDataSet("SELECT * FROM viewStock;");
            //DataSet ds = viewReport;
            DataTable dt = (DataTable)binding.DataSource;

            dataProducts = new List<reportProduct>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportProduct dataList = new reportProduct();

                dataList.Code = dt.Rows[i]["Code"].ToString();
                dataList.Name = dt.Rows[i]["ProductName"].ToString();
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
            DataSet ds = Helper.getDataSet("SELECT * FROM viewPurchase WHERE Code = '" + code + "';");
            DataTable dt = ds.Tables[0];

            dataPurchases = new List<reportPurchaseRenew>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportPurchaseRenew dataList = new reportPurchaseRenew();

                dataList.PurCode = dt.Rows[i]["Code"].ToString();
                dataList.PurDate = dt.Rows[i]["PurDate"].ToString();
                dataList.ProName = dt.Rows[i]["ProductName"].ToString();
                dataList.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.UnitPrice = Convert.ToDouble(dt.Rows[i]["Unitprice"].ToString());
                dataList.Payment = Convert.ToDouble(dt.Rows[i]["Paid"].ToString());
                dataList.Balance = Convert.ToDouble(dt.Rows[i]["Balance"].ToString());
                dataList.SupName = dt.Rows[i]["SupplierName"].ToString();
                dataList.EmpName = dt.Rows[i]["EmployeeName"].ToString();
                dataList.Total = Convert.ToDouble(dt.Rows[i]["Total"].ToString());

                dataPurchases.Add(dataList);
            }
        }

        private void addCurrentSupplierToPrint()
        {
            //DataSet ds = Helper.getDataSet("SELECT * FROM viewSupplier;");
            //DataTable dt = ds.Tables[0];
            DataTable dt = (DataTable)binding.DataSource;

            dataSuppliers = new List<reportSupplierRenew>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportSupplierRenew dataList = new reportSupplierRenew();

                dataList.SupCode = dt.Rows[i]["Code"].ToString();
                dataList.NameEN = dt.Rows[i]["SupplierName"].ToString();
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
            //try
            //{
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
                if (cbSortby.SelectedIndex == 4)
                {
                    purchaseAllReport report = new purchaseAllReport();
                    new reportViewer(report).ShowDialog();
                }
                if (cbSortby.SelectedIndex == 1)
                {
                    List<reportPurchaseWeekly> list = new List<reportPurchaseWeekly>();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        reportPurchaseWeekly obj = new reportPurchaseWeekly(DateTime.Parse(row.Cells[0].Value.ToString()).ToShortDateString(), DateTime.Parse(row.Cells[1].Value.ToString()).ToShortDateString(), row.Cells["Payment"].Value.ToString(), row.Cells["Balance"].Value.ToString(), row.Cells["Total"].Value.ToString());
                        list.Add(obj);
                    }

                    new reportViewer(list).ShowDialog();
                }
                if (cbSortby.SelectedIndex == 2)
                {
                    purchaseMonthlyReport report = new purchaseMonthlyReport();
                    new reportViewer(report).ShowDialog();
                }
                if (cbSortby.SelectedIndex == 3)
                {
                    purchaseYearlyReport report = new purchaseYearlyReport();
                    new reportViewer(report).ShowDialog();
                }
                if (cbSortby.SelectedIndex == 0)
                {
                    PurchaseDailyReport report = new PurchaseDailyReport();
                    new reportViewer(report).ShowDialog();
                }
            }
            else if (currentSelected.Equals("invoice"))
            {


                if (cbSortby.SelectedIndex == 4)
                {

                    invoiceAllReport report = new invoiceAllReport();
                    new reportViewer(report).ShowDialog();
                }
                if (cbSortby.SelectedIndex == 1)
                {
                    invoiceWeeklyReport report = new invoiceWeeklyReport();
                    List<reportPurchaseWeekly> list = new List<reportPurchaseWeekly>();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        reportPurchaseWeekly obj = new reportPurchaseWeekly(DateTime.Parse(row.Cells[0].Value.ToString()).ToShortDateString(), DateTime.Parse(row.Cells[1].Value.ToString()).ToShortDateString(), row.Cells["Payment"].Value.ToString(), row.Cells["Balance"].Value.ToString(), row.Cells["TotalPrice"].Value.ToString());
                        list.Add(obj);
                    }

                    report.SetDataSource(list);
                    new reportViewer(report).ShowDialog();
                   
                }
                if (cbSortby.SelectedIndex == 2)
                {
                    invoiceMonthlyReport report = new invoiceMonthlyReport();
                    new reportViewer(report).ShowDialog();
                }
                if(cbSortby.SelectedIndex==3)
                {
                    invoiceYearlyReport report = new invoiceYearlyReport();
                    new reportViewer(report).ShowDialog();
                }
                if (cbSortby.SelectedIndex == 0)
                {
                    invoiceDailyReport report=new invoiceDailyReport();
                    
                    new reportViewer(report).ShowDialog();
                }

            }
            else if (currentSelected.Equals("stock"))
            {
                addCurrentProductToPrint();
                new reportViewer(dataProducts).ShowDialog();
            }
            else if (currentSelected.Equals("income"))
            {
                List<GeneralReport> list=new List<GeneralReport>();
                ReportDocument report=new ReportDocument();
                if(cbSortby.SelectedIndex==1)
                {

                    report = new ReportIncomeWeekly();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        GeneralReport obj = new GeneralReport();
                        obj.Date1 = row.Cells[0].Value + "";
                        obj.Date2 = row.Cells[1].Value + "";
                        obj.Payment = double.Parse(row.Cells[2].Value + "");
                        obj.Balance = double.Parse(row.Cells[3].Value + "");
                        obj.Total = double.Parse(row.Cells[4].Value + "");

                        obj.Title = "Income Weekly";
                        list.Add(obj);

                    }
                }
                else if(cbSortby.SelectedIndex==0)
                {
                    report = new ReportIncome();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row=viewReport.Rows[i];
                        GeneralReport obj = new GeneralReport();
                        obj.Date1 = row.Cells[0].Value+"";
                        obj.Payment = double.Parse(row.Cells[1].Value + "");
                        obj.Balance = double.Parse(row.Cells[2].Value + "");
                        obj.Total = double.Parse(row.Cells[3].Value + "");

                        obj.Title = "Income Daily";
                        list.Add(obj);

                    }
                }
                else if(cbSortby.SelectedIndex==2)
                {

                    report = new ReportIncome();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        GeneralReport obj = new GeneralReport();
                        obj.Date1 = row.Cells[0].Value + "";
                        obj.Payment = double.Parse(row.Cells[1].Value + "");
                        obj.Balance = double.Parse(row.Cells[2].Value + "");
                        obj.Total = double.Parse(row.Cells[3].Value + "");

                        obj.Title = "Income Monthly";
                        list.Add(obj);

                    }
                }
                else if (cbSortby.SelectedIndex == 3)
                {

                    report = new ReportIncome();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        GeneralReport obj = new GeneralReport();
                        obj.Date1 = row.Cells[0].Value + "";
                        obj.Payment = double.Parse(row.Cells[1].Value + "");
                        obj.Balance = double.Parse(row.Cells[2].Value + "");
                        obj.Total = double.Parse(row.Cells[3].Value + "");

                        obj.Title = "Income Yearly";
                        list.Add(obj);

                    }
                }
                else if (cbSortby.SelectedIndex == 4)
                {

                    report = new ReportIncome();
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        GeneralReport obj = new GeneralReport();
                        obj.Date1 = row.Cells[0].Value + "";
                        obj.Payment = double.Parse(row.Cells[3].Value + "");
                        obj.Balance = double.Parse(row.Cells[4].Value + "");
                        obj.Total = double.Parse(row.Cells[5].Value + "");

                        obj.Title = "Income All";
                        list.Add(obj);

                    }

                }
                report.SetDataSource(list);
                new reportViewer(report).ShowDialog();
            }
            else
            {
                MessageBox.Show("Something error!!!", "Warning!");
            }

            //catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //    return; }
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        string dStart = null, dEnd = null;
        private void btnFilter_Click(object sender, EventArgs e)
        {
            cbSortby.SelectedIndex = 4;

            dStart = dateStart.Value.ToString("yyyy-MM-dd");
            dEnd = dateEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("select InvoiceCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(CusFNKH,' ',CusLNKH) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE Convert(date,I.Date) BETWEEN '" + dStart + "' and '" + dEnd + "'", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "invoice";

                    this.Text = " Report Invoice => From " + dStart + " To " + dEnd;
                    this.Refresh();
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("select PurCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(SuFNKH,' ',SuLNKH) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE Convert(date,I.Date) BETWEEN '" + dStart + "' and '" + dEnd + "'", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";

                    this.Text = " Report Purchase => From " + dStart + " To " + dEnd;
                    this.Refresh();

                }
                else if (currentSelected.Equals("income"))
                {
                    Helper.BindGridView("select InvoiceCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(CusFNKH,' ',CusLNKH) as CustomerName ,I.TotalPrice,(TotalPrice-Profits) Cost,I.Profits from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE Convert(date,I.Date) BETWEEN '" + dStart + "' and '" + dEnd + "'", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "income";

                    this.Text = " Report Income => From " + dStart + " To " + dEnd;
                    this.Refresh();
                }
            }
            catch (Exception) { return; }
        }

        private void loadNumRecord()
        {
            lbNumRecord.Text = (viewReport.RowCount-1) + "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch(currentSelected)
            {
                case "customer":
                    if (txtSearch.Text.Trim() != "")
                    {
                        this.Text = "Report Customer | Search: " + txtSearch.Text.Trim();
                        this.Refresh();

                        Helper.BindGridView("SELECT * FROM viewCustomer WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewCustomer;", binding, viewReport);

                        this.Text = "Report Customer";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                case "supplier":
                    if (txtSearch.Text.Trim() != "")
                    {
                        this.Text = "Report Supplier | Search: " + txtSearch.Text.Trim();
                        this.Refresh();

                        Helper.BindGridView("SELECT * FROM viewSupplier WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();

                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewSupplier;", binding, viewReport);

                        this.Text = "Report Supplier";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                case "employee":
                    if (txtSearch.Text.Trim() != "")
                    {
                        this.Text = "Report Employee | Search: " + txtSearch.Text.Trim();
                        this.Refresh();

                        Helper.BindGridView("SELECT * FROM viewEmployee WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewEmployee;", binding, viewReport);

                        this.Text = "Report Employee";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                case "purchase":
                    if (txtSearch.Text.Trim() != "")
                    {
                        this.Text = "Report Purchase | Search: " + txtSearch.Text.Trim();
                        this.Refresh();

                        if (dStart != null && dEnd!=null)
                        {
                            Helper.BindGridView("SELECT * FROM viewPurchase WHERE "+cbSearchBy.SelectedItem+" LIKE '%" + txtSearch.Text + "%' AND CONVERT(date,PurDate) BETWEEN '"+dStart+"' AND '"+dEnd+"';", binding, viewReport);
                        }
                        else
                        {
                            Helper.BindGridView("SELECT * FROM viewPurchase WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%'", binding, viewReport);

                        }

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewPurchase;", binding, viewReport);

                        this.Text = "Report Purchase";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                case "invoice":
                    if (txtSearch.Text.Trim() != "")
                    {
                        this.Text = "Report Invoice | Search: " + txtSearch.Text.Trim();
                        this.Refresh();

                        Helper.BindGridView("SELECT * FROM viewInvoice WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%';", binding, viewReport);
                       

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewInvoice;", binding, viewReport);

                        this.Text = "Report Invoice";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                case "stock":
                    if (txtSearch.Text.Trim() != "")
                    {

                        this.Text = "Report Stock | Search: " + txtSearch.Text.Trim();
                        this.Refresh();


                        Helper.BindGridView("SELECT * FROM viewStock WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewStock;", binding, viewReport);

                        this.Text = "Report Stock";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                case "income":
                    if (txtSearch.Text.Trim() != "")
                    {

                        this.Text = "Report Income | Search: " + txtSearch.Text.Trim();
                        this.Refresh();


                        Helper.BindGridView("SELECT * FROM viewIncome WHERE " + cbSearchBy.SelectedItem + " LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewIncome;", binding, viewReport);

                        this.Text = "Report Income";
                        this.Refresh();

                        loadNumRecord();
                    }
                    break;
                default:
                    
                    this.Text = "Report";
                    this.Refresh();

                    MessageBox.Show("Please select one to search!");
                    break;
            }

            Helper.AutoFitColumns(viewReport);
        }

        private void loadSearchFilter(string searchText,string field, DataGridView dg)
        {
            foreach(DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[field].ToString().ToLower().Contains(searchText.ToLower()))
                {
                    MessageBox.Show(row.Cells[field].ToString());
                }
                else
                {
                    dg.Rows.Remove(row);
                }
            }
        }

        public static int DaysInYear(int year)
        {
            return DateTime.IsLeapYear(year) ? 366 : 365;
        }

        private void cbSortby_SelectedIndexChanged(object sender, EventArgs e)
        {

            showBy();

            //DateTime last_day = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);//

            //MessageBox.Show("" + current_date + "\n" + "");
        }

        

        private void showBy()
        {
            DateTime today = DateTime.Today;
            int last_day = int.Parse(new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today
                .Year, today.Month)).ToString("dd"));
            string[] show_by = { "daily", "weekly", "monthly", "yearly", "all" };
            int[] in_day = { 1, 7, last_day, DaysInYear(today.Year), 0 };
            int current_index = cbSortby.SelectedIndex;
            string current_date = today.ToString("yyyy-MM-dd");
            string start_date = Helper.StartOfWeek(today, DayOfWeek.Monday).ToString("yyyy-MM-dd");
            string end_date = (Helper.StartOfWeek(today,DayOfWeek.Monday).AddDays(in_day[current_index]-1).ToString("yyyy-MM-dd"));

            if (show_by[current_index].Equals(show_by[0]))
            {
                if (currentSelected.Equals("invoice"))
                {

                    Helper.BindGridView("Select convert(date,Min(Date)) Date,SUM(Payment) as Payment,SUM(Balance) as Balance,SUM(TotalPrice) as TotalPrice  from Invoice GROUP BY YEAR([Date]) , MONTH(Date),DAY([Date])", binding, viewReport);

                    //Helper.BindGridView("SELECT i.InvoiceNo,i.Date,i.TotalPrice,i.Payment,i.Profits,i.Balance,CONCAT(c.CusLNEN,' ',c.CusFNEN) Buyer,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) Seller FROM Invoice i INNER JOIN Customers c ON i.CusID = c.CusID INNER JOIN Employee e ON i.EmpID = e.EmpID;", binding, viewReport);

                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {

                    Helper.BindGridView("Select convert(date,Min(Date)) Date,SUM(Payment) as Payment,SUM(Balance) as Balance,SUM(Total) as Total  from Purchase GROUP BY YEAR([Date]) , MONTH(Date),DAY([Date])", binding, viewReport);

                   // Helper.BindGridView("SELECT PurCode,CONVERT(date,Date) Date,Payment,Balance,Total FROM Purchase;", binding, viewReport);

                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";
                }
                else if (currentSelected.Equals("income"))
                {
                    viewReport.Columns.Clear();

                    Helper.BindGridView("Select format(min([Date]),'yyyy-MM-dd') Date,SUM(TotalPrice) TotalPrice,(SUM(TotalPrice)-SUM(Profits)) Cost,SUM(Profits) Profits from Invoice group BY year([Date]),Month([Date]),day([Date]) ORDER BY Date ", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                }
            }
            else if (show_by[current_index].Equals(show_by[1]))
            {
                if (currentSelected.Equals("invoice"))
                {

                    Helper.BindGridView("set datefirst 1 select Convert(date,DATEADD(day,1-DATEPART(dw, min(DATE)),min(DATE))) as Start_Date, convert(date,DATEADD(day,7-DATEPART(dw, min(DATE)),min(DATE))) as End_Date, SUM(TotalPrice) TotalPrice, SUM(Balance) Balance, SUM(Payment) Payment from Invoice  GROUP BY YEAR([Date]),MONTH([Date]),DATEPART(ww, [Date])", binding, viewReport);

                    //Helper.BindGridView("SELECT i.InvoiceNo,i.Date,i.TotalPrice,i.Payment,i.Profits,i.Balance,CONCAT(c.CusLNEN,' ',c.CusFNEN) Buyer,CONCAT(e.EmpLNEN,' ',e.EmpFNEN) Seller FROM Invoice i INNER JOIN Customers c ON i.CusID = c.CusID INNER JOIN Employee e ON i.EmpID = e.EmpID WHERE Date BETWEEN '" + start_date + "' AND '" + end_date + "';", binding, viewReport);

                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("set datefirst 1 select Convert(date,DATEADD(day,1-DATEPART(dw, min(DATE)),min(DATE))) as Start_Date,convert(date,DATEADD(day,7-DATEPART(dw, min(DATE)),min(DATE))) as End_Date,sum(Payment) as Payment,sum(Balance) as Balance, sum(total) as Total from Purchase GROUP BY YEAR(Date),Month(DATE),DATEPART(ww, DATE) ORDER BY Start_date", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";
                }
                else if (currentSelected.Equals("income"))
                {
                    viewReport.Columns.Clear();

                    Helper.BindGridView("set datefirst 1 Select format(DATEADD(day, 1-DATEPART(dw, min([Date])), min([Date])),'yyyy-MM-dd') Start_Date,format(DATEADD(day, 7-DATEPART(dw, min([Date])), min([Date])),'yyyy-MM-dd') END_Date,SUM(TotalPrice) TotalPrice,(SUM(TotalPrice)-SUM(Profits)) Cost,SUM(Profits) Profits from Invoice group BY year([Date]) ,Month([Date]) ,DATEPART(wk, [Date]) ORDER BY Start_Date", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                }
            }
            else if (show_by[current_index].Equals(show_by[2]))
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("select format(Max(Date),'yyyy-MMM') as 'Year-Mon',SUM(TotalPrice) TotalPrice,SUM(Balance) Balance,SUM(Payment) Payment from Invoice GROUP BY YEAR([Date]),MONTH([Date]) ORDER BY 'Year-Mon'", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("SELECT format(convert(date,MIN(DATE)),'yyyy-MMM') 'Year-Mon',sum(Payment) as Payment,sum(Balance) as Balance, sum(total) as Total from Purchase GROUP BY YEAR(Date),Month(DATE) ORDER BY 'Year-Mon'", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";
                }
                else if (currentSelected.Equals("income"))
                {
                    viewReport.Columns.Clear();
                    Helper.BindGridView("Select format(min([Date]),'yyyy-MMM') Date,SUM(TotalPrice) TotalPrice,(SUM(TotalPrice)-SUM(Profits)) Cost,SUM(Profits) Profits from Invoice group BY year([Date]),Month([Date]) ORDER BY Date ", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                }
            }
            else if (show_by[current_index].Equals(show_by[3]))
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("select format(Max(Date),'yyyy') as Date,SUM(TotalPrice) TotalPrice,SUM(Balance) Balance ,SUM(Payment) Payment from Invoice GROUP BY YEAR([Date])", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("SELECT format(convert(date,MIN(DATE)),'yyyy') 'Year',sum(Payment) as Payment,sum(Balance) as Balance, sum(total) as Total from Purchase GROUP BY YEAR(Date) ORDER BY 'Year'", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "purchase";
                }
                else if (currentSelected.Equals("income"))
                {
                    viewReport.Columns.Clear();

                    Helper.BindGridView("Select format(min([Date]),'yyyy') Date,SUM(TotalPrice) TotalPrice,(SUM(TotalPrice)-SUM(Profits)) Cost,SUM(Profits) Profits from Invoice group BY year([Date]) ORDER BY Date ", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                }
            }
            else
            {
                if (currentSelected.Equals("invoice"))
                {
                    metroTile3_Click(null, null);
                }
                else if (currentSelected.Equals("purchase"))
                {
                    metroTile2_Click(null, null);
                }
                else if (currentSelected.Equals("income"))
                {
                    metroTile6_Click(null, null);
                }
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            cbSortby.SelectedIndex = 4;
            viewReport.Columns.Clear();

            Helper.BindGridView("Select format([Date],'yyyy-MM-dd hh:mm tt') DATETIME,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) CustomerName,TotalPrice,(TotalPrice-Profits) Cost,Profits from Invoice I INNER JOIN Customers C on C.CusID=I.CusID INNER JOIN Employee E on E.EmpID=I.EmpID ORDER BY Date;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "income";

            this.Text = "Report Income";
            this.Refresh();

            visiableFilterStock(false);
            visiableFilterDate();
            visiableShowby();

        }

        private void viewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataGridViewRow currentrow;
        string additionalsql = "";

        private void viewReport_DoubleClick(object sender, EventArgs e)
        {
            func = new Function();
            currentrow=viewReport.SelectedRows[0];
            if (!currentrow.Cells[0].Value.ToString().Equals(""))
            {
                ReportDocument report=new ReportDocument();
                if(currentSelected.Equals("invoice"))
                {  
                    // Daily Invoice
                    List<GeneralReport> list=new List<GeneralReport>();
                    
                    if (cbSortby.SelectedIndex == 0)
                    {
                      
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE CONVERT(date,i.[Date])='"+DateTime.Parse(Cell("Date")).ToShortDateString()+"'").Rows)
                        {
                            GeneralReport obj=new GeneralReport(row[0]+"",DateTime.Parse(Cell(0)).ToShortDateString(),row[1].ToString(),row[2].ToString(),row[3].ToString(),row[4].ToString(),row[5].ToString());
                            obj.Title = "List Invoice-Day";
                            list.Add(obj);
                        }
                        report=new listPurchaseReport();
                        report.SetDataSource(list);

                    }

                    // Invoice Weekly
                    if (cbSortby.SelectedIndex == 1)
                    {

                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE I.Date BETWEEN '" + DateTime.Parse(Cell("Start_Date")).ToShortDateString() + "' and '" + DateTime.Parse(Cell("End_Date")).ToShortDateString() + "'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", DateTime.Parse(Cell(0)).ToShortDateString(), DateTime.Parse(Cell(1)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Invoice List-Week";
                            list.Add(obj);
                        }
                        report = new listWeeklyPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Monthly Invoice
                    else if(cbSortby.SelectedIndex==2)
                    {
                        
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE format(i.[Date],'yyyy-MMM')=format(convert(date,'" + DateTime.Parse(Cell("Year-Mon")).ToShortDateString()+"'),'yyyy-MMM')").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", DateTime.Parse(Cell(0)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "List Invoice-Month";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Yearly Invoice
                    else if (cbSortby.SelectedIndex == 3)
                    {
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE format(i.[Date],'yyyy')='" + Cell("Date") + "'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", Cell(0), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "List Invoice-Year";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);
                    }
                    else
                    {
                        if (cbSortby.SelectedIndex == 4)
                        {
                            string code = viewReport.SelectedRows[0].Cells[0].Value.ToString();
                            addCurrentInvoiceToPrint(code);

                            new reportViewer(dataInvoices).ShowDialog();
                            return;
                        }
                    }
                }
                else if (currentSelected == "purchase")
                {
                    List<GeneralReport> list = new List<GeneralReport>();
                    // Purchase Daily
                    if (cbSortby.SelectedIndex == 0)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(SuFNEN,' ',SuLNEN) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE CONVERT(date,i.[Date])='" + DateTime.Parse(Cell(0)).ToShortDateString() + "'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "",DateTime.Parse(Cell(0)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "List Purchase-Day";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);

                    }
                    // Weekly Purchase
                    else if (cbSortby.SelectedIndex == 1)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(SuFNEN,' ',SuLNEN) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE I.[Date] BETWEEN '" + DateTime.Parse(Cell(0)).ToShortDateString()+"' and '"+DateTime.Parse(Cell(1)).ToShortDateString()+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", DateTime.Parse(Cell(0)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "List Purchase-Week";
                            list.Add(obj);
                        }
                        report = new listWeeklyPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Purchase Monthly
                    else if (cbSortby.SelectedIndex == 2)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(SuFNEN,' ',SuLNEN) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE format(Date,'yyyy-MMM')='" + Cell("Year-Mon")+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", Cell(0), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "List Purchase-Month";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Purchase Yearly
                    else if (cbSortby.SelectedIndex == 3)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(SuFNEN,' ',SuLNEN) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE format(Date,'yyyy')='" + Cell(0)+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", Cell(0), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "List Purchase- Day";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);
                    }
                    else
                    {
                        if (cbSortby.SelectedIndex == 4)
                        {
                            string code = viewReport.SelectedRows[0].Cells[0].Value.ToString();
                            addCurrentPurchaseToPrint(code);
                            new reportViewer(dataPurchases).ShowDialog();
                            return;
                        }
                    }

                }
                else if (currentSelected.Equals("income"))
                {
                    List<GeneralReport> list = new List<GeneralReport>();

                    // income daily
                    if (cbSortby.SelectedIndex == 0)
                    {
                        report = new listReportIncome();
                        foreach(DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.TotalPrice,(TotalPrice-Profits) Cost,I.Profits from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE CONVERT(date,i.[Date])='" + DateTime.Parse(Cell(0)).ToShortDateString()+"'").Rows)
                        {
                            GeneralReport obj=new GeneralReport(row[0].ToString(),DateTime.Parse(Cell(0)).ToShortDateString(),row[1]+"",row[2]+"",row[3]+"",row[4]+"",row[5]+"");
                            obj.Title = "Income List-Day";
                            list.Add(obj);
                        }
                        report.SetDataSource(list);
                    }

                    // income Monthly
                    if (cbSortby.SelectedIndex == 2)
                    {
                     
                        report = new listReportIncome();
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.TotalPrice,(TotalPrice-Profits) Cost,I.Profits from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE format(i.[Date],'yyyy-MMM')='" + Cell(0)+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0].ToString(), DateTime.Parse(Cell(0)).ToShortDateString(), row[1] + "", row[2] + "", row[3] + "", row[4] + "", row[5] + "");
                            obj.Title = "Income  List-Month";
                            list.Add(obj);
                        }
                        report.SetDataSource(list);
                    }

                    // Yearly List Income
                    
                    if (cbSortby.SelectedIndex == 3)
                    {

                        report = new listReportIncome();
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.TotalPrice,(TotalPrice-Profits) Cost,I.Profits from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE year(i.[Date])='" + Cell(0)+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0].ToString(), DateTime.Parse(Cell(0)).ToShortDateString(), row[1] + "", row[2] + "", row[3] + "", row[4] + "", row[5] + "");
                            obj.Title = "Income  List-Year";
                            list.Add(obj);
                        }
                        report.SetDataSource(list);
                    }

                    // Weekly lncome List
                    if (cbSortby.SelectedIndex == 1)
                    {
                        report = new listReportIncomeWeekly();
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNEN,' ',E.EmpLNEN) as EmployeeName,concat(CusFNEN,' ',CusLNEN) as CustomerName ,I.TotalPrice,(TotalPrice-Profits) Cost,I.Profits from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE [Date] BETWEEN '" + DateTime.Parse(Cell(0)).ToShortDateString()+"' and '"+DateTime.Parse(Cell(1)).ToShortDateString()+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0].ToString(), DateTime.Parse(Cell(0)).ToShortDateString(),DateTime.Parse(Cell(1)).ToShortDateString(), row[1] + "", row[2] + "", row[3] + "", row[4] + "", row[5] + "");
                            obj.Title = "Income  List-Week";
                            list.Add(obj);
                        }
                        report.SetDataSource(list);
                        
                    }
                    // Nothing To Show
                    if (cbSortby.SelectedIndex == 4)
                        return;
                }
                else if(currentSelected.Equals("customer"))
                {
                    //MessageBox.Show(Cell(0));
                    addCurrentCustomerListReport(Cell(0));
                    new reportViewer(dataCustomerAllReports).ShowDialog();
                }
                else if(currentSelected.Equals("employee"))
                {
                    if (cbEmployeeby.SelectedIndex.Equals(0))
                    {
                        addCurrentEmployeeListReportInvoice(Cell(0));
                        new reportViewer(dataEmployeeAllReportsInvoice).ShowDialog();
                    }
                    else if(cbEmployeeby.SelectedIndex.Equals(1))
                    {
                        addCurrentEmployeeListReportPurchase(Cell(0));
                        new reportViewer(dataEmployeeAllReportsPurchase).ShowDialog();
                    }

                }
                else if(currentSelected.Equals("supplier"))
                {
                    addCurrentSupplierListReport(Cell(0));
                    new reportViewer(dataSupplierAllReports).ShowDialog();
                }

                if (currentSelected.Equals("invoice")||currentSelected.Equals("purchase")||currentSelected.Equals("income"))
                {
                    new reportViewer(report).ShowDialog();
                }
            }
        }

        public string Cell(int index)
        {
            return currentrow.Cells[index].Value.ToString();
        }

        public string Cell(string index)
        {
            return currentrow.Cells[index].Value.ToString();
        }

        private void dateStart_DropDown(object sender, EventArgs e)
        {
          
        }
        private void dateStart_Enter(object sender, EventArgs e)
        {
            dateStart.MaxDate = dateEnd.Value;
        }

        private void dateEnd_Enter(object sender, EventArgs e)
        {
            dateEnd.MinDate = dateStart.Value;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exec(string table)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + ";", Connection.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbFilter2.Items.Add(reader.GetValue(2) + "");
                }

                reader.Close();
                cmd.Dispose();

                cbFilter2.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "EXEC");
                cbFilter2.Enabled = false;

            }
        }

        private void loadFilterData(int filtertype)
        {
            try
            {
                if (filtertype.Equals(0))
                {
                    exec("Model");
                }
                else
                {
                    exec("Phone_Type");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "loadFilter");
            }
        }

        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cbFilter2.Enabled = true;

                if (cbFilter.SelectedIndex.Equals(1))
                {
                    cbFilter2.Items.Clear();
                    loadFilterData(0);

                }
                else if (cbFilter.SelectedIndex.Equals(2))
                {
                    cbFilter2.Items.Clear();
                    loadFilterData(1);

                }
                else
                {
                    cbFilter2.Items.Clear();
                    cbFilter2.Enabled = false;

                    loadData("");

                }
            }
            catch(Exception) { }
        }

        private void loadData(string sql="")
        {
            try
            {
                Helper.BindGridView("SELECT * FROM viewStock " + sql, binding, viewReport);
                Helper.AutoFitColumns(viewReport);
            }
            catch (Exception) { }
        }

        private void cbFilter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFilter.SelectedIndex.Equals(1))
                {
                    loadData("WHERE Brand = '" + cbFilter2.SelectedItem + "'");
                }
                else if (cbFilter.SelectedIndex.Equals(2))
                {
                    loadData("WHERE PhoneType = '" + cbFilter2.SelectedItem + "';");
                }
                else
                {
                    loadData("");
                }
            }
            catch(Exception) { }
        }

        private void visiableFilterDate(bool tf=true)
        {
            if(tf)
            {
                lbFromdate.Visible = tf;
                lbTodate.Visible = tf;
                dateStart.Visible = tf;
                dateEnd.Visible = tf;
                btnFilter.Visible = tf;
            }
            else
            {
                lbFromdate.Visible = tf;
                lbTodate.Visible = tf;
                dateStart.Visible = tf;
                dateEnd.Visible = tf;
                btnFilter.Visible = tf;
            }
        }

        private void visiableShowby(bool tf=true)
        {
            if(tf)
            {
                lbShowby.Visible = tf;
                cbSortby.Visible = tf;
            }
            else
            {
                lbShowby.Visible = tf;
                cbSortby.Visible = tf;
            }
        }
    }
}
