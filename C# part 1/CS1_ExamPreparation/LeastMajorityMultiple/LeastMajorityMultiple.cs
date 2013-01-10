using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static int[] results = new int[10];
        static int min = int.MaxValue;

        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            int[] listOfints = { a, b, c, d, e };


            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        //Console.WriteLine("{0},{1},{2}",listOfints[i],listOfints[j],listOfints[k]);
                        FindMin(listOfints[i], listOfints[j], listOfints[k]);
                    }
                }
            }
            Console.WriteLine(min);
        }

        static void FindMin(int p1, int p2, int p3)
        {
            if (min > LCM(LCM(p1, p2), p3))
            {
                min = LCM(LCM(p1, p2), p3);
            }
        }

        static int LCM(int p1, int p2)
        {
            return Math.Abs(p1 * p2) / GCD(p1, p2);
        }

        static int GCD(int a, int b)
        {
            int temp = 0;
            if (b == 0)
            {
                return a;
            }
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return a;

        }
    }
}
