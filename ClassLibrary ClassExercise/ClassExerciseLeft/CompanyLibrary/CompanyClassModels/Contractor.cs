using System;
using System.Collections.Generic;
using System.Text;
using CompanyLibrary.CompanyEnums;

namespace CompanyLibrary.CompanyClassModels
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor()
        {
            Role = CompanyRole.Contractor;
        }

        public Contractor(string name,string lastName,double workHours,int payPerHour, Manager responsible) {
            Role = CompanyRole.Contractor;
            FirstName = name;
            LastName = lastName;
            Salary = workHours*payPerHour;
        }

        public override double GetSalary()
        {
           
            return Salary;
        }
    }
}
