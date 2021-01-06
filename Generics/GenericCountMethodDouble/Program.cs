using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxStore<double> boxStore = new BoxStore<double>();
            for (int i = 0; i < n; i++)
            {
                double valueInput = double.Parse(Console.ReadLine());
                Box<double> intBox = new Box<double>(valueInput);
                boxStore.AddBox(intBox);
            }

            double value = double.Parse(Console.ReadLine());
            int counter = boxStore.GetCount(value);
            Console.WriteLine(counter);
        }
    }
}
