using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console
            //and then swap the values of the variables so that the first variable has the second value
            //and the second variable the first value. Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5

            Console.WriteLine("Please insert 2 numbers and we will swap them for you!");
            bool parseNoOne = int.TryParse(Console.ReadLine(), out int noOne);
            bool parseNoTwo = int.TryParse(Console.ReadLine(), out int noTwo);
            if (parseNoOne && parseNoTwo)
            {
                Console.WriteLine("The first inserted number is " + noOne + " and the second inserted number is " + noTwo + "!");
                int noThree = noOne;
                noOne = noTwo;
                noTwo = noThree;
                Console.WriteLine("Now the first number is " + noOne + " and the second number is " + noTwo + "!");

            }
            else
            {
                Console.WriteLine("Please enter valid numbers!");
            }

        }
    }
}
