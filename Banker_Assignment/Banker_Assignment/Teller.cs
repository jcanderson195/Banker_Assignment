using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker_Assignment
{
    class Teller : Employee
    {
        public string ID;
        public string hireDate;
        public int securityLevel;
        public int wage;

        public Teller(string FirstName, string LastName, string DOB, string SocialSecurityNumber,string id, string HireDate, int SecurityLevel, 
            int Wage)
        {
            firstName = FirstName;
            lastName = LastName;
            id = ID;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
            wage = Wage;
        }

        public double payRaise()
        {
            double currentWage;
            Console.WriteLine("Enter a your current wage: ");
            currentWage = Convert.ToInt32(Console.ReadLine());
            double newWage = currentWage + 2.50;
            Console.WriteLine("Your new wage is "+newWage+ " an hour.");
            return newWage;
        }

    }
}
