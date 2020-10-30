using System;
using System.Collections.Generic;

namespace _15._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols.Add(text[i], 0);
                }
                symbols[text[i]]++;
            }
            foreach (var letter in symbols)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
