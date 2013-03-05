namespace task1_ClassSchool
{
    public class Student : People
    {
        #region Fields
        
        private int number;
        private string comment;
        
        #endregion
        
        #region Constructors
        
        public Student() : this(null,null,-1,null)
        {
        }
        
        public Student(string fname, string lname, int number) : this(fname,lname,number,null)
        {
        }
        
        public Student(string fname, string lname, int number, string comment) : base(fname,lname)
        {
            this.number = number;
            this.comment = comment;
        }
        
        #endregion
        
        #region Properties
        
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        
        #endregion
    
        #region Methods

        #endregion
    }
}


