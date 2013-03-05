namespace task2_AbstractClassHuman
{
    public abstract class Human
    {
        #region Fields
        
        private string firstName;
        private string lastName;
        
        #endregion
        
        #region Constructors
        
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        #endregion
        
        #region Properties
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        
        #endregion
    
        #region Methods

        #endregion
    }
}
