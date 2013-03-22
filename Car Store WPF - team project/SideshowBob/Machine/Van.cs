using SideshowBob.Machine.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.Interfaces;
using SideshowBob.ExceptionClasses;

namespace SideshowBob.Machine
{
    public class Van : Vehicle, IWarrantyExtendable, IReplacable
    {
        //fields
        private bool isAvailable;
        private bool inSerivise;
        private int passengers;
        private double load;
                
        //constructors
        public Van(string color, int wheels, Model model, DateTime year, decimal price, bool isAvailable, bool inSerivise, double speed)
        {            
             this.Color = color;
             if (wheels == 4)
             {
                 this.Wheels = wheels;
             }
             else
             {
                 throw new VehiclePropertyException("Vans can have only 4 wheels!");
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

        public double Load
        {
            get { return this.load; }
            set { this.load = value; }
        }
        //methods
        public override void AbleToTransport()
        {
            if (this.Passengers > 0 && this.Passengers < 18)
            {
                Console.WriteLine("This van can transport {0} passengers", this.Passengers);
            }
            if (this.Load > 0 && this.Load < 3.5)
            {
                Console.WriteLine("This van can transport {0} tons", this.Load);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Van's can not transport more than 18 or less than 0 passengers! Also are not abble to carry more than 3.5 tons and less than 0!");
            }
        }

        //Interface methods
        public decimal ExtendedWarrantyCost()
        {
            if (this.Price > 10000)
            {
                return this.Price / 20;
            }
            else
            {
                throw new ArgumentOutOfRangeException("No warranty extension on cars below 10 000 lv!");
            }
        }

        public bool CheckIfReplacable()
        {
            if (DateTime.Now.Year - this.Year.Year > 2)
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
