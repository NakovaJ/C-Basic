using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_Homework
{
    public class Car
    {
        public Car()
        {
           // Console.WriteLine("I am constructing a new car now!");
        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver DriverName { get; set; }
        public int CalculateSpeed()
        {
            return DriverName.Skill * Speed;
        }

    }
}
