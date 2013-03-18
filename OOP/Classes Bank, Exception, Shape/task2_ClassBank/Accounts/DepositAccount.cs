using System;

namespace task2_ClassBank
{
    public class DepositAccount : Account, IDeposit, IWithdrow
    {
        #region Constructors

        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }
        
        #endregion
        
        #region Methods

        public override decimal CalculateInterest(short months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
        
        public void Deposit(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentOutOfRangeException("You cannot deposit this amount: " + money);
            }
            Balance += money;
        }
        
        public void Withdraw(int amount)
        {
            if (Balance < amount)
            {
                throw new ArgumentOutOfRangeException("Insufficient funds!");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "Deposit Account";
        }
    
        #endregion
    }
}
