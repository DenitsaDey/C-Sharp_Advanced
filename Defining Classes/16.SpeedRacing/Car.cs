using System;
using System.Collections.Generic;
using System.Text;

namespace _16.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public void DriveCar(double distnace)
        {
            double result = this.FuelAmount - (this.FuelConsumptionPerKm * distnace);
            if(result >= 0)
            {
                this.FuelAmount = result;
                this.TravelledDistance += distnace;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive"); 
            }
        }
    }
}
