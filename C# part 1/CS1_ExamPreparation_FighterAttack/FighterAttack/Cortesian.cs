using System;

namespace FighterAttack
{
    class Cortesian
    {
        static void Main(string[] args)
        {
            int px1 = int.Parse(Console.ReadLine());
            int py1 = int.Parse(Console.ReadLine());
            int px2 = int.Parse(Console.ReadLine());
            int py2 = int.Parse(Console.ReadLine());
            int fx = int.Parse(Console.ReadLine());
            int fy = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int left = px1 < px2 ? px1 : px2;
            int right = px1 > px2 ? px1 : px2;
            int top = py1 > py2 ? py1 : py2;
            int bottom = py1 < py2 ? py1 : py2;

            int bombTargetX = fx + d;
            int bombTargetY = fy;

            int damage = 0;

            //if
            //(
            // (bombTargetX >= left && bombTargetX <= right) &&
            // (bombTargetY >= bottom && bombTargetY <= top)
            //)
            //{
            //    damage += 100;
            //}
            if (InsideArea(left, right, bottom, top, bombTargetX, bombTargetY))
            {
                damage += 100;
            }


            //if
            //(
            // ((bombTargetX + 1) >= left && (bombTargetX + 1) <= right) &&
            // (bombTargetY >= bottom && bombTargetY <= top)
            //)
            //{
            //    damage += 75;
            //}

            if (InsideArea(left, right, bottom, top, bombTargetX+1, bombTargetY))
            {
                damage += 75;
            }

            //if
            //(
            // (bombTargetX >= left && bombTargetX <= right) &&
            // ((bombTargetY + 1) >= bottom && (bombTargetY + 1) <= top)
            //)
            //{
            //    damage += 50;
            //}

            if (InsideArea(left, right, bottom, top, bombTargetX, bombTargetY+1))
            {
                damage += 50;
            }

            //if
            //(
            // (bombTargetX >= left && bombTargetX <= right) &&
            // ((bombTargetY - 1) >= bottom && (bombTargetY - 1) <= top)
            //)
            //{
            //    damage += 50;
            //}

            if (InsideArea(left, right, bottom, top, bombTargetX, bombTargetY-1))
            {
                damage += 50;
            }

            Console.WriteLine("{0}%", damage);
        }
        static bool InsideArea(int left, int right, int bottom, int top, int x, int y)
        {
            bool result = false;

            if (x >= left && x <= right && y >= bottom && y <= top)
            {
                result = true;
            }

            return result;
        }
    }
}
