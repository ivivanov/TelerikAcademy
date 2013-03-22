using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.Interfaces;
using SideshowBob.Person.Enumerations;

namespace SideshowBob.Person.Clients
{
    public class Individual : Client
    {
        public Individual(string firstName, string lastName, int clientID, Gender gender, int age) : base(firstName, lastName, clientID,gender, age)
        {
        }
        
        //Methods
        public string ShowDiscount()
        {
            return string.Format("Your discount is 5%");
        }
    }
}