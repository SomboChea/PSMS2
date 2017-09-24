using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class StructStockInOut
    {
        public StructStockInOut()
        {

        }
        public StructStockInOut(string code, string proCode, string proName, string proSize, string proColor, string brand, string pType, string type, int proQty, double price, double payment, double balance, string empName, string date, string time)
        {
            Code = code;
            ProCode = proCode;
            ProName = proName;
            ProSize = proSize;
            ProColor = proColor;
            Brand = brand;
            PType = pType;
            Type = type;
            ProQty = proQty;
            Price = price;
            Payment = payment;
            Balance = balance;
            EmpName = empName;
            Date = date;
            Time = time;
        }

        public string Code { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public string ProSize { get; set; }
        public string ProColor { get; set; }
        public string Brand { get; set; }
        public string PType { get; set; }
        public string Type { get; set; }
        public int ProQty { get; set; }
        public double Price { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        public string EmpName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public double TotalPrice
        {
            get { return ProQty * Price; }
        }
    }
}
