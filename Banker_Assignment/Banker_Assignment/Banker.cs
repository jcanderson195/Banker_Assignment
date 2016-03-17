using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker_Assignment
{
    class Banker : Employee
    {
        public string ID;
        public string hireDate;
        public int securityLevel;
        public int fixedSalary;

        public Banker(string FirstName, string LastName, string DOB, string SocialSecurityNumber,string id, string HireDate, int SecurityLevel, int FixedSalary)
        {
            firstName = FirstName;
            lastName = LastName;
            ID = id;
            hireDate = HireDate;
            securityLevel = SecurityLevel;
            fixedSalary = FixedSalary;
        }
    }
}
