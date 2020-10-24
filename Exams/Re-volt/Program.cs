using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_Feb_Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Stack<string> positions = new Stack<string>();

            char[,] field = new char[n, n];
            fillMatrix(field);

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                bool flag = false;
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                        flag = true;
                        break;
                    }                   
                }
                if (flag)
                {
                    break;
                }
            }
            positions.Push($"{playerRow} {playerCol}");

            for (int i = 0; i < m; i++)
            {
                field[playerRow, playerCol] = '-';

                string command = Console.ReadLine();
                MovePlayer(n, ref playerRow, ref playerCol, command);
                positions.Push($"{playerRow} {playerCol}");

                char playerPosition = field[playerRow, playerCol];
                
                if (playerPosition == 'B')
                {
                    int[] bonusPosition = positions.Peek().Split().Select(int.Parse).ToArray();
                    playerRow = bonusPosition[0];
                    playerCol = bonusPosition[1];
                    MovePlayer(n, ref playerRow, ref playerCol, command);                    
                    positions.Push($"{playerRow} {playerCol}");
                    playerPosition = field[playerRow, playerCol];
                }
                if (playerPosition == 'T')
                {
                    positions.Pop();
                    int[] trapPosition = positions.Peek().Split().Select(int.Parse).ToArray();
                    playerRow = trapPosition[0];
                    playerCol = trapPosition[1];
                    playerPosition = field[playerRow, playerCol];
                }
                if (playerPosition == 'F')
                {
                    Console.WriteLine("Player won!");
                    field[playerRow, playerCol] = 'f';
                    break;
                }
                field[playerRow, playerCol] = 'f';
                
            }

            for (int row = 0; row < n; row++)
            {
                bool flag = false;
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'F')
                    {
                        Console.WriteLine("Player lost!");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            printMatrix(field);
        }

        private static void MovePlayer(int n, ref int playerRow, ref int playerCol, string command)
        {
            switch (command)
            {
                case "up":
                    playerRow--;
                    if (playerRow < 0)
                    {
                        playerRow = n - 1;
                    }
                    break;
                case "down":
                    playerRow++;
                    if (playerRow > n - 1)
                    {
                        playerRow = 0;
                    }
                    break;
                case "left":
                    playerCol--;
                    if (playerCol < 0)
                    {
                        playerCol = n - 1;
                    }
                    break;
                case "right":
                    playerCol++;
                    if (playerCol > n - 1)
                    {
                        playerCol = 0;
                    }
                    break;
            }
        }

        private static void printMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void fillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
