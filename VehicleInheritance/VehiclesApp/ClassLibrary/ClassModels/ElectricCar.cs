using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.ClassModels
{
   public class ElectricCar:Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }
        public bool IsCurrentlyOnBattery { get; set; }

        public ElectricCar() : base(EngineType.ElectricCar) { }

        public void Recharge()
        {
            Console.WriteLine(BatteryPercentage < 30 ? "Recharge your car immediately!" : "No worries you have quite enough battery, keep driving!");

        }

        public void SetMaxSpeed()
        {
            if (IsCurrentlyOnBattery)
            {
                MaxSpeed = 150;
            }
            else
            {
                MaxSpeed = 220;
            }
            
        }
        public override void Drive()
        {
            Console.WriteLine($"Driving this {TypeOfEngine} is cool and the max speed is {MaxSpeed}");
        }
    }
}
