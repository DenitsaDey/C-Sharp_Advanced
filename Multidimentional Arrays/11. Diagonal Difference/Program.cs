using System;
using System.Linq;

namespace _11._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] square = new int[n, n];
            for (int i = 0; i < square.GetLength(0); i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < currentRow.Length; j++)
                {
                    square[i, j] = currentRow[j];
                }
            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                primaryDiagonal += square[i, i];
                secondaryDiagonal += square[i, square.GetLength(1) - (i + 1)];
            }
            
            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }
    }
}
