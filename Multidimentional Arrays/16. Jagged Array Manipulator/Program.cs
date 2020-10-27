using System;
using System.Linq;

namespace _16._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] myJagged = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                myJagged[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();
            }
            for (int i = 0; i < rows - 1; i++)
            {
                if (myJagged[i].Length == myJagged[i + 1].Length)
                {
                    for (int j = 0; j < myJagged[i].Length; j++)
                    {
                        myJagged[i][j] *= 2;
                        myJagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < myJagged[i].Length; j++)
                    {
                        myJagged[i][j] /= 2;
                    }
                    for (int j = 0; j < myJagged[i + 1].Length; j++)
                    {
                        myJagged[i + 1][j] /= 2;
                    }
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                bool valid = false;
                if (row >= 0 && row < myJagged.Length
                        && col >= 0 && col < myJagged[row].Length)
                {
                    valid = true;
                }

                if (command[0] == "Add" && valid)
                {
                    myJagged[row][col] += value;
                }
                else if (command[0] == "Subtract" && valid)
                {
                    myJagged[row][col] -= value;
                }
            }
            foreach (var row in myJagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
