using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;
using ClassLibrary.Models;
using System.Linq;

namespace Academy_Services.StudentServices
{
   public static class StudentServices
    {
        //Checks username and password when student logges in
        public static Student DisplayStudentLogin(List<Member>allUsers)
        {
            for(; ; )
            {
                Console.Clear();

                Console.WriteLine("Welcome to student login page!");
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to out of the Academy Management App");
                Console.WriteLine();
                Console.WriteLine("Please enter your username!");
                string userNameOfUser = Console.ReadLine();
                if (userNameOfUser == "x") return null ;

                Console.WriteLine("Please enter your password!");
                string passwordOfUser = Console.ReadLine();
                if (passwordOfUser == "x") return null ;

                Member needed = allUsers
                                        .Where(x => x.UserName == userNameOfUser)
                                        .SingleOrDefault();
                if (needed.Role == AcademyRole.Student)
                {
                    Student studentLogged = (Student)needed;
                    if (studentLogged == null || studentLogged.Password != passwordOfUser)
                    {

                        Console.WriteLine("Sorry no such a user!");
                        Console.WriteLine("Please try again!");
                        continue;
                    }
                    else return studentLogged;
                }
               
                
               
            }
            
            
        }

        //Displays the subject that the student already passed
        public static void DisplayPassedSubjects(Student studentLoged)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Your passed subjects with the appropriate grades are:");
                Console.WriteLine();
                studentLoged.GetPassedSubjectsWithGrades();
                Console.WriteLine();
                List<int> grades = new List<int>();
                foreach (var (key,value) in studentLoged.SubjectsAlreadyPassedWithGrades)
                {
                    grades.Add(value);
                }
                double averageGrade = grades.Average();

                 Console.WriteLine();
                 Console.WriteLine($"Your AVERAGE GRADE  so far is {averageGrade} ");
                Console.WriteLine();

                Console.WriteLine("Enter x ---------> to go back!");
                string enteredInput = Console.ReadLine();
                if (enteredInput == "x") break;
            }
        }

        //Displays the current subject that the student is listening
        public static void SubjectsCurrentlyListened(Student studentLoged, List<Member> allUsers)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine($"The subject you are currently listening is {studentLoged.SubjectCurrentllyAttened}");
                Console.WriteLine();
                Trainer trainerOfStudentActive = (Trainer)allUsers
                                                .Where(x => x.Role == AcademyRole.Trainer)
                                                .Where(x => x.Group == AcademyGroup.G4)
                                                .SingleOrDefault();
                Console.WriteLine($"TRAINER for this subject is {trainerOfStudentActive.FirstName}");
                trainerOfStudentActive.GetAssistent();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                string enteredInput = Console.ReadLine();
                if (enteredInput == "x") break;
            }
        }

        //Displays all the subject left for listening
        public static void SubjectsLeft(Student studentLoged)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine($"Subject currently listened is: {studentLoged.SubjectCurrentllyAttened}");
                Console.WriteLine();

                Console.WriteLine($"Subjects left are:");
                Console.WriteLine();
                List<AcademySubject> subjectsLeft = new List<AcademySubject>();

                foreach (AcademySubject item in AcademySubject.GetValues(typeof(AcademySubject)))
                {
                    int counter = 0;

                    foreach (var (key, value) in studentLoged.SubjectsAlreadyPassedWithGrades)
                    {

                        if (key != item)
                        {
                            counter++;
                            if (counter == 4)
                            {
                                subjectsLeft.Add(item);

                            }

                            subjectsLeft.Remove(key);


                        }

                    }

                }
                subjectsLeft.Remove(AcademySubject.AdvancedCSharp);
                subjectsLeft.Remove(AcademySubject.none);
                for (int i = 0; i < subjectsLeft.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {subjectsLeft[i]}");
                }

                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                string enteredInput = Console.ReadLine();
                if (enteredInput == "x") break;
            }
        }

        //This method diplays the group and the info for the gorup the student is being in
        public static void CheckYourGroup(Student studentLoged, List<Member> allUsers)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"You are part of {studentLoged.Group} Group!");
                Console.WriteLine();
                Trainer trainerOfStudentActive = (Trainer)allUsers
                                              .Where(x => x.Role == AcademyRole.Trainer)
                                              .Where(x => x.Group == AcademyGroup.G4)
                                              .SingleOrDefault();
                Console.WriteLine($"TRAINER for the current subject is this group is {trainerOfStudentActive.FirstName} {trainerOfStudentActive.LastName}.");
                trainerOfStudentActive.GetAssistent();
                Console.WriteLine();
                List<Member> studentsOfSameGroup = allUsers
                                               .Where(x => x.Role == AcademyRole.Student)
                                               .Where(x => x.Group == studentLoged.Group)
                                               .ToList();
                Console.WriteLine("STUDENTS IN THIS GROUP ARE:");
                for (int i = 0; i < studentsOfSameGroup.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{studentsOfSameGroup[i].FirstName} {studentsOfSameGroup[i].LastName}");

                }

                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                string enteredInput = Console.ReadLine();
                if (enteredInput == "x") break;
            }
        }

        //The display basic menu when student logged in
        public static void StudentDisplayMenu(Student studentLoged)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"{studentLoged.FirstName} you have successfully logged in!");
            Console.WriteLine();
            Console.WriteLine("Enter 1 ---------> to check all the passed subjects and your grades!");
            Console.WriteLine("Enter 2 ---------> to check the subject you are currently listening!");
            Console.WriteLine("Enter 3 ---------> to check your subjects left!");
            Console.WriteLine("Enter 4 ---------> to check your Group");
            Console.WriteLine("Enter x ---------> to log out of the Academy Management App");
        }
    }
}
