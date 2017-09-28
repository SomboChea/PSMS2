using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class employeeListReportsInvoice
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string EmpCode { get; set; }
        public string EmployeeName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public int ProQty { get; set; }
        public double Price { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get { return ProQty * Price; } }
    }
}
