using System;

namespace KolednaElha
{
    class Borche
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = "";
            for (int i = 1; i < n; i++)
            {
                line = new string('.', n - 1 - i) + new string('*',2 * i - 1) + new string('.', n - 1 - i);
                Console.WriteLine(line);
            }
            Console.WriteLine(new string('.', n - 2) + "*" + new string('.', n - 2));
        }
    }
}
