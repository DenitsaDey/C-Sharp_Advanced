﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_Feb_Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> claimedItems = new List<int>();

            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            while(firstBox.Count>0 && secondBox.Count > 0)
            {
                int sum = firstBox.Peek() + secondBox.Peek();
                if(sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }
            if(firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if(secondBox.Count== 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (claimedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
            }
        }
    }
}
