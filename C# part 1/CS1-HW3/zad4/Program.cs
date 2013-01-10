using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.	Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
            int n = int.Parse(Console.ReadLine());
            int temp = n / 10;
            temp /= 10;
            temp %= 10;
            Console.WriteLine(temp == 7);
        }
    }
}
