using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ClassModels
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
            Console.WriteLine("I am base constructor and I'm constructing a vehicle!");
        }
        public Vehicle(int id,string manufacturer,string model)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Console.WriteLine("I am second Vehicle constructor and I'm constructing a vehicle!");

        }
        public void PrintInfo()
        {
            Console.WriteLine($"This is a Vehicle from {Manufacturer}, model:{Model} with ID number {Id}");
        }
    }
}
