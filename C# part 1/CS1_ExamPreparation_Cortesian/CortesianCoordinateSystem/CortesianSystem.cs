using System;

namespace CortesianCoordinateSystem
{
    class CortesianSystem
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(CheckPosition(x, y));
        }

        static int CheckPosition(double x, double y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else
            {
                if (x == 0 && y != 0)
                {
                    return 5;
                }
                else
                {
                    if (x != 0 && y == 0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (x > 0 && y > 0)
                        {
                            return 1;
                        }
                        else
                        {
                            if (x < 0 && y > 0)
                            {
                                return 2;
                            }
                            else
                            {
                                if (x < 0 && y < 0)
                                {
                                    return 3;
                                }
                                else
                                {
                                    return 4;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
