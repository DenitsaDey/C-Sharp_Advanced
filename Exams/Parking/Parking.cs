using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Car car)
        {
            if (Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = data.Where(c => c.Manufacturer == manufacturer).FirstOrDefault(c => c.Model == model);
            return data.Remove(car);
        }

        public Car GetLatestCar()
        {
            if (this.Count == 0)
            {
                return null;
            }
            else
            {
                Car car = data.OrderByDescending(c => c.Year).FirstOrDefault();
                return car;
            }
        }
        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.Where(c => c.Manufacturer == manufacturer).FirstOrDefault(c => c.Model == model);
            if (data.Contains(car))
            {
                return car;
            }
            return null;
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            data.ForEach(c => sb.AppendLine(c.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
