using System;
using System.Collections.Generic;
using System.Text;
using CompanyLibrary.CompanyClassModels;
using CompanyLibrary.CompanyEnums;



namespace CompanyLibrary.CompanyClassModels
{
    public class CEO:Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharePrice { get; set; }
        public CEO() 
        {

            Role = CompanyRole.CEO;
        }
        public CEO(string name, string lastname,int salary,double sharePrice,int shares,Employee[] arrayOfEmployees)
        {
            FirstName = name;
            LastName = lastname;
            Salary = salary;
            SharePrice = sharePrice;
            Shares = shares;
            Role = CompanyRole.CEO;
            Employees = arrayOfEmployees;
        }

        public void AddSharePrice(double sharePriceInput)
        {
            SharePrice = sharePriceInput;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("These are the employees working in the company:");
            Console.WriteLine($"Name:{FirstName} {LastName} working as {Role}!");
            foreach(Employee person in Employees)
            {
            Console.WriteLine($"Name:{person.FirstName} {person.LastName} working as {person.Role}!");

            }
        }
        public override double GetSalary()
        {
            Salary = Salary + SharePrice * Shares;
            Console.WriteLine($"Salary of {FirstName} is {Salary}!");
            return Salary;
        }
    }
}
