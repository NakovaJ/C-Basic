using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Write a program that will generate an appropriate grade for the entered number of exam points!

            Console.WriteLine("Please enter the number of points you have!");
            bool parsingSuccess = int.TryParse(Console.ReadLine(), out int points);
            if (parsingSuccess)
            {
                int plusMinus = points % 10;
                char x = ' ';

                if (points <= 50)
                {
                   
                    Console.WriteLine($"You have grade 5{x} !");
                }
                else if (points>50 && points<=60)
                {
                    if (plusMinus == 1 || plusMinus == 2 || plusMinus == 3) x = '-';
                    if (plusMinus == 8 || plusMinus == 9 || plusMinus == 0) x = '+';
                    Console.WriteLine($"You have grade 6{x} !");
                }
                else if(points>60 && points <= 70)
                {
                    if (plusMinus == 1 || plusMinus == 2 || plusMinus == 3) x = '-';
                    if (plusMinus == 8 || plusMinus == 9 || plusMinus == 0) x = '+';
                    Console.WriteLine($"You have grade 7{x} !");

                }
                else if (points > 70 && points <= 80)
                {
                    if (plusMinus == 1 || plusMinus == 2 || plusMinus == 3) x = '-';
                    if (plusMinus == 8 || plusMinus == 9 || plusMinus == 0) x = '+';
                    Console.WriteLine($"You have grade 8{x} !");

                }
                else if (points > 80 && points <= 90)
                {
                    if (plusMinus == 1 || plusMinus == 2 || plusMinus == 3) x = '-';
                    if (plusMinus == 8 || plusMinus == 9 || plusMinus == 0) x = '+';
                    Console.WriteLine($"You have grade 9{x} !");

                }
                else if (points > 90 && points <= 100)
                {
                    if (plusMinus == 1 || plusMinus == 2 || plusMinus == 3) x = '-';
                    if (plusMinus == 8 || plusMinus == 9 || plusMinus == 0) x = '+';
                    Console.WriteLine($"You have grade 10{x} !");

                }
                else
                {
                    Console.WriteLine("You didn't enter correct number of points!");
                }
            }
            else
            {
                Console.WriteLine("You didn't enter valid input of points!");
            }





        }
    }
}
