using System;
using System.Linq;

namespace _14._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                bool valid = true;
                int row1 = -1;
                int col1 = -1;
                int row2 = -1;
                int col2 = -1;
                if (command.Length == 5 && command[0] == "swap")
                {
                    row1 = int.Parse(command[1]);
                    col1 = int.Parse(command[2]);
                    row2 = int.Parse(command[3]);
                    col2 = int.Parse(command[4]);
                }
                else
                {
                    valid = false;
                }
                if(row1 > matrix.GetLength(0)-1 || row2 > matrix.GetLength(0)-1
                    || row1<0 || row2 <0
                    || col1>matrix.GetLength(1)-1 || col2>matrix.GetLength(1)-1
                    || col1<0 || col2 < 0)
                {
                    valid = false;
                }
                if(command[0] != "swap" || command.Length != 5 || !valid)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
