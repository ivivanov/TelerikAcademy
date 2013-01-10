using System;

namespace Sevenland
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            int kDecimal = ConvertToDecimal(k);
   
            Console.WriteLine(ConvertToSedmichna(kDecimal + 1));
        }

        
       
        static int ConvertToSedmichna(int decNumber)
        {
            int len = Convert.ToString(decNumber).Length;

            int result = 0;
            int cialoChislo = -1;
            int pow = 1;
            while (cialoChislo !=0)
            {
                result += (decNumber % 7) * pow;
                pow *= 10;
                cialoChislo = decNumber / 7;
                decNumber = cialoChislo;
            }
            return result;
        }

        static int ConvertToDecimal(int sedmichnaNumber)
        {
            int result = 0;
            int pow = 0;
            while (sedmichnaNumber > 0)
            {
                result += sedmichnaNumber % 10 * (int)Math.Pow(7, pow);
                pow++;
                sedmichnaNumber /= 10;
            }
            return result;
        }
    }
}
