using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportPurchase
    {
        public reportPurchase()
        {

        }
        public reportPurchase(string purCode, string purDate, double payment, double balance, string supName, string empName, double total)
        {
            PurCode = purCode;
            PurDate = purDate;
            Payment = payment;
            Balance = balance;
            SupName = supName;
            EmpName = empName;
            Total = total;
        }

        public string PurCode { get; set; }
        public string PurDate { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        public string SupName { get; set; }
        public string EmpName { get; set; }
        public double Total { get; set; }
    }
}
