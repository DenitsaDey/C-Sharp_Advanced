using System;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();
            double res = DateModifier.GetDaysBetween(dateOne, dateTwo);
            Console.WriteLine(res);
        }
    }
}
