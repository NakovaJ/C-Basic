using System;
using System.Collections.Generic;
using System.Text;
using CompanyLibrary.CompanyEnums;
using CompanyLibrary.CompanyClassModels;

namespace CompanyLibrary.CompanyClassModels
{
    public class SalesPerson:Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson() :base(500.00) { }
        public SalesPerson(string name,string lastName,double success)
        {
            FirstName = name;
            LastName = lastName;
            Salary = 500;
            SuccessSaleRevenue = success;
        }
        public void AddSuccessRevenue(double additionalRevenue)
        {
            SuccessSaleRevenue += additionalRevenue;
        }
        public override double GetSalary()
        {
           
            if (SuccessSaleRevenue <= 2000)
            {
                Salary = Salary + 500;
               
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                Salary = Salary + 1000;
                
            }
            else
            {
                Salary = Salary + 1500;
            }
            return Salary;
        }



    }
}
