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
            //11.	Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
            int i = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int mask = 1 << b;
            Console.WriteLine((i & mask) == mask ? 1 : 0);
        }
    }
}
