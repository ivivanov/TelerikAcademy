using System;

namespace BitArray64
{
    class TestApp
    {
        static void Main(string[] args)
        {
            BitArray64 z = new BitArray64(128);
            z[0] = 1;
            Console.WriteLine(z);
            foreach (var item in z)
            {
                Console.Write(item);
            }
            BitArray64 y = new BitArray64(129);
            Console.WriteLine(z==y);
        }
    }
}
