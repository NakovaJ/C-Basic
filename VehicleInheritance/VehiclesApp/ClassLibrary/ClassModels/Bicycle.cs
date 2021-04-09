using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.ClassModels
{
    public class Bicycle:WheeledVehicle
    {
        int NoOfSpeeds { get; set; }
        bool IsElectric { get; set; }
        
        public Bicycle() : base("Bicycle")
        {

        }

        public void Ride()
        {
            Console.WriteLine($"Riding this {Type} is amazing and so fun!");
        }
        public override void Repair()
        {
            Console.WriteLine("Bicycles in general are easy for maintaing and the reparing costs are very low!");
        }
    }
}
