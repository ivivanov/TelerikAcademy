using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.	Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Point ({0},{1}) is within a circle K(O, 5)? : {2}", x, y, (x * x + y * y) < 5);
        }
    }
}
