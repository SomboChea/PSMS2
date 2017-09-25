using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportPurchaseWeekly
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double Onhand { get; set; }
        public double Credit { get; set; }
        public double Total { get; set; }
        public reportPurchaseWeekly(string startdate,string enddate,string onhand,string credit,string total)
        {
            StartDate = startdate;
            EndDate = enddate;
            Onhand =double.Parse(onhand);
            Credit = double.Parse(credit);
            Total = double.Parse(total);
        }
      
    }
}
