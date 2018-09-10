using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vehicle
    {
        public string Name { get; set; }

        public int Seats { get; set; }
        public string FuelType { get; set; }
        public int FuelQuantity { get; set; }

        public Vehicle(string name)
        {

        }

        public void Refuel(int quantity)
        {
            FuelQuantity += quantity;
        }

     

    }

    class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Rego { get; set; }
        public Car() : base("Camry")
        {

        }

    }

    class Boat : Vehicle
    {
        public string Type { get; set; }
        public int MotorCount { get; set; }
        public Boat() : base("Cool ass Boat")
        {
            this.Type = "SailBoat"
        }

    }
}
