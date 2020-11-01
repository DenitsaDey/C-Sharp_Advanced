using System;
using System.Linq;

namespace _13._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> smallestNum = n =>
            {
                int minNum = int.MaxValue;
                foreach (var num in nums)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }
                return minNum;
            };
            Console.WriteLine(smallestNum(nums));
        }
    }
}
