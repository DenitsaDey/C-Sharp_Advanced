using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine())!= "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if(command[0] == "IN")
                {
                    parkingLot.Add(command[1]);
                }
                else if(command[0] == "OUT")
                {
                    if (parkingLot.Contains(command[1]))
                    {
                        parkingLot.Remove(command[1]);
                    }
                }
            }
            if(parkingLot.Count != 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
