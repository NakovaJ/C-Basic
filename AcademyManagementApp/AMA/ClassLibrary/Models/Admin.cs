using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;
using ClassLibrary.Enums;

namespace ClassLibrary.Models
{
    public class Admin:Member
    {
        public Admin() : base(AcademyRole.Admin)
        {

        }
        public Admin(string name, string lastName, int age, string userName, string password, string email, int phone)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phone;
            Role = AcademyRole.Admin;
        }
        public void GetGeneralInfo()
        {
            Console.WriteLine(string.Format("ADMIN:{0} {1}", FirstName, LastName));
            Console.WriteLine(string.Format("AGE: {0}", Age));
            Console.WriteLine(string.Format("EMAIL: {0}", Email));
            Console.WriteLine(string.Format("PHONE NUMBER: {0:0##-###-###}", PhoneNumber));
        }
        public void GetPrivateInfo()
        {
            Console.WriteLine($"USERNAME: {UserName}");
            Console.WriteLine($"PASWORD: {Password}");

        }
    }
}
