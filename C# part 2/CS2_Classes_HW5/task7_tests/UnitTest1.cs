using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task7_SoutingYardAndPolishNotation;
using System.Collections.Generic;

namespace task7_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ExprSolver inst = new ExprSolver();
            //(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
            string expresion = "(3+5.3) * (2.7 + sqrt(4)) / pow(2,2)";
            expresion =inst.ReplaceFunctionsWithEvaluation(expresion);
            expresion =inst.ClearSpaces(expresion);
                            //(3+5.3)*(2.7+2)/4
            Stack<object> splitedExpresion =inst.SplitExpresion(expresion);
            Stack<object> splited = new Stack<object>();
            splited.Push("(");
            splited.Push(3.0);
            splited.Push("+");
            splited.Push(5.3);
            splited.Push(")");
            splited.Push("*");
            splited.Push("(");
            splited.Push(2.7);
            splited.Push("+");
            splited.Push(2.0);
            splited.Push(")");
            splited.Push("/");
            splited.Push(4.0);

            object[] x = splited.ToArray();
            string xx = string.Join(" ", x);
            object[] y = splitedExpresion.ToArray();
            string yy = string.Join(" ", y);


            splitedExpresion = inst.ReverseStack(splitedExpresion);
            Stack<object> reversedPolishNotation = inst.ShuntingYard(splitedExpresion);
            //3	5.3	+ 2.7 2	+ 4 / *
            Stack<object> shunt = new Stack<object>();

            shunt.Push("*");
            shunt.Push("/");
            shunt.Push(4.0);
            shunt.Push("+");
            shunt.Push(2.0);
            shunt.Push(2.7);
            shunt.Push("+");
            shunt.Push(5.3);
            shunt.Push(3.0);
            object[] a = shunt.ToArray();
            string aa = string.Join(" ", a);
            object[] b = splitedExpresion.ToArray();
            string bb = string.Join(" ", b);
            double polish = inst.ReversedPolishNotation(reversedPolishNotation);

            //ReplaceFunctionsWithEvaluation and ClearSpaces Test 
            Assert.AreEqual("(3+5.3)*(2.7+2)/4", expresion);
            //SplitExpresion Test
            Assert.AreEqual(xx, yy);
            //ReverseStack and ShuntingYard Test
            Assert.AreEqual(aa, bb);
            Assert.AreEqual(9.753, polish);
        }
    }
}
