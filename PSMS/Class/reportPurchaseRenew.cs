using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportPurchaseRenew
    {
        public reportPurchaseRenew()
        {

        }

        public reportPurchaseRenew(string purCode, string purDate, string proName, int quantity, double unitPrice, double amount, double payment, double balance, string supName, string empName, double total)
        {
            PurCode = purCode;
            PurDate = purDate;
            ProName = proName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Amount = amount;
            Payment = payment;
            Balance = balance;
            SupName = supName;
            EmpName = empName;
            Total = total;
        }

        public string PurCode { get; set; }
        public string PurDate { get; set; }
        public string ProName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Amount { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        public string SupName { get; set; }
        public string EmpName { get; set; }
        public double Total { get; set; }
    }
}
