using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    class Program
    {
        static void Main(string[] args)
        {
           // Declare  two integer variables and assign them with 5 and 10 and after that exchange their values
            int number1 = 5, number2 = 10;
            //Console.WriteLine("number1 = {0}, number2 = {1}",number1,number2);
            number1 += number2;
            number2 = number1 - number2;
            number1 -= number2;
            //Console.WriteLine("number1 = {0}, number2 = {1}", number1, number2);
        }
    }
}
