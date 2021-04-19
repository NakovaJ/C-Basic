using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;
using ClassLibrary.Models;

namespace ClassLibrary.Models
{
    public class Trainer:Member
    {
        List<AcademySubject> SubjectsTeaching { get; set; }
        AcademySubject CurrenSubjectTeaching { get; set; }
      
        string Assistent { get; set; }

        public Trainer() : base(AcademyRole.Trainer)
        {

        }
        public Trainer(string name, string lastName, int age, string userName, string password, string email, int phone,List<AcademySubject>teachingSubjects,AcademySubject current,AcademyGroup group,string assistent) {
            FirstName = name;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phone;
            Role = AcademyRole.Trainer;
            SubjectsTeaching = teachingSubjects;
            CurrenSubjectTeaching = current;
            Group = group;
            Assistent = assistent;
        }

        public void GetGeneralInfo()
        {
            Console.WriteLine(string.Format("TRAINER:{0} {1}", FirstName, LastName));
            Console.WriteLine(string.Format("AGE: {0}", Age));
            Console.WriteLine(string.Format("EMAIL: {0}", Email));
            Console.WriteLine(string.Format("PHONE NUMBER: {0:0##-###-###}", PhoneNumber));
        }
        public void GetAssistent()
        {
            Console.WriteLine($"ASSISTANT: {Assistent}");
        }
        public string AssistentName()
        {
            return Assistent;
        }
        public void GetPrivateInfo()
        {
            Console.WriteLine($"USERNAME: {UserName}");
            Console.WriteLine($"PASWORD: {Password}");

        }
        public void GetSubjectsTeaching()
        {
           // SubjectsTeaching.ForEach(x => Console.WriteLine(x));
           for(int i = 0; i < SubjectsTeaching.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{SubjectsTeaching[i]}");
            }
        }
        public AcademySubject CurentSubject()
        {
            return CurrenSubjectTeaching;
        }
      
    }
}
