using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
            string cmnd = Console.ReadLine();
            //Func<int[], string, List<int>> nums = (range, cmnd) =>
            //{
            //    List<int> final = new List<int>();
            //    string command = cmnd;
            //    switch (command)
            //    {
            //        case "even":
            //            for (int i = range[0]; i <= range[1]; i++)
            //            {
            //                if(i % 2 == 0)
            //                {
            //                    final.Add(i);
            //                }
            //            }
            //            break;
            //        case "odd":
            //            for (int i = range[0]; i <= range[1]; i++)
            //            {
            //                if (i % 2 != 0)
            //                {
            //                    final.Add(i);
            //                }
            //            }
            //            break;
            //    }
            //    return final;
            //};
            //Console.WriteLine(string.Join(" ", nums(range, cmnd)));
            Action<int[], string> printNums = (range, cmnd) =>
            {
                
                
                switch (cmnd)
                {
                    case "even":
                        for (int i = range[0]; i <= range[1]; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        break;
                    case "odd":
                        for (int i = range[0]; i <= range[1]; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(i + " ");
                            }
                        }
                        break;
                }
            };
            printNums(range, cmnd);
        }
    }
}
