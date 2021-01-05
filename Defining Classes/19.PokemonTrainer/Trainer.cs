using System;
using System.Collections.Generic;
using System.Text;

namespace _19.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Collection { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Collection = new List<Pokemon>();
        }
    }
}
