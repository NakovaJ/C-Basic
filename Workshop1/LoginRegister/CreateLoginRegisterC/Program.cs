using CreateLoginRegisterC.ClassesCreated;
using System;

namespace CreateLoginRegisterC
{

    class Program
    {
       

        static void Register(User[]test)
        {
            for (; ; )
            {
                Console.WriteLine("----REGISTER-----");
                Console.WriteLine("Please enter a username you want to use!(It has to be at least 3 characters!)");
                string usernameEntered = Console.ReadLine();
              
                Console.WriteLine("Please enter a password (bear in mind it has to have at least 6 characters, one capital letter and no spaces)!");
                string passwordEntered = Console.ReadLine();
                Console.WriteLine("Please confirm your password!");
                string passwordConfirmed = Console.ReadLine();
                if (usernameEntered.Length < 3)
                {
                    Console.WriteLine("Username has to be at least 3 characters long!");
                }
                if (passwordEntered.Length < 6)
                {
                    Console.WriteLine("Your password does not meet the required length!");
                   
                }
               
                bool capitalLetter = false;
                bool isThereWhiteSpace = false;

                foreach (char item in passwordEntered)
                {
                    if (Char.IsUpper(item))
                    {
                        capitalLetter = true;
                    }
                    if (Char.IsWhiteSpace(item))
                    {
                        isThereWhiteSpace = true;

                    }
                }
                if (capitalLetter == false || isThereWhiteSpace == true)
                {
                    Console.WriteLine("Your password should contain at least one Uppercase Letter and no space!");
                }

                if (passwordEntered != passwordConfirmed)
                {
                    Console.WriteLine("Your passwords do not match please start again!");
                }
               
                if (passwordEntered.Length >= 6 && capitalLetter && isThereWhiteSpace == false)
                    {
                    bool isThereUserLikeThat = false;
                    foreach(User person in test)
                    {
                        if (person.Username == usernameEntered)
                        {
                            Console.WriteLine("Sorry there is already such a user!");
                            isThereUserLikeThat = true;
                        }
                    }

                    if (!isThereUserLikeThat)
                    {
                        Array.Resize(ref test, test.Length + 1);
                        test[test.Length - 1] = new User(1000 + test.Length - 1, usernameEntered, passwordEntered, new string[0] { });
                        Console.WriteLine("YOU have successfully registered!!");
                        Console.WriteLine(test[test.Length - 1].Username);
                        Console.WriteLine("___________________________________");

                        Console.WriteLine("Press x to logout!");


                        string logOutUserButton = Console.ReadLine();

                        if (logOutUserButton.ToLower() == "x") break;
                    }
                   
                    
                }

            }
           
            

        }


        static void Login(User[] test)
        {
            for (; ; )
            {
                Console.WriteLine("Welcome to LOGIN Page!");
                Console.WriteLine("Please enter your username");
                string userNameEntered = Console.ReadLine();
                Console.WriteLine("Enter your password!");
                string userPasswordEntered = Console.ReadLine();
              
                foreach (User item in test)
                {
                    
                    if (item.Username == userNameEntered)
                    {
                      
                        if (item.Password == userPasswordEntered)
                        {
                            Console.WriteLine($"{item.Username} Welcome to your page, there are your following messages:");
                            foreach (string message in item.Messages)
                            {
                                Console.WriteLine(message);


                            }
                            if (item.Messages.Length == 0)
                            {
                                Console.WriteLine("You have no messages so far!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Please doublecheck your password, it seems like incorrect!");
                        }
                    }

                }
                
                Console.WriteLine("Press x to logout or press any other button to continue!");
                string logOutUserButton = Console.ReadLine();
                if (logOutUserButton.ToLower() == "x") break;
            }

        }
       

        static void Main(string[] args)

        {
            User[] arrayOfPageUsers = new User[] {
                new User(1000,"Jelena","Jelena",new []{"Hello there Jelena!","C# exercises are current task","It may seem difficult and it really is :)","That's it bye bye!" }),
                new User(1001,"Mihaela","Mihaela",new []{"Hello there Mihaela","How you doin'?" }),
                new User(1002,"Marko","MarkoM",new string[]{"Hi Marko","How's life?","THank you and see you soon!"}),
                new User(1003,"Marjan","Marjan",new string[]{"Welcome to this page","Sorry we can not provide you answer!","See you soon!"} )};

            //Register(arrayOfPageUsers);
            //Console.WriteLine(arrayOfPageUsers.Length);


            for (; ; )
            {
                Console.WriteLine("Welcome to our awsome website!");
                Console.WriteLine("For login press ----------> 1 ");
                Console.WriteLine("For register press -------> 2 ");
                string userChoise = Console.ReadLine();
                if (userChoise != "1" && userChoise != "2")
                {
                    Console.WriteLine("Please choose between 1 and 2!");

                }
                else
                {
                    switch (userChoise)
                    {
                        case "1":

                            Login(arrayOfPageUsers);

                            break;
                        case "2":

                            Register(arrayOfPageUsers);
                            Login(arrayOfPageUsers);


                            break;

                    }
                    break;
                }


                Console.Clear();
            }




        }
    }
}
