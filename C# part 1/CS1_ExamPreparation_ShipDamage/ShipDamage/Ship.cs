using System;

namespace ShipDamage
{
    class Ship
    {
        static void Main(string[] args)
        {
            //          0      1    2   3   4   5    6    7    8    9       10
            // input = {SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3.}
            int[] input = new int[11];
            for (int i = 0; i < 11; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
    
            //int[] input = 
            //{
            //    -6,
            //    6,
            //    -11,
            //    3,
            //    1,
            //    -9,
            //    -4,
            //    -11,
            //    -1,
            //    2,
            //    2
            //};

            int top = input[1] > input[3] ? input[1] : input[3];
            int bottom = input[1] < input[3] ? input[1] : input[3];
            int left = input[0] < input[2] ? input[0] : input[2];
            int right = input[0] > input[2] ? input[0] : input[2];

            //ShipCoordinates Sx1,Sy1,Sx2,Sy2
            //int[] ShipCoordinates = { input[0], input[1], input[2], input[3] };
            //projectile [x,y]
            int[] projectile1 = { input[5], CalculateYprojectile(input[6], input[4]) };
            int[] projectile2 = { input[7], CalculateYprojectile(input[8], input[4]) };
            int[] projectile3 = { input[9], CalculateYprojectile(input[10], input[4]) };
            int[][] projectiles = { projectile1, projectile2, projectile3 };
            int damage = 0;
            
            for (int i = 0; i < 3; i++)
            {
                damage += CalculateDamage(top, bottom, left, right, projectiles[i]);
            }
            Console.WriteLine("{0}%",damage);
        }

        static int CalculateDamage(int top, int bottom, int left, int right, int[] projectile)
        {
            int projectileX = projectile[0];
            int projectileY = projectile[1];
            //if ((projectileX == top && projectileY == top) || (projectileX == bottom && projectileY == bottom))
            if (
                (projectileX == left && projectileY == top) ||
                (projectileX == right && projectileY == top) ||
                (projectileX == left && projectileY == bottom) ||
                (projectileX == right && projectileY == bottom)
              )
            {
                return 25;
            }
            else
            {
                if (
                    ((projectileX == left || projectileX == right) && (projectileY > bottom && projectileY < top)) ||
                    ((projectileY == top || projectileY == bottom) && (projectileX > left && projectileX < right))
                   )
                {
                    return 50;
                }
                else
                {
                    if (projectileX > left && projectileX < right && projectileY < top && projectileY > bottom)
                    {
                        return 100;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            
        }


        static int CalculateYprojectile(int cy,int h)
        {
            //int result = (Math.Abs(h) + Math.Abs(cy)) + Math.Abs(h);
            return 2 * h - cy;
            //return result;
        }
    }
}
