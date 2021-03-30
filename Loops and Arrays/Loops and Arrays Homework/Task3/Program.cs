using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            //Get a number from the console between 1 and 2 and print the students from that group in the console.
            //Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            string[] G1 = new string [] { "Jelena", "Marko", "Mihaela", "Marjan", "Jana" };
            string[] G2 = new string[] { "Keti", "Stefan", "Ana", "Sofija", "Mihail" };
            Console.WriteLine("Please enter choose between G1 and G2 group, by entering 1 or 2!");

            for (; ; )
            {
                bool parsedOk = int.TryParse(Console.ReadLine(), out int userPreference);
                if (parsedOk)
                {
                    if(userPreference==1||userPreference==2)
                    {
                        switch (userPreference)
                        {
                            case 1:
                                foreach (string student in G1)
                                {
                                    Console.WriteLine(student);
                                }
                                break;
                            case 2:
                                foreach (string student in G2)
                                {
                                    Console.WriteLine(student);
                                }
                                break;
                           
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose exactly betwwen 1 or 2! Do not enter any other numbers!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter a number, not any other letter or scharacter!");
                }
            }
            
        }
    }
}
