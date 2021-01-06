using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();
            string fullName = $"{items[0]} {items[1]}";
            MyTuple<string, string> myTuple = new MyTuple<string, string>(fullName, items[2]);
            Console.WriteLine(myTuple);

            string[] secondItems = Console.ReadLine().Split();
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(secondItems[0], int.Parse(secondItems[1]));
            Console.WriteLine(secondTuple);

            string[] thirdItems = Console.ReadLine().Split();
            MyTuple<int, double> thirdTuple = new MyTuple<int, double>(int.Parse(thirdItems[0]), double.Parse(thirdItems[1]));
            Console.WriteLine(thirdTuple);
        }
    }
}
