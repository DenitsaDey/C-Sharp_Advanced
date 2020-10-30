using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if(input[0]>=48 && input[0] <= 57)
                {
                    vip.Add(input);
                }
                else
                {
                    guests.Add(input);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                if(input[0] >= 48 && input[0] <= 57)
                {
                    vip.Remove(input);
                }
                else
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }
                Console.WriteLine(guests.Count + vip.Count);
            if(vip.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vip));
            }
            if(guests.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, guests));
            }
        }
    }
}
