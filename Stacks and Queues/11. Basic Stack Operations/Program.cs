using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(nums[0]);
            int s = int.Parse(nums[1]);
            int x = int.Parse(nums[2]);
            Stack<int> myStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            for (int i = 0; i < s; i++)
            {
                myStack.Pop();
            }
            if (myStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Min());
            }
            else if(myStack.Count == 0)
            {
                Console.WriteLine(0);
            }

        }
    }
}
