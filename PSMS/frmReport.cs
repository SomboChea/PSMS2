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
             
            }
            else
            {
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
                btnFilter.Enabled = false;
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
            Helper.BindGridView("SELECT PurCode,Date,Payment,Balance,Total FROM Purchase;", binding, viewReport);
            Helper.AutoFitColumns(viewReport);
            dateEnable(true);

            loadNumRecord();
            currentSelected = "purchase";
        }

        //View Invoices
        private void metroTile3_Click(object sender, EventArgs e)
        {
            Helper.BindGridView("SELECT i.InvoiceCode, i.TotalPrice, i.Balance, i.Date, CONCAT(c.CusLNEN,c.CusFNEN) CustomerName FROM Invoice i INNER JOIN Customers c ON i.CusID = c.CusID; ", binding, viewReport);
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
                        if (cbSortby.SelectedIndex == 0)
                        {
                            string code = viewReport.SelectedRows[0].Cells[0].Value.ToString();
                            addCurrentPurchaseToPrint(code);
                            new reportViewer(dataPurchases).ShowDialog();
                        }
                    }
                }
                else if (currentSelected.Equals("invoice"))
                {
                    if(viewReport.SelectedCells.Count > 0)
                    {
                        if (cbSortby.SelectedIndex == 0)
                        {
                            string code = viewReport.SelectedRows[0].Cells[0].Value.ToString();
                            addCurrentInvoiceToPrint(code);
                            new reportViewer(dataInvoices).ShowDialog();
                        }
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
            string end_date = (today.AddDays(in_day[current_index] - 1).ToString("yyyy-MM-dd"));

            if (show_by[current_index].Equals(show_by[0]))
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("SELECT InvoiceCode, TotalPrice,Balance,CONVERT(date,Date) Date FROM Invoice;", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("SELECT PurCode,CONVERT(date,Date) Date,Payment,Balance,Total FROM Purchase);", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";
                }
            }
            else if (show_by[current_index].Equals(show_by[1]))
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("select CONVERT(Date,MIN(DATE)) as Start_Date,CONVERT(Date,MAX(Date)) as End_Date,SUM(TotalPrice) TotalPrice,SUM(Balance) Balance from Invoice  GROUP BY YEAR([Date]),MONTH([Date]),DATEPART(ww, [Date])", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "invoice";
                }
                else if (currentSelected.Equals("purchase"))
                {
                    Helper.BindGridView("SELECT convert(date,MIN(DATE)) as Start_Date,CONVERT(date,Max(DATE)) as End_Date,sum(Payment) as Payment,sum(Balance) as Balance, sum(total) as Total from Purchase GROUP BY YEAR(Date),Month(DATE),DATEPART(ww, DATE) ORDER BY Start_date", binding, viewReport);
                    Helper.AutoFitColumns(viewReport);

                    loadNumRecord();
                    currentSelected = "purchase";
                }
            }
            else if (show_by[current_index].Equals(show_by
                [2]))
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("select format(Max(Date),'yyyy-MMM') as 'Year-Mon',SUM(TotalPrice) TotalPrice,SUM(Balance) Balance from Invoice GROUP BY YEAR([Date]),MONTH([Date]) ORDER BY 'Year-Mon'", binding, viewReport);
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
            }
            else if (show_by[current_index].Equals(show_by[3]))
            {
                if (currentSelected.Equals("invoice"))
                {
                    Helper.BindGridView("select format(Max(Date),'yyyy') as Date,SUM(TotalPrice) TotalPrice,SUM(Balance) Balance from Invoice GROUP BY YEAR([Date])", binding, viewReport);
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
            }
            else
            {
                MessageBox.Show("All");
            }
        }
    }
}
