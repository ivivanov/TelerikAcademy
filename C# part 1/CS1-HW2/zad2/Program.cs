using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
            float number1 = 12.345f;
            float number2 = 3456.091f;
            double number3 = 34.567839023;
            double number4 = 8923.1234857;
            Console.WriteLine("{0} {1} {2} {3}",number1,number2,number3,number4);
        }
    }
}
