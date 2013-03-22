using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideshowBob.ExceptionClasses
{
    public class VehiclePropertyException : ApplicationException
    {        
        public VehiclePropertyException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }

        public VehiclePropertyException(string message)
            : this(message, null)
        {
        }

    }
}
