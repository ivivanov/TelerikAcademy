using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two string variables and assign them with “Hello” and “World”. 
            //Declare an object variable and assign it with the concatenation of the first two variables 
            //(mind adding an interval). Declare a third string variable and initialize it with the value of 
            //the object variable (you should perform type casting).

            string string1 = "Hello", string2 = "World";
            object conCat = string1 + " " + string2;
            string string3 = (string)conCat;
            //Console.WriteLine(string3);
        }
    }
}
