using System;

namespace Tik_Tak
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 4:
            //Write a program, where for a given number entered via the keyboard, it will print:

            //"Tik" if divisible by 3,
            //"Tak" if divisible by 5,
            //"Tik - Tak" if divisible by 3 and 5.
            //If the number is not divisible by 3 or 5, then print "Bad number".
            int value;
            Console.WriteLine("Please insert a number!");
            bool parsingSuccess = int.TryParse(Console.ReadLine(), out int parsedNo);
            if (parsingSuccess)
            {
                if ( parsedNo % 3 == 0 && parsedNo % 5 == 0)
                {
                    value = 3;
                }
                else if (parsedNo % 5 == 0)
                {
                    value = 2;
                }
                else if (parsedNo % 3 == 0)
                {
                    value = 1;
                }
                else
                {
                    value = 0;
                };


                switch (value)
                {
                    case 1:
                        Console.WriteLine("Tik");
                        break;
                    case 2:
                        Console.WriteLine("Tak");
                        break;
                    case 3:
                        Console.WriteLine("Tik-Tak");
                        break;
                    case 0:
                        Console.WriteLine("Bad number");
                        break;
                };
               
              
            }
            else
            {
                Console.WriteLine("Eneter a valid number!");
            }
        }
    }
}
