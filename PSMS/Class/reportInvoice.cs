using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportInvoice
    {
        public string InvoiceCode { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public string Sellby { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }

        public reportInvoice()
        {
        }

        public reportInvoice(string invoiceCode, string proCode, string proName, int quantity, double price, double amount, string sellby, string customerName, string phone, string address, string date)
        {
            InvoiceCode = invoiceCode;
            ProCode = proCode;
            ProName = proName;
            Quantity = quantity;
            Price = price;
            Amount = amount;
            Sellby = sellby;
            CustomerName = customerName;
            Phone = phone;
            Address = address;
            Date = date;
        }
    }
}
