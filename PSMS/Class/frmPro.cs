using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS
{
    class frmPro
    {
        public int pro_id { set; get; }
        public string pro_code { set; get; }
        public string pro_name { set; get; }
        public string pro_size { set; get; }
        public string color { set; get; }
        public int quantity { set; get;}
        public int model { set; get; }
        public int ph_type { set; get; }
        public int type { set; get; }
        public float saleprice { set; get; }
        public float unitprice { set; get; }
        public byte[] img { get; set; }
    }
}
