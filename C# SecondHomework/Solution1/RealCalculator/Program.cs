using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input
            //and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //            The result is: 25
            int parsedInput1;
            int parsedInput2;
            char userOperator;
          
            Console.WriteLine("Please enter the first number!");
            bool parsingSuccess1 = int.TryParse(Console.ReadLine(), out parsedInput1);
            Console.WriteLine("Please enter the second number!");
            bool parsingSuccess2 = int.TryParse(Console.ReadLine(), out parsedInput2);

            Console.WriteLine("Please enter an operator like  +, -, *, / !");
            bool parsingOperatorSuccess = char.TryParse(Console.ReadLine(), out userOperator);

            if (parsingSuccess1 && parsingSuccess2)
            {
                if(parsingOperatorSuccess&&(userOperator=='+' ||  userOperator == '-' || userOperator == '*' || userOperator == '/'))
                {
                    switch (userOperator)
                    {
                        case '+':
                            Console.WriteLine($"The sum of the inserted numbers is {parsedInput1 + parsedInput2}!");
                            break;
                        case '-':
                            Console.WriteLine($"The deduction of the inserted numbers is {parsedInput1 - parsedInput2}!");
                            break;
                        case '*':
                            Console.WriteLine($"The multiplication of the inserted numbers is {parsedInput1 * parsedInput2}!");
                            break;
                        case '/':
                            Console.WriteLine($"The division of the inserted numbers is {parsedInput1 / parsedInput2}!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You have to choose from  the given operators!");
                }
               
            }
            else
            {
                Console.WriteLine("Please insert valid inputs!");
            }
            
            





        }
    }
}
