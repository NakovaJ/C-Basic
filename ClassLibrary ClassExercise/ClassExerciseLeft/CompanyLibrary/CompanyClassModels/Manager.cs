using System;
using System.Collections.Generic;
using System.Text;
using CompanyLibrary.CompanyClassModels;
using CompanyLibrary.CompanyEnums;

namespace CompanyLibrary.CompanyClassModels
{
    public class Manager : Employee
    {
        private double Bonus{get;set;}
        public Manager() {
            Role = CompanyRole.Manager;
                }
        
        public Manager(string name,string secondName,double salary)
        {
            FirstName = name;
            LastName = secondName;
            Role = CompanyRole.Manager;
            Salary = salary;
        }

        public void AddBonus(double additionalBonus)
        {
            Bonus += additionalBonus;
        }
        public override double GetSalary()
        {
            Salary += Bonus;
            return Salary;
        }
    }
}
