using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> record = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!record.ContainsKey(input[0]))
                {
                    record.Add(input[0], new List<decimal>());
                }
                record[input[0]].Add(decimal.Parse(input[1]));
            }
            foreach (var student in record)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x=>x.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
