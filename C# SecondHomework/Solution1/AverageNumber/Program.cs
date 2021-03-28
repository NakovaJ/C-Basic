using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2
            //Create new console application “AverageNumber” that takes four numbers as input
            //to calculate and print the average.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Please insert 4 numbers so you can calculate the average out of them!");
            bool parseNoOne = float.TryParse(Console.ReadLine(), out float no1);
            bool parseNoTwo = float.TryParse(Console.ReadLine(), out float no2);
            bool parseNoThree = float.TryParse(Console.ReadLine(), out float no3);
            bool parseNoFour = float.TryParse(Console.ReadLine(), out float no4);
            float result = (no1 + no2 + no3 + no4) / 4;
           if(parseNoOne && parseNoTwo && parseNoThree && parseNoFour)
            {
                Console.WriteLine("The average of " + no1 + " " + no2 + " " + no3 + " " + no4 + " is " + result);

            }
            else
            {
                Console.WriteLine("Please insert valid inputs!");
            }
        }
    }
}
