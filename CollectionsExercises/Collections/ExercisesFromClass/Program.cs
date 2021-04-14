using System;
using System.Collections.Generic;

namespace ExercisesFromClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            phoneBook.Add("Jelena", 070123456);
            phoneBook.Add("Matej", 070112233);
            phoneBook.Add("Andrijana", 070998839);
            phoneBook.Add("Ljupcho", 070334454);
            phoneBook.Add("Ivana", 070987886);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your phonebook!");
                Console.WriteLine("Please choose from the given options!");
                Console.WriteLine("Enter 1 ---> to find the number of the name you entered!");
                Console.WriteLine("Enter 2 ---> to find the owner of the number you entered!");
                string userChoise = Console.ReadLine();
            
                if (userChoise == "1")
                {
                    Console.WriteLine("Please enter a name of the person and we'll give you his/her number!");
                    string userName = Console.ReadLine();
                    if (phoneBook.ContainsKey(userName))
                    {
                        
                        Console.WriteLine(string.Format("Phone number of {0} is {1:0##-###-###}",userName,phoneBook[userName]));
                    }
                    else
                    {
                        Console.WriteLine("No such a name in this phonebook sorry!");
                    }break;
                }
                else if (userChoise == "2")
                {
                    Console.WriteLine("Please enter a number and we'll give you his owner's name!");
                    bool okParsing = int.TryParse(Console.ReadLine(), out int userNumber);
                   
                    if (phoneBook.ContainsValue(userNumber))
                    {
                        string phoneOwner = "";
                        foreach(var item in phoneBook)
                        {
                            if (item.Value == userNumber)
                            {
                                phoneOwner = item.Key;
                            }
                        }
                        Console.WriteLine("Phone number {0:0##-###-###} belongs to {1}!",userNumber,phoneOwner);
                       
                        
                    }
                    else
                    {
                        Console.WriteLine("We do not have such a number in this phonebook sorry!");

                    }break;
                }
                else continue;



            }
        }
    }
}
