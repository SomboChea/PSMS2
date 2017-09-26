using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class GeneralReport
    {
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string OtherName { get; set; }
        public string EmpName { get; set; }
        public double Total { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        public string InvoiceCode { get; set; }
        public string Title { get; set; }
        public GeneralReport()
        {

        }
        public GeneralReport(string InvoiceCode,string Date,string Othername,string EmpName , string payment,string balance,string Total)
        {
            this.InvoiceCode = InvoiceCode;
            this.Date1 = Date;
            this.OtherName = Othername;
            this.EmpName = EmpName;
            this.Total = double.Parse(Total);
            this.Payment = double.Parse(payment);
            this.Balance = double.Parse(balance);
        }
        public GeneralReport(string InvoiceCode, string StartDate,string EndDate, string Othername, string EmpName, string payment, string balance, string Total)
        {
            this.InvoiceCode = InvoiceCode;
            this.Date1 = StartDate;
            this.Date2 = EndDate;
            this.OtherName = Othername;
            this.EmpName = EmpName;
            this.Total = double.Parse(Total);
            this.Payment = double.Parse(payment);
            this.Balance = double.Parse(balance);
        }

    }
}
