using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;


namespace ClassLibrary.ClassModels
{
    public class Car:WheeledVehicle
    {
        public EngineType TypeOfEngine { get; set; }
        public int FuelCOnsumption { get; set; }
        public int NoOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public Car() : base("Car") { }

        public Car(EngineType someType)
        {
            TypeOfEngine = someType;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"The {TypeOfEngine} is driving with max spped of {MaxSpeed} km/h!");
        }
        public override void Repair()
        {
            Console.WriteLine($"Repairing of {TypeOfEngine} might be needed more often and it it way expensive!");
        }
    }
}
