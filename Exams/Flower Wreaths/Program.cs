using System;
using System.Collections.Generic;
using System.Linq;

namespace _19_Aug_Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int wreaths = 0;
            List<int> stored = new List<int>();

            while (lilies.Count > 0 && roses.Count > 0 && wreaths < 5)
            {
                int sum = lilies.Peek() + roses.Peek();

                if(sum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if(sum > 15)
                {
                    int currentLily = lilies.Pop() - 2;
                    lilies.Push(currentLily);
                }
                else if(sum < 15)
                {
                    stored.Add(sum);
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            wreaths += stored.Sum() / 15;
            if(wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {(5-wreaths)} wreaths more!");
            }
        }
    }
}
