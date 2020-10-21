using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;
        
        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            data = new List<Present>();
        }
        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Present present)
        {
           if(Capacity > Count)
            {
                data.Add(present);
            }          
        }

        public bool Remove(string name)
        {
            Present present = data.FirstOrDefault(x => x.Name == name);
            return data.Remove(present);
        }

        public Present GetHeaviestPresent()
        {
            Present present = data.OrderByDescending(p => p.Weight).FirstOrDefault();
            return present;
        }

        public Present GetPresent(string name)
        {
            Present present = data.FirstOrDefault(x => x.Name == name);
            return present;
        }

        public string Report()
        {
            return $"{this.Color} bag contains:{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine, data)}";
            
        }
    }
}
