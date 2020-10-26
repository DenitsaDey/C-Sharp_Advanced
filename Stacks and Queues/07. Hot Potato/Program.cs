using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> circle = new Queue<string>(children);
            while (circle.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    circle.Enqueue(circle.Dequeue());
                }
                Console.WriteLine($"Removed {circle.Dequeue()}");
            }
            Console.WriteLine($"Last is {circle.Peek()}");
        }
    }
}
