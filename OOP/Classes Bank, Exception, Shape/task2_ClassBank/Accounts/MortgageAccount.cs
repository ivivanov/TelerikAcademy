using System;
using task2_ClassBank.Customers;

namespace task2_ClassBank.Accounts
{
    class MortgageAccount : Account, IDeposit
    {
        #region Constructors
        
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }
        
        #endregion
        
        #region Methods
        
        public void Deposit(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentOutOfRangeException("You cannot deposit this amount: " + money);
            }
            Balance += money;
        }

        public override decimal CalculateInterest(short months)
        {
            if (this.Customer is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                return base.CalculateInterest((short)(months - 12)) + base.CalculateInterest(12) / 2;
            }
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest((short)(months - 6));
            }
            return 0;
        }

        public override string ToString()
        {
            return "Mortgage Account";
        }
    
        #endregion
    }
}
