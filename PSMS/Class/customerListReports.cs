using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class customerListReports
    {
        public customerListReports()
        {

        }

        public customerListReports(string invcode, string code, string name, string date, string tel, string address, string proCode, string proName, int proQty, double price)
        {
            InvCode = invcode;
            Code = code;
            Name = name;
            Date = date;
            Tel = tel;
            Address = address;
            ProCode = proCode;
            ProName = proName;
            ProQty = proQty;
            Price = price;
        }
        
        public string InvCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public int ProQty { get; set; }
        public double Price { get; set; }
        public double Amount
        {
            get { return ProQty* Price; }
        }
    }
}
