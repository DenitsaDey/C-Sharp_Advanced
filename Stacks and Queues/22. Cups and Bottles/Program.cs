using System;
using System.Collections.Generic;
using System.Linq;

namespace _22._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] bottlesContent = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>(bottlesContent);
            Queue<int> cups = new Queue<int>(cupsCapacity);
            int wastedWater = 0;
            while (cups.Count != 0)
            {
                int currentCup = cups.Peek();
                while (bottles.Count != 0)
                {
                    int currentBottle = bottles.Pop();
                    while (currentCup > currentBottle)
                    {
                        currentCup -= currentBottle;
                        currentBottle = bottles.Pop();
                    }
                    if (currentCup <= currentBottle)
                    {
                        wastedWater += currentBottle - currentCup;
                        cups.Dequeue();
                        break;
                    }
                }
                if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ",cups)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}

