using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Classes;
using MovieStoreLibrary.Enums;
using System.Linq;


namespace MovieAppServicies.ForEmployees
{
    public static class ClassEmployee
    {
        public static string WelcomeToMovieApp()
        {
            Console.WriteLine();
            Console.WriteLine("WELCOME TO OUR AWESOME MoveStoreApp!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("For login--------------------> please press 1!");
                Console.WriteLine();
                Console.WriteLine("For registration please------> please press 2!");
                string userChoise = Console.ReadLine();
                if (userChoise == "1")
                {
                    return "login";
                }
                else if (userChoise == "2")
                {
                    return  "register";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("WELCOME TO OUR AWESOME MoveStoreApp!");
                    Console.WriteLine();
                    Console.WriteLine("Please choose only from the provided options!");
                    Console.WriteLine();

                }
            }

        }



        public static Member Login(Member[]testMembers)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the LOGIN page!");
            Console.WriteLine();
            while (true)
            {

                Console.WriteLine("Please enter your username!");
                string userInputUsername = Console.ReadLine();
                Console.WriteLine("Please enter your password!");
                string userInputPassword = Console.ReadLine();
                bool foundEmployee = false;

                foreach (Member person in testMembers)
                {
                    if (person.UserName == userInputUsername)
                    {
                        foundEmployee = true;
                        if (person.Password == userInputPassword)
                        {
                            return person;
                          
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Welcome to the LOGIN page!");
                            Console.WriteLine();
                            Console.WriteLine("Wrong Password, please try again!");
                            Console.WriteLine();


                        }

                    }
                    

                }
                if (!foundEmployee)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Welcome to the LOGIN page!");
                    Console.WriteLine();
                    Console.WriteLine("There is no user with such a username, please try again!");
                    Console.WriteLine();

                }
            }
        }


       

        //  DISPLAY REGISTERED USERS, EMPLOYEES AND ALL TOGETHER
        public static void RegisteredUsers(Member[] allMembers,User[]users)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("REGISTERED MEMBERS IN THE MOVIESTOREApp:");
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please choose the coresponding number from the menu!");
                Console.WriteLine("Press 1 -------->  Display all registered users in the store!");
                Console.WriteLine("Press 2 -------->  Display all employees in the store!");
                Console.WriteLine("Press 3 -------->  Display all registered users and employees in the store!");
                Console.WriteLine("Press x -------->  To go back!");

                Console.WriteLine();
                string userChoise = Console.ReadLine();
                if (userChoise.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                if (userChoise == "1" || userChoise == "2" || userChoise == "3")
                {
                    switch (userChoise)
                    {
                        case "1":
                            while (true) {
                                Console.Clear();
                                Console.WriteLine("To go back to the previous menu press  x  !");
                                Console.WriteLine("Listing all the regisered users in the store:");
                                Console.WriteLine();
                                foreach (User person in users)
                                {
                                    if (person.Role == AppRole.User)
                                    {
                                        Console.WriteLine($"USER:  {person.FirstName} {person.LastName}");
                                        Console.WriteLine($"ID:  {person.MemberNumber}");
                                        Console.WriteLine($"TYPE OF SUBSCRIPTION:  {person.TypeOfSubscription}");
                                        Console.WriteLine($"AGE:  {person.Age} years old!");
                                        Console.WriteLine($"PHONE:  {person.PhoneNumber}");
                                        Console.WriteLine($"REGISTRATION DATE: {person.DateOfRegisteration}");
                                        Console.WriteLine();
                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("To go back to the previous menu press  x  !");
                                string userInput = Console.ReadLine();
                                if (userInput.ToLower() == "x") break;
                            }
                            break;
                        case "2":
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("To go back to the previous menu press  x  !");
                                Console.WriteLine("Listing all employees in the store:");
                                Console.WriteLine();
                                foreach (Member person in allMembers)
                                {
                                    if (person.Role == AppRole.Employee)
                                    {
                                        Console.WriteLine($"EMPLOYEE:  {person.FirstName} {person.LastName}");
                                        Console.WriteLine($"AGE:  {person.Age} years old!");
                                        Console.WriteLine($"PHONE:  {person.PhoneNumber}");
                                        Console.WriteLine($"REGISTRATION DATE: {person.DateOfRegisteration}");
                                        Console.WriteLine();
                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("To go back to the previous menu press  x  !");
                                string userInput = Console.ReadLine();
                                if (userInput.ToLower() == "x") break;
                            }
                            break;
                        case "3":
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("To go back to the previous menu press  x  !");
                                Console.WriteLine("Listing all registered users and employees in the store:");
                                Console.WriteLine();
                                foreach (Member person in allMembers)
                                {
                                    Console.WriteLine($"PERSON:  {person.FirstName} {person.LastName}");
                                    Console.WriteLine($"ROLE:  {person.Role}");
                                    Console.WriteLine($"AGE:  {person.Age} years old!");
                                    Console.WriteLine($"PHONE:  {person.PhoneNumber}");
                                    Console.WriteLine($"REGISTRATION DATE: {person.DateOfRegisteration}");
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("To go back to the previous menu press  x  !");
                                string userInput = Console.ReadLine();
                                if (userInput.ToLower() == "x") break;
                            }
                            
                            break;
                    }
                    if (userChoise.ToLower() == "x") break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Please choose only from the given options!");
                }

            }
        }


        //DISPLAY ALL MOVIES--->RENTED AND FOR RENT
        public static void DisplayMovies(User[] users, Movie[] movies)
        {
            Console.WriteLine();
            Console.WriteLine("MOVIES IN THE MOVIESTOREApp:");
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please choose the coresponding number from the menu!");
                Console.WriteLine("Press 1 -------->  Display all movies!");
                Console.WriteLine("Press 2 -------->  Display only instore movies available for rent!");
                Console.WriteLine("Press 3 -------->  Display only currently rented movies");
                Console.WriteLine("Press x -------->  To go back!");

                Console.WriteLine();
                string userChoise = Console.ReadLine();
                if (userChoise.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                if (userChoise == "1" || userChoise == "2" || userChoise == "3")
                {
                    while (true)
                    {
                        

                        switch (userChoise)
                        {
                            case "1":
                               
                                    Console.Clear();
                                    Console.WriteLine();

                                    Console.WriteLine("To go back to the previous menu press  x  !");
                                    Console.WriteLine();

                                    Console.WriteLine("Listing all movies:");
                                    Console.WriteLine();
                                    foreach (Movie item in movies)
                                    {
                                        bool isMovieHere1 = false;

                                        foreach (User person in users)
                                        {
                                            foreach (Movie rentedMovie in person.RentedMovies)
                                            {
                                                if (rentedMovie.Title == item.Title)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine($"TITLE: ***{item.Title}***");
                                                    Console.WriteLine($"YEAR: {item.Year}");
                                                    Console.WriteLine($"DESCRIPTION: {item.Description}");

                                                    isMovieHere1 = true;
                                                }
                                            }


                                        }

                                        if (!isMovieHere1)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"TITLE: {item.Title}");
                                            Console.WriteLine($"YEAR: {item.Year}");
                                            Console.WriteLine($"DESCRIPTION: {item.Description}");

                                        }
                                    }

                            

                                break;
                            case "2":
                               
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("To go back to the previous menu press  x  !");
                                    Console.WriteLine();

                                    Console.WriteLine("Display only instore movies:");
                                    Console.WriteLine();
                                    bool isMovieHere2 = false;
                                    foreach (Movie item in movies)
                                    {
                                        isMovieHere2 = false;

                                        foreach (User person in users)
                                        {
                                            foreach (Movie rentedMovie in person.RentedMovies)
                                            {
                                                if (rentedMovie.Title == item.Title)
                                                {
                                                    isMovieHere2 = true;
                                                }
                                            }


                                        }

                                        if (!isMovieHere2)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"TITLE: {item.Title}");
                                            Console.WriteLine($"YEAR: {item.Year}");
                                            Console.WriteLine($"DESCRIPTION: {item.Description}");

                                        }
                                    }
                               

                                break;
                            case "3":
                               
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("To go back to the previous menu press  x  !");
                                    Console.WriteLine("Listing only currently rented movies:");
                                    Console.WriteLine();
                                    bool isMovieHere3 = false;
                                    foreach (Movie item in movies)
                                    {


                                        foreach (User person in users)
                                        {
                                            foreach (Movie rentedMovie in person.RentedMovies)
                                            {
                                                if (rentedMovie.Title == item.Title)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine($"TITLE: ***{item.Title}***");
                                                    Console.WriteLine($"YEAR: {item.Year}");
                                                    Console.WriteLine($"DESCRIPTION: {item.Description}");
                                                    Console.WriteLine($"CURRENTLY RENTED BY: {person.FirstName} {person.LastName} with Member ID: {person.MemberNumber}");
                                                }
                                            }


                                        }


                                   
                                }
                                break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("To go back to the previous menu press  x  !");
                        string userInput1 = Console.ReadLine();
                        if (userInput1.ToLower() == "x")
                        {
                            Console.Clear();
                            break;

                        }

                    }
                  
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Please choose only from the given options!");
                }

            }

        }


        //ADD NEW USER
        public static User AddNewUser(Member[] members,User[]users)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("ADD NEW USER:");
            string firstNameRegisteredUser ;
            string lastNameRegisteredUser = "";
            string ageOfRegisteredUser ;
            int ageRegisteredUser = 0;
            string userNameRegisteredUser = "";
            string passwordRegisteredUser = "";
            string phoneRegisteredUser1="";

            int phoneRegisteredUser = 0;
            string subscriptionTypeRegisteredUser = "";
            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Press x -------->  To go back!");
               

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter user's First Name!");
                    Console.WriteLine("*Name can not be less than 3 letters!");

                    firstNameRegisteredUser = Console.ReadLine();

                    if (firstNameRegisteredUser.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }

                    else if (firstNameRegisteredUser.Length < 3)
                    {
                        Console.WriteLine("First Name of user can not have less than3 letters!");
                    }
                    else break;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("ADD NEW USER:");
                    Console.WriteLine();
                    Console.WriteLine("Press x -------->  To go back!");

                }
                if (firstNameRegisteredUser.ToLower() == "x")
                {
                    Console.Clear(); break;
                }
                Console.WriteLine("First Name entered!!");
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter user's Last Name!");
                    Console.WriteLine("*LastName can not be less than 4 letters!");

                    lastNameRegisteredUser = Console.ReadLine();
                    if (lastNameRegisteredUser.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (lastNameRegisteredUser.Length < 4)
                    {
                        Console.WriteLine("Last Name of user can not have less than 4 letters!");
                    }
                    else break;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("ADD NEW USER:");
                    Console.WriteLine();
                    Console.WriteLine("Press x -------->  To go back!");
                    Console.WriteLine();
                    Console.WriteLine("First Name entered!!");

                }
                if (lastNameRegisteredUser.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Last Name entered!!");

               

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a username");
                    Console.WriteLine("**Username must be at least 6 characters and have at least one number digit!!");
                    userNameRegisteredUser = Console.ReadLine();
                    if (userNameRegisteredUser.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }
                    bool isThereDigit = false;

                    foreach (char c in userNameRegisteredUser)
                    {
                        if (System.Char.IsDigit(c))
                        {
                            isThereDigit = true;
                        }

                    }

                    if (userNameRegisteredUser.Length < 6)
                    {
                        Console.WriteLine("Username must be at least 6 characters!");
                    }
                    else if (!isThereDigit)
                    {
                        Console.WriteLine("Username must have at least one digit!");
                    }
                    else
                    {
                        bool isThereAnotherUsernameLikeThis = false;
                        foreach (Member person in members)
                        {
                            if (person.UserName == userNameRegisteredUser)
                            {
                                isThereAnotherUsernameLikeThis = true;
                            }
                        }

                        if (!isThereAnotherUsernameLikeThis)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("ADD NEW USER:");
                            Console.WriteLine();
                            Console.WriteLine("Press x -------->  To go back!");
                            Console.WriteLine();
                            Console.WriteLine("First Name entered!!");
                            Console.WriteLine();
                            Console.WriteLine("Last Name entered!!");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Username already taken, please try with another one!");
                        }


                    }


                }
                if (userNameRegisteredUser.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Username entered!");

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a password");
                    Console.WriteLine("**Password must be at least 6 characters, have at least one Capital letter and have at least one number digit!!");
                    passwordRegisteredUser = Console.ReadLine();
                    if (passwordRegisteredUser.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }
                    bool isThereDigit = false;
                    bool isThereCapitalLetter = false;
                    foreach (char c in passwordRegisteredUser)
                    {
                        if (System.Char.IsDigit(c))
                        {
                            isThereDigit = true;
                        }
                        if (System.Char.IsUpper(c))
                        {
                            isThereCapitalLetter = true;
                        }
                    }

                    if (passwordRegisteredUser.Length < 6)
                    {
                        Console.WriteLine("Password must be at least 6 characters!");
                    }
                    else if (!isThereDigit)
                    {
                        Console.WriteLine("Password must have at least one digit!");
                    }
                    else if (!isThereCapitalLetter)
                    {
                        Console.WriteLine("Password must have at least one Capital Letter!");
                    }
                    else break;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("ADD NEW USER:");
                    Console.WriteLine();
                    Console.WriteLine("Press x -------->  To go back!");
                    Console.WriteLine();
                    Console.WriteLine("First Name entered!!");
                    Console.WriteLine();
                    Console.WriteLine("Last Name entered!!");
                    Console.WriteLine();
                    Console.WriteLine("Username entered!");
                    Console.WriteLine();
                }
                if (passwordRegisteredUser.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }

                Console.WriteLine("Password entered!");


                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter user's phone number!");
                    Console.WriteLine("**Phone number must be 9 digit and start with either 070 or 071 or 072 or 075!!");
                     phoneRegisteredUser1 = Console.ReadLine();
                    if (phoneRegisteredUser1.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }
                    char[] phoneRegisteredUser2 = phoneRegisteredUser1.ToCharArray();

                    if (phoneRegisteredUser1.Length != 9)
                    {
                        Console.WriteLine("Phone number must be exactly 9 digits!");
                    }
                    else if (phoneRegisteredUser2[0] != '0' || phoneRegisteredUser2[1] != '7')
                    {
                        Console.WriteLine("**Phone number must start with either 070 or 071 or 072 or 075 or 076!!");

                    }
                    else if (phoneRegisteredUser2[2] == '3' || phoneRegisteredUser2[2] == '4' || phoneRegisteredUser2[2] == '7' || phoneRegisteredUser2[2] == '8' || phoneRegisteredUser2[2] == '9')
                    {
                        Console.WriteLine("**Phone number must start with either 070 or 071 or 072 or 075 or 076!!");

                    }
                    else
                    {
                        bool parsingSuccess = int.TryParse(phoneRegisteredUser1, out phoneRegisteredUser);
                        if (parsingSuccess)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("ADD NEW USER:");
                            Console.WriteLine();
                            Console.WriteLine("Press x -------->  To go back!");
                            Console.WriteLine();
                            Console.WriteLine("First Name entered!!");
                            Console.WriteLine();
                            Console.WriteLine("Last Name entered!!");
                            Console.WriteLine();
                            Console.WriteLine("Username entered!");
                            Console.WriteLine();
                            Console.WriteLine("Password entered!");
                            Console.WriteLine();


                        }
                        break;

                    }



                }
                if (phoneRegisteredUser1.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }

                Console.WriteLine("Phone number entered!");

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter user's type of subscription: Montly or Yearly!");
                    Console.WriteLine("**For monthly subscription enter ---> m !!");
                    Console.WriteLine("**For yearly subscription enter  ---> y !!");

                    subscriptionTypeRegisteredUser = Console.ReadLine();
                    if (subscriptionTypeRegisteredUser.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }

                    if (subscriptionTypeRegisteredUser.ToLower() != "m" && subscriptionTypeRegisteredUser.ToLower() != "y")
                    {
                        Console.WriteLine("Please choose from the ofered options!");
                    }
                    else {
                       


                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("ADD NEW USER:");
                        Console.WriteLine();
                        Console.WriteLine("Press x -------->  To go back!");
                        Console.WriteLine();
                        Console.WriteLine("First Name entered!!");
                        Console.WriteLine();
                        Console.WriteLine("Last Name entered!!");
                        Console.WriteLine();
                        Console.WriteLine("Username entered!");
                        Console.WriteLine();
                        Console.WriteLine("Password entered!");
                        Console.WriteLine();
                        Console.WriteLine("Phone number entered!");
                        Console.WriteLine();
                        break;

                    }

                }
                if (subscriptionTypeRegisteredUser.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }

                Console.WriteLine("User subscription type entered!");
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter user's Age!");
                    Console.WriteLine("*If user is less than 12 can not be registered!!");
                    ageOfRegisteredUser = Console.ReadLine();
                    bool parsingSuccess = int.TryParse(ageOfRegisteredUser, out ageRegisteredUser);
                    if (ageOfRegisteredUser.ToLower() == "x")
                    {
                        Console.Clear();
                        break;
                    }


                    if (!parsingSuccess)
                    {
                        Console.WriteLine("Please enter a valid age!");
                    }
                    else  if (ageRegisteredUser < 12)
                    {
                        Console.WriteLine("User can not be registered as he/she does not have the minimum age!");
                    }
                   else if (ageRegisteredUser > 80)
                    {
                        Console.WriteLine("Sorry but you exceeded the limit in age!");
                    }
                    else {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("ADD NEW USER:");
                        Console.WriteLine();
                        Console.WriteLine("Press x -------->  To go back!");
                        Console.WriteLine();
                        Console.WriteLine("First Name entered!!");
                        Console.WriteLine();
                        Console.WriteLine("Last Name entered!!");
                        Console.WriteLine();
                        Console.WriteLine("Username entered!");
                        Console.WriteLine();
                        Console.WriteLine("Password entered!");
                        Console.WriteLine();
                        Console.WriteLine("Phone number entered!");
                        Console.WriteLine();
                        Console.WriteLine("User subscription type entered!");

                        break;
                    }
                    



                }
                if (ageOfRegisteredUser.ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("User age entered!");

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("User was successfully registered!");
                    Console.WriteLine();
                    Console.WriteLine("Please press x------> to go back!");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "x")
                    {
                        break;
                    }
                    Console.Clear();
                }break;
               




            }
          
            return new User(firstNameRegisteredUser, lastNameRegisteredUser, ageRegisteredUser, userNameRegisteredUser, passwordRegisteredUser, phoneRegisteredUser, DateTime.Today.ToString(), users.Length + 1000, subscriptionTypeRegisteredUser, new Movie[0]);


        }

        //DELETE EXISTING USER
        public static int[] DeleteExistingUser(User[]users,Member[]members)
        {
            int userInputInt;
            int secondItemIndex;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("DELETE EXISTING USER:");
            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("All the MOVIESTOREApp users are displayed below.");
                Console.WriteLine("In order to delete a specific user please press the coresponding number of the user!");
                Console.WriteLine();

                for (int i = 1; i <= users.Length; i++)
                {
                    Console.WriteLine($"Press {i} ------> to delete {users[i - 1].FirstName} {users[i - 1].LastName} with username {users[i - 1].UserName} and member ID: {users[i - 1].MemberNumber}");
                    Console.WriteLine();
                }
                string userInput = Console.ReadLine();
                
                bool parsingSuccess = int.TryParse(userInput, out  userInputInt);
                if (parsingSuccess)
                {

                    if (userInputInt <= users.Length && userInputInt > 0)
                    {
                        for (int a = 0; a < members.Length; a++)
                        {
                            if (users[userInputInt - 1].UserName == members[a].UserName)
                            {
                                secondItemIndex = a;
                                Console.Clear();
                                return new int[] { userInputInt, secondItemIndex };



                            }

                        }
                    }
                    else Console.Clear();
                }
                else Console.Clear();
                
                
                
               

                
            }


        }


        //EMPLOYEE CHECK HIS/HER BONUS

        public static void CheckEmployeeBonus(Employee empl)
        {
            Console.Clear();

            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("CHECK YOUR ESTIMATED BONUS FOR THIS MONTH:");
                Console.WriteLine();


                empl.SetBonus();
                if (empl.Bonus == null)
                {
                    Console.WriteLine("Based on your estimated scheduled working hours you have no bonus for this month!");
                    Console.WriteLine("Bid for more working hours!");
                }
                else
                {
                    Console.WriteLine($"Your estimated BONUS, based on your planed schedule working hours, is {empl.Bonus * 100}%!");

                }
                Console.WriteLine();
                Console.WriteLine("Press x -------->  To go back!");


                if (Console.ReadLine().ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();

            }
        }
    }
}
