using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> myStack = new MyStack<string>();

            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] tokens = input.Split(new string[] {" ", ", "}, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                if(command == "Push")
                {
                    foreach (var item in tokens.Skip(1))
                    {
                        myStack.Push(item);
                    }
                }
                if(command == "Pop")
                {
                    if(myStack.Count != 0)
                    {
                        myStack.Pop(); 
                    }
                    else
                    {
                        Console.WriteLine("No elements");
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
