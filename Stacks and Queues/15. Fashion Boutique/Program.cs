using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int initialCapacity = rackCapacity;
            int counterRacks = 0;
            while (clothes.Count != 0)
            {
                if (rackCapacity - clothes.Peek() >= 0)
                {
                    rackCapacity -= clothes.Pop();
                }
                else
                {
                    counterRacks++;
                    rackCapacity = initialCapacity;
                }
            }
            Console.WriteLine(counterRacks + 1);
        }
    }
}
