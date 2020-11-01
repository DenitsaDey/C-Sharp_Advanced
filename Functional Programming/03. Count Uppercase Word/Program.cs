using System;
using System.Linq;

namespace _03._Count_Uppercase_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpperCase = x => x[0] == x.ToUpper()[0];
            //Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(isUpperCase)
            //    .ToArray()));
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(isUpperCase)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
