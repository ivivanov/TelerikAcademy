namespace task1_ClassSchool
{
    public class Discipline
    {
        #region Fields
        
        private string name;
        private byte numberOfLectures;
        private byte numberOfExercises;
        private string comment;
        
        #endregion
        
        #region Constructors
        
        public Discipline() : this(null,0,0,null)
        {
        }
        
        public Discipline(string name, byte numberOfLectures, byte numberOfExercises) : this(name,numberOfLectures,numberOfExercises,null)
        {
        }
        
        public Discipline(string name, byte numberOfLectures, byte numberOfExercises, string comment)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
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
        
        public byte NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
        
        public byte NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        
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
    
        #region Methods

        #endregion
    }
}
