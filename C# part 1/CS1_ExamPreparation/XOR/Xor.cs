using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOR
{
    class Xor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long inputNumber = 0;
            long result = 0;
            for (int i = 0; i < n; i++)
            {
                inputNumber = long.Parse(Console.ReadLine());
                result = result ^ inputNumber;
            }
            Console.WriteLine(result);
        }
    }
}
