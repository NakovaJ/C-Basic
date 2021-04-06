using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Write a program to calculate the sum of all two - digit pairs
            //numbers.The resulting amount is printed on a screen.
            int sumOfAllTwoDigitNumbers = 0;
            for (int i = 10; i < 100; i++)
            {
                sumOfAllTwoDigitNumbers += i;
            }
            Console.WriteLine("The sum of all two digit numbers is " + sumOfAllTwoDigitNumbers);

            //2.Write a program to calculate the sum of all odd
            //two - digit numbers.The program prints the amount on the screen in the
            // format: 11 + 13 + 15 + 17 + ... +97 + 99 = 2475
            int sumOfAllOddTwoDigitNumbers = 0;
            for (int i = 11; i < 100; i += 2)
            {
                sumOfAllOddTwoDigitNumbers += i;
                if (i < 99)
                {
                    Console.Write($"{ i} +");

                }
                else
                {
                    Console.Write($"{i}={sumOfAllOddTwoDigitNumbers}");
                }
            }

            //3.Write a program to calculate y = x ^ n
            static void CalculatePowerOf(int x, int n)
            {
                int y = 1;
                for (int i = 1; i <= n; i++)
                {
                    y *= x;
                }
                Console.WriteLine();
                Console.WriteLine($"{x} on power of {n} is {y}! ");

            }
            CalculatePowerOf(3, 3);

            //4.Write a program that will determine from n numbers(entered from the keyboard)
            //the number of numbers that are divisible by 3, when divided by 3 have a remainder of 1,
            //when divided by 3 have a remainder of 2.
            Console.WriteLine("Please enter 5 numbers!");
            int[] userInputs = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

            foreach (int item in userInputs)
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine($"Number {item} is divisible by 3!");
                }
                else if (item % 3 == 1)
                {
                    Console.WriteLine($"Number {item} when divided by 3, has a remainder of 1!");

                }
                else
                {
                    Console.WriteLine($"Number {item} when divided by 3, has a remainder of 2!");

                }
            }


            //5.Write a program that will determine from a range of numbers(entered from the keyboard) the
            //numbers where the sum of all least significant digits is equal to
            //the most significant digit.
            //  example:
            //            start = 200
            //  end = 300
            //  Result: 202(2 = 0 + 2), 211(2 = 1 + 1), 220(2 = 2 + 0)
            static void MostSignificantDigit(int rangeFrom, int rangeTo)
            {
                int firstDigit = 0;
                int sumOfRestDigits = 0;
                for (int i = rangeFrom; i < rangeTo; i++)
                {
                    sumOfRestDigits = 0;
                    for (int a = 0; a < i.ToString().Length; a++)
                    {
                        firstDigit = i.ToString()[0] - '0';
                        sumOfRestDigits += i.ToString()[a] - '0';
                    }
                    if (firstDigit == sumOfRestDigits - firstDigit)
                    {
                        Console.Write(i);
                        Console.Write(" ");

                    }

                }
            }
            Console.WriteLine("Please enter number from which the range you want to start!");
            bool parsingSuccess1 = int.TryParse(Console.ReadLine(), out int firstParameter);
            Console.WriteLine("Please enter number till which the range you want to end!");

            bool parsingSuccess2 = int.TryParse(Console.ReadLine(), out int secondParameter);

            if (parsingSuccess1 && parsingSuccess2)
            {
                MostSignificantDigit(firstParameter, secondParameter);
            }
            else
            {
                Console.WriteLine("You need to enter valid numbers!");
            }

            Console.WriteLine("END");




            //6.Write a program that will print all the numbers in a given range that are
            //read the same from left to right and right to left, ex. 12321 5061605
            static void Palindrome(int rangeFrom, int rangeTo)
            {
                for (int i = rangeFrom; i < rangeTo; i++)
                {
                    string ofNumber = i.ToString();
                    string reversedNo = "";

                    for (int a = ofNumber.Length - 1; a >= 0; a--)
                    {
                        reversedNo += ofNumber[a];
                    }
                    if (reversedNo == ofNumber)
                    {
                        Console.WriteLine(reversedNo);
                    }



                }
            }

            Console.WriteLine("Please enter a range of 2 numbers!");
            Console.WriteLine("Enter your first number!");
            bool parsingSuccess3 = int.TryParse(Console.ReadLine(), out int no1);
            Console.WriteLine("Enter your second number!");
            bool parsingSuccess4 = int.TryParse(Console.ReadLine(), out int no2);

            for (; ; )
            {
                if (parsingSuccess3 && parsingSuccess4)
                {
                    Palindrome(no1, no2);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid numbers!");
                }
            }
        }
    }
}
