using System;
using System.Collections.Generic;
using System.Linq;

namespace _16._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            nums.Reverse();
            //Func<int, bool> predicate = x => x % 2 != 0;
            //nums = nums.Where(predicate).ToList();
            nums = nums.Where(x => x % n != 0).ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
