using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            //the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
            int n = 10, num = 2;
            for (int i = 0; i < n - 1; i++)
            {
                if (num % 2 == 0)
                {
                    Console.Write("{0}, ", num++);
                }
                else
                {
                    Console.Write("{0}, ", (num++) * (-1));
                }
            }
        }
    }
}
