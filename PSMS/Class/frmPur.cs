using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS
{
    class frmPur
    {
        public int pur_id { set; get; }
        public string pur_code { set; get; }
        public DateTime date { set; get; }
        public float payment { set; get; }
        public float balance { set; get; }
        public int suID { set; get; }
        public int empID { set; get; }
        public float total { set; get; }
    }
}
