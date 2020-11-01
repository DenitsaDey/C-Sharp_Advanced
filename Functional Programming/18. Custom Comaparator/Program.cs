using System;
using System.Collections.Generic;
using System.Linq;

namespace _18._Custom_Comaparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(nums);
            List<int> even = nums.Where(x => x % 2 == 0).ToList();
            List<int> odd = nums.Where(x => x % 2 != 0).ToList();
            for (int i = 0; i < odd.Count; i++)
            {
                even.Add(odd[i]);
            }
            Console.WriteLine(string.Join(" ", even));
        }
    }
}
