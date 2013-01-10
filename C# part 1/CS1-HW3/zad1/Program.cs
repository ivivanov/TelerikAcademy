using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Write an expression that checks if given integer is odd or even.
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 2 == 0) ? "Even" : "Odd");
        }
    }
}
