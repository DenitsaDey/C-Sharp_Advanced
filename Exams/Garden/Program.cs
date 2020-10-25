using System;
using System.Collections.Generic;
using System.Linq;

namespace _25_Oct_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int dimension = size[0];
            int[,] garden = new int[dimension, dimension];
            fillMatrix(garden);

            string input = string.Empty;

            List<string> plantedFlowers = new List<string>();

            while ((input = Console.ReadLine())!= "Bloom Bloom Plow")
            {
                int[] coordinates = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int row = coordinates[0];
                int col = coordinates[1];
                if((row<0 || row>= dimension) || (col<0 || col >= dimension))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    plantedFlowers.Add(input);
                }
            }

            foreach (var flower in plantedFlowers)
            {
                int[] currentFlowerPlace = flower
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currRow = currentFlowerPlace[0];
                int currCol = currentFlowerPlace[1];
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    garden[currRow, col]++;
                }
                for (int row = 0; row < garden.GetLength(0); row++)
                {
                    garden[row, currCol]++;
                }
                garden[currRow, currCol]--;
            }
            printMatrix(garden);
        }
        private static void printMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void fillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
        }
    }
}
