using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Stack<int> nums = new Stack<int>();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    nums.Push(input[i]);
            //}
            //string command = string.Empty;
            //while ((command = Console.ReadLine().ToLower())!= "end")
            //{
            //    string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    if(info[0] == "add")
            //    {
            //        int num1 = int.Parse(info[1]);
            //        int num2 = int.Parse(info[2]);
            //        nums.Push(num1);
            //        nums.Push(num2);
            //    }
            //    else if(info[0] == "remove")
            //    {
            //        int count = int.Parse(info[1]);
            //        if (count <= nums.Count)
            //        {
            //            for (int i = 0; i < count; i++)
            //            {
            //                nums.Pop();
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"Sum: {nums.Sum()}");
            
            Stack<int> nums = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            
            string command = string.Empty;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (info[0] == "add")
                { 
                    nums.Push(int.Parse(info[1]));
                    nums.Push(int.Parse(info[2]));
                }
                else if (info[0] == "remove")
                {
                    int count = int.Parse(info[1]);
                    if (count <= nums.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            nums.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {nums.Sum()}");
        }
    }
}
