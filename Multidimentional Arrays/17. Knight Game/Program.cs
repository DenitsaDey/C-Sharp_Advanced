using System;

namespace _17._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string currentRow = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            bool attack = true;
            int removedKs = 0;
            while (attack)
            {
                int attackerRow = -1;
                int attackerCol = -1;
                int maxCounter = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        char current = matrix[i, j];
                        int counter = 0;
                        if (current == 'K')
                        {
                            counter = GetCountAttackedKs(matrix, i, j, counter);

                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                                attackerRow = i;
                                attackerCol = j;
                            }
                        }
                    }
                    
                }
                if (maxCounter == 0)
                {
                    attack = false;
                }
                else
                {
                    matrix[attackerRow, attackerCol] = 'O';
                    removedKs++;
                }
            }
            Console.WriteLine(removedKs);
        }

        private static int GetCountAttackedKs(char[,] matrix, int i, int j, int counter)
        {
            if (i - 2 >= 0 && j - 1 >= 0 && matrix[i - 2, j - 1] == 'K')
            {
                counter++;
            }
            if (i - 2 >= 0 && j + 1 < matrix.GetLength(1) && matrix[i - 2, j + 1] == 'K')
            {
                counter++;
            }
            if (i - 1 >= 0 && j - 2 >= 0 && matrix[i - 1, j - 2] == 'K')
            {
                counter++;
            }
            if (i - 1 >= 0 && j + 2 < matrix.GetLength(1) && matrix[i - 1, j + 2] == 'K')
            {
                counter++;
            }
            if (i + 1 < matrix.GetLength(0) && j - 2 >= 0 && matrix[i + 1, j - 2] == 'K')
            {
                counter++;
            }
            if (i + 1 < matrix.GetLength(0) && j + 2 < matrix.GetLength(1) && matrix[i + 1, j + 2] == 'K')
            {
                counter++;
            }
            if (i + 2 < matrix.GetLength(0) && j - 1 >= 0 && matrix[i + 2, j - 1] == 'K')
            {
                counter++;
            }
            if (i + 2 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1) && matrix[i + 2, j + 1] == 'K')
            {
                counter++;
            }

            return counter;
        }
    }
}
