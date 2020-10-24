using System;
using System.Linq;

namespace _19_Aug_Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            fillMatrix(field);

            int polliFlowers = 0;
            int beeRow = -1;
            int beeCol = -1;

            for (int row = 0; row < n; row++)
            {
                bool flag = false;
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                field[beeRow, beeCol] = '.';
                switch (command)
                {
                    case "up":
                        beeRow--;
                        break;
                    case "down":
                        beeRow++;
                        break;
                    case "left":
                        beeCol--;
                        break;
                    case "right":
                        beeCol++;
                        break;
                }
                if(!BeeIsInside(beeRow, beeCol, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                char beePosition = field[beeRow, beeCol];
                if (beePosition == 'O')
                {
                    field[beeRow, beeCol] = 'B';
                }
                else
                {
                    if (beePosition == 'f')
                    {
                        polliFlowers++;
                    }
                    field[beeRow, beeCol] = 'B';
                    command = Console.ReadLine();
                }
            }

            if(polliFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {(5-polliFlowers)} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polliFlowers} flowers!");
            }

            printMatrix(field);

        }
        private static bool BeeIsInside(int beeRow, int beeCol, int n)
        {
            if(beeRow<0 || beeCol <0 || beeRow >= n || beeCol >= n)
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
