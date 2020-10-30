using System;
using System.Collections.Generic;

namespace _11._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                names.Add(username);
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
