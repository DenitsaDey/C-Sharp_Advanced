using System;
using System.Linq;

namespace _17_Dec_Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int presents = m;

            int n = int.Parse(Console.ReadLine());
            char[,] neighbourhood = new char[n, n];
            fillMatrix(neighbourhood);

            int santaRow = -1;
            int santaCol = -1;
            int totalNiceKids = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (neighbourhood[row, col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    if(neighbourhood[row, col] == 'V')
                    {
                        totalNiceKids++;
                    }
                }
            }
            int niceKidsLeft = totalNiceKids;

            string input = string.Empty;
            while ((input = Console.ReadLine())!= "Christmas morning" && presents > 0)
            {
                neighbourhood[santaRow, santaCol] = '-';
                switch (input)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }
                char santaPosition = neighbourhood[santaRow, santaCol];
                if(santaPosition == 'V')
                {
                    presents--;
                    niceKidsLeft--;
                }
                if (santaPosition == 'C')
                {
                    if(neighbourhood[santaRow - 1, santaCol] != '-')
                    {
                        presents--;
                        if(neighbourhood[santaRow - 1, santaCol] == 'V')
                        {
                            niceKidsLeft--;
                        }
                        neighbourhood[santaRow - 1, santaCol] = '-';
                    }
                    if (neighbourhood[santaRow, santaCol + 1] != '-')
                    {
                        presents--;
                        if (neighbourhood[santaRow, santaCol+1] == 'V')
                        {
                            niceKidsLeft--;
                        }
                        neighbourhood[santaRow, santaCol + 1] = '-';
                    }
                    if (neighbourhood[santaRow + 1, santaCol] != '-')
                    {
                        presents--;
                        if (neighbourhood[santaRow + 1, santaCol] == 'V')
                        {
                            niceKidsLeft--;
                        }
                        neighbourhood[santaRow + 1, santaCol] = '-';
                    }
                    if (neighbourhood[santaRow, santaCol - 1] != '-')
                    {
                        presents--;
                        if (neighbourhood[santaRow, santaCol - 1] == 'V')
                        {
                            niceKidsLeft--;
                        }
                        neighbourhood[santaRow, santaCol - 1] = '-';
                    }
                }
                neighbourhood[santaRow, santaCol] = 'S';
            }
            if (presents <= 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            printMatrix(neighbourhood);
            if(niceKidsLeft <= 0)
            {
                Console.WriteLine($"Good job, Santa! {totalNiceKids} happy nice kid/s.");
            }
            else if (niceKidsLeft > 0)
            {
                Console.WriteLine($"No presents for {niceKidsLeft} nice kid/s.");
            }
        }

        private static void printMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void fillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
