using PSMS.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());

            //Function dt = new Function();
            //Connection.Open("localhost", "PSMS2");
            //SqlCommand sqlcmd = new SqlCommand();

            //DataTable Invoicedata = dt.GetData("Select InvoiceNo from Invoice");
            //foreach (DataRow row in Invoicedata.Rows)
            //{
            //    int Inid = int.Parse(row["InvoiceNo"].ToString());
            //    DataTable InvoiceDetail = dt.GetData("Select * from InvoiceDetail where InvoiceNo=" + Inid);
            //    double profit = 0;
            //    foreach (DataRow Detailrow in InvoiceDetail.Rows)
            //    {
            //        double pricein = double.Parse(Connection.ExecuteScalar("Select UnitPrice from Product where PID='" + Detailrow["PID"] + "'") + "") * int.Parse(Detailrow["Quantity"] + "");
            //        double priceout = double.Parse(Detailrow["Saleprice"] + "") * int.Parse("" + Detailrow["quantity"]);
            //        profit += priceout - pricein;
            //    }
            //    Connection.ExecuteScalar("Update Invoice set Profits='" + profit + "' where InvoiceNo='" + row["InvoiceNo"] + "'");
            //}
            //Console.Write("finish");
            //Console.ReadKey();

        }
    }
}
