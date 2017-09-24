using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportStockOut:StructStockInOut
    {
        public int PaymentVerify { get; set; }
        public double Profits { get; set; }
        public string CusName { get; set; }
    }
}
