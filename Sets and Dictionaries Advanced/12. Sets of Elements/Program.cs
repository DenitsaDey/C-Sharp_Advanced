using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLengths = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            HashSet<string> first = new HashSet<string>();
            HashSet<string> second = new HashSet<string>();
            for (int i = 0; i < setsLengths[0]; i++)
            {
                string element = Console.ReadLine();
                first.Add(element);
            }
            for (int i = 0; i < setsLengths[1]; i++)
            {
                string element = Console.ReadLine();
                second.Add(element);
            }
            first.IntersectWith(second);
            Console.WriteLine(string.Join(" ",first));
        }
    }
}
