using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegisteration { get; set; }
       public  AppRole Role { get; set; }
        public Member() {}
        public Member(AppRole Employee ){
            Role = AppRole.Employee;
        }

        public Member(string name,string lastName,int age,string userName,string password,int phone,DateTime registrationDate)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phone;
            DateOfRegisteration = registrationDate;
        }
    


        public void DisplayInfo()
        {
            Console.WriteLine($"User:{FirstName} {LastName}-----> Registered on:{DateOfRegisteration}");

        }


    }
}
