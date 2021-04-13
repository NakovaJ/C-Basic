using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Classes;
using MovieStoreLibrary.Enums;

namespace MovieAppServicies.ForCustomers
{
    public static class ClassCustomer
    {
        

            //REGISTRATION OF NEW USER BY HIMSELF
            //ADD NEW USER
            public static User RegisterNewUser(Member[] members, User[] users)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
                string firstNameRegisteredUser;
                string lastNameRegisteredUser = "";
                string ageOfRegisteredUser;
                int ageRegisteredUser = 0;
                string userNameRegisteredUser = "";
                string passwordRegisteredUser = "";
                string phoneRegisteredUser1 = "";

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
                        Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
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
                        Console.WriteLine("REGISTRATION on MOVIESTOREApp: ");
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
                                Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
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
                        Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
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
                                Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
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
                        else
                        {



                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
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
                        else if (ageRegisteredUser < 12)
                        {
                            Console.WriteLine("User can not be registered as he/she does not have the minimum age!");
                        }
                        else if (ageRegisteredUser > 80)
                        {
                            Console.WriteLine("Sorry but you exceeded the limit in age!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("REGISTRATION on MOVIESTOREApp:");
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
                    }
            break;





        }

            return new User(firstNameRegisteredUser, lastNameRegisteredUser, ageRegisteredUser, userNameRegisteredUser, passwordRegisteredUser, phoneRegisteredUser, DateTime.Today.ToString(), users.Length + 1000, subscriptionTypeRegisteredUser, new Movie[0]);


            }
        

        //DISPLAY USER INFO
        public static void DisplayUserInfo(User user)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("PERSONAL INFO AND SUBSCRIPTION TYPE:");
                Console.WriteLine();
                Console.WriteLine($"Name and LastName: {user.FirstName} {user.LastName}");
                Console.WriteLine();

                Console.WriteLine($"Username and Password: {user.UserName} {user.Password}");
                Console.WriteLine();

                Console.WriteLine($"Your type of subscription: {user.TypeOfSubscription}!");
                Console.WriteLine();


                if (user.TypeOfSubscription == SubscriptionTYpe.Annually)
                {
                    TimeSpan timeLeft = user.DateOfRegisteration.AddYears(1) - DateTime.Now;

                    Console.WriteLine($"You have {timeLeft.Days} days left until expiration of your subscription!");
                }
                else
                {
                    TimeSpan timeLeft = user.DateOfRegisteration.AddMonths(1) - DateTime.Now;


                    if (timeLeft.Days < 0)
                    {
                        Console.WriteLine("Your subscription has already expired, now is the perfect time to renew it!");
                    }
                    else
                    {
                        Console.WriteLine($"You have {timeLeft.Days} days left until expiration of your subscription!");

                    }

                }
                Console.WriteLine();
                Console.WriteLine("Please press x ------> to go back!");
                if (Console.ReadLine().ToLower() == "x")
                {
                    break;
                }
            }
        }

        //DISPLAY MOVIES THAT THE USER OWES TO THE STORE
       public static void DisplayRentedMovies(User user)
        {
            while (true)
            {
                Console.WriteLine("MOVIES YOU OWE TO THE MOVIE STORE:");
                foreach (Movie item in user.RentedMovies)
                {
                    Console.WriteLine();
                    Console.WriteLine($"TITLE: {item.Title}");
                    Console.WriteLine($"YEAR: {item.Year}");
                    Console.WriteLine($"DESCRIPTION: {item.Description}");
                }
                Console.WriteLine();
                Console.WriteLine("Please press x ------> to go back!");
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
