using System;
using System.Linq;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            int symbRow = -1;
            int symbCol = -1;
            bool flag = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(symbol == matrix[row, col])
                    {
                        symbRow = row;
                        symbCol = col;
                        Console.WriteLine($"({symbRow}, {symbCol})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if(symbRow == -1)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
            
        }
    }
}
