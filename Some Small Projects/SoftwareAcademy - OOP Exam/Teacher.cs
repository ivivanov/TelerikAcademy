using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        #region Fields
        
        private IList<ICourse> courses;
        private string name;
        
        #endregion
        
        #region Constructors
        
        public Teacher(string name)
        {
            this.name = name;
            courses = new List<ICourse>();
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
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null!");
                }
                this.name = value;
            }
        }
        
        public IList<ICourse> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Teacher: Name={0}", this.Name));
            if (this.Courses.Count != 0)
            {
                result.Append("; Courses=[");
                for (int i = 0; i < this.Courses.Count; i++)
                {
                    if (i == this.Courses.Count - 1)
                    {
                        break;
                    }
                    result.Append(this.Courses[i].Name);
                    result.Append(",");
                }
                result.Append(this.Courses[this.Courses.Count - 1].Name);
                result.Append(']');
            }
            return result.ToString();
        }
    
        #endregion
    }
}