using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;

        

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Parking(int capacity)
        {
            this.cars = new Dictionary<string, Car>();
            this.Capacity = capacity;
        }
        public string AddCar(Car car)
        {
            if (this.cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (this.cars.Count == this.Capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

        }
        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.ContainsKey(registrationNumber))
            {
                this.cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            if (this.cars.ContainsKey(registrationNumber))
            {
                return cars[registrationNumber];
            }
            else
            {
                return null;
            }
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            for (int i = 0; i < registrationNumbers.Count; i++)
            {

                if (this.cars.ContainsKey(registrationNumbers[i]))
                {
                    this.cars.Remove(registrationNumbers[i]);
                }

            }
        }
        public int Count => this.cars.Count;

    }
}
