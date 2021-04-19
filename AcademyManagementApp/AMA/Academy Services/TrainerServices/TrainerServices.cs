using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;
using ClassLibrary.Models;
using System.Linq;
using System.ComponentModel;

namespace Academy_Services.TrainerServices
{
    public class TrainerServices
    {
        //Basically doing the custom login for trainer
        public static Trainer DisplayTrainerLogin(List<Member> allUsers)
        {
            for (; ; )
            {
                Console.Clear();

                Console.WriteLine("Welcome to trainer login page!");
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to out of the Academy Management App");
                Console.WriteLine();
                Console.WriteLine("Please enter your username!");
                string userNameOfUser = Console.ReadLine();
                if (userNameOfUser == "x") return null;

                Console.WriteLine("Please enter your password!");
                string passwordOfUser = Console.ReadLine();
                if (passwordOfUser == "x") return null;

                Member needed = allUsers
                                        .Where(x => x.UserName == userNameOfUser)
                                        .SingleOrDefault();
                if (needed.Role == AcademyRole.Trainer)
                {
                    Trainer trainerLogged = (Trainer)needed;

                    if (trainerLogged == null || trainerLogged.Password != passwordOfUser)
                    {

                        Console.WriteLine("Sorry no such a user!");
                        Console.WriteLine("Please try again!");
                        continue;
                    }
                    else return trainerLogged;
                }
                else continue;



            }


        }

        // //The display basic menu when student logged in
        public static void TrainerDisplayMenu(Trainer trainerLoged)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"{trainerLoged.FirstName} you have successfully logged in!");
            Console.WriteLine();
            Console.WriteLine("Enter 1 ---------> to check Personal Info");
            Console.WriteLine("Enter 2 ---------> to display all the subjects you teach!");
            Console.WriteLine("Enter 3 ---------> to display the current subject you teach!");
            Console.WriteLine("Enter 4 ---------> to check the group you are teachin in!");
            Console.WriteLine("Enter x ---------> to log out of the Academy Management App");
        }


        //Display trainers personal info
        public static void DisplayTrainerInfo(Trainer trainerLogged)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to out of the Academy Management App");
                Console.WriteLine();
                Console.WriteLine("Your Personal Info:");
                Console.WriteLine();

                trainerLogged.GetGeneralInfo();
                string userInput = Console.ReadLine();
                if (userInput == "x") break;
            } 
        }

        //Display subject trainer teaches
        public static void DisplaySubjectsTeaching(Trainer trainerLogged)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to out of the Academy Management App");
                Console.WriteLine();
                Console.WriteLine("The subjects, you are assigned as a trainer this year:");
                Console.WriteLine();

                trainerLogged.GetSubjectsTeaching();
                string userInput = Console.ReadLine();
                if (userInput == "x") break;
            }
        }

        //Display Current Subject
        public static void DisplayCurrentSubject(Trainer trainerLogged)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to out of the Academy Management App");
                Console.WriteLine();
                if (trainerLogged.CurentSubject() == AcademySubject.none)
                {
                    Console.WriteLine("You have no current subject teaching!");
                }
                else
                {
                    Console.WriteLine($"The current subject you teach is: {trainerLogged.CurentSubject()}!");
                    Console.WriteLine();

                    Console.WriteLine($"Your assistant for this subject is {trainerLogged.AssistentName()}!");
                    
                }
                
                string userInput = Console.ReadLine();
                if (userInput == "x") break;
            }
        }

        //Displaying Trainer's group he/she is currently teaching in
        public static void CheckYourGroup(Trainer trainerLogged, List<Member> allUsers)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine();
                if (trainerLogged.CurentSubject() == AcademySubject.none)
                {
                    Console.WriteLine("You are not teaching in any group currently!");
                }
                else
                {
                    Console.WriteLine($"You are teaching in {trainerLogged.Group} Group!");
                    Console.WriteLine();
                    List<Member> studentsBelongingToGroup = allUsers
                                                  .Where(x => x.Role == AcademyRole.Student)
                                                  .Where(x => x.Group == trainerLogged.Group)
                                                  .ToList();


                    Console.WriteLine("STUDENTS IN THIS GROUP ARE:");
                    for (int i = 0; i < studentsBelongingToGroup.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{studentsBelongingToGroup[i].FirstName} {studentsBelongingToGroup[i].LastName}");

                    }

                  
                }
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                string enteredInput = Console.ReadLine();
                if (enteredInput == "x") break;

            }
        }
    }
}
