using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Rabbit rabbit)
        {
            if (this.Count < this.Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);
            return data.Remove(rabbit);
        }

        public void RemoveSpecies(string species)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Species == species);
            while (data.Contains(rabbit))
            {
                data.Remove(rabbit);
            }
            
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);
            rabbit.Available = false;
            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = data.Where(r => r.Species == species).ToArray();
            foreach (var rabbit in rabbits)
            {
                if (data.Contains(rabbit))
                {
                    rabbit.Available = false;
                }
            }
            return rabbits;
        }

        public string Report()
        {
            return $"Rabbits available at {this.Name}:{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine, data.Where(r => r.Available == true))}";
        }
    }
}
