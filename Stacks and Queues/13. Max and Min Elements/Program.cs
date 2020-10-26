using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._Max_and_Min_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> elements = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(command[0] == "1")
                {
                    int num = int.Parse(command[1]);
                    elements.Push(num);
                }
                else if(command[0] == "2" && elements.Count != 0)
                {
                    elements.Pop();
                }
                else if(command[0] == "3" && elements.Count != 0)
                {
                    Console.WriteLine(elements.Max());
                }
                else if(command[0] == "4" && elements.Count != 0)
                {
                    Console.WriteLine(elements.Min());
                }
            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
