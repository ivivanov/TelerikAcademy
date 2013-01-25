using System;
using System.Text;
namespace task9_FloatToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
            byte[] binary = BitConverter.GetBytes(-21.165f);
            StringBuilder xa =new StringBuilder();
            
            foreach (var item in binary)
            {
                xa.Append(Convert.ToString(item, 2));
            }
            Console.WriteLine(xa.ToString());
       

        }
    }
}
