using System;
using System.Collections.Generic;
using System.Text;
using CompanyLibrary.CompanyEnums;

namespace CompanyLibrary.CompanyClassModels
{
   public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CompanyRole Role { get; set; }  
        protected double Salary { get; set; }
        
        public Employee() { }
        public Employee(string nameOfEmployee,string lastNameOfEmployee,CompanyRole roleOfEmployee,double salaryOfEmploye)
        {
            FirstName = nameOfEmployee;
            LastName = lastNameOfEmployee;
            Role = roleOfEmployee;
            Salary = salaryOfEmploye;
        }
        public Employee(double salaryOfEmployee)
        {
            Salary = salaryOfEmployee;
            Role = CompanyRole.Sales;
        }
       
        public void PrintInfo()
        {
            Console.WriteLine($"The employee {FirstName} {LastName} is on {Role} position and currently receives salary of {Salary}$.");
        }
        public virtual double GetSalary()
        {
             return Salary;
        }
    }
}
