using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> bracketIndex = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    bracketIndex.Push(i);
                }
                else if(expression[i] == ')')
                {
                    int startIndex = bracketIndex.Pop();
                    string current = expression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(current);
                }
            }
        }
    }
}
