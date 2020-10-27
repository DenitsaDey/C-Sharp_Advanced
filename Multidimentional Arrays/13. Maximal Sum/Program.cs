using System;
using System.Linq;

namespace _13._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            int maxSum = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol+1]} {matrix[maxRow, maxCol+2]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow+1, maxCol+1]} {matrix[maxRow+1, maxCol+2]}");
            Console.WriteLine($"{matrix[maxRow+2, maxCol]} {matrix[maxRow+2, maxCol+1]} {matrix[maxRow+2, maxCol+2]}");
        }
    }
}
