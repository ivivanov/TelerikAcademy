using System;

namespace task7_ReverseNumber
{
    public class NumReverse
    {
        //Write a method that reverses the digits of given decimal number. Example: 256  652
        public int Reverser(int a)
        {
            if (a < 10 && a > -10)
            {
                return a;
            }
            string number = a.ToString();
            int pow = 1;
            int reversed = 0;
            for (int i = 0; i < number.Length; i++)
            {
                reversed += (number[i] -'0')* pow;
                pow *= 10;
            }
            return reversed;
        }
    }
}
