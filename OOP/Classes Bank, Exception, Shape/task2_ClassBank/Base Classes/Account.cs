namespace task2_ClassBank
{
    public abstract class Account
    {
        #region Fields
        
        private Customer owner;
        private decimal balance;
        private decimal interestRate;
        
        #endregion
        
        #region Constructors
        
        public Account(Customer owner, decimal balance, decimal interestRate)
        {
            this.owner = owner;
            this.balance = balance;
            this.interestRate = interestRate;
        }
        
        #endregion
        
        #region Properties
        
        public Customer Customer
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }
        
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }
        
        #endregion
        
        #region Methods

        public virtual decimal CalculateInterest(short months)
        {
            if (months > 0)
            {
                return months * interestRate;
            }
            return 0;
        }

        #endregion
    }
}
