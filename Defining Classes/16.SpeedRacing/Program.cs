using System;
using System.Collections.Generic;

namespace _16.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> race = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car current = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                race.Add(input[0], current);
            }
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] command = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = command[1];
                double km = double.Parse(command[2]);
                race[carModel].DriveCar(km);
            }
            foreach (var car in race)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}
