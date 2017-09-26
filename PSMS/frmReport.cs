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
            
        }

        //View Suppliers
        private void metroTile5_Click(object sender, EventArgs e)
        {
            Helper.BindGridView("SELECT * FROM viewSupplier;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "supplier";

        }

        //View Employees
        private void metroTile4_Click(object sender, EventArgs e)
        {
            Helper.BindGridView("SELECT EmpCode,FullNameEN,Gender,IDCard,Address,Phone,Email,PositionName,Salary,JoinDate FROM viewEmployee;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "employee";
        }

        //View Purchases
        private void metroTile2_Click(object sender, EventArgs e)
        {
            cbSortby.SelectedIndex = 4;
            Helper.BindGridView("SELECT PurCode,Date,Payment,Balance,Total FROM Purchase;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "purchase";
        }

        //View Invoices
        private void metroTile3_Click(object sender, EventArgs e)
        {
            cbSortby.SelectedIndex = 4;
            Helper.BindGridView("SELECT i.InvoiceCode,i.Payment , i.Balance,i.TotalPrice, i.Date, CONCAT(c.CusLNEN,c.CusFNEN) CustomerName FROM Invoice i INNER JOIN Customers c ON i.CusID = c.CusID; ", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "invoice";
        }

        //View Stocks
        private void viewStock_Click(object sender, EventArgs e)
        {
            viewReport.DataSource = binding;
            Helper.BindGridView("SELECT PCode,PName,PSize,Color,Quantity,Brand,PhoneType,Type,SalePrice,UnitPrice FROM viewStock;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(false);

            loadNumRecord();
            currentSelected = "stock";
        }

        //Defines for Reports DATA
        List<reportCustomer> dataCustomers;
        List<reportEmployee> dataEmployees;
        List<reportInvoice> dataInvoices;
        List<reportProduct> dataProducts;
        List<reportPurchaseRenew> dataPurchases;
        List<reportSupplierRenew> dataSuppliers;

        List<reportRevenueWeekly> dataRevenueweekly;
        
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

        
        Function func;
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
                if(cbSortby.SelectedIndex==1)
                {
                    IncomeWeeklyReport report = new IncomeWeeklyReport();
                    new reportViewer(report).ShowDialog();
                }
                else if(cbSortby.SelectedIndex==0)
                {
                    IncomeDailyReport report = new IncomeDailyReport();
                    
                    new reportViewer(report).ShowDialog();
                }
                else if(cbSortby.SelectedIndex==2)
                {
                    IncomeMonthlyReport report = new IncomeMonthlyReport();
                    new reportViewer(report).ShowDialog();
                }
                else if (cbSortby.SelectedIndex == 3)
                {
                    IncomeYearlyReport report = new IncomeYearlyReport();
                    new reportViewer(report).ShowDialog();
                }
                else if (cbSortby.SelectedIndex == 4)
                {
                    IncomeAllReport report = new IncomeAllReport();
                    new reportViewer(report).ShowDialog();
                }
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string dStart = dateStart.Value.ToString("yyyy-MM-dd");
            string dEnd = dateEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("SELECT InvoiceCode, TotalPrice,Balance,CONVERT(date,Date) Date FROM Invoice WHERE CONVERT(date,Date) BETWEEN '" + dStart + "' AND '" + dEnd + "' ;", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("SELECT PurCode,CONVERT(date,Date) Date,Payment,Balance,Total FROM Purchase WHERE CONVERT(date,Date) BETWEEN '" + dStart + "' AND '" + dEnd + "';", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";
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
                        Helper.BindGridView("SELECT * FROM viewCustomer WHERE FullNameEN LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewCustomer;", binding, viewReport);

                        loadNumRecord();
                    }
                    break;
                case "supplier":
                    if (txtSearch.Text.Trim() != "")
                    {
                        Helper.BindGridView("SELECT * FROM viewSupplier WHERE FullNameEN LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();

                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewSupplier;", binding, viewReport);

                        loadNumRecord();
                    }
                    break;
                case "employee":
                    if (txtSearch.Text.Trim() != "")
                    {
                        Helper.BindGridView("SELECT * FROM viewEmployee WHERE FullNameEN LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewEmployee;", binding, viewReport);

                        loadNumRecord();
                    }
                    break;
                case "purchase":
                    if (txtSearch.Text.Trim() != "")
                    {
                        Helper.BindGridView("SELECT * FROM viewPurchase WHERE FullNameEN LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewPurchase;", binding, viewReport);

                        loadNumRecord();
                    }
                    break;
                case "invoice":
                    if (txtSearch.Text.Trim() != "")
                    {
                        Helper.BindGridView("SELECT * FROM viewInvoice WHERE CustomerName LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewInvoice;", binding, viewReport);

                        loadNumRecord();
                    }
                    break;
                case "stock":
                    if (txtSearch.Text.Trim() != "")
                    {
                        Helper.BindGridView("SELECT * FROM viewStock WHERE PName LIKE '%" + txtSearch.Text + "%';", binding, viewReport);

                        loadNumRecord();
                    }
                    else
                    {
                        Helper.BindGridView("SELECT * FROM viewStock;", binding, viewReport);

                        loadNumRecord();
                    }
                    break;
                default:
                    MessageBox.Show("Please select one to search!");
                    break;
            }

            Helper.AutoFitColumns(viewReport);
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

                    Helper.BindGridView("SELECT  convert(date,max(date)) as dated , sum(Total) as Purchase ,'' as Invoice from Purchase UNION select convert(date,min(DATE)) as dated , '',sum(TotalPrice)  from Invoice group BY YEAR(Date),MONTH(date),day(date) ORDER BY dated", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                    viewReport.Columns.Add("columnBalance", "Balance");
                    double balance = 0;
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        balance += double.Parse(row.Cells["Invoice"].Value.ToString()) - double.Parse(row.Cells["Purchase"].Value.ToString());
                        row.Cells["columnBalance"].Value = balance + "";
                    }
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

                    Helper.BindGridView("SELECT Convert(date,DATEADD(day,1-DATEPART(dw, min(DATE)),min(DATE))) as Start_Date, convert(date,DATEADD(day,7-DATEPART(dw, min(DATE)),min(DATE))) as End_Date , sum(Total) as Purchase ,'' as Invoice from Purchase UNION select Convert(date,DATEADD(day,1-DATEPART(dw, min(DATE)),min(DATE))) as Start_Date,convert(date,DATEADD(day,7-DATEPART(dw, min(DATE)),min(DATE))) as End_Date, '',sum(TotalPrice)  from Invoice group BY YEAR(Date),MONTH(date),DATEPART(ww, date)", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                    viewReport.Columns.Add("columnBalance", "Balance");
                    double balance = 0;
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        balance += double.Parse(row.Cells["Invoice"].Value.ToString()) - double.Parse(row.Cells["Purchase"].Value.ToString());
                        row.Cells["columnBalance"].Value = balance + "";
                    }
                    this.Text = balance + "";
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
                    Helper.BindGridView("select format(min(date),'yyyy-MMM') as Date ,sum(Total) as Purchase ,'' Invoice from Purchase union select format(min(date),'yyyy-MMM') as Date, '',sum(TotalPrice)  from Invoice group BY YEAR(Date),MONTH(date),MONTH(date) ORDER BY date", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                    viewReport.Columns.Add("columnBalance", "Balance");
                    double balance = 0;
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        balance += double.Parse(row.Cells["Invoice"].Value.ToString()) - double.Parse(row.Cells["Purchase"].Value.ToString());
                        row.Cells["columnBalance"].Value = balance + "";
                    }
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

                    Helper.BindGridView("SELECT  format(max(date),'yyyy') as dated , sum(Total) as Purchase ,'' as Invoice from Purchase UNION select format(min(DATE),'yyyy') as dated , '',sum(TotalPrice)  from Invoice group BY YEAR(Date)", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);
                    loadNumRecord();
                    currentSelected = "income";

                    viewReport.Columns.Add("columnBalance", "Balance");
                    double balance = 0;
                    for (int i = 0; i < viewReport.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = viewReport.Rows[i];
                        balance += double.Parse(row.Cells["Invoice"].Value.ToString()) - double.Parse(row.Cells["Purchase"].Value.ToString());
                        row.Cells["columnBalance"].Value = balance + "";
                    }
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
            Helper.BindGridView("SELECT  date , Total as Purchase ,'' as Invoice from Purchase UNION select DATE , '',TotalPrice  from Invoice ORDER BY Date;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "income";

            viewReport.Columns.Add("columnBalance", "Profits");
            double balance = 0;
            for (int i = 0; i < viewReport.Rows.Count - 1; i++)
            {
                DataGridViewRow row = viewReport.Rows[i];
                balance += double.Parse(row.Cells["Invoice"].Value.ToString()) - double.Parse(row.Cells["Purchase"].Value.ToString());
                row.Cells["columnBalance"].Value = balance + "";
            }

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
                      
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(CusFNKH,' ',CusLNKH) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE CONVERT(date,i.[Date])='"+DateTime.Parse(Cell("Date")).ToShortDateString()+"'").Rows)
                        {
                            GeneralReport obj=new GeneralReport(row[0]+"",DateTime.Parse(Cell(0)).ToShortDateString(),row[1].ToString(),row[2].ToString(),row[3].ToString(),row[4].ToString(),row[5].ToString());
                            obj.Title = "Daily Invoice";
                            list.Add(obj);
                        }
                        report=new listPurchaseReport();
                        report.SetDataSource(list);
                    }

                    // Invoice Weekly
                    if (cbSortby.SelectedIndex == 1)
                    {

                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(CusFNKH,' ',CusLNKH) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE I.Date BETWEEN '" + DateTime.Parse(Cell("Start_Date")).ToShortDateString() + "' and '" + DateTime.Parse(Cell("End_Date")).ToShortDateString() + "'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", DateTime.Parse(Cell(0)).ToShortDateString(), DateTime.Parse(Cell(1)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Weekly Invoice";
                            list.Add(obj);
                        }
                        report = new listWeeklyPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Monthly Invoice
                    else if(cbSortby.SelectedIndex==2)
                    {
                        
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(CusFNKH,' ',CusLNKH) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE format(i.[Date],'yyyy-MMM')=format(convert(date,'"+DateTime.Parse(Cell("Year-Mon")).ToShortDateString()+"'),'yyyy-MMM')").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", DateTime.Parse(Cell(0)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Monthly Invoice";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Yearly Invoice
                    else if (cbSortby.SelectedIndex == 3)
                    {
                        foreach (DataRow row in func.GetData("select InvoiceCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(CusFNKH,' ',CusLNKH) as CustomerName ,I.Payment, I.Balance,I.TotalPrice from Invoice as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Customers C on I.CusID=C.CusID WHERE format(i.[Date],'yyyy')='" + Cell("Date") + "'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", Cell(0), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Yearly Invoice";
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
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(SuFNKH,' ',SuLNKH) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE CONVERT(date,i.[Date])='" + DateTime.Parse(Cell(0)).ToShortDateString() + "'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "",DateTime.Parse(Cell(0)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Purchase Daily";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);

                    }
                    // Weekly Purchase
                    else if (cbSortby.SelectedIndex == 1)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(SuFNKH,' ',SuLNKH) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE I.[Date] BETWEEN '"+DateTime.Parse(Cell(0)).ToShortDateString()+"' and '"+DateTime.Parse(Cell(1)).ToShortDateString()+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", DateTime.Parse(Cell(0)).ToShortDateString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Purchase Weekly";
                            list.Add(obj);
                        }
                        report = new listWeeklyPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Purchase Monthly
                    else if (cbSortby.SelectedIndex == 2)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(SuFNKH,' ',SuLNKH) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE format(Date,'yyyy-MMM')='"+Cell("Year-Mon")+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", Cell(0), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Purchase Monthly";
                            list.Add(obj);
                        }
                        report = new listPurchaseReport();
                        report.SetDataSource(list);
                    }
                    // Purchase Yearly
                    else if (cbSortby.SelectedIndex == 3)
                    {
                        foreach (DataRow row in func.GetData("select PurCode,concat(E.EmpFNKH,' ',E.EmpLNKH) as EmployeeName,concat(SuFNKH,' ',SuLNKH) as SupplierName ,I.Payment, I.Balance,I.Total from Purchase as I INNER JOIN Employee as E on E.EmpID=I.EmpID INNER JOIN Supplier S on I.SuID=S.SuID WHERE format(Date,'yyyy')='"+Cell(0)+"'").Rows)
                        {
                            GeneralReport obj = new GeneralReport(row[0] + "", Cell(0), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                            obj.Title = "Purchase Yearly";
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
                    List<IncomeReport> list1 = new List<IncomeReport>();
                    List<IncomeReport> list2 = new List<IncomeReport>();

                    // income daily
                    if (cbSortby.SelectedIndex == 0)
                    {
                        report = new listIncomeReport();
         
                        foreach (DataRow row1 in func.GetData("select I.InvoiceCode , concat(CusFNKH,CusLNKH) CustomerName,concat(EmpFNKH,EmpLNKH) EmployeeName,TotalPrice from Invoice I INNER JOIN Customers C on I.CusID=C.CusID INNER JOIN Employee E on E.EmpID=I.EmpID where Convert(date,[Date])='" + DateTime.Parse(Cell(0)).ToString("MM-dd-yyyy") + "'").Rows)
                        {
                            IncomeReport Revenue = new IncomeReport();
                            Revenue.InvoiceCode = row1[0].ToString();
                            Revenue.OtherName = row1[1].ToString();
                            Revenue.EmpName = row1[2].ToString();
                            Revenue.Revenue = row1[3].ToString();

                            list1.Add(Revenue);
                        } 
                        report.Subreports[0].SetDataSource(list1);
                        foreach(DataRow row2 in func.GetData("select P.PurCode , concat(SuFNKH,SuLNKH) SupplierName,concat(EmpFNKH,EmpLNKH) EmployeeName,P.Total from Purchase P INNER JOIN Employee E on E.EmpID=P.EmpID INNER JOIN Supplier S on S.SuID=P.SuID where convert(date,[Date])='"+DateTime.Parse(Cell(0)).ToString("MM-dd-yyyy")+"'").Rows)
                        {  IncomeReport Expense = new IncomeReport();
                           Expense.InvoiceCode = row2[0].ToString();
                           Expense.OtherName = row2[1].ToString();
                           Expense.EmpName = row2[2].ToString();
                           Expense.Expense = row2[3].ToString();

                           list1.Add(Expense);                       
                        } 
                        report.Subreports[1].SetDataSource(list2);
                    }
                }
                new reportViewer(report).ShowDialog();
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
    }
}
