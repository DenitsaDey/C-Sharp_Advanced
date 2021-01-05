using System;
using System.Collections.Generic;
using System.Linq;

namespace _18.CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string power = input[1];
                Engine currentEngine = new Engine(model, power);
                currentEngine.Displacement = "n/a";
                currentEngine.Efficiency = "n/a";
                if (input.Length == 3)
                {
                    int displacement;
                    if(int.TryParse(input[2], out displacement))
                    {
                        currentEngine.Displacement = input[2];
                    }
                    else
                    {
                        currentEngine.Efficiency = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    currentEngine.Displacement = input[2];
                    currentEngine.Efficiency = input[3];
                }
                engines.Add(currentEngine);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int j = 0; j < m; j++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = info[0];
                string engineModel = info[1];
                Car currentCar = new Car(carModel, engines.FirstOrDefault(e => e.Model == engineModel));
                currentCar.Weight = "n/a";
                currentCar.Color = "n/a";
                if (info.Length == 3)
                {
                    int weight;
                    if(int.TryParse(info[2], out weight))
                    {
                        currentCar.Weight = info[2];
                    }
                    else
                    {
                        currentCar.Color = info[2];
                    }
                }
                if (info.Length == 4)
                {
                    currentCar.Weight = info[2];
                    currentCar.Color = info[3];
                }
                cars.Add(currentCar);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
