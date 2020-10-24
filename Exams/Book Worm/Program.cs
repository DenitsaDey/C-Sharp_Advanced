using System;
using System.Collections.Generic;
using System.Linq;

namespace _26_Oct_Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = Console.ReadLine();
            Stack<char> letters = new Stack<char>();
            for (int i = 0; i < initial.Length; i++)
            {
                letters.Push(initial[i]);
            }
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];
            fillMatrix(field);

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                bool flag = false;
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'P')
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

            string command = string.Empty;
            while ((command = Console.ReadLine())!= "end")            
            {
                field[playerRow, playerCol] = '-';

                switch (command)
                {
                    case "up":
                        playerRow--;
                        if (playerRow < 0)
                        {
                            Punished(letters);
                            playerRow = 0;
                        }
                        break;
                    case "down":
                        playerRow++;
                        if (playerRow > n - 1)
                        {
                            Punished(letters);
                            playerRow = n-1;
                        }
                        break;
                    case "left":
                        playerCol--;
                        if (playerCol < 0)
                        {
                            Punished(letters);
                            playerCol = 0;
                        }
                        break;
                    case "right":
                        playerCol++;
                        if (playerCol > n - 1)
                        {
                            Punished(letters);
                            playerCol = n-1;
                        }
                        break;
                }


                char playerPosition = field[playerRow, playerCol];

                if (playerPosition != '-')
                {
                    letters.Push(playerPosition);
                }
                
                field[playerRow, playerCol] = 'P';

            }
            
            Console.WriteLine(string.Join("", letters.Reverse()));
            printMatrix(field);

        }

        private static void Punished(Stack<char> letters)
        {
            if (letters.Count > 0)
            {
                letters.Pop();
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
