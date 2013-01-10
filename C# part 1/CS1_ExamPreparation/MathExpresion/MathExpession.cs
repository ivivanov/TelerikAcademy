using System;

namespace MathExpresion
{
    class MathExpession
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            //float m = float.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            decimal sinus = (decimal)Math.Sin((double)Math.Truncate(m) % 180);

            decimal expresion = (n * n + 1 / (m * p) + 1337) / (n - 128.523123123m * p) + sinus;
            
            Console.WriteLine("{0:F6}",expresion);
        }
    }
}
