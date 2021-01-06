using System;
using System.Linq;

namespace GenericSwapMethodInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxStore<int> boxStore = new BoxStore<int>();
            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxStore.AddBox(box);
            }
            int[] index = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            boxStore.SwapBoxes(index[0], index[1]);
            Console.WriteLine(boxStore.ToString());
        }
    }
}
