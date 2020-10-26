using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int counterPassed = 0;
            Queue<string> cars = new Queue<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                if(input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    if(n > cars.Count)
                    {
                        n = cars.Count;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counterPassed++;
                    }
                }
            }
            Console.WriteLine($"{counterPassed} cars passed the crossroads.");
        }
    }
}
