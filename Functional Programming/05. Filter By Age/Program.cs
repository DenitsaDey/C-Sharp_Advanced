using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> namebook = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                namebook.Add(info[0], int.Parse(info[1]));
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            if(condition == "younger")
            {
                var conditionedBook = namebook
                    .Where(y => y.Value < age)
                    .ToDictionary(x => x.Key, y => y.Value);
                PrintResult(format, conditionedBook);
            }
            else if(condition == "older")
            {
                var conditionedBook = namebook
                    .Where(x => x.Value >= age)
                    .ToDictionary(x => x.Key, y => y.Value);
                PrintResult(format, conditionedBook);
            }
        }

        private static void PrintResult(string format, Dictionary<string, int> conditionedBook)
        {
            if (format == "name")
            {
                foreach (var name in conditionedBook)
                {
                    Console.WriteLine(name.Key);
                }
            }
            else if (format == "age")
            {
                foreach (var name in conditionedBook)
                {
                    Console.WriteLine(name.Value);
                }
            }
            else if (format == "name age")
            {
                foreach (var name in conditionedBook)
                {
                    Console.WriteLine($"{name.Key} - {name.Value}");
                }
            }
        }
    }
}
