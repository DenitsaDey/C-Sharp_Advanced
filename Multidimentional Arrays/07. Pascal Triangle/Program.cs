using System;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] triangle = new long[rows][];
            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                triangle[i][i+1 -1] = 1;
                if (rows > 2)
                {
                    for (int j = 1; j < triangle[i].Length - 1; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j-1] + triangle[i - 1][j];
                    }
                }
                Console.WriteLine(string.Join(" ", triangle[i]));
            }           
        }
    }
}
