using System.Collections.Generic;

namespace task1_ClassSchool
{
    public class Class
    {
        #region Fields
        
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Discipline> disciplines;
        private string textIdentifier;
        private string comment;
        
        #endregion
        
        #region Constructors
        
        public Class() : this(null,null,null,null,null)
        {
        }
        
        public Class(List<Student> students, List<Teacher> teachers, List<Discipline> disciplines, string textIdentifier) : this(students,teachers,disciplines,textIdentifier,null)
        {
        }
        
        public Class(List<Student> students, List<Teacher> teachers, List<Discipline> disciplines, string textIdentifier, string comment)
        {
            this.students = students;
            this.teachers = teachers;
            this.disciplines = disciplines;
            this.textIdentifier = textIdentifier;
            this.comment = comment;
        }
        
        #endregion
        
        #region Properties
        
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
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
        
        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                this.textIdentifier = value;
            }
        }
        
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
        
        #endregion
    
        #region Methods

        #endregion
    }
}
