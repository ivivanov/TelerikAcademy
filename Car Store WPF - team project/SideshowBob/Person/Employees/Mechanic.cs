using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.Interfaces;
using SideshowBob.Person.Enumerations;

namespace SideshowBob.Person.Employees
{
    public class Mechanic : Employee
    {
        //constructor
        public Mechanic(string firstName, string lastName, Gender gender, double salary, int age) : base(firstName, lastName, gender,salary, age)
        {
        }

        //Interface method
        public string ShowDiscount()
        {
            return string.Format("Your discount is 5%");
        }
    }
}