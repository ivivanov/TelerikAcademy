using System;

namespace task12_AlphabetLetters
{
    class Program
    {

        static char[] lettersArr = new char[52];

        static void Main(string[] args)
        {
            //Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

            string word = Console.ReadLine();
            char letter = 'A';
            int counter = 0;
            while (letter >= 'A' && letter <= 'Z')
            {
                lettersArr[counter++] = letter++;
            }
            letter = 'a';
            while (letter >= 'a' && letter <= 'z')
            {
                lettersArr[counter++] = letter++;
            }

            foreach (var item in word)
            {
                Console.Write(FindIndex(item)+" ");
            }
            Console.WriteLine();
        }

        static int FindIndex(char item)
        {
            int i = 0;
            while (item != lettersArr[i])
            {
                i++;
            }
            return i;
        }
    }
}
