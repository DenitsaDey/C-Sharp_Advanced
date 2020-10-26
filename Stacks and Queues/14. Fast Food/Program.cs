using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAvailable = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Console.WriteLine(orders.Max());
            while (orders.Count != 0 && (foodAvailable - orders.Peek()) >= 0)
            {
                foodAvailable -= orders.Dequeue();
            }
            if (orders.Count != 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
