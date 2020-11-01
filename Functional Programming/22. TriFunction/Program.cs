using System;
using System.Collections.Generic;
using System.Linq;

namespace _22._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Func<string, int, bool> checker = (x, y) =>
           {
               int sum = x.Select(c => (int)c).Sum();
               
               if(sum>= y)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           };
            foreach (var name in names)
            {
                if(checker(name, n))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}
