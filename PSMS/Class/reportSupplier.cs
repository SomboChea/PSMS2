using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportSupplier
    {

        public reportSupplier()
        {

        }
        public reportSupplier(string supCode, string nameKH, string nameEN, string gender, string phone, string email, double balance)
        {
            SupCode = supCode;
            NameKH = nameKH;
            NameEN = nameEN;
            Gender = gender;
            Phone = phone;
            Email = email;
            Balance = balance;
        }

        public string SupCode { get; set; }
        public string NameKH { get; set; }
        public string NameEN { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Balance { get; set; }
    }
}
