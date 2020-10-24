using System;
using System.Collections.Generic;

namespace _28_Jun_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] territory = new char[n, n];
            fillMatrix(territory);

            int food = 0;
            int snakeRow = -1;
            int snakeCol = -1;
            List<int[]> burrows = new List<int[]>();
            

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (territory[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;                       
                    }
                    else if(territory[row, col] == 'B')
                    {
                        burrows.Add(new int[] {row, col});
                    }
                }                
            }

            while(food < 10)
            {
                territory[snakeRow, snakeCol] = '.';
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "right":
                        snakeCol++;
                        break;
                }
                if(!SnakeIsInside(snakeRow, snakeCol, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                char snakePosition = territory[snakeRow, snakeCol];
                if(snakePosition == '*')
                {
                    food++;
                }
                else if(snakePosition == 'B')
                {
                    territory[snakeRow, snakeCol] = '.';

                    int[] b1 = burrows[0];
                    int[] b2 = burrows[1];
                    if(snakeRow == b1[0] && snakeCol == b1[1])
                    {
                        snakeRow = b2[0];
                        snakeCol = b2[1];
                    }
                    else
                    {
                        snakeRow = b1[0];
                        snakeCol = b1[1];
                    }
                }
                territory[snakeRow, snakeCol] = 'S';
            }
            if(food >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {food}");

            printMatrix(territory);
        }

        private static bool SnakeIsInside(int snakeRow, int snakeCol, int n)
        {
            if (snakeRow < 0 || snakeCol < 0 || snakeRow >= n || snakeCol >= n)
            {
                return false;
            }
            return true;
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
