using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11_CardsPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = null;
            
            for (int i = 1; i <= 4; i++)
            {
                //hearts clubs diamonds spades
                switch (i)
                { 
                    case(1):
                        color = "Hearts";
                        break;
                    case(2):
                        color = "Clubs";
                        break;
                    case(3):
                        color = "Diamonds";
                        break;
                    case(4):
                        color = "Spades";
                        break;
                }
                Console.WriteLine();
                for (int j = 2; j <= 14; j++)
                {
                    //A, K, Q, J, 10, 9, 8, 7, 6, 5, 4, 3, 2.
                    switch (j)
                    {
                        case (2):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (3):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (4):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (5):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (6):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (7):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (8):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (9):
                            Console.WriteLine("{0,2} of {1}", j, color);
                            break;
                        case (10):
                            Console.WriteLine("{0} of {1}", j, color);
                            break;
                        case (11):
                            Console.WriteLine("{0,2} of {1}", "J", color);
                            break;
                        case (12):
                            Console.WriteLine("{0,2} of {1}", "Q", color);
                            break;
                        case (13):
                            Console.WriteLine("{0,2} of {1}", "K", color);
                            break;
                        case (14):
                            Console.WriteLine("{0,2} of {1}", "A", color);
                            break;
                    }
                }
            }
        }
    }
}
