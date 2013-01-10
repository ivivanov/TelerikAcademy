using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.	Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            Console.WriteLine("Third bit is : {0}", ((n & mask) == mask) ? 1 : 0);
        }
    }
}
