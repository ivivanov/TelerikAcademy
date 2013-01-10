using System;

namespace SandGlass
{
    class PrintSandWatch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            for (i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(new string('.',i) + new string('*',n - 2 * i) + new string('.',i));
            }
            
            for (i = i - 2; i >= 0; i--)
            {
                Console.WriteLine(new string('.', i) + new string('*', n - 2 * i) + new string('.', i));
            }
        }
    }
}
