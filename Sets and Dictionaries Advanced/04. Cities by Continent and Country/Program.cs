using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> globe = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!globe.ContainsKey(input[0]))
                {
                    globe.Add(input[0], new Dictionary<string, List<string>>());
                }
                if (!globe[input[0]].ContainsKey(input[1]))
                {
                    globe[input[0]].Add(input[1], new List<string>());
                }
                globe[input[0]][input[1]].Add(input[2]);
            }
            foreach (var continent in globe)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
