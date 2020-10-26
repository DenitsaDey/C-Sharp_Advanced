using System;
using System.Collections.Generic;
using System.Linq;

namespace _17._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> circle = new Queue<string>();
            int totalFuel = 0;
            for (int i = 0; i < n; i++)
            {
                string pump = Console.ReadLine();
                pump += $" {i}";

                circle.Enqueue(pump);
            }

            for (int i = 0; i < circle.Count; i++)
            {
                int[] currentPump = circle.Peek()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int fuel = currentPump[0];
                int distance = currentPump[1];
                totalFuel += fuel;
                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }
                circle.Enqueue(circle.Dequeue());

            }
            string indexFirstPump = circle.Peek().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray()[2];
            Console.WriteLine(indexFirstPump);
        }
    }
}
