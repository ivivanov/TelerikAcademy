using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad12
{
    class Program
    {
        static void Main(string[] args)
        {
             // 12.	We are given integer number n, value v (v=0 or 1) and a position p. 
             //Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
             //Example: 
             //n = 5 (00000101), p=3, v=1  13 (00001101)
             //n = 5 (00000101), p=2, v=0  1 (00000001)
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter 0 or 1: ");
            int v = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter bit position: ");
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary representation of your number: {0}, decimal: {1}", Convert.ToString(number, 2), number);
            
            int mask = 1 << position;            
            number = (v == 0) ? number & ~mask : number | mask;
            Console.WriteLine("Binary representation of your number after modification: {0}, decimal: {1}", Convert.ToString(number, 2), number);
        }
    }
}
