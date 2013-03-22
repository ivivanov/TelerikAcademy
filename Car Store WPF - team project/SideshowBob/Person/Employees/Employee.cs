using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.Interfaces;
using SideshowBob.Person.Enumerations;
using System.ComponentModel;

namespace SideshowBob.Person.Employees
{
    public abstract class Employee : PersonBase, IDiscounter, ICompleteTask, INotifyPropertyChanged
    {
        private double salary;
        private bool isBusy;
        
        //constructor
        public Employee(string firstName, string lastName, Gender gender, double salary, int age, bool isBusy = true) : base(firstName, lastName, gender, age)
        {
            this.isBusy = isBusy;
            this.salary = salary;
        }

        public Employee()
        {
        }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
            set
            {
                this.isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = double.Parse( value.ToString());
                OnPropertyChanged("Salary");
            }
        }

        //Interface method
        public string ShowDiscount()
        {
            return string.Format("Your discount is 5%");
        }

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