
/*
 * Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace task1_StringBuilderExtensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            if (index >= builder.Length || index < 0 || length > builder.Length || length < 0)
            {
                throw new ArgumentOutOfRangeException("index/length is not valid!");
            }
            StringBuilder newBuilder = new StringBuilder();
            for (int i = index; i < length; i++)
            {
                newBuilder.Append(builder[i]);
            }
            return newBuilder;
        }

        public static int IndexOf(this StringBuilder builder, char value)
        {
            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == value)
                {
                    return i;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            /////////////////////////// Substring testing//////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Substring testing\n");
            List<StringBuilder> names = new List<StringBuilder> { new StringBuilder("Cvetan Ivanov"), new StringBuilder("Boris Ivanov"), new StringBuilder("Doncho Minkov"), new StringBuilder("Cecka Cacheva") };
            foreach (StringBuilder name in names)
            {
                Console.WriteLine("First name: {0}", name.Substring(0, name.IndexOf(' ')));
            }
        }
    }
}
