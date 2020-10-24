using System;
using System.Collections.Generic;
using System.Linq;

namespace _28_Jun_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> casing = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> pouch = new Dictionary<string, int> {
                {"Datura Bombs", 0 },
                {"Cherry Bombs", 0 },
                {"Smoke Decoy Bombs", 0 }
            };
            int[] values = new int[] { 40, 60, 120 };

            while (effects.Count > 0 && casing.Count > 0 && pouch.Any(e => e.Value < 3))
            {
                int sum = effects.Peek() + casing.Peek();
                if (values.Contains(sum))
                {
                    if(sum == 40)
                    {
                        pouch["Datura Bombs"]++;
                    }
                    else if(sum == 60)
                    {
                        pouch["Cherry Bombs"]++;
                    }
                    else
                    {
                        pouch["Smoke Decoy Bombs"]++;
                    }
                    effects.Dequeue();
                    casing.Pop();
                }
                else
                {
                    int casingValue = casing.Pop() - 5;
                    casing.Push(casingValue);
                }
            }
            if(pouch.All(e => e.Value >= 3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if(effects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (casing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            foreach (var bomb in pouch.OrderBy(b=>b.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}

