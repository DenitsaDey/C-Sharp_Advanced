using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHash = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                myHash.Add(name);
            }
            Console.WriteLine(string.Join(Environment.NewLine, myHash));
        }
    }
}
