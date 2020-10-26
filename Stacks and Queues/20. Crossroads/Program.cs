using System;
using System.Collections.Generic;

namespace _20._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenTime = int.Parse(Console.ReadLine());
            int initialGreenTime = greenTime;
            int windowTime = int.Parse(Console.ReadLine());
            string input = string.Empty;
            bool safe = true;
            int counterCars = 0;
            Queue<string> cars = new Queue<string>();
            while ((input = Console.ReadLine())!= "END")
            {
                if(input != "green")
                {
                    cars.Enqueue(input);
                }
                else if(input == "green" && cars.Count != 0)
                {
                    string currentCar = cars.Dequeue();
                    greenTime = initialGreenTime;
                    bool queue = true;
                    while(currentCar.Length < greenTime)
                    {
                        greenTime -= currentCar.Length;
                        counterCars++;
                        if(cars.Count != 0)
                        {
                            currentCar = cars.Dequeue();
                        }
                        else
                        {
                            queue = false;
                            break;
                        }
                    }
                    if (queue)
                    {
                        int index = greenTime + windowTime;
                        if (index < currentCar.Length)
                        {
                            safe = false;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[index]}.");
                            break;
                        }
                        else
                        {
                            counterCars++;
                        }
                    }
                }
            }
            if (safe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counterCars} total cars passed the crossroads.");
            }
        }
    }
}
