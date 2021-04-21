using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;
using ClassLibrary.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Academy_Services.AdminServices
{
    public class AdminServices
    {
        #region Display Login For Admins
        public static Admin DiplayLoginForAdmin(List<Member> allUsers)
        {
            for (; ; )
            {
                Console.Clear();

                Console.WriteLine("Welcome to the admin login page!");
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

                if (needed.Role == AcademyRole.Admin)
                {
                    Admin adminLogged = (Admin)needed;

                    if (adminLogged == null || adminLogged.Password != passwordOfUser)
                    {

                        Console.WriteLine("Sorry no such a user!");
                        Console.WriteLine("Please try again!");
                        continue;
                    }
                    else return adminLogged;
                }
                else continue;



            }
        }
        #endregion


        #region Display For Users

        public static void DisplayUsers(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Display users page");
                Console.WriteLine();
                Console.WriteLine("Enter 1 ---------> to display all Users!");
                Console.WriteLine("Enter 2 ---------> to display only Students!");
                Console.WriteLine("Enter 3 ---------> to display only Trainers!");
                Console.WriteLine("Enter 4 ---------> to display only Admins!");
                Console.WriteLine("Enter x ---------> to go back!");
                string userInput = Console.ReadLine();
                if (userInput == "x") break;
                switch (userInput)
                {
                    case "1":

                        DisplayAllUsers(allUsers);
                        break;
                    case "2":
                        DisplayAllStudents(allUsers);
                        break;
                    case "3":
                        DisplayAllTrainers(allUsers);
                        break;
                    case "4":
                        DisplayAllAdmins(allUsers);
                        break;
                }
            }

        }
        #endregion

        #region Display All Users
        public static void DisplayAllUsers(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("All the users currently active on Academy Management App");

                int i = 0;

                allUsers.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");
                   
                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
            }

        }
        #endregion

        #region Display All Students
        public static void DisplayAllStudents(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("All the students currently active on Academy Management App");
                

                List<Member> allStudents = allUsers.Where(x => x.Role == AcademyRole.Student)
                                    .ToList();
                int i = 0;
                allStudents.ForEach(x =>
        {
            i++;
            Console.WriteLine();
            Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

            Console.WriteLine($"Academy role:{x.Role}");

            Console.WriteLine($"Age {x.Age}");
            Console.WriteLine($"Email {x.Email}");
            Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

            Console.WriteLine($"username and password { x.UserName} {x.Password}");

        });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
            }


        }

        #endregion

        #region Display All Trainers
        public static void DisplayAllTrainers(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("All the trainers currently active on Academy Management App");
                

                List<Member> allTrainers = allUsers.Where(x => x.Role == AcademyRole.Trainer)
                                    .ToList();
                int i = 0;
                allTrainers.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");

                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
            }

        }

        #endregion

        #region Display All Admins
        public static void DisplayAllAdmins(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("All the admins currently active on Academy Management App");
                
                List<Member> allAdmins = allUsers.Where(x => x.Role == AcademyRole.Admin)
                                    .ToList();
                int i = 0;
                allAdmins.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");

                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;

            }
        }

        #endregion

        #region Display Subjects
        public static void DisplaySubjects(List<Member> allUsers) {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("All the subjects availabe on the Academy:");
                Console.WriteLine();
                List<Member> memberStudents = allUsers.Where(x => x.Role == AcademyRole.Student)
                          
                                                       .ToList();
                List<Student> students = new List<Student>();
                memberStudents.ForEach(x => students.Add((Student)x));

                int a = 0;

                foreach (AcademySubject item in AcademySubject.GetValues(typeof(AcademySubject)))
                {
                    int i = 0;
                    foreach (Student student in students)
                    {
                        
                        
                        foreach(var(key,value) in student.SubjectsAlreadyPassedWithGrades)
                        {
                            if (item == key)
                            {
                                i++;
                            }
                        }

                    }
                    a++;
                    if (item != AcademySubject.none)
                    {
                        Console.WriteLine($"{a}.{item} -------> passed by {i} students.");

                    }

                }

                    string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
            }
           

        }
        #endregion

        #region Display For Removing Users
        public static void DisplayForRemovigUsers(List<Member> allUsers,Admin adminLogged)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Select category to easily find the user you want to remove!");
                Console.WriteLine();
                Console.WriteLine("Enter 1 ---------> to display all Users!");
                Console.WriteLine("Enter 2 ---------> to display only Students!");
                Console.WriteLine("Enter 3 ---------> to display only Trainers!");
                Console.WriteLine("Enter 4 ---------> to display only Admins!");
                Console.WriteLine("Enter x ---------> to go back!");
                string userInput = Console.ReadLine();
                if (userInput == "x") break;
                switch (userInput)
                {
                    case "1":

                        DisplayUsersToRemove(allUsers);
                        break;
                    case "2":
                        DisplayStudentsToRemove(allUsers);
                        break;
                    case "3":
                        DisplayTrainersToRemove(allUsers);
                        break;
                    case "4":
                        DisplayAdminsToRemove(allUsers,adminLogged);
                        break;
                }
            }

        }
        #endregion

        #region Display Users To Remove
        public static void DisplayUsersToRemove(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("Select which user you want to remove!");


                int i = 0;

                allUsers.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"Enter {i} -------->to remove the user below!");
                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");

                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
                bool parssingSuccess = int.TryParse(usersInput, out int numberUserInput);
                if (parssingSuccess && numberUserInput<=allUsers.Count)
                {
                     allUsers.Remove(allUsers[numberUserInput - 1]);
                    
                   
                }
            }

        }
        #endregion

        #region Display Students To Remove
        public static void DisplayStudentsToRemove(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("Select which student you want to remove!");


                List<Member> allStudents = allUsers.Where(x => x.Role == AcademyRole.Student)
                                    .ToList();
                int i = 0;
                allStudents.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"Enter {i} --------> to remove the student below!");
                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");

                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
                bool parssingSuccess = int.TryParse(usersInput, out int numberUserInput);
                if (parssingSuccess && numberUserInput <= allUsers.Count)
                {
                   foreach(Member person in allUsers)
                    {
                        if (person.UserName == allStudents[numberUserInput - 1].UserName)
                        {
                            allUsers.Remove(person);
                            break;

                        }
                    }
                   

                }
            }


        }
        #endregion


        #region Display Trainers To Remove
        public static void DisplayTrainersToRemove(List<Member> allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("Select which trainer you want to remove!");



                List<Member> allTrainers = allUsers.Where(x => x.Role == AcademyRole.Trainer)
                                    .ToList();
                int i = 0;
                allTrainers.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"Enter {i} --------> to remove the trainer below!");

                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");

                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
                bool parssingSuccess = int.TryParse(usersInput, out int numberUserInput);
                if (parssingSuccess && numberUserInput <= allUsers.Count)
                {
                    foreach(Member person in allUsers)
                    {
                        if (person.UserName == allTrainers[numberUserInput - 1].UserName)
                        {
                            allUsers.Remove(person);
                            break;

                        }
                    }

                }
            }

        }
