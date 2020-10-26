using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> people = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if(input != "Paid")
                {
                    people.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine, people));
                    people.Clear();
                }
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
