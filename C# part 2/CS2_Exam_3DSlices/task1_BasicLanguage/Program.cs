using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;

namespace task1_BasicLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.SetIn(new StreamReader(@"../../test.txt"));
#endif

            StringBuilder input = new StringBuilder();

            for (string line; (line = Console.ReadLine()) != null; )
            {
                input.AppendLine(line);
            }
            Regex spliter = new Regex(@"(?!\))\s*;\s*");
            string[] splitedInput = spliter.Split(input.ToString());
            Regex lineSpliter = new Regex(@"\w+\s*\((.|\s)*?\)");
            StringBuilder output = new StringBuilder();
           
            for (int i = 0; i < splitedInput.Length; i++)
            {
                if (splitedInput[i].StartsWith("EXIT"))
                {
                    break;
                }
                MatchCollection splitedLine = lineSpliter.Matches(splitedInput[i]);

                BuildOutput(splitedLine, ref output);
     
            }
            StreamWriter blq = new StreamWriter(@"../../out.txt",false);
            using (blq)
            {
                blq.WriteLine(output);
            }
            //Console.WriteLine(output.ToString());
        }

        static void BuildOutput(MatchCollection splitedLine, ref StringBuilder output)
        {
            //FOR( 0 , 1 ) 
            //FOR(5   ) 
            //PRINT(black and \r\n yellow, ) 
            int iterations = 1;
            string operation = null;
            string message = null;
            foreach (Match item in splitedLine)
            {
                operation = item.ToString().Trim();
                if(operation[0] == 'F')
                {
                    iterations *= GetIterations(item.ToString());
                }
                if (operation[0] == 'P')
                {
                    message = GetMessage(item.ToString());
                }
            }
            for (int i = 0; i < iterations; i++)
            {
                output.Append(message);
            }
        }

        static string GetMessage(string p)
        {
            //Regex regexMsg = new Regex(@"\((?<value>.*?)\)");
            //Match value = regexMsg.Match(p);
            int indexBeg = p.IndexOf('(');
            int indexEnd = p.Length;
            int len = indexEnd - indexBeg -2;
            return p.Substring(indexBeg+1, len);
        }

        static int GetIterations(string fors)
        {
            //FOR(2)  FOR(2,3)
            //FOR   ( 1  ,   5   ) 
            int i = 1;
            string[] abstr = new string[2];
            int a = 0;
            int b = 0;
            fors = fors.Trim();
            string values = "";
            Regex regex = new Regex(@"FOR\s*\((?<value>.*?)\s*\)");
            Match match = regex.Match(fors);
            while (match.Success)
            {
                values = match.Groups["value"].Value;
                abstr = values.Split(',');
                if (abstr.Length == 2)
                {
                    a = int.Parse(abstr[0]);
                    b = int.Parse(abstr[1]);
                    i *= (b - a + 1);
                }
                else
                {
                    a = int.Parse(abstr[0]);
                    i *= a;
                }
                match = match.NextMatch();
            }
            return i;
        }
    }
}

/* OLD IDEA
 * //Subirane na print valutata i chistene na printovete
            List<string> prints = new List<string>();
 * Regex regexPrint = new Regex(@"PRINT\s*\((?<value>.+?)\)\s*\;");
            Match matchPrint = regexPrint.Match(input.ToString());
            int removedStrLen = 0;
            string strForInsert = "PRINT";
            while (matchPrint.Success)
            {
                removedStrLen = (matchPrint.Value).Length;
                strForInsert = strForInsert.PadRight(removedStrLen, '#');
                input.Remove(matchPrint.Index, matchPrint.Length);
                input.Insert(matchPrint.Index, strForInsert);
                prints.Add(matchPrint.Groups["value"].ToString());
                matchPrint = matchPrint.NextMatch();
                strForInsert = "PRINT";
            }
            Regex regexFor = new Regex(@"(FOR\s*\(.*?\s*\)[\s]*)+");
            Match matchFor = regexFor.Match(input.ToString());
            StringBuilder output = new StringBuilder();
            int count = 0;
            if (input[0] == 'P')
            {
                output.Append(prints[count++]);
            }

            while (matchFor.Success)
            {
                int iterCount = GetIterations(matchFor.Value);
                

                for (int i = 0; i < iterCount; i++)
                {
                    output.Append(prints[count]);
                }
                count++;
                matchFor = matchFor.NextMatch();
            }
            while (count < prints.Count)
            {
                output.Append(prints[count++]);
            }
            Console.WriteLine(output);
        }

        static int GetIterations(string fors)
        {
            //FOR(2)  FOR(2,3)
            //FOR   ( 1  ,   5   ) 
            int i = 1;
            string[] abstr = new string[2];
            int a = 0;
            int b = 0;
            fors = fors.Trim();
            string values = "";
            Regex regex = new Regex(@"FOR\s*\((?<value>.*?)\s*\)");
            Match match = regex.Match(fors);
            while (match.Success)
            {
                values = match.Groups["value"].Value;
                abstr = values.Split(',');
                if (abstr.Length == 2)
                {
                    a = int.Parse(abstr[0]);
                    b = int.Parse(abstr[1]);
                    i *= (b - a + 1);
                }
                else
                {
                    a = int.Parse(abstr[0]);
                    i *= a;
                }
                match = match.NextMatch();
            }
            return i;
        }
*/