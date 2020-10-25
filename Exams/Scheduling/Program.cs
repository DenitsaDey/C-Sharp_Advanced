using System;
using System.Collections.Generic;
using System.Linq;

namespace _25_Oct_Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> thread = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int taskToKill = int.Parse(Console.ReadLine());

            while(tasks.Peek() != taskToKill)
            {
                if(tasks.Peek() <= thread.Peek())
                {
                    tasks.Pop();
                }
                thread.Dequeue();
            }
            Console.WriteLine($"Thread with value {thread.Peek()} killed task {taskToKill}");
            Console.WriteLine(string.Join(" ", thread));
        }
    }
}
