using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<int, int> adding = n => n + 1;
            Func<int, int> multiplying = n => n * 2;
            Func<int, int> subtracting = n => n - 1;
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        nums = nums.Select(adding).ToList();
                        
                        break;

                    case "multiply":
                        nums = nums.Select(multiplying).ToList();
                        
                        break;

                    case "subtract":
                        nums = nums.Select(subtracting).ToList();
                        break;

                    case "print":
                        Action<List<int>> printing = n => Console.WriteLine(string.Join(" ", n));
                        printing(nums);
                        break;
                    
                }
            }
        }
    }
}
