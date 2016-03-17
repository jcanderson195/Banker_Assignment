using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker_Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Banker newBanker = new Banker("Justin","Anderson","06/10/95","355233245","978","02/15/15",1,25000);
            Teller newTeller = new Teller("Gwen", "Johnson", "09/08/90", "458538747", "654", "07/22/12", 2, 10);
            Customer newCustomer = new Customer("Sam","Williams","08/10/64","348542946",36785,450.67, 637,"10/24/01");


            newTeller.payRaise();

            newCustomer.CustomerCreditScore();

            newCustomer.AccountBalance();

            List<Employee> PeopleOfTheBank = new List<Employee>();
            PeopleOfTheBank.Add(newBanker);
            PeopleOfTheBank.Add(newTeller);
            
            foreach (Employee employee in PeopleOfTheBank)
            {
                Console.WriteLine(employee.firstName);
            }

            List<People> CustomerOfBank = new List<People>();
            CustomerOfBank.Add(newCustomer);

            foreach (People people in CustomerOfBank)
            {
                Console.WriteLine(people.firstName);
            }
  

        }
    }
}
