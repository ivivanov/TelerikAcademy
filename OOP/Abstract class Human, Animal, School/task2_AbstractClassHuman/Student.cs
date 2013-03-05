namespace task2_AbstractClassHuman
{
    public class Student : Human
    {
        #region Fields
        
        private byte grade;
        
        #endregion
        
        #region Constructors
        
        public Student(string firstName, string lastName, byte grade = 0) : base(firstName,lastName)
        {
            this.grade = grade;
        }
        
        #endregion
        
        #region Properties
        
        public byte Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
        
        #endregion
    
        #region Methods

        #endregion
    }
}
