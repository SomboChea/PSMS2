using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Class
{
    public class reportEmployee
    {

        public reportEmployee()
        {

        }
        public reportEmployee(string empCode, string nameKH, string nameEN, string gender, string address, string email, string position, double salary, string joinDate)
        {
            EmpCode = empCode;
            NameKH = nameKH;
            NameEN = nameEN;
            Gender = gender;
            Address = address;
            Email = email;
            Position = position;
            Salary = salary;
            JoinDate = joinDate;
        }

        public string EmpCode { get; set; }
        public string NameKH { get; set; }
        public string NameEN { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string JoinDate { get; set; }
    }
}
