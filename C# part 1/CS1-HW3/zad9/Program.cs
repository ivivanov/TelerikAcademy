using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.	Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool isInsideCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
            bool isInsideRectangle = (x >= 1) && (x <= 5) && (y <= -1) && (y >= -3);
            bool inCircleOutRec = isInsideCircle && !isInsideRectangle;
            Console.WriteLine(inCircleOutRec);
        }
    }
}
