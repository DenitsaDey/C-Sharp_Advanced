using System;
using System.Linq;

namespace _12._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string[,] matrix = new string[input[0], input[1]];
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) -1; j++)
                {
                    if(matrix[i, j] == matrix[i, j+1] 
                        && matrix[i+1, j] == matrix[i+1, j+1]
                        && matrix[i,j] == matrix[i+1, j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
