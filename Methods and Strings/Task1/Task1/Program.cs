using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the existing Console Application create  a new method called Substrings
            //●In that method enter the following string :"Hello from SEDC Codecademy 2021"
            //●Ask the user to enter a number n.
            //●Print the first n characters from that string and print the length of the new string.
            //●Try to handle all the scenarios

             static string Substrings(int userInput)
            {
              
                if (userInput == 0)
                {
                    return "Sorry but the number you entered is 0 and we can not present you any part of the sentence!";
                }
                else if (userInput > 32)
                {
                    return "The number you entered is bigger than the length of the given sentence itself!";
                }
                else
                {
                    string sentence = "Hello from SEDC Codeacademy 2012";
                    string newSentence = sentence.Substring(0, userInput);
                    return string.Format("The new sentence created by taking the first {0} characters from the given sentence is {1}! According this the length of the new sentence is {2} charachters.", userInput, newSentence.ToUpper(), newSentence.Length);

                }
            }
            Console.WriteLine("Please enter a number!");
            bool parsedOk = int.TryParse(Console.ReadLine(), out int userNumber);
            if(parsedOk)
            {
               Console.WriteLine( Substrings(userNumber));
            }
           
            

        }
    }
}
