using System;
using System.Linq;

namespace _20._Radioactive_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            char[,] lair = new char[input[0], input[1]];
            for (int i = 0; i < lair.GetLength(0); i++)
            {
                string currentInput = Console.ReadLine();
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    lair[i, j] = currentInput[j];
                }
            }

            int currentRow = -1;
            int currentCol = -1;
            bool won = false;
            bool dead = false;
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            for (int i = 0; i < command.Length; i++)
            {
                char currentCmnd = command[i];
                if (currentCmnd == 'L')
                {
                    if (currentCol - 1 < 0)
                    {
                        lair[currentRow, currentCol] = '.';
                        won = true;
                    }
                    else if (currentCol - 1 >= 0 && lair[currentRow, currentCol - 1] == '.')
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow, currentCol - 1] = 'P';
                        currentCol--;
                    }
                    else if (currentCol - 1 >= 0 && lair[currentRow, currentCol - 1] == 'B')
                    {
                        dead = true;
                        currentCol--;
                    }

                    MultiplyBunnies(lair);
                    dead = CheckPlayerStatus(lair, dead, won);

                }
                else if (currentCmnd == 'R')
                {
                    if (currentCol + 1 >= lair.GetLength(1))
                    {
                        lair[currentRow, currentCol] = '.';
                        won = true;
                    }
                    else if (currentCol + 1 < lair.GetLength(1) && lair[currentRow, currentCol + 1] == '.')
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow, currentCol + 1] = 'P';
                        currentCol++;
                    }
                    else if (currentCol + 1 < lair.GetLength(1) && lair[currentRow, currentCol + 1] == 'B')
                    {
                        lair[currentRow, currentCol] = '.';
                        dead = true;
                        currentCol++;
                    }

                    MultiplyBunnies(lair);
                    dead = CheckPlayerStatus(lair, dead, won);
                }
                else if (currentCmnd == 'U')
                {
                    if (currentRow - 1 < 0)
                    {
                        lair[currentRow, currentCol] = '.';
                        won = true;
                    }
                    else if (currentRow - 1 >=0 && lair[currentRow - 1, currentCol] == '.')
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow - 1, currentCol] = 'P';
                        currentRow--;
                    }
                    else if (currentRow - 1 >= 0 && lair[currentRow - 1, currentCol] == 'B')
                    {
                        lair[currentRow, currentCol] = '.';
                        dead = true;
                        currentRow--;
                    }

                    MultiplyBunnies(lair);
                    dead = CheckPlayerStatus(lair, dead, won);
                }
                else if (currentCmnd == 'D')
                {
                    if (currentRow + 1 >= lair.GetLength(0))
                    {
                        lair[currentRow, currentCol] = '.';
                        won = true;
                    }
                    else if (currentRow + 1 < lair.GetLength(0) && lair[currentRow + 1, currentCol] == '.')
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow + 1, currentCol] = 'P';
                        currentRow++;
                    }
                    else if (currentRow + 1 < lair.GetLength(0) && lair[currentRow+1, currentCol] == 'B')
                    {
                        lair[currentRow, currentCol] = '.';
                        dead = true;
                        currentRow++;
                    }

                    MultiplyBunnies(lair);
                    dead = CheckPlayerStatus(lair, dead, won);
                }
                if (won || dead)
                {
                    break;
                }
            }

            for (int i = 0; i < lair.GetLength(0); i++)
            {
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    Console.Write(lair[i, j]);
                }
                Console.WriteLine();
            }
            if (won)
            {                
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
            else if (dead)
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
        }

        private static bool CheckPlayerStatus(char[,] lair, bool dead, bool won)
        {
            int playerPresent = 0;
            foreach (char symb in lair)
            {
                if (symb == 'P')
                {
                    playerPresent++;
                }
            }
            if (playerPresent == 0 && !won)
            {
                dead = true;
            }
            else
            {
                dead = false;
            }

            return dead;
        }

        private static void MultiplyBunnies(char[,] lair)
        {
            for (int j = 0; j < lair.GetLength(0); j++)
            {
                for (int k = 0; k < lair.GetLength(1); k++)
                {
                    if (lair[j, k] == 'B')
                    {
                        if (k - 1 >= 0 && lair[j,k-1] != 'B')
                        {
                            lair[j, k - 1] = 'N';
                        }
                        if (k + 1 < lair.GetLength(1) && lair[j, k + 1]!='B')
                        {
                            lair[j, k + 1] = 'N';
                        }
                        if (j - 1 >= 0 && lair[j - 1, k] != 'B')
                        {
                            lair[j - 1, k] = 'N';
                        }
                        if (j + 1 < lair.GetLength(0) && lair[j + 1, k] != 'B')
                        {
                            lair[j + 1, k] = 'N';
                        }
                    }
                }
            }
            for (int j = 0; j < lair.GetLength(0); j++)
            {
                for (int k = 0; k < lair.GetLength(1); k++)
                {
                    if (lair[j, k] == 'N')
                    {
                        lair[j, k] = 'B';
                    }
                }
            }
        }
    }
}
