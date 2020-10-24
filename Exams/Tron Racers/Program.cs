using System;

namespace _24_Feb_Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];
            fillMatrix(field);

            int fRow = -1;
            int fCol = -1;

            int sRow = -1;
            int sCol = -1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'f')
                    {
                        fRow = row;
                        fCol = col;
                    }
                    else if (field[row, col] == 's')
                    {
                        sRow = row;
                        sCol = col;
                    }
                }               
            }

            bool bothAlive = true;
            while (bothAlive)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string fMove = command[0];
                string sMove = command[1];

                MovePlayer(n, ref fRow, ref fCol, fMove);
                MovePlayer(n, ref sRow, ref sCol, sMove);

                char fPosition = field[fRow, fCol];
                char sPosition = field[sRow, sCol];

                if (fPosition == 's')
                {
                    bothAlive = false;
                    field[fRow, fCol] = 'x';
                    break;
                }
                else
                {
                    field[fRow, fCol] = 'f';
                }
                if (sPosition == 'f')
                {
                    bothAlive = false;
                    field[sRow, sCol] = 'x';
                    
                }
                else
                {
                    field[sRow, sCol] = 's';
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
