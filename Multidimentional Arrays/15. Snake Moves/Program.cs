using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            
            string input = Console.ReadLine();
            Queue<char> text = new Queue<char>(input);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if(row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = text.Peek();
                        text.Enqueue(text.Dequeue());
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = text.Peek();
                        text.Enqueue(text.Dequeue());
                    }
                }               
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
