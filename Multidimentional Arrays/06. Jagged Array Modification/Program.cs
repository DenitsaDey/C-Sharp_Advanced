using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[n][];
            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                jaggedMatrix[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            string input = "";
            while ((input = Console.ReadLine())!= "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || row > jaggedMatrix.Length - 1 || col < 0 || col > jaggedMatrix[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");                   
                }
                else
                {
                    if (command[0] == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedMatrix[i]));
            }
        }
    }
}
