using SideshowBob.ExceptionClasses;
using SideshowBob.Machine.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.Interfaces;

namespace SideshowBob.Machine
{
    public class Truck : Vehicle, IWarrantyExtendable, IReplacable
    {
        //fields
        private bool isAvailable;
        private bool inSerivise;
        private double load;
                
        //constructors
        public Truck(string color, int wheels, Model model, DateTime year, decimal price, bool isAvailable, bool inSerivise, double speed)
        {            
             this.Color = color;
             if (wheels >= 4 && wheels < 27)
             {
                 this.Wheels = wheels;
             }
             else
             {
                 throw new VehiclePropertyException("Trucks can have no more than 26 and no less than 4 wheels!");
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

        public double Load
        {
            get { return this.load; }
            set { this.load = value; }
        }

        //methods
        public override void AbleToTransport()
        {
            if (this.Load > 25.0 && this.Load < 0)
            {
                Console.WriteLine("This truck is abble to transport {0} tons", this.Load);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Trucks's can not transport more than 25 (legally) or less than 0 tons!");
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
