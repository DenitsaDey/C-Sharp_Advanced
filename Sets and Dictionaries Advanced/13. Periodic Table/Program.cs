using System;
using System.Collections.Generic;

namespace _13._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < element.Length; j++)
                {
                    periodicTable.Add(element[j]);
                }
            }
            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
