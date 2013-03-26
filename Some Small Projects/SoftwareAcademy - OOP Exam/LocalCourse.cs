using System;
using System.Text;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        #region Fields
        
        private string lab;
        
        #endregion
        
        #region Constructors
        
        public LocalCourse(string name, ITeacher teacher, string lab) : base(name,teacher)
        {
            this.lab = lab;
        }
        
        #endregion
        
        #region Properties
        
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                this.lab = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append(base.ToString());
            
            if (this.Lab != "" && this.Lab != null)
            {
                result.Append(String.Format("; Lab={0}", this.Lab));
            }
            
            return result.ToString();
        }
    
        #endregion
    }
}