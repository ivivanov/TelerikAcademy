using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.	Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            bool result = ((v & mask) == mask);
            Console.WriteLine("Bit at position {0} is 1 : {1}", p, result);
        }
    }
}
