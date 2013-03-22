using SideshowBob.Person.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideshowBob.Person
{
    public abstract class PersonBase : INotifyPropertyChanged
    {
        #region Fields
        
        private string firstName;
        private string lastName;
        private Gender gender;
        private int age;
        
        #endregion
        
        //constructor
        public PersonBase(string firstName, string lastName, Gender gender, int age=18)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Age = age;
        }
        
        public PersonBase()
        {
        }
        
        //properties

        #region Gender Properties
        
        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
                OnPropertyChanged("Gender");
            }
        }
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name should contain some letters");
                }
                this.firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The last name should contain some letters");
                }
                this.lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 18)
                {
                    this.age = value;
                    OnPropertyChanged("Age");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Client must be at least 18 years old.");
                }
            }
        }

        #endregion
        
        // methods
        
        #region INotifyPropertyChanged Members
        
        public event PropertyChangedEventHandler PropertyChanged;
            
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}