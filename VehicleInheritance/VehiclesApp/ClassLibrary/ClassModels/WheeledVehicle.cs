using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ClassModels
{
    public class WheeledVehicle:Vehicle
    {
        public int NoOfWheels { get; set; }
        public string Type { get; set; }

        public WheeledVehicle()
        {
            Console.WriteLine("I am base constructor for Wheeled Vehicle and I'm constructing a vehicle!");

        }
        public WheeledVehicle(string type)
        {
            Type = type;
            Console.WriteLine("I am a second constructor for WheeledVehicle and I'm constructing a vehicle!");

        }

        public virtual void Repair()
        {
            Console.WriteLine($"This {Type} needs often repairs!");
        }
        


    }
}
