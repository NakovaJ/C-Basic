using System;

namespace Classes_and_Objects_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //Make a class Driver. Add properties: Name, Skill
            //Make a class Car. Add properties: Model, Speed and Driver
            //Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates
            //the skill multiplied by the speed of the car and return it as a result.
            //Make a method RaceCars() that will get two Car objects that will determine which car
            //will win and print the result in the console.
            static string RaceCars(Car car1, Car car2)
            {
                if (car1.CalculateSpeed() > car2.CalculateSpeed())
                {
                    return $"{car1.Model} driven by {car1.DriverName.Name} was driving {car1.Speed}km per hour and is faster than" +
                        $" {car2.Model} driven by {car2.DriverName.Name}, which was driving {car2.Speed} km per hour!";
                }
                else if (car2.CalculateSpeed() > car1.CalculateSpeed())
                {
                    return $"{car2.Model} driven by {car2.DriverName.Name} was driving {car2.Speed}km per hour and is faster than" +
                        $" {car1.Model} driven by {car1.DriverName.Name}, which was driving {car1.Speed} km per hour!";
                }
                else
                {
                    return $"{car1.Model} driven by {car1.DriverName.Name} is as fast as {car2.Model} driven by {car2.DriverName}.They were both driving with {car1.Speed}km per hour so there is no winner!";
                }
            }
            //Make 4 car objects and 4 driver objects.
            Driver bob = new Driver();
            bob.Name = "Bob";
            bob.Skill = 3;

            Driver greg = new Driver();
            greg.Name = "Greg";
            greg.Skill = 2;

            Driver jill = new Driver()
            {
                Name = "Jill",
                Skill = 5
            };

            Driver anne = new Driver()
            {
                Name = "Anne",
                Skill = 4
            };

            Car carNo1 = new Car();
            carNo1.Model = "Hyundai";
            carNo1.Speed = 200;

            Car carNo2 = new Car();
            carNo2.Model = "Mazda";
            carNo2.Speed = 180;


            Car carNo3 = new Car()
            {
                Model = "Ferrari",
                Speed = 210
            };
            Car carNo4 = new Car()
            {
                Model = "Porsche",
                Speed = 190
            };

            for(; ; ) { 
            //Ask the user to select a two cars and two drivers for the cars.
            //Add the drivers to the cars and call the RaceCars() methods
            Car car1 = carNo1;
            Car car2 = carNo1;
            Driver driver1 = bob;
            Driver driver2 = bob;
                //tuka imam prashanje, zoshto ako gi pisam Car car1; i Car car2;(vo smisla samo da pisam kako ke se vikaat i od koj tip se)
                //a ne im dadam inicijalna vrednost C# place?

            while (true)
            {
                Console.WriteLine("Please choose a racing car!");
                Console.WriteLine("For Hyundai enter 1!");
                Console.WriteLine("For Mazda enter 2!");
                Console.WriteLine("For Ferrari enter 3!");
                Console.WriteLine("For Porshe enter 4!");
                Console.WriteLine("      ");

                bool parsigSuccessfull = int.TryParse(Console.ReadLine(), out int carTypeUserInput1);
                if (parsigSuccessfull)
                {
                    if (carTypeUserInput1 == 1 || carTypeUserInput1 == 2 || carTypeUserInput1 == 3 || carTypeUserInput1 == 4)
                    {
                        switch (carTypeUserInput1)
                        {
                            case 1:
                                car1 = carNo1;
                                Console.WriteLine("Ok you choose Hyundai, now please choose a drver for you car!");
                                break;
                            case 2:
                                car1 = carNo2;
                                Console.WriteLine("Ok you choose Mazda, now please choose a drver for you car!");

                                break;
                            case 3:
                                car1 = carNo3;
                                Console.WriteLine("Ok you choose Ferrari, now please choose a drver for you car!");

                                break;
                            case 4:
                                car1 = carNo4;
                                Console.WriteLine("Ok you choose Porshe!");

                                break;

                        }

                        break;
                    }


                }

            }



            while (true)
            {
                Console.WriteLine("      ");

                Console.WriteLine("For Bob enter 1!");
                Console.WriteLine("For Greg enter 2!");
                Console.WriteLine("For Jill enter 3!");
                Console.WriteLine("For Anne enter 4!");
                Console.WriteLine("      ");


                bool parsingSuccessful = int.TryParse(Console.ReadLine(), out int driverUserInput1);
                if (parsingSuccessful)
                {
                    if (driverUserInput1 == 1 || driverUserInput1 == 2 || driverUserInput1 == 3 || driverUserInput1 == 4)
                    {
                        switch (driverUserInput1)
                        {
                            case 1:
                                driver1 = bob;
                                Console.WriteLine("You chose Bob as a driver!");
                                break;
                            case 2:
                                driver1 = greg;
                                Console.WriteLine("You chose Greg as a driver!");
                                break;
                            case 3:
                                driver1 = jill;
                                Console.WriteLine("You chose Jill as a driver!");
                                break;
                            case 4:
                                driver1 = anne;
                                Console.WriteLine("You chose Anne as a driver!");
                                break;
                        }
                        break;
                    }

                }
            }

            Console.WriteLine("   ");
            Console.WriteLine("Now you can choose a second car and a second driver!");
            Console.WriteLine(" Keep in mind that now you can not choose the same car and the same driver!");


            while (true)
            {

                Console.WriteLine("Please choose another racing car!");
                Console.WriteLine();
                Console.WriteLine("For Hyundai enter 1!");
                Console.WriteLine("For Mazda enter 2!");
                Console.WriteLine("For Ferrari enter 3!");
                Console.WriteLine("For Porshe enter 4!");
                Console.WriteLine("      ");


                bool parsigSuccessfull = int.TryParse(Console.ReadLine(), out int carTypeUserInput1);
                if (parsigSuccessfull)
                {
                    if (carTypeUserInput1 == 1 || carTypeUserInput1 == 2 || carTypeUserInput1 == 3 || carTypeUserInput1 == 4)
                    {

                        switch (carTypeUserInput1)
                        {
                            case 1:
                                car2 = carNo1;
                                Console.WriteLine("You choose Hyundai as a second car!");
                                break;
                            case 2:
                                car2 = carNo2;
                                Console.WriteLine("You choose Mazda as a second car!");

                                break;
                            case 3:
                                car2 = carNo3;
                                Console.WriteLine("You choose Ferrari as a second car!");

                                break;
                            case 4:
                                car2 = carNo4;
                                Console.WriteLine("You choose Porshe as a second car!");

                                break;

                        }
                        if (car1 != car2)
                        {
                            break;

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("And you can not chose the same car again!");
                            Console.WriteLine("That's why we kindly ask you to ");
                        }

                    }


                }

            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose a driver for this car!");
                Console.WriteLine("For Bob enter 1!");
                Console.WriteLine("For Greg enter 2!");
                Console.WriteLine("For Jill enter 3!");
                Console.WriteLine("For Anne enter 4!");

                bool parsingSuccessful = int.TryParse(Console.ReadLine(), out int driverUserInput1);
                if (parsingSuccessful)
                {
                    if (driverUserInput1 == 1 || driverUserInput1 == 2 || driverUserInput1 == 3 || driverUserInput1 == 4)
                    {
                        switch (driverUserInput1)
                        {
                            case 1:
                                driver2 = bob;
                                Console.WriteLine("You chose Bob as a driver");
                                break;
                            case 2:
                                driver2 = greg;
                                Console.WriteLine("You chose Greg as a driver");

                                break;
                            case 3:
                                driver2 = jill;
                                Console.WriteLine("You chose Jill as a driver");

                                break;
                            case 4:
                                driver2 = anne;
                                Console.WriteLine("You chose Anne as a driver");

                                break;
                        }
                        if (driver1 != driver2)
                        {
                            break;

                        }
                        else
                        {
                            Console.WriteLine("And you can not chose the same driver again That's why we kindly ask you to ");
                        }
                    }

                }
            }

            car1.DriverName = driver1;
            car2.DriverName = driver2;
            Console.WriteLine(RaceCars(car1, car2));

                string userPreference;

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to race again?");
                    Console.WriteLine("If yes ----> enter y ");
                    Console.WriteLine("If no------> enter n ");
                    string userAnswer = Console.ReadLine().ToLower();
                    userPreference = userAnswer;
                    if (userAnswer != "n" && userAnswer != "y")
                    {
                        Console.WriteLine("Please choose from the given answers!");
                    }
                    else
                    {
                        break;
                    }
                  
                }

                if (userPreference == "n") break;

               
            }
        //Test Data:
        //Choose a car no.1:
        //Hyundai
        //Mazda
        //Ferrari
        //Porsche
        //Choose Driver:
        //Bob
        //Greg
        //Jill
        //Anne
        //Choose a car no.2:
        //Hyundai
        //Mazda
        //Ferrari
        //Porsche
        //Choose Driver:
        //Bob
        //Greg
        //Jill
        //Anne
        //Expected Output:
        //Car no. 2 was faster.
        //BONUS 1: If a user chooses option one for the first care, eliminate that option when the user picks car two.

        //BONUS 2: Make the Output message say what was the model of the car that won,
        //what speed was it going and which driver was driving it.

        //BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat
        //the racing function.
    }
}
}
