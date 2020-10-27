using System;
using System.Linq;

namespace _18._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            string[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentBomb = coordinates[i]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int bombRow = currentBomb[0];
                int bombCol = currentBomb[1];
                ChangeMatrixAfterBomb(size, matrix, bombRow, bombCol);
            }
            int counter = 0;
            int sum = 0;
            foreach (int cell in matrix)
            {
                if (cell > 0)
                {
                    counter++;
                    sum += cell;
                }
            }
            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ChangeMatrixAfterBomb(int size, int[,] matrix, int bombRow, int bombCol)
        {
            if (matrix[bombRow, bombCol] > 0)
            {
                int power = matrix[bombRow, bombCol];
                matrix[bombRow, bombCol] = 0;
                if (bombRow - 1 >= 0 && bombCol - 1 >= 0 && matrix[bombRow - 1, bombCol - 1] > 0)
                {
                    matrix[bombRow - 1, bombCol - 1] -= power;
                }
                if (bombRow - 1 >= 0 && bombCol >= 0 && matrix[bombRow - 1, bombCol] > 0)
                {
                    matrix[bombRow - 1, bombCol] -= power;
                }
                if (bombRow - 1 >= 0 && bombCol + 1 < size && matrix[bombRow - 1, bombCol + 1] > 0)
                {
                    matrix[bombRow - 1, bombCol + 1] -= power;
                }
                if (bombCol - 1 >= 0 && matrix[bombRow, bombCol - 1] > 0)
                {
                    matrix[bombRow, bombCol - 1] -= power;
                }
                if (bombCol + 1 < size && matrix[bombRow, bombCol + 1] > 0)
                {
                    matrix[bombRow, bombCol + 1] -= power;
                }
                if (bombRow + 1 < size && bombCol - 1 >= 0 && matrix[bombRow + 1, bombCol - 1] > 0)
                {
                    matrix[bombRow + 1, bombCol - 1] -= power;
                }
                if (bombRow + 1 < size && matrix[bombRow + 1, bombCol] > 0)
                {
                    matrix[bombRow + 1, bombCol] -= power;
                }
                if (bombRow + 1 < size && bombCol + 1 < size && matrix[bombRow + 1, bombCol + 1] > 0)
                {
                    matrix[bombRow + 1, bombCol + 1] -= power;
                }
            }
        }
    }
}