#endregion

        #region Display Admins To Remove
        public static void DisplayAdminsToRemove(List<Member> allUsers,Admin adminLogged)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter x ---------> to go back!");
                Console.WriteLine();
                Console.WriteLine("Select which admin you want to remove!");
                Console.WriteLine("Keep in mind you can not remove yourself!!!");



                List<Member> allAdmins = allUsers.Where(x => x.Role == AcademyRole.Admin)
                                    .ToList();
                int i = 0;
                allAdmins.ForEach(x =>
                {
                    i++;
                    Console.WriteLine();
                    Console.WriteLine($"Enter {i} --------> to remove the admin below!");

                    Console.WriteLine($"{i}.{x.FirstName} {x.LastName}");

                    Console.WriteLine($"Academy role:{x.Role}");

                    Console.WriteLine($"Age {x.Age}");
                    Console.WriteLine($"Email {x.Email}");
                    Console.WriteLine(string.Format("Phone number: {0:0##-###-###}", x.PhoneNumber));

                    Console.WriteLine($"username and password { x.UserName} {x.Password}");

                });
                string usersInput = Console.ReadLine();
                if (usersInput == "x") break;
                bool parssingSuccess = int.TryParse(usersInput, out int numberUserInput);
                if (parssingSuccess && numberUserInput <= allUsers.Count)
                {
                    if (adminLogged.UserName != allAdmins[numberUserInput - 1].UserName)
                    {
                        
                        foreach(Member person in allUsers)
                        {
                            if (allAdmins[numberUserInput - 1].UserName == person.UserName)
                            {
                                allUsers.Remove(person);
                                break;
                            }
                        }
                        

                    }

                    
                }

            }
        }
        #endregion

        #region Add New User

        public static void AddNewUser(List<Member>allUsers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Add new user:");
                Console.WriteLine();
                Console.WriteLine("Enter 1 ---------> to add new Student!");
                Console.WriteLine("Enter 2 ---------> to add new Trainer!");
                Console.WriteLine("Enter 3 ---------> to add new Admin!");
                Console.WriteLine("Enter x ---------> to go back!");
                string userInput = Console.ReadLine();
                if (userInput == "x") break;
                switch (userInput)
                {
                    case "1":
                        AddNewStudent(allUsers);
                        break;
                    case "2":
                        AddNewTrainer(allUsers);
                        break;
                    case "3":
                        AddNewAdmin(allUsers);
                        break;
                }
            }
        }
