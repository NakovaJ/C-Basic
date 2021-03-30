using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a console application called SumOfEven.
            // Inside it create an array of 6 integers.
            // Get numbers from the input, find and print the sum of the even numbers
            // from the array:
            int[] givenArray = new int[6];
            int sumOfEvenNo = 0;
            int i = 0;
            while(i<=5)
            {
                Console.WriteLine("Please enter a number!");
                bool parsedOK = int.TryParse(Console.ReadLine(), out int userInputNo);
                if(parsedOK)
                {
                    if(userInputNo%2==0)
                    {
                        sumOfEvenNo += userInputNo;
                    }
                    givenArray[i] = userInputNo;
                    i++;
                }

            }
            Console.WriteLine("The sum of the entered numbers is " + sumOfEvenNo);
        }
    }
}
