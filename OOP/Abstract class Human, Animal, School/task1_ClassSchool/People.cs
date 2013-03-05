namespace task1_ClassSchool
{
    public class People
    {
        #region Fields
        
        private string firstName;
        private string lastName;
        
        #endregion
        
        #region Constructors
        
        public People() : this(null, null)
        {
        }
        
        public People(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        #endregion
        
        #region Properties
        
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
        
        #endregion
    
        #region Methods

        #endregion
    }
}
