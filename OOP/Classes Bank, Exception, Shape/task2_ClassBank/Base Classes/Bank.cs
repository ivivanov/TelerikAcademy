using System.Collections.Generic;

namespace task2_ClassBank
{
    public class Bank
    {
        #region Fields
        
        private List<Account> accounts;
        private string bankName;
        
        #endregion
        
        #region Constructors
        
        public Bank(string name)
        {
            this.accounts = new List<Account>();
            this.bankName = name;
        }

        #endregion
        
        #region Properties
            
        public string BankName
        {
            get
            {
                return this.bankName;
            }
            set
            {
                this.bankName = value;
            }
        }
            
        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }
        
        #endregion
        
        #region Methods
            
        public void AddAccount(params Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                Accounts.Add(account);
            }
        }
            
        public void RemoveAccount(params Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                Accounts.Remove(account);
            }
        }

        public override string ToString()
        {
            return "Bank: " + this.bankName;
        }

        #endregion
    }
}
