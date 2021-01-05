using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double engineSpeed = double.Parse(carInfo[1]);
                double enginePower = double.Parse(carInfo[2]);
                double cargoWeight = double.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double t1Pressure = double.Parse(carInfo[5]);
                double t1Age = double.Parse(carInfo[6]);
                double t2Pressure = double.Parse(carInfo[7]);
                double t2Age = double.Parse(carInfo[8]);
                double t3Pressure = double.Parse(carInfo[9]);
                double t3Age = double.Parse(carInfo[10]);
                double t4Pressure = double.Parse(carInfo[11]);
                double t4Age = double.Parse(carInfo[12]);


                Tire t1 = new Tire(t1Pressure, t1Age);
                Tire t2 = new Tire(t2Pressure, t2Age);
                Tire t3 = new Tire(t3Pressure, t3Age);
                Tire t4 = new Tire(t4Pressure, t4Age);
                Car currentCar = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), t1, t2, t3, t4);
                cars.Add(currentCar);
            }
            string command = Console.ReadLine();
            if(command == "fragile")
            {              
                var sortedCars = cars.Where(x => x.cargo.Type == "fragile").Where(x => x.tireset.Any(t=> t.Pressure < 1)).ToList();
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if(command == "flamable")
            {
                var sortedCars = cars.Where(x => x.cargo.Type == "flamable").Where(x => x.engine.Power > 250).ToList();
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        } 
    }
}
