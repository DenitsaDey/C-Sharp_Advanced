using System;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayInput = Console.ReadLine().Split();
            Dictionary<string, int> counting = new Dictionary<string, int>();
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (!counting.ContainsKey(arrayInput[i]))
                {
                    counting.Add(arrayInput[i], 0);
                }
                counting[arrayInput[i]]++;
            }
            foreach (var digit in counting)
            {
                Console.WriteLine($"{digit.Key} - {digit.Value} times");
            }
        }
    }
}
