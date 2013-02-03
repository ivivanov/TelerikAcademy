using System;
using System.IO;

namespace task4_3DSlices
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
            Console.SetIn(new StreamReader(@"../../test.txt"));
            #endif
            string sizes= Console.ReadLine();
            sizes=sizes.Trim();
            string[] sizessplited = sizes.Split();
            
            int width = int.Parse(sizessplited[0]);
            int height = int.Parse(sizessplited[1]);
            int depth = int.Parse(sizessplited[2]);

            int[, ,] cube = new int[width, height, depth];
            int sumAllElements = 0;
            int countSlices = 0;
            //input
            for (int h = 0; h < height; h++)
            {
                string[] rows = Console.ReadLine().Split('|');
                for (int d = 0; d < depth; d++)
                {
                    string row = rows[d];
                    row = row.Trim();
                    string[] nums = row.Split();
                    for (int w = 0; w < width; w++)
                    {
                        cube[w,h,d] = int.Parse(nums[w]);
                        sumAllElements += int.Parse(nums[w]);
                    }
                }
            }

            //test print

            //for (int h = 0; h < height; h++)
            //{
            //    Console.WriteLine();
            //    for (int d = 0; d < depth; d++)
            //    {
            //        Console.Write(" | ");
            //        for (int w = 0; w < width; w++)
            //        {
            //            Console.Write(cube[w, h, d]+" "); 
            //        }
            //    }
            //}
            int partialSum = 0;
            for (int h = 0; h < height-1; h++)
            {
              
                for (int d = 0; d < depth; d++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        partialSum += cube[w,h,d];
                    }
                }
                if (partialSum == sumAllElements / 2.0)
                {
                    countSlices++;
                }
            }
            partialSum = 0;
            for (int d = 0; d < depth-1; d++)
            {
               
                for (int h = 0; h < height; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        partialSum += cube[w,h,d];
                    }
                }
                if (partialSum == sumAllElements / 2.0)
                {
                    countSlices++;
                }
            }
            partialSum = 0;
            for (int w = 0; w < width-1; w++)
            {
               
                for (int d = 0; d < depth; d++)
                {
                    for (int h = 0; h < height; h++)
                    {
                        partialSum += cube[w,h,d];
                    }
                }
                if (partialSum == sumAllElements / 2.0)
                {
                    countSlices++;
                }
            }
            Console.WriteLine(countSlices);
        }
    }
}
