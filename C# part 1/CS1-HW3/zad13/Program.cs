using System;

namespace zad13
{
    class Program
    {
        //This function swaps the bit on positionOne with the bit on positionTwo
        //The function returs new number of type uint with swaped bits.
        static uint swapBits(byte positionOne, byte positionTwo, uint number)
        {
            uint one = 1;            
            uint maskOne = one << positionOne;
            uint maskTwo = one << positionTwo;
            byte posOneInfo = ((number & maskOne) == maskOne) ? (byte)1 : (byte)0;
            byte posTwoInfo = ((number & maskTwo) == maskTwo) ? (byte)1 : (byte)0;

            number = posTwoInfo == 0 ? number & ~maskOne : number | maskOne;
            number = posOneInfo == 0 ? number & ~maskTwo : number | maskTwo;

            return number;
        }

        static void Main()
        {
            //13.	Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            uint number = uint.Parse(Console.ReadLine());
            byte bitPos3 = 3, bitPos4 = 4, bitPos5 = 5, bitPos24 = 24, bitPos25 = 25, bitPos26 = 26;

            number = swapBits(bitPos3, bitPos24, number);
            number = swapBits(bitPos4, bitPos25, number);
            number = swapBits(bitPos5, bitPos26, number);
           
            Console.WriteLine(number);
        }
    }
}
