using System;
using task7_ReverseNumber;

namespace task13_TaskSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that can solve these tasks:
             
                Reverses the digits of a number
                Calculates the average of a sequence of integers
                Solves a linear equation a * x + b = 0
            
             * Create appropriate methods.
             * Provide a simple text-based menu for the user to choose which task to solve.
             * Validate the input data:
                    The decimal number should be non-negative
                    The sequence should not be empty
                    a should not be equal to 0
            */

            PrintMenu();
            WaitForKey();
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select the number of the operation:");
            Console.WriteLine("1. Reverse the digits of a number.");
            Console.WriteLine("2. Calculate the average of a sequence of integers.");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }

        static void WaitForKey()
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.D1)
                {
                    Reverser();
                }
                if (pressedKey.Key == ConsoleKey.D2)
                {
                    AvarageCalc();
                }
                if (pressedKey.Key == ConsoleKey.D3)
                {
                    LinearEquationSolver();
                }
                if (pressedKey.Key == ConsoleKey.D4)
                {
                    Environment.Exit(0);
                }
                PrintMenu();
            }
        }

        static void LinearEquationSolver()
        {
            Console.WriteLine("Enter linear equation (a * x + b = 0): ");
            string input = AskForInput();
            int[] abParams = new int[2];
            while (!(StringToArrLikeEquation(input, ref abParams)))
            {
                Console.WriteLine("Enter valid equation! Example: -31*x + 12 = 0");
                input = AskForInput();
            }
            Console.WriteLine("The answer of {0} is x = {1}",input,EquationSolver(abParams));
        }

        static bool StringToArrLikeEquation(string input,ref int[] ab)
        {
            bool flag = true;
            input = input.Trim();
            input = input.Replace(" ", "");
            input = input.Replace("*", " * ");
            input = input.Replace("-", " - ");
            input = input.Replace("+", " + ");
            input = input.Replace("=", " = ");
            input = input.Trim();
            string[] splitedInput = input.Split(' ');
            if (splitedInput.Length < 7 || splitedInput[0] == "0" || (splitedInput[0]=="-" && splitedInput[1]=="0"))
            {
                flag = false;
            }
            else
            {
                //if a is < 0
                if (splitedInput[0] == "-")
                {
                    if (!(int.TryParse(splitedInput[1], out ab[0])))
                    {
                        flag = false;
                    }
                    ab[0] *= -1;
                    if (splitedInput[4] == "+")
                    {
                        if (!(int.TryParse(splitedInput[5], out ab[1])))
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        if (!(int.TryParse(splitedInput[5], out ab[1])))
                        {
                            flag = false;
                        }
                        ab[1] *= -1;
                    }
                }
                // if a is > 0
                else
                {
                    if (!(int.TryParse(splitedInput[0], out ab[0])))
                    {
                        flag = false;
                    }
                    if (splitedInput[3] == "+")
                    {
                        if (!(int.TryParse(splitedInput[4], out ab[1])))
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        if (!(int.TryParse(splitedInput[4], out ab[1])))
                        {
                            flag = false;
                        }
                        ab[1] *= -1;
                    }
                }
            }
            return flag;
        }

        private static string EquationSolver(int[] ab)
        {
            ab[1] *= -1;
            double result = ab[1] / (double)ab[0];
            return result.ToString();
        }

        static void Reverser()
        {
            NumReverse inst = new NumReverse();
            Console.WriteLine("Enter integer number to reverse: ");
            int input = 0;
            while (!(int.TryParse(Console.ReadLine(), out input)))
            {
                Console.WriteLine("Enter valid number!");
            }
            Console.WriteLine(inst.Reverser(input));
        }

        static void AvarageCalc()
        {
            Console.WriteLine("Enter sequence of numbers separated by spaces");
            string input = AskForInput();
            int[] ints = new int[0];
            while(!(ParseStringToArrOfNums(input, ref ints)))
            {
                Console.WriteLine("Invalid sequence! (Empty?, Not all elements are integers?)");
                input = AskForInput();
            }
            Console.WriteLine(Avg(ints));
        }

        private static double Avg(int[] ints)
        {
            int length = ints.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += ints[i];
            }
            return sum / (double)length;
        }

        static bool ParseStringToArrOfNums(string input, ref int[] ints)
        {
            bool flag = true;
            input = input.Trim();
            string[] stringOfNumbers = input.Split();
            ints = new int[stringOfNumbers.Length];
            for (int i = 0; i < stringOfNumbers.Length; i++)
            {
                if (!(int.TryParse(stringOfNumbers[i], out ints[i])))
                {
                    flag = false;
                }
            }
            return flag;
        }

        static string AskForInput()
        {
            return Console.ReadLine();
        }
    }
}
