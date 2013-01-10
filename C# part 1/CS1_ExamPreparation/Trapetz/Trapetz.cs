using System;

namespace Trapetz
{
    class Trapetz
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 2;
            int height = n + 1;

            String filler = new String('.', n);
            String traptzSide = new String('*', n);
            Console.WriteLine(filler + traptzSide);

            for (int i = 1; i < height - 1; i++)
            {
                String line = new String('.', n - i);
                line = line + '*';
                String filler2 = new String('.', i + n - 2);
                line = line + filler2 + "*";
                Console.WriteLine(line);
            }
            String trapetzSide = new String('*', width);
            Console.WriteLine(trapetzSide);
        }
    }
}