#endregion

        #region Adding New Student
        public static void AddNewStudent(List<Member> allusers)
        {
            string confirmedStudentName = "";
            string confirmedStudentLastName="";
            int confirmedStudentAge=0;
            string confirmedStudentUsername="";
            string confirmedStudentPassword="";
            string confirmedStudentEmail="";
            int confirmedStudentPhone=0;
            AcademyGroup confirmedStudentGroup = AcademyGroup.none;

            while (true)
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Enter x ---------> to go back!");

                Console.WriteLine();
                Console.WriteLine("Adding new student:");
                Console.WriteLine();
                string studentName = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's First Name!");
                    Console.WriteLine("***it can not be shorter than 3 letters***");
                    studentName = Console.ReadLine();
                    if (studentName == "x") break;
                    if (studentName.Length >= 3) {confirmedStudentName = studentName;break; };
                    Console.WriteLine();
                }
                if(studentName =="x")break;

                string studentLastName ="";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Last Name!");
                    Console.WriteLine("***it can not be shorter than 4 letters***");
                    studentLastName = Console.ReadLine();
                    if (studentLastName == "x") break;
                    if (studentLastName.Length >= 4) {confirmedStudentLastName = studentLastName;break; };
                    Console.WriteLine();
                }
                    if (studentLastName == "x") break;

                string studentAgeInput ="";

                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Age!");
                    Console.WriteLine("***student must be at least 18***");
                    studentAgeInput = Console.ReadLine();
                    if (studentAgeInput == "x") break;
                    bool parsingSuccessful = int.TryParse(studentAgeInput, out int studentAge);
                    if(parsingSuccessful && studentAge >= 18)
                    {confirmedStudentAge = studentAge;
                        break;
                    };
                }
                if (studentAgeInput == "x") break;

                string studentUsername = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Username!");
                    Console.WriteLine("***it can not be shorter than 6 digits and must have al least one number***");
                    studentUsername = Console.ReadLine();
                    if (studentUsername == "x") break;
                    bool containsInt = studentUsername.Any(char.IsDigit);
                    if (studentUsername.Length >= 6 && containsInt) 
                    {confirmedStudentUsername = studentUsername;
                        break; };
                    Console.WriteLine();
                }
                if (studentUsername == "x") break;

                string studentPassword ="";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Password!");
                    Console.WriteLine("***it can not be shorter than 6 digits and must have al least one number and one Capital Letter***");
                    studentPassword = Console.ReadLine();
                    if (studentPassword == "x") break;
                    bool containsInt = studentPassword.Any(char.IsDigit);
                    bool containsCapital= studentPassword.Any(char.IsUpper);
                    if (studentPassword.Length >= 6 && containsInt && containsCapital)
                    {
                         confirmedStudentPassword = studentPassword;
                        break;
                    };
                    Console.WriteLine();
                }
                if (studentPassword == "x") break;

                string studentEmail = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Email!");
                    Console.WriteLine("***should be in valid format***");
                    studentEmail = Console.ReadLine();
                    if (studentEmail == "x") break;
                    bool validAddress = false;

                    if (new EmailAddressAttribute().IsValid(studentEmail))
                    {
                         validAddress = true;

                    }
                    
                    if (validAddress)
                    {
                         confirmedStudentEmail = studentEmail;
                        break;
                    };
                }
                if (studentEmail == "x") break;

                string studentPhone="";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Phone number!");
                    Console.WriteLine("***should be 9 digits long***");
                    studentPhone = Console.ReadLine();
                    if (studentPhone == "x") break;
                    bool successfulParssing = int.TryParse(studentPhone, out confirmedStudentPhone);

                    if (successfulParssing && studentPhone.Length==9)
                    {
                        
                        break;
                    };
                }
                if (studentPhone == "x") break;

                string studentGroup ="";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Group!");
                    Console.WriteLine("***from the given options***");
                    Console.WriteLine("Enter 1 ------->for G1");
                    Console.WriteLine("Enter 2 ------->for G2");
                    Console.WriteLine("Enter 3 ------->for G3");
                    Console.WriteLine("Enter 4 ------->for G4");
                    Console.WriteLine("Enter 5 ------->for G5");


                    studentGroup = Console.ReadLine();
                    if (studentGroup == "x") break;
                    if(studentGroup=="1"||studentGroup=="2" || studentGroup == "3" || studentGroup=="4" || studentGroup == "5")
                    {
                        switch (studentGroup)
                        {
                            case "1":
                                confirmedStudentGroup = AcademyGroup.G1;
                                break;
                            case "2":
                                confirmedStudentGroup = AcademyGroup.G2;
                                break;
                            case "3":
                                confirmedStudentGroup = AcademyGroup.G3;
                                break;
                            case "4":
                                confirmedStudentGroup = AcademyGroup.G4;
                                break;
                            case "5":
                                confirmedStudentGroup = AcademyGroup.G5;
                                break;
                        }break;
                    }

                    
                }
                if (studentGroup == "x") break;

                allusers.Add(new Student(confirmedStudentName, confirmedStudentLastName, confirmedStudentAge, confirmedStudentUsername, confirmedStudentPassword, confirmedStudentEmail, confirmedStudentPhone, new Dictionary<AcademySubject, int>() { }, AcademySubject.HTML5_CSS3, confirmedStudentGroup));
                break;

            }
        }
        #endregion

        #region Method for creating new Admin
        public static void AddNewAdmin(List<Member> allusers)
        {
            string confirmedStudentName = "";
            string confirmedStudentLastName = "";
            int confirmedStudentAge = 0;
            string confirmedStudentUsername = "";
            string confirmedStudentPassword = "";
            string confirmedStudentEmail = "";
            int confirmedStudentPhone = 0;
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Enter x ---------> to go back!");

                Console.WriteLine();
                Console.WriteLine("Adding new student:");
                Console.WriteLine();
                string studentName = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's First Name!");
                    Console.WriteLine("***it can not be shorter than 3 letters***");
                    studentName = Console.ReadLine();
                    if (studentName == "x") break;
                    if (studentName.Length >= 3) { confirmedStudentName = studentName; break; };
                    Console.WriteLine();
                }
                if (studentName == "x") break;

                string studentLastName = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Last Name!");
                    Console.WriteLine("***it can not be shorter than 4 letters***");
                    studentLastName = Console.ReadLine();
                    if (studentLastName == "x") break;
                    if (studentLastName.Length >= 4) { confirmedStudentLastName = studentLastName; break; };
                    Console.WriteLine();
                }
                if (studentLastName == "x") break;

                string studentAgeInput = "";

                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Age!");
                    Console.WriteLine("***student must be at least 18***");
                    studentAgeInput = Console.ReadLine();
                    if (studentAgeInput == "x") break;
                    bool parsingSuccessful = int.TryParse(studentAgeInput, out int studentAge);
                    if (parsingSuccessful && studentAge >= 18)
                    {
                        confirmedStudentAge = studentAge;
                        break;
                    };
                }
                if (studentAgeInput == "x") break;

                string studentUsername = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Username!");
                    Console.WriteLine("***it can not be shorter than 6 digits and must have al least one number***");
                    studentUsername = Console.ReadLine();
                    if (studentUsername == "x") break;
                    bool containsInt = studentUsername.Any(char.IsDigit);
                    if (studentUsername.Length >= 6 && containsInt)
                    {
                        confirmedStudentUsername = studentUsername;
                        break;
                    };
                    Console.WriteLine();
                }
                if (studentUsername == "x") break;

                string studentPassword = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Password!");
                    Console.WriteLine("***it can not be shorter than 6 digits and must have al least one number and one Capital Letter***");
                    studentPassword = Console.ReadLine();
                    if (studentPassword == "x") break;
                    bool containsInt = studentPassword.Any(char.IsDigit);
                    bool containsCapital = studentPassword.Any(char.IsUpper);
                    if (studentPassword.Length >= 6 && containsInt && containsCapital)
                    {
                        confirmedStudentPassword = studentPassword;
                        break;
                    };
                    Console.WriteLine();
                }
                if (studentPassword == "x") break;

                string studentEmail = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Email!");
                    Console.WriteLine("***should be in valid format***");
                    studentEmail = Console.ReadLine();
                    if (studentEmail == "x") break;
                    bool validAddress = false;

                    if (new EmailAddressAttribute().IsValid(studentEmail))
                    {
                        validAddress = true;

                    }

                    if (validAddress)
                    {
                        confirmedStudentEmail = studentEmail;
                        break;
                    };
                }
                if (studentEmail == "x") break;

                string studentPhone = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Phone number!");
                    Console.WriteLine("***should be 9 digits long***");
                    studentPhone = Console.ReadLine();
                    if (studentPhone == "x") break;
                    bool successfulParssing = int.TryParse(studentPhone, out confirmedStudentPhone);

                    if (successfulParssing && studentPhone.Length == 9)
                    {

                        break;
                    };
                }
                if (studentPhone == "x") break;

             

                allusers.Add(new Admin(confirmedStudentName, confirmedStudentLastName, confirmedStudentAge, confirmedStudentUsername, confirmedStudentPassword, confirmedStudentEmail, confirmedStudentPhone));
                break;

            }
        }

        #endregion

        #region Method for creating new Trainer

        public static void AddNewTrainer(List<Member> allusers)
        {
            string confirmedStudentName = "";
            string confirmedStudentLastName = "";
            int confirmedStudentAge = 0;
            string confirmedStudentUsername = "";
            string confirmedStudentPassword = "";
            string confirmedStudentEmail = "";
            int confirmedStudentPhone = 0;
            AcademyGroup confirmedStudentGroup = AcademyGroup.none;
            string confirmedAssistent = "";
            List<AcademySubject> teachingSubjects = new List<AcademySubject>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Enter x ---------> to go back!");

                Console.WriteLine();
                Console.WriteLine("Adding new TRAINER:");
                Console.WriteLine();
                string studentName = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's First Name!");
                    Console.WriteLine("***it can not be shorter than 3 letters***");
                    studentName = Console.ReadLine();
                    if (studentName == "x") break;
                    if (studentName.Length >= 3) { confirmedStudentName = studentName; break; };
                    Console.WriteLine();
                }
                if (studentName == "x") break;

                string studentLastName = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Last Name!");
                    Console.WriteLine("***it can not be shorter than 4 letters***");
                    studentLastName = Console.ReadLine();
                    if (studentLastName == "x") break;
                    if (studentLastName.Length >= 4) { confirmedStudentLastName = studentLastName; break; };
                    Console.WriteLine();
                }
                if (studentLastName == "x") break;

                string studentAgeInput = "";

                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Age!");
                    Console.WriteLine("***student must be at least 18***");
                    studentAgeInput = Console.ReadLine();
                    if (studentAgeInput == "x") break;
                    bool parsingSuccessful = int.TryParse(studentAgeInput, out int studentAge);
                    if (parsingSuccessful && studentAge >= 18)
                    {
                        confirmedStudentAge = studentAge;
                        break;
                    };
                }
                if (studentAgeInput == "x") break;

                string studentUsername = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Username!");
                    Console.WriteLine("***it can not be shorter than 6 digits and must have al least one number***");
                    studentUsername = Console.ReadLine();
                    if (studentUsername == "x") break;
                    bool containsInt = studentUsername.Any(char.IsDigit);
                    if (studentUsername.Length >= 6 && containsInt)
                    {
                        confirmedStudentUsername = studentUsername;
                        break;
                    };
                    Console.WriteLine();
                }
                if (studentUsername == "x") break;

                string studentPassword = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Password!");
                    Console.WriteLine("***it can not be shorter than 6 digits and must have al least one number and one Capital Letter***");
                    studentPassword = Console.ReadLine();
                    if (studentPassword == "x") break;
                    bool containsInt = studentPassword.Any(char.IsDigit);
                    bool containsCapital = studentPassword.Any(char.IsUpper);
                    if (studentPassword.Length >= 6 && containsInt && containsCapital)
                    {
                        confirmedStudentPassword = studentPassword;
                        break;
                    };
                    Console.WriteLine();
                }
                if (studentPassword == "x") break;

                string studentEmail = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Email!");
                    Console.WriteLine("***should be in valid format***");
                    studentEmail = Console.ReadLine();
                    if (studentEmail == "x") break;
                    bool validAddress = false;

                    if (new EmailAddressAttribute().IsValid(studentEmail))
                    {
                        validAddress = true;

                    }

                    if (validAddress)
                    {
                        confirmedStudentEmail = studentEmail;
                        break;
                    };
                }
                if (studentEmail == "x") break;

                string studentPhone = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Phone number!");
                    Console.WriteLine("***should be 9 digits long***");
                    studentPhone = Console.ReadLine();
                    if (studentPhone == "x") break;
                    bool successfulParssing = int.TryParse(studentPhone, out confirmedStudentPhone);

                    if (successfulParssing && studentPhone.Length == 9)
                    {

                        break;
                    };
                }
                if (studentPhone == "x") break;

                string studentGroup = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter STUDENT's Group!");
                    Console.WriteLine("***from the given options***");
                    Console.WriteLine("Enter 1 ------->for G1");
                    Console.WriteLine("Enter 2 ------->for G2");
                    Console.WriteLine("Enter 3 ------->for G3");
                    Console.WriteLine("Enter 4 ------->for G4");
                    Console.WriteLine("Enter 5 ------->for G5");


                    studentGroup = Console.ReadLine();
                    if (studentGroup == "x") break;
                    if (studentGroup == "1" || studentGroup == "2" || studentGroup == "3" || studentGroup == "4" || studentGroup == "5")
                    {
                        switch (studentGroup)
                        {
                            case "1":
                                confirmedStudentGroup = AcademyGroup.G1;
                                break;
                            case "2":
                                confirmedStudentGroup = AcademyGroup.G2;
                                break;
                            case "3":
                                confirmedStudentGroup = AcademyGroup.G3;
                                break;
                            case "4":
                                confirmedStudentGroup = AcademyGroup.G4;
                                break;
                            case "5":
                                confirmedStudentGroup = AcademyGroup.G5;
                                break;
                        }
                        break;
                    }


                }
                if (studentGroup == "x") break;

                string assistentInput = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's Assistent Name and Last name!");
                    Console.WriteLine("***name and last name must be in the same line***");
                    assistentInput = Console.ReadLine();
                    if (assistentInput == "x") break;
                    if (assistentInput.Length >= 6) { confirmedAssistent = assistentInput; break; };
                    Console.WriteLine();
                }
                if (assistentInput == "x") break;

                string subjectFromAdmin = "";
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Please enter TRAINER's teaching Subjects!");
                    Console.WriteLine("***press x ---->only when you entered all subjects!***");
                    
                    Console.WriteLine();
                    Console.WriteLine("Please choose from the following subjects!");
                    int i = 0;
                    int a = 0;
                    foreach (AcademySubject item in AcademySubject.GetValues(typeof(AcademySubject)))
                    {
                        i++;
                        Console.WriteLine($"Press {i} ----->to add {item}");
                    }
                    subjectFromAdmin = Console.ReadLine();
                    if (subjectFromAdmin == "x") break;
                    bool okParsing = int.TryParse(subjectFromAdmin, out int chosenSubject);
                    if (okParsing)
                    {
                        foreach (AcademySubject item in AcademySubject.GetValues(typeof(AcademySubject)))
                        {
                            a++;
                            if (chosenSubject == a)
                            {
                                teachingSubjects.Add(item);
                            }
                        }
                    }
                   



                }
                if (subjectFromAdmin == "x") break;





            }
            allusers.Add(new Trainer(confirmedStudentName, confirmedStudentLastName, confirmedStudentAge, confirmedStudentUsername, confirmedStudentPassword, confirmedStudentEmail, confirmedStudentPhone, teachingSubjects, AcademySubject.none, AcademyGroup.none, confirmedAssistent));

        }
        #endregion

    }
}
