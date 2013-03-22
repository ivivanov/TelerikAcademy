using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideshowBob.Interfaces
{
    public interface IDiscounter
    {
        //Every employee has different discount based on position. The method will check the position and return a corresponding % discount (to string)
        //Every customer groups also has different discount

        string ShowDiscount();
    }
}
