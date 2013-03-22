using SideshowBob.Machine.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.ExceptionClasses;

namespace SideshowBob.Machine
{
    public abstract class Vehicle : INotifyPropertyChanged
    {
        //fields
        private string color;
        private int wheels;
        private Model model;
        private DateTime year;
        private decimal price;
        private double speed;

        //private Category category;

        //constructors
        public Vehicle()
        {
        }

        public Vehicle(string color, int wheels, Model model, DateTime year, decimal price)
        { 
            this.color = color;
            this.wheels = wheels;
            this.model = model;
            this.year = year;
            this.price = price;
        }
                       
        //properties

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
                OnPropertyChanged("Color");
            }
        }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }
            set
            {
                this.wheels = value;
                OnPropertyChanged("Wheels");
            }
        }

        public Model Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
                OnPropertyChanged("Model");
            }
        }

        public DateTime Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
                OnPropertyChanged("Year");
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                    OnPropertyChanged("Price");
                }
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                OnPropertyChanged("Speed");
            }
        }

        //public Category Category
        //{
        //    get
        //    {
        //        return this.category;
        //    }
        //    set
        //    {
        //        this.category = value;
        //        OnPropertyChanged("Category");
        //    }
        //}
        //methods
        public abstract void AbleToTransport();
        
        public double Accelerate()
        {
            if (speed < 360)
            {
                speed += 10;
            }

            return speed;
        }

        public double Brake()
        {
            if (speed >= 10)
            {
                speed -= 10;
            }
            else
            {
                speed = 0;
            }

            return speed;
        }

        public override string ToString()
        {
            return String.Format("Category: {0}, {1}, Date manufactured: {2}, Price: {3}, Wheels: {4}, Color: {5}, Speed: {6}", this.GetType().Name, this.Model, this.Year.Month + "/" + this.Year.Year, this.Price, this.Wheels, this.Color, this.Speed);
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