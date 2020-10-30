using System;
using System.Collections.Generic;

namespace _16._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] items = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < items.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(items[j]))
                    {
                        wardrobe[color].Add(items[j], 0);
                    }
                    wardrobe[color][items[j]]++;
                }
            }
            string[] wantedItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string wantedColor = wantedItem[0];
            string wantedClothes = wantedItem[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothing in color.Value)
                {
                    Console.Write($"* {clothing.Key} - {clothing.Value}");
                    if (color.Key == wantedColor && clothing.Key == wantedClothes)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
