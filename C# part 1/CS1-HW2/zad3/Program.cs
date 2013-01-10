using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
            decimal number1 = Math.Round(5.00000001m, 6);
            decimal number2 = Math.Round(5.00000003m, 6);
            Console.WriteLine("Is {0} equal to {1} : {2}",number1,number2, (number1 == number2));
        }
    }
}
