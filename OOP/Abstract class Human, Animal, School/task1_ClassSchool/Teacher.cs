using System.Collections.Generic;

namespace task1_ClassSchool
{
    public class Teacher : People
    {
        #region Fields
        
        private List<Discipline> disciplines;
        private string comment;
        
        #endregion
        
        #region Constructors
        
        public Teacher() : this(null, null, null, null)
        {
        }
        
        public Teacher(string fname, string lname, List<Discipline> disciplines) : this(fname, lname,disciplines, null)
        {
        }
        
        public Teacher(string fname, string lname, List<Discipline> disciplines, string comment) : base(fname, lname)
        {
            this.disciplines = disciplines;
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
        
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
        
        #endregion
    
        #region Methods

        #endregion
    }
}
