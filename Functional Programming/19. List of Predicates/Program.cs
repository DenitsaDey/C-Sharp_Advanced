using System;
using System.Collections.Generic;
using System.Linq;

namespace _19._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] division = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                bool flag = true;
                for (int j = 0; j < division.Length; j++)
                {
                    Predicate<int> checker = x => i % x == 0;

                    if (!checker(division[j]))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
