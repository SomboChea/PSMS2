using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    class Stock
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public string PType { get; set; }
        public string Type { get; set; }
        public double SalePrice { get; set; }
        public double UnitPrice { get; set; }
        public double SaleAmount()
        {
            return Quantity * SalePrice;
        }
        public double UnitAmount()
        {
            return Quantity * UnitPrice;
        }
    }
}
