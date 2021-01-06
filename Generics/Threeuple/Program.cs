using System;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();
            string fullName = $"{items[0]} {items[1]}";
            string address = items[2];
            string town = $"{items[items.Length - 1]}";
            if(items.Length > 4)
            {
                town = $"{items[items.Length - 2]} {items[items.Length - 1]}";
            }
            MyThreeuple<string, string, string> myThreeuple = new MyThreeuple<string, string, string>(fullName, address, town);
            Console.WriteLine(myThreeuple);

            string[] secondItems = Console.ReadLine().Split();
            bool drinking = false;
            if(secondItems[2] == "drunk")
            {
                drinking = true;
            }
            MyThreeuple<string, int, bool> secondThreeuple = new MyThreeuple<string, int, bool>(secondItems[0], int.Parse(secondItems[1]), drinking);
            Console.WriteLine(secondThreeuple);

            string[] thirdItems = Console.ReadLine().Split();
            MyThreeuple<string, double, string> thirdThreeuple = new MyThreeuple<string, double, string>(thirdItems[0], double.Parse(thirdItems[1]), thirdItems[2]);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
