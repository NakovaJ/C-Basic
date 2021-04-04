using System;

namespace Class_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create a class Student that has properties: Name, Academy and Group
            // ●Create an array with 5 new Students(objects )
            // ●The user should enter a name and the user information should be displayed in the console
            // if a user by that name exists
            // ●If there is no such user it should show an error message

            Student jelena = new Student()
            {
                Name = "Jelena",
                Academy = "SEDC",
                Group = "G4"
            };

            Student marjan = new Student()
            {
                Name = "Marjan",
                Academy = "SEDC",
                Group = "G1"
            };

            Student mihaela = new Student();
            mihaela.Name = "Mihaela";
            mihaela.Academy = "Kidergarden Academy";
            mihaela.Group = "3";

            Student marko = new Student();
            marko.Name = "Marko";
            marko.Academy = "Sport Academy";
            marko.Group = "Group 6";

            Student ana = new Student()
            {
                Name = "Ana",
                Academy = "xxx",
                Group = "G7"
            };
            Student[] allStudents = new Student[5] { jelena, marjan, mihaela, marko, ana };

            Console.WriteLine("Please enter the name of the student, whose data you want to check!");
            string userInput = Console.ReadLine().ToLower();

            int counter = 0;

            foreach (Student person in allStudents)
            {
                if (userInput == person.Name.ToLower())
                {
                    Console.WriteLine($"The student you are looking for is {person.Name}, " +
                        $"studing on {person.Academy} in group {person.Group}! ");
                }
                else
                {
                    counter++;
                    if(counter==5)
                    {
                        Console.WriteLine("Sorry there is no student with such a name in our database!");
                    }
                }

            }
        }
    }
}
