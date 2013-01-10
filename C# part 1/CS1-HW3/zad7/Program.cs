using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.	Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;
            if ((n > 100) || (n < 2))
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else 
                    {
                        isPrime = true;
                    }
                }
            }
            Console.WriteLine("Is number {0} prime number? : {1}", n, isPrime);
        }
    }
}
