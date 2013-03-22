using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideshowBob.Interfaces
{
    public interface IWarrantyExtendable
    {
        //Warranty provided with each vehicle type

        decimal ExtendedWarrantyCost();      //warranty can be extended only on that cost more than 10 000, will cost 20% of the price on Trucks/Vans, 10% for the rest
       
    }
}
