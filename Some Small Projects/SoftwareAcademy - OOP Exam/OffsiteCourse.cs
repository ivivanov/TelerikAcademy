using System;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        #region Fields
        
        private string town;
        
        #endregion
        
        #region Constructors
        
        public OffsiteCourse(string name, ITeacher teacher, string town) : base(name,teacher)
        {
            this.town = town;
        }
        
        #endregion
        
        #region Properties
        
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        #endregion
        
        #region Methods
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append(base.ToString());
            
            if (this.Town != "")
            {
                result.Append(String.Format("; Town={0}", this.Town));
            }
        
            return result.ToString();
        }

        #endregion
    }
}