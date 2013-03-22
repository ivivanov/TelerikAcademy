using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SideshowBob.Interfaces;
using SideshowBob.Person.Enumerations;

namespace SideshowBob.Person.Clients
{
    public class Company : Client
    {
        //constructor
        public Company(string companyName, int clientID) : base(companyName, companyName, clientID,Gender.Male,18)
        {
        }

        //methods        
    
        public string ShowDiscount()
        {
            return string.Format("Your discount is 15%");
        }
    }
}