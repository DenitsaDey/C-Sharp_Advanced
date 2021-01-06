using System;

namespace GenericBoxOfInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                Box<int> currentBox = new Box<int>(current);
                Console.WriteLine(currentBox.ToString());
            }
        }
    }
}
