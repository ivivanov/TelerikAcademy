using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace task7_SoutingYardAndPolishNotation
{
    public class ExprSolver
    {
        static void Main(string[] args)
        {
            /* Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
            Real numbers, e.g. 5, 18.33, 3.14159, 12.6
            Arithmetic operators: +, -, *, / (standard priorities)
            Mathematical functions: ln(x), sqrt(x), pow(x,y)
            Brackets (for changing the default priorities)
	            Examples:
	            (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
	            pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
	            Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".*/
            //string expresion = "  pow( 2 , 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
            string expresion = "  (3+5) * 2 - 4 / pow(2,2)";
            ExprSolver inst = new ExprSolver();
            //string expresion = "(3+5.3) * 2.7 + sqrt(4) / pow(2,8)";

            Console.WriteLine(inst.ExpresionSolever(expresion));
        }

        public double ExpresionSolever(string expresion)
        {
            expresion = ReplaceFunctionsWithEvaluation(expresion);
            expresion = ClearSpaces(expresion);
           
            
            //(3+5.3)*2.7+2/256
            Stack<object> splitedExpresion = SplitExpresion(expresion);
            splitedExpresion = ReverseStack(splitedExpresion);
          
            //(3+5) * 2 - 4 / 4
            //3 5 + 2 * 4 - 4 /
	
            Stack<object> reversedPolishNotation = ShuntingYard(splitedExpresion);
            return ReversedPolishNotation(reversedPolishNotation);
        }

        private Stack<object> ShuntingYard(Stack<object> right)
        {
            //(3+5) * 2 - 4 / 4
            //3 5 + 2 * 4 - 4 /
            Stack<object> left = new Stack<object>();
            Stack<object> down = new Stack<object>();
            object token;
            while (right.Count != 0)
            {
                token = right.Pop();
                if (token.GetType() == typeof(double))
                {
                    left.Push(token);
                }
                else
                {
                    down.Push(token);
                }
            }
        }

        public double ReversedPolishNotation(Stack<object> reversedPolishNotation)
        {
            Stack<object> down = new Stack<object>();
            object x=0;
            object leftNum;
            object rightNum;
            if (reversedPolishNotation.Count != 0)
            {
                x = reversedPolishNotation.Pop();
                while (reversedPolishNotation.Count != 0)
                {
                    while (x.GetType() == typeof(double) && reversedPolishNotation.Count != 0)
                    {
                        down.Push(x);
                        x = reversedPolishNotation.Pop();
                    }
                    while (x.GetType() == typeof(string) && reversedPolishNotation.Count != 0)
                    {
                        rightNum = down.Pop();
                        leftNum = down.Pop();
                        down.Push(SimpleCalculation(leftNum, x, rightNum));
                        x = reversedPolishNotation.Pop();
                    }

                }
                rightNum = down.Pop();
                leftNum = down.Pop();
                x = SimpleCalculation(leftNum, x, rightNum);
            }
            return double.Parse(x.ToString());
        }

        public double SimpleCalculation(object leftNum, object x, object rightNum)
        {
            double numL = double.Parse(leftNum.ToString());
            double numR = double.Parse(rightNum.ToString());
            switch (x.ToString())
            { 
                case("+"):
                    return Math.Round((numL + numR), 3);
                case("-"):
                    return Math.Round((numL - numR), 3);
                case("*"):
                    return Math.Round((numL * numR), 3);
                case("/"):
                    return Math.Round((numL / numR), 3);
                default:
                    return 0;
            }
        }

        //public Stack<object> ShuntingYard(Stack<object> right)
        //{
        //    //(3+5) * 2 - 4 / 4
        //    //3 5 + 2 * 4 - 4 /
        //    Stack<object> left = new Stack<object>();
        //    Stack<object> down = new Stack<object>();
        //    object r;
        //    object d;
        //    object l;
        //    while (right.Count != 0)
        //    {
        //        r = right.Pop();
        //        if (r.GetType() == typeof(double))
        //        {
        //            left.Push(r);
        //        }
        //        else
        //        {
        //            if (NotClosingBracket(r))
        //            {
        //                if (down.Count != 0)
        //                {
        //                    d = down.Pop();
        //                    if (!NotClosingBracket(d))
        //                    {
        //                        left.Push(d);
        //                    }
        //                    else
        //                    {
        //                        down.Push(d);
        //                    }
                            
        //                }
        //                down.Push(r);
        //            }
        //            else
        //            {
        //                d = down.Pop();
        //                while (d.ToString() != "(")
        //                {
        //                    left.Push(d);
        //                    d = down.Pop();
        //                }
        //            }
        //        }
        //    }
        //    while (down.Count != 0)
        //    {
        //        d = down.Pop();
        //        left.Push(d);
        //    }
        //    while (left.Count != 0)
        //    {
        //        l = left.Pop();
        //        right.Push(l);
        //    }
        //    return right;
        //}

        public string ReplaceFunctionsWithEvaluation(string expresion)
        {
            Regex functionPatternRegex = new Regex(@"(\bln\([ \d\.-]+\))|(\bsqrt\([ \d\.-]+\))|(\bpow\([ \d\.-]+,[ \d\.-]+\))");
            Match match = functionPatternRegex.Match(expresion);
            double result = 0;
            while (match.Success)
            {
                result = EvaluateFunction(match.Value);
                expresion = expresion.Replace(match.Value, result.ToString());
                match = match.NextMatch();
            }
            return expresion;

        }

        public Stack<object> SplitExpresion(string expresion)
        {
            Stack<object> splitedExpresion = new Stack<object>();
            string number = "";
            //(3+5.3)*2.7+2/256
            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];
                if (c == '+' || c == '*' || c == '/' || c == '(' || c == ')' || c == '-')
                {
                    if (number.Length != 0)
                    {
                        splitedExpresion.Push(double.Parse(number));
                        number = "";
                    }
                    if (c == '-' && IsSignMinus(i, expresion))
                    {
                        number += c;
                    }
                    else
                    {
                        splitedExpresion.Push(c.ToString());
                    }
                }
                else
                {
                    if (c != '.' && c < '0' && c > '9')
                    {
                        splitedExpresion.Push(double.Parse(number));
                        number = "";
                    }
                    number += c;
                }
            }
            if (number.Length != 0)
            {
                splitedExpresion.Push(double.Parse(number));
            }
            return splitedExpresion;
        }

        public double EvaluateFunction(string mathFunc)
        {
            //pow( -2.5 , 33.1 ) -> pow(-2.5,33.1)
            mathFunc = mathFunc.Trim();
            mathFunc = mathFunc.Replace(" ", "");
            Regex numberPatternRegex = new Regex(@"(\((?<number>[\d-\.]+)\))|(\((?<number>[-\.\d]+))|(,(?<number>[-\.\d]+)\))");
            Match num = numberPatternRegex.Match(mathFunc);
            string x;
            string y;
            double realX;
            double realY;
            switch (mathFunc[0]) 
            { 
                case ('p'):
                    x = num.Groups["number"].Value;
                    num = num.NextMatch();
                    y = num.Groups["number"].Value;
                    realX = double.Parse(x);
                    realY = double.Parse(y);
                    return Math.Round((Math.Pow(realX, realY)),3);
                case('l'):
                    x = num.Groups["number"].Value;
                    realX = double.Parse(x);
                    return Math.Round((Math.Log10(realX)),3);
                case('s'):
                    x = num.Groups["number"].Value;
                    realX = double.Parse(x);
                    return Math.Round((Math.Sqrt(realX)),3);
                default:
                    return 0;
            }
        }

        public Stack<object> ReverseStack(Stack<object> splitedExpresion)
        {
            Stack<object> reversed = new Stack<object>();
            object a;
            if (splitedExpresion.Count == 1)
            {
                return splitedExpresion;
            }

            while (splitedExpresion.Count != 0)
            {
                a = splitedExpresion.Pop();
                reversed.Push(a);
            }
            return reversed;
        }

        public bool NotClosingBracket(object x)
        {
            if (x.ToString() == ")")
            {
                return false;
            }
            return true;
        }

        public bool IsSignMinus(int i, string expresion)
        {
            if (i == 0 || expresion[i - 1] == '(')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ClearSpaces(string expresion)
        {
            expresion = expresion.Replace(" ", "");
            return expresion;
        }
    }
}