using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    class employeeListReportsPurchase:employeeListReportsInvoice
    {
        public double Paid { get; set; }
        public double Balance { get; set; }
        public double Total { get; set; }
    }
}
