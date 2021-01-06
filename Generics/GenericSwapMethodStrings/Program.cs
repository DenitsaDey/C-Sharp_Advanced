using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxStore<string> boxStore = new BoxStore<string>();
            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxStore.AddBox(box);
            }
            int[] index = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            boxStore.SwapBoxes(index[0], index[1]);
            Console.WriteLine(boxStore.ToString());
        }
    }
}
