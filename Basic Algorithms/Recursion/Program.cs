using System;
using System.Linq;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = Sum(arr);
            Console.WriteLine(result);
        }

        private static int Sum(int[] arr, int index = 0)
        {
            if(index == arr.Length)
            {
                return 0;
            }
            return arr[index] + Sum(arr, index + 1);
        }
    }
}
