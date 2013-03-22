using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.ExceptionClasses;
using SideshowBob.Machine.Enumerations;
using SideshowBob.Interfaces;

namespace SideshowBob.Machine
{
    public class SUV : Vehicle, IWarrantyExtendable, IReplacable
    {
        //fields
        private bool isAvailable;
        private bool inSerivise;
        private int passengers;
                
        //constructors
        public SUV(string color, int wheels, Model model, DateTime year, decimal price, bool isAvailable, bool inSerivise, double speed)
        {            
             this.Color = color;
             if (wheels == 4)
             {
                 this.Wheels = wheels;
             }
             else
             {
                 throw new VehiclePropertyException("SUV's can have only 4 wheels!");
             } 
             this.Model = model;
             this.Year = year;
             this.Price = price;
             this.IsAvailable = isAvailable;
             this.InSerivise = inSerivise;
             this.Speed = speed;
        }      

        //properties
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public bool InSerivise
        {
            get { return inSerivise; }
            set { inSerivise = value; }
        }

        public int Passengers
        {
            get { return this.passengers; }
            set { this.passengers = value; }
        }

        //methods
        public override void AbleToTransport()
        {
            if (this.Passengers > 0 && this.Passengers <= 8)
            {
                Console.WriteLine("This SUV can transport {0} passengers", this.Passengers);
            }
            else
            {
                throw new ArgumentOutOfRangeException("SUV's cannot transport more than 8 or less than 0 passengers!");
            }
        }
      
        //Interface methods
        public decimal ExtendedWarrantyCost()
        {
            if (this.Price > 10000)
            {
                return this.Price / 10;
            }
            else
            {
                throw new ArgumentOutOfRangeException("No warranty extension on cars below 10 000 lv!");
            }
        }

        public bool CheckIfReplacable()
        {
            if (DateTime.Now.Year - this.Year.Year > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
