using System;
namespace anacciPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            char x_2 = first;
            char x_1 = second;
            char x = second;
            char x1 = ' ';
            int charIndex = 0;
            char previousA = '@';

            //if (GetLeterIndex(x_2) + GetLeterIndex(x_1) > 26)
            //{
            //    x = (char)(((GetLeterIndex(x_2) + GetLeterIndex(x_1)) % 26) + previousA);
            //}
            //else
            //{
            //    x = (char)(GetLeterIndex(x_2) + GetLeterIndex(x_1) + previousA);
            //}

            if (GetLeterIndex(x_1) + GetLeterIndex(x_2) > 26)
            {
                x1 = (char)(((GetLeterIndex(x_1) + GetLeterIndex(x_2)) % 26) + previousA);
            }
            else
            {
                x1 = (char)(GetLeterIndex(x_1) + GetLeterIndex(x_2) + previousA);
            }

            Console.WriteLine(x_2);
            for (int i = 0; i < l-1; i++)
            {
                Console.Write(x);
                Console.Write(new string(' ', i));
                Console.Write(x1);
                Console.WriteLine();
                x_2 = x;
                x_1 = x1;


                if (GetLeterIndex(x_2) + GetLeterIndex(x_1) > 26)
                {
                    x = (char)(((GetLeterIndex(x_2) + GetLeterIndex(x_1)) % 26) + previousA);
                }
                else
                {
                    x = (char)(GetLeterIndex(x_2) + GetLeterIndex(x_1) + previousA);
                }

                if (GetLeterIndex(x_1) + GetLeterIndex(x) > 26)
                {
                    x1 = (char)(((GetLeterIndex(x_1) + GetLeterIndex(x)) % 26) + previousA);
                }
                else
                {
                    x1 = (char)(GetLeterIndex(x_1) + GetLeterIndex(x) + previousA);
                }
            }
        }

        static int GetLeterIndex(char letter)
        {
            char previousA = '@';
            return letter - previousA;
        }
    }
}
