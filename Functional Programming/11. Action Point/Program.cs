using System;

namespace _11._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //Action<string> printName = n => Console.WriteLine(n);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    printName(names[i]);
            //}
            Action<string[]> printName = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printName(names);
        }
    }
}
