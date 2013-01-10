using System;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] catVotes = new int[10];
            
            while (n > 0)
            {
                int catNumber = int.Parse(Console.ReadLine());
                catVotes[catNumber-1] += 1;
                n--;
            }
            int max = catVotes[9];
            byte maxIndex = 9;
            for (int i = 9; i >= 0; i--)
            {
                if (max < catVotes[i])
                {
                    max = catVotes[i];
                    maxIndex = (byte)i;
                }
            }
            Console.WriteLine(maxIndex + 1);
        }
    }
}
