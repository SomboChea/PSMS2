using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportRevenueWeekly
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Onhand { get; set; }
        public string Credit { get; set; }
        public string Total { get; set; }
        public reportRevenueWeekly(string startdate,string enddate,string onhand,string credit,string total)
        {
            StartDate = startdate;
            EndDate = enddate;
            Onhand = onhand;
            Credit = credit;
            Total = total;
        }
        public reportRevenueWeekly()
        {

        }
    }
}
