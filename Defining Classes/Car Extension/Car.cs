using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double fuleQuantity;

        public double FuelQuantity
        {
            get { return fuleQuantity; }
            set { fuleQuantity = value; }
        }

        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            var fuelLeft = this.FuelQuantity - (this.FuelConsumption * distance);
            if (fuelLeft > 0)
            {
                this.FuelQuantity = fuelLeft;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}{Environment.NewLine}" +
                $"Model: {this.Model}{Environment.NewLine}" +
                $"Year: {this.Year}{Environment.NewLine}" +
                $"Fuel: {this.FuelQuantity:F2}L";
        }
    }
}
