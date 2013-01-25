using System;

namespace task15_SieveErathosthenesPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            bool[] notPrimes = new bool[n];
            FindPrimes(notPrimes);

            for (int i = 2; i < n; i++)
            {
                if (notPrimes[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void FindPrimes(bool[] notPrimes)
        {
            int lastNumber = notPrimes.Length;
            if (lastNumber < 2)
            {
                return;
            }

            notPrimes[0] = notPrimes[1] = true;

            int primeIndex = 0;

            for (int i = 0; i < Math.Sqrt(lastNumber); i++)
            {
                if (notPrimes[i] != true)
                {
                    for (int j = i*2; j < lastNumber; j+=i)
                    {
                        notPrimes[j] = true;
                    }
                }
            }
            
        }
    }
}
