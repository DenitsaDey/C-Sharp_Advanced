﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _17.RawData
{
    class Engine
    {
        public double Speed { get; set; }
        public double Power { get; set; }

        public Engine(double speed, double power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }
}
