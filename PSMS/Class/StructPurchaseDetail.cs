using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    class StructPurchaseDetail
    {
        public StructPurchaseDetail()
        {

        }

        public StructPurchaseDetail(int purID, int pID, int quantity, double unitPrice, double salePrice)
        {
            PurID = purID;
            PID = pID;
            Quantity = quantity;
            UnitPrice = unitPrice;
            SalePrice = salePrice;
        }

        public int PurID { get; set; }
        public int PID { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SalePrice { get; set; }
        public double Amount { get { return UnitPrice * UnitPrice; } }

    }
}
