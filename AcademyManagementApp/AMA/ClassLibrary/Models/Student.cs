using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;
using ClassLibrary.Models;

namespace ClassLibrary.Models
{
    public class Student : Member
    {
        public Dictionary<AcademySubject, int> SubjectsAlreadyPassedWithGrades { get; set; }
        public AcademySubject SubjectCurrentllyAttened { get; set; }

      
        public Student():base(AcademyRole.Student)
        {

        }
        public Student(string name,string lastName,int age,string userName,string password,string email,int phone,Dictionary<AcademySubject,int>passedSubjects,AcademySubject curentSubject,AcademyGroup group)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phone;
            Role = AcademyRole.Student;
            SubjectsAlreadyPassedWithGrades = passedSubjects;
            SubjectCurrentllyAttened = curentSubject;
            Group = group;
        }

        public void GetGeneralInfo()
        {
            Console.WriteLine(string.Format("STUDENT:{0} {1}", FirstName, LastName));
            Console.WriteLine(string.Format("AGE: {0}",Age));
            Console.WriteLine(string.Format("EMAIL: {0}", Email));
            Console.WriteLine(string.Format("PHONE NUMBER: {0:0##-###-###}", PhoneNumber));
        }
        public void GetPrivateInfo()
        {
            Console.WriteLine($"USERNAME: {UserName}");
            Console.WriteLine($"PASWORD: {Password}");

        }
        public void GetPassedSubjectsWithGrades()
        {
            foreach (var (key, value) in SubjectsAlreadyPassedWithGrades)
            {
                Console.WriteLine($"SUBJECT: {key} ---------> GRADE: {value}");
            }
        }
       
    }
}
