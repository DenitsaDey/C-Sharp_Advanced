using System;
using System.Linq;

namespace _05._Square_With_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int elementRow = -1;
            int elementCol = -1;
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        elementRow = row;
                        elementCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[elementRow, elementCol]} {matrix[elementRow, elementCol+1]}");
            Console.WriteLine($"{matrix[elementRow + 1, elementCol]} {matrix[elementRow + 1, elementCol+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
