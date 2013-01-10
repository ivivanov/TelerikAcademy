using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
            
            int length = 20;
            int[] array = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                array[i] = i * 5;
            }

            Console.Write("[");
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
                if (i == length -1) 
                {
                    Console.Write("]");
                    break;
                }
                Console.Write(", ");
            }
        }
    }
}
