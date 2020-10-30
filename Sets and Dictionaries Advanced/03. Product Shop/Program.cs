using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (!shops.ContainsKey(info[0]))
                {
                    shops.Add(info[0], new Dictionary<string, double>());
                }                
                shops[info[0]].Add(info[1], double.Parse(info[2]));
            }
            foreach (var store in shops)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
