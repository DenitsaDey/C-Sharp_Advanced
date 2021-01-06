using System;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxStore<string> boxStore = new BoxStore<string>();
            for (int i = 0; i < n; i++)
            {
                string valueInput = Console.ReadLine();
                Box<string> stringBox = new Box<string>(valueInput);
                boxStore.AddBox(stringBox);
            }

            string value = Console.ReadLine();
            int counter = boxStore.GetCount(value);
            Console.WriteLine(counter);
        }
    }
}
