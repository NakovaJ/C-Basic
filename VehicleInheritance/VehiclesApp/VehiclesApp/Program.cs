using System;
using ClassLibrary.ClassModels;
using ClassLibrary.Enums;




namespace VehiclesApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Vehicle myCar = new Vehicle(1234, "Porsche", "IDontCareAboutTheModel");
            myCar.PrintInfo();
            WheeledVehicle myBicycle = new WheeledVehicle()
            {
                Id = 1001,
                Manufacturer = "Trek",
                Model = "Mount Bike"
            };
            myBicycle.PrintInfo();
            myBicycle.Repair();

            Bicycle myRealBicycle = new Bicycle();
        
            myRealBicycle.Repair();

            Car myFirstCar = new Car();
            myFirstCar.TypeOfEngine = EngineType.Car;
            myFirstCar.MaxSpeed = 200;
            myFirstCar.Drive();
            myFirstCar.Repair();

            ElectricCar myElectricCar = new ElectricCar();
            myElectricCar.MaxSpeed=120;
            myElectricCar.BatteryPercentage = 20;
            myElectricCar.SetMaxSpeed();
            myElectricCar.Drive();
            myElectricCar.Recharge();
        }
    }
}
