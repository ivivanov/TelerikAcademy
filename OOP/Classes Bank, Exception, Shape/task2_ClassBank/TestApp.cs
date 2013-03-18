using System;
using task2_ClassBank.Customers;
using task2_ClassBank.Accounts;

namespace task2_ClassBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank FIB = new Bank("First Investment Bank");

            FIB.Accounts.Add(new DepositAccount(new IndividualCustomer("Petar Kostov"), 10000m, 8m));
            FIB.Accounts.Add(new LoanAccount(new CompanyCustomer("Stomana Pernik"), 1000000000m, 3m));
            FIB.Accounts.Add(new MortgageAccount(new IndividualCustomer("Cecka Cacheva"), 40000m, 6m));
           
            foreach (Account acc in FIB.Accounts)
            {
                Console.WriteLine(acc.CalculateInterest(5));
            }
        }
    }
}
