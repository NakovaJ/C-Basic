using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //●Create an array with names
            //●Give an option to the user to enter a name from the keyboard
            //●After entering the name put it in the array
            //●Ask the user if they want to enter another name(Y / N)
            //●Do the same process over
            //and over until the user enters N
            //●Print all the names after user enters N

            string[] names = new string[] { "Jelena", "Marko", "Mihaela" };
            for( ; ; )
            {
                Console.WriteLine("Would you like to add a name to the array? Please type Y or N!");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "Y" || userAnswer == "y")
                {
                    Console.WriteLine("Please enter the name you wanna add!");
                    string newName = Console.ReadLine();
                    Array.Resize(ref names, names.Length+1 );
                    names[names.Length-1] = newName;
                }
                else if(userAnswer == "N" || userAnswer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please give a proper answer with Y for Yes or N for No!");
                }
            }
        }
    }
}
