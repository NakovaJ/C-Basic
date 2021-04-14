using System;
using CompanyLibrary.CompanyClassModels;
using CompanyLibrary.CompanyEnums;
using System.Linq;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FIRST PART OF TASK
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

            #endregion

            #region
            Console.WriteLine("---------SECOND PART OF TASK-------");
            Manager Dann = new Manager("Dann", "Kohr", 2000);
            Manager Rob = new Manager("Rob", "Kohr", 1600);
            Contractor John = new Contractor("John", "Smith", 30, 15,Dann);
            Contractor Alex = new Contractor("Alex", "Sherill", 20, 13, Rob);
            SalesPerson Marry = new SalesPerson("Marry", "Moskovic", 2500);

            Employee[] companyWith2Managers2COntractorsAndOneSalesPerson = new Employee[]
            {
                Dann,
                Rob,
                John,
                Alex,
                Marry
            };
            foreach(Employee person in companyWith2Managers2COntractorsAndOneSalesPerson)
            {
                Console.WriteLine($"{person.FirstName} receives salary of {person.GetSalary()}$");
            }
          
            SalesPerson bob = new SalesPerson("Bob", "Bobert", 1500);
            Manager rick = new Manager("Rick", "Rickert", 1234);
            Contractor mona = new Contractor("Mona", "Monalisa", 120, 10, rick);
            Employee igor = new Employee("Igor", "Igorsky", CompanyRole.Other, 1000);
            SalesPerson lea = new SalesPerson("lea", "Leova", 3000);

            Employee[] workingForRon = new Employee[] { bob, rick, mona, igor, lea };

            CEO Ron = new CEO("Ron", "Ronsky", 1500, 5, 580,workingForRon);
            Ron.PrintInfo();
            Ron.PrintEmployees();
            Ron.GetSalary();




            #endregion

        }
    }
}
