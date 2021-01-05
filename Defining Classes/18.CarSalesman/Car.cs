using System;
using System.Collections.Generic;
using System.Text;

namespace _18.CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine carEngine)
        {
            this.Model = model;
            this.CarEngine = carEngine;
        }

        public Car(string model, Engine carEngine, string weight, string color)
            :this(model, carEngine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"{Model}:{Environment.NewLine}" +
                $"   {CarEngine.Model}:{Environment.NewLine}" +
                $"      Power: {CarEngine.Power}{Environment.NewLine}" +
                $"      Displacement: {CarEngine.Displacement}{Environment.NewLine}" +
                $"      Efficiency: {CarEngine.Efficiency}{Environment.NewLine}" +
                $"  Weight: {Weight}{Environment.NewLine}" +
                $"  Color: {Color}";
        }
    }
}
