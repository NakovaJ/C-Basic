using System;
using CompanyLibrary.CompanyClassModels;
using CompanyLibrary.CompanyEnums;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our company");
            Employee jelena = new Employee
            {
                FirstName = "Jelena",
                LastName = "Nakova",
                Role = CompanyRole.Other,
               

            };
            jelena.GetSalary();
            jelena.PrintInfo();
            Employee marjan = new Employee("Marjan", "Nakov", CompanyRole.Sales, 200.00);
            marjan.PrintInfo();
            marjan.GetSalary();
            marjan.PrintInfo();
            
            SalesPerson mihaela = new SalesPerson("Mihaela", "Nakova", 125.00);
            
            mihaela.PrintInfo();
           Console.WriteLine( mihaela.GetSalary());

            SalesPerson marko = new SalesPerson("Marko", "Nakov", 2001);
            marko.PrintInfo();
            Console.WriteLine(marko.GetSalary());

            Manager mila = new Manager("Mila", "Apostolova", 1000);
            mila.PrintInfo();
            mila.AddBonus(1200);
            Console.WriteLine(mila.GetSalary());
            
            
        }
    }
}
