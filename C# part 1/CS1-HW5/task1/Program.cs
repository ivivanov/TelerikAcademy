using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
            int a = 15;
            int b = 13;
            //if (a > b)
            //{
            //    a = a + b;
            //    b = a - b;
            //    a = a - b;
            //}
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }
}
