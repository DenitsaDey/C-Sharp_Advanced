using System;

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
		private double fuelQuantity;

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}
		private double fuelConsumption;

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

		public void Drive(double distance)
		{
			double result = this.FuelQuantity - (this.FuelConsumption * distance/100);
			if (result <= 0)
			{
				System.Console.WriteLine("Not enough fuel to perform this trip!");
			}
			else
			{
				this.FuelQuantity -= this.FuelConsumption * distance/100;
			}
		}
		public string WhoAmI()
		{
			return $"Make: {this.Make}{Environment.NewLine}Model: {this.Model}{Environment.NewLine}Year: {this.Year}{Environment.NewLine}Fuel: {this.FuelQuantity:f2}L";
		}

		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.FuelQuantity = 200;
			this.FuelConsumption = 10;
		}

		public Car(string make, string model, int year)
			: this()
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
			this.fuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
		}

		public Engine Engine { get; set; }
		public Tire[] Tires { get; set; }
		public Tire[] Tire { get; set; }

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
			:this(make, model, year, fuelQuantity, fuelConsumption)
		{
			this.Engine = engine;
			this.Tires = tires;
		}
		
	}
}
