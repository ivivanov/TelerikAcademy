using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.
            //Examplpe:
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            //Forbidden words:
            string words = "PHP, CLR, Microsoft";
            //output:
            //********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
            string refactored = ForbiddenWordsRemover(text, words);
            Console.WriteLine(refactored);

        }

        static string ForbiddenWordsRemover(string text, string forbiddenWords)
        {
            string[] words = forbiddenWords.Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }
            int length = text.Length;
            string word = "";
            int wordLen = 0;
            string asterix = "";
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                wordLen = word.Length;
                asterix = new string('*', wordLen);
                text = text.Replace(word, asterix);
              
            }
            return text;
        }
    }
}
