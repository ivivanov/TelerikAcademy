using System;

namespace TelerikLogoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = (x + 1) / 2;
            int outsideDots = 0;
            int middleDots = 0;
            int dotsBetween = 1;
            int lineLength = x * 2 - 1 + 2 * (z - 1);
            string line = "";

            outsideDots = z - 1;
            middleDots = lineLength - (2 * outsideDots + 2);
            line = new string('.', outsideDots) +
                '*' +
                new string('.', middleDots) +
                '*' +
                new string('.', outsideDots);
            Console.WriteLine(line);

            outsideDots--;
            dotsBetween = 1;
            middleDots -=2;

            for (int i = z - 1; i > 0; i--)
            {
                line = new string('.', outsideDots) +
                '*' +
                new string('.', dotsBetween) +
                '*' +
                new string('.', middleDots) +
                '*' +
                new string('.', dotsBetween) +
                '*' +
                new string('.', outsideDots);
                Console.WriteLine(line);
                outsideDots--;
                dotsBetween += 2;
                middleDots -= 2;
            }

            
            //for (int i = middleDots; i > 0; i--)
            while(middleDots>0)
            {
                line = new string('.', dotsBetween) +
                    '*' +
                    new string('.', middleDots) +
                    '*' +
                    new string('.', dotsBetween);
                middleDots -= 2;
                dotsBetween++;
                Console.WriteLine(line);
            }
            line = new string('.', lineLength / 2) + '*' + new string('.', lineLength / 2 );
            Console.WriteLine(line);

            dotsBetween = 1;
            outsideDots = (lineLength - 3) / 2;
            for (int i = 0; i < x-1; i++)
            {
                line = new string('.', outsideDots) + '*' + new string('.', dotsBetween) + '*' + new string('.', outsideDots);
                outsideDots--;
                dotsBetween += 2;
                Console.WriteLine(line);
            }

            outsideDots++;
            dotsBetween -= 2;
            for (int i = 0; i < x-2; i++)
            {
                outsideDots++;
                dotsBetween -= 2;
                line = new string('.', outsideDots) + '*' + new string('.', dotsBetween) + '*' + new string('.', outsideDots);
                Console.WriteLine(line);
            }
            line = new string('.', lineLength / 2) + '*' + new string('.', lineLength / 2);
            Console.WriteLine(line);
        }
    }
}
