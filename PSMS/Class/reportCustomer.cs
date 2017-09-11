using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    class reportCustomer
    {
        public reportCustomer(string cCode, string nameEN, string nameKH, string gender, string address, string phone, double balance, string empName, string openDate)
        {
            CCode = cCode;
            NameEN = nameEN;
            NameKH = nameKH;
            Gender = gender;
            Address = address;
            Phone = phone;
            Balance = balance;
            EmpName = empName;
            OpenDate = openDate;
        }

        public string CCode { get; set; }
        public string NameEN { get; set; }
        public string NameKH { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Balance { get; set; }
        public string EmpName { get; set; }
        public string OpenDate { get; set; }
    }
}
