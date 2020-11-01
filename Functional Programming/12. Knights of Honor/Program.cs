using System;
using System.Linq;

namespace _12._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] knights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> addHonor = k => Console.WriteLine($"Sir {string.Join(Environment.NewLine + "Sir ", k)}");

            addHonor(knights);

            //string[] knights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => "Sir " + n).ToArray();
            //Action<string[]> addHonor = k => Console.WriteLine(string.Join(Environment.NewLine, k));

            //addHonor(knights);
        }
    }
}
