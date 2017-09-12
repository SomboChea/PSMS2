using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportProduct
    {
        public reportProduct()
        {

        }
        public reportProduct(string code, string name, string size, string color, int quantity, string brand, string pType, string type, double salePrice, double unitPrice)
        {
            Code = code;
            Name = name;
            Size = size;
            Color = color;
            Quantity = quantity;
            Brand = brand;
            PType = pType;
            Type = type;
            SalePrice = salePrice;
            UnitPrice = unitPrice;
        }

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
    }
}
