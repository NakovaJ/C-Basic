using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Services.GeneralSerices
{
    public static class GeneralServicies
    {
        public static string BasicLoginMenu()
        {
          
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Academy Management App!");
                Console.WriteLine();
                Console.WriteLine("Enter 1 ---------> to login as Admin!");
                Console.WriteLine("Enter 2 ---------> to login as Trainer!");
                Console.WriteLine("Enter 3 ---------> to login as Student!");
                Console.WriteLine("Enter 4 ---------> to login no matter your Academy Role!");
                Console.WriteLine("Enter x ---------> to out of the Academy Management App!");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                   
                    return "adminLogin";
                }
                else if (userInput == "2")
                {
                  
                    return "trainerLogin";

                }
                else if (userInput == "3")
                {
                    
                    return "studentLogin";

                }
                else if (userInput == "4")
                {
                    return "regularLogin";

                }
                else if (userInput == "x")
                {
                    return "";
                }

            }
        }
    }
}
