using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> myStack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                myStack.Push(input[i]);
            }
            while (myStack.Count != 0)
            {
                Console.Write(myStack.Pop());
            }
            //Console.WriteLine(string.Join("", new Stack<char>(Console.ReadLine())));
        }
    }
}
