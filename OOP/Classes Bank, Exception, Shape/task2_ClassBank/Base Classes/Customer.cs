namespace task2_ClassBank
{
    public abstract class Customer
    {
        #region Fields
        
        private string name;
        
        #endregion
        
        #region Constructors
        
        public Customer(string name)
        {
            this.name = name;
        }
        
        #endregion
        
        #region Properties
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    
        #endregion
    }
}
