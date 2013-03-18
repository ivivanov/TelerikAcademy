using System;
using task2_ClassBank.Customers;

namespace task2_ClassBank.Accounts
{
    public class LoanAccount : Account, IDeposit
    {
        #region Constructors
        
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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
                return base.CalculateInterest((short)(months - 2));
            }
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest((short)(months - 3));
            }
            return 0;
        }

        public override string ToString()
        {
            return "Loan Account";
        }

        #endregion
    }
}
