using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Course : ICourse
    {
        #region Fields
        
        private string name;
        private IList<string> topics;
        private ITeacher teacher;
        
        #endregion
        
        #region Constructors
        
        public Course(string name, ITeacher teacher = null)
        {
            this.name = name;
            this.teacher = teacher;
            this.topics = new List<string>();
        }
        
        #endregion
        
        #region Properties
        
        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
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
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null!");
                }
                this.name = value;
            }
        }
        
        public IList<string> Topics
        {
            get
            {
                return this.topics;
            }
            set
            {
                this.topics = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            if (this.Teacher != null)
            {
                result.Append(String.Format("{0}: Name={1}; Teacher={2}", this.GetType().Name, this.Name, this.Teacher.Name));
            }
            else
            {
                result.Append(String.Format("{0}: Name={1}", this.GetType().Name, this.Name));
            }
            
            if (this.Topics.Count != 0)
            {
                result.Append("; Topics=[");
                for (int i = 0; i < this.Topics.Count; i++)
                {
                    if (i == this.Topics.Count - 1)
                    {
                        break;
                    }
                    result.Append(this.Topics[i]);
                    result.Append(", ");
                }
                result.Append(this.Topics[this.Topics.Count - 1]);
                result.Append(']');
            }
            
            return result.ToString();
        }
    
        #endregion
    }
}