using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideshowBob.Interfaces
{
    public interface IReplacable
    {
        //Implement the method to check for each vehicle type if it can be replaced based on year of the model 
        //example: SUV older than 5 years cannot be replaced, Trucks older than 2 years cannot be replaced, etc....
        bool CheckIfReplacable();
    }
}
