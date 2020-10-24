using System;
using System.Collections.Generic;
using System.Linq;

namespace _26_Oct_Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> male = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> female = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int matches = 0;

            while(female.Count>0 && male.Count > 0)
            {
                if (female.Peek() <= 0 || male.Peek() <= 0)
                {
                    if (female.Peek() <= 0)
                    {
                        female.Dequeue();
                    }
                    if (male.Peek() <= 0)
                    {
                        male.Pop();
                    }
                }
                else if (female.Peek() % 25 == 0 || male.Peek() % 25 == 0)
                {
                    if (female.Peek() % 25 == 0)
                    {
                        female.Dequeue();
                        female.Dequeue();
                    }
                    if (male.Peek() % 25 == 0)
                    {
                        male.Pop();
                        male.Pop();
                    }
                }
                else if(female.Peek() == male.Peek())
                {
                    matches++;
                    female.Dequeue();
                    male.Pop();
                }
                else
                {
                    female.Dequeue();
                    int newMaleValue = male.Pop() - 2;
                    male.Push(newMaleValue);
                }
            }
            Console.WriteLine($"Matches: {matches}");
            if(male.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ", male)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }
            if (female.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
