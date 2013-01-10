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
            //2.	Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
            int n = int.Parse(Console.ReadLine());
            bool division = ((n % 7 == 0) && (n % 5 == 0));
            Console.WriteLine("number n can be divided 7 and 5 in the same time ? :{0}",division);
        }
    }
}
