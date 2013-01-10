using System;

namespace LiulinRoad
{
    class RoadMap
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n - 1;
            string trees = "";
            string path = "*";
            string line = "";
            Console.WriteLine(path + (new string('.', n - 1)));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine((new string('.', i)) + path + (new string('.', n - i - 1))); 
            }
            for (int i = n - 2; i >= 0; i--)
            {
                Console.WriteLine((new string('.', i)) + path + (new string('.', n - i - 1)));
            }
        }
    }
}
