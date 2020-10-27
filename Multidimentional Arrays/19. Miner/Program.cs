using System;

namespace _19._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[,] matrix = new string[size, size];
            for (int i = 0; i < size; i++)
            {
                string[] currentInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentInput[j];
                }
            }
            int startRow = -1;
            int startCol = -1;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == "s")
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            int coalCollected = 0;
            int coalAvailable = 0;
            foreach (string symbol in matrix)
            {
                if (symbol == "c")
                {
                    coalAvailable++;
                }
            }
            bool flag = true;
            int currentRow = startRow;
            int currentCol = startCol;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "left" && currentCol - 1 >= 0)
                {
                    currentCol--;
                    if (matrix[currentRow, currentCol] == "c")
                    {
                        matrix[currentRow, currentCol] = "*";
                        coalCollected++;
                        if(coalCollected == coalAvailable)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                            break;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                        flag = false;
                        break;
                    }
                }
                else if (command[i] == "right" && currentCol + 1 < size)
                {
                    currentCol++;
                    if (matrix[currentRow, currentCol] == "c")
                    {
                        matrix[currentRow, currentCol] = "*";
                        coalCollected++;
                        if (coalCollected == coalAvailable)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                            break;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                        flag = false;
                        break;
                    }
                }
                else if (command[i] == "up" && currentRow - 1 >= 0)
                {
                    currentRow--;
                    if (matrix[currentRow, currentCol] == "c")
                    {
                        matrix[currentRow, currentCol] = "*";
                        coalCollected++;
                        if (coalCollected == coalAvailable)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                            break;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                        flag = false;
                        break;
                    }
                }
                else if (command[i] == "down" && currentRow + 1 < size)
                {
                    currentRow++;
                    if (matrix[currentRow, currentCol] == "c")
                    {
                        matrix[currentRow, currentCol] = "*";
                        coalCollected++;
                        if (coalCollected == coalAvailable)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                            break;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                        flag = false;
                        break;
                    }
                }
            }
            if (coalAvailable > coalCollected && flag)
            {
                Console.WriteLine($"{coalAvailable - coalCollected} coals left. ({currentRow}, {currentCol})");
            }
        }
    }
}
