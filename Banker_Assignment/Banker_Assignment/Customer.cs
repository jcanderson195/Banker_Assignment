using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker_Assignment
{
    class Customer : People
    {
        public int accountNumber;
        public double accountBalance;
        public int creditScore;
        public string creationDate;

        public Customer(string FirstName, string LastName, string DOB, string SocialSecurityNum,int AccountNumber, double AccountBalance, int CreditScore, string CreationDate)
        {
            firstName = FirstName;
            accountNumber = AccountNumber;
            accountBalance = AccountBalance;
            creditScore = CreditScore;
            creationDate = CreationDate;

        }

        public int CustomerCreditScore()
        {
            int customerCreditScore = 637;
            Console.WriteLine("Customer credit score is "+customerCreditScore);
            return customerCreditScore;
        }

        public double AccountBalance()
        {

            double money = 450.67;
            double balance = money - 50.67; 
            Console.WriteLine("Customer account balance has decreased to "+balance);
            return balance;
            
        }

    }
}
