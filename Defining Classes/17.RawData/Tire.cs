using System;
using System.Collections.Generic;
using System.Text;

namespace _17.RawData
{
    public class Tire
    {
        public double Pressure { get; set; }
        public double Age { get; set; }

        public Tire(double pressure, double age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
}
