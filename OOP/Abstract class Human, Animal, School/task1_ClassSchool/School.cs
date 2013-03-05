using System.Collections.Generic;

namespace task1_ClassSchool
{
    public class School
    {
        #region Fields
        
        private string name;
        private List<Class> classes;
        private List<Teacher> teachers;
        
        #endregion
        
        #region Constructors
        
        public School() : this(null,null,null)
        {
        }
        
        public School(string name) : this(name,null,null)
        {
        }
        
        public School(string name, List<Class> classes, List<Teacher> teachers)
        {
            this.name = name;
            this.classes = classes;
            this.teachers = teachers;
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
        
        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }
        
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
        
        #endregion
    
        #region Methods

        #endregion
    }
}
