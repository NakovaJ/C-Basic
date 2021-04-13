using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes
{
    public class Employee:Member
    {
        private double Salary { get; set; }
        //should be default 300 euro
        public int HoursPerMonth { get; set; }
       public  Nullable<double> Bonus { get; set; }
       

        public Employee() 
        {
            Role = AppRole.Employee;
        }
        public Employee(string name, string lastName, 
            int age, string userName, string password,
            string registrationDate, int phone,int hoursPerMonth
            )
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phone;
            DateOfRegisteration = DateTime.Parse(registrationDate);
            Role = AppRole.Employee;
            Salary = 300;
            Role = AppRole.Employee;
            HoursPerMonth = hoursPerMonth;

        }

      

        public void SetBonus()
        {
            if (HoursPerMonth >= 160)
            {
                Bonus = 0.3;
            }
            else
            {
                Bonus = null;
            }
        }
        public void SetSalary()
        {
            if (Bonus != null)
            {
            Salary =(double)( Bonus * HoursPerMonth)+Salary;
            }
           
        }

    }
}
