using SideshowBob.Interfaces;
using SideshowBob.Person.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideshowBob.Person.Clients
{
    public abstract class Client : PersonBase, IDiscounter
    {
        public int ClientID { get; protected set; }

        //Base constructor
        public Client(string firstName, string lastName,int clientID, Gender gender=Gender.Male, int age=18) : base(firstName, lastName, gender, age)
        {
            this.ClientID = clientID;
        }

        public string ShowDiscount()
        {
            return string.Format("Your discount is 5%");
        }
    }
}
