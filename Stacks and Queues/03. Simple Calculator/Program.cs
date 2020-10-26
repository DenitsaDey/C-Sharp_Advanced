using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> calculation = new Stack<string>(expression.Reverse());
            while (calculation.Count > 1)
            {
                int first = int.Parse(calculation.Pop());
                string operation = calculation.Pop();
                int second = int.Parse(calculation.Pop());
                if (operation == "+")
                {
                    calculation.Push((first + second).ToString());
                }
                else if (operation == "-")
                {
                    calculation.Push((first - second).ToString());
                }
            }
            Console.WriteLine(calculation.Pop());

            //Stack<string> calculation = new Stack<string>();
            //calculation.Push(expression[0]);
            //for (int i = 1; i < expression.Length; i+=2)
            //{
            //    int first = int.Parse(calculation.Pop());
            //    string operation = expression[i];
            //    int second = int.Parse(expression[i + 1]);
            //    if (operation == "+")
            //    {
            //        calculation.Push((first + second).ToString());
            //    }
            //    else if (operation == "-")
            //    {
            //        calculation.Push((first - second).ToString());
            //    }
            //}
            //Console.WriteLine(string.Join("",calculation));
        }
    }
}
