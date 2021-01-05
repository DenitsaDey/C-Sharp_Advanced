using System;
using System.Collections.Generic;
using System.Text;

namespace _17.RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public Tire[] tireset { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire t1, Tire t2, Tire t3, Tire t4)
        {
            this.Model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tireset = new Tire[4] { t1, t2, t3, t4 };
        }
    }
}
