using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(nums[0]);
            int s = int.Parse(nums[1]);
            int x = int.Parse(nums[2]);
            Queue<int> myQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            for (int i = 0; i < s; i++)
            {
                myQueue.Dequeue();
            }
            if (myQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Min());
            }
            else if (myQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
