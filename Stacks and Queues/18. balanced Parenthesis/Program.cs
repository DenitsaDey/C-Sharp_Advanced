using System;
using System.Collections.Generic;

namespace _18._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> openingBrackets = new Stack<char>();
            bool flag = true;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBrackets.Push(')');
                }
                else if (expression[i] == '[')
                {
                    openingBrackets.Push(']');
                }
                else if (expression[i] == '{')
                {
                    openingBrackets.Push('}');
                }
                else
                {
                    if (openingBrackets.Count == 0)
                    {
                        Console.WriteLine("NO");
                        flag = false;
                        break;
                    }
                    else
                    {
                        if (expression[i] != openingBrackets.Pop())
                        {
                            Console.WriteLine("NO");
                            flag = false;
                            break;
                        }
                    }                  
                }                           
            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
