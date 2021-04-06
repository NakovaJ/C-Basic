using System;

namespace Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program where a seven - digit number is entered from the keyboard. 
            //The program prints YES if the number is special and "NO" otherwise.A number is special
            //if it is divisible by its first digit and is not divisible by the sum of the last two,
            //or if it is not divisible by its second digit and is not divisible by the sum of the last two. 
            //Beware of dividing by 0, print an "Unvalid Number" message in such a case.
            Console.WriteLine("Please enter a 7 digit number!");
            bool parsingSuccess = int.TryParse(Console.ReadLine(), out int userNumber);
            if (parsingSuccess){
                if (userNumber.ToString().Length == 7)
                {
                    string userInputString = userNumber.ToString();
                    int firstDigit = userInputString[0] - '0';
                    int secondDigit = userInputString[1] - '0';
                    int lastDigit = userInputString[6] - '0';
                    int beforeLastDigit = userInputString[5] - '0';
                    if  (beforeLastDigit != 0 && lastDigit != 0)
                    {
                        if (userNumber % firstDigit == 0 && userNumber % (lastDigit + beforeLastDigit) != 0)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                    else if (secondDigit!=0 && beforeLastDigit!=0 && lastDigit!=0)
                    {
                        if(userNumber % secondDigit != 0 && userNumber % (lastDigit + beforeLastDigit) != 0)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("You should have entered 7 digit number!");
                }
            }
            else
            {
                Console.WriteLine("You did not enter a valid number!");
            }

            //2.Create a program that for a given date from standard input (in DD MM GGGG format)
            //will print YES or NO message
            //on standard output depending on whether the entered date is correct or not.
            //When determining the validity of the date,
            //all factors should be taken into account: whether the month is a number between 1 and 12, 
            //whether the day corresponds to the number of days in that month. 
            //If it is 29.02, be careful if it is a leap year.
            //A leap year is any year that is divisible by 400 or divisible by 4, but not by 100.
            Console.WriteLine("Please enter a date in the following format: DD MM GGGG");
            string userDate = Console.ReadLine();
            string[] splitted = userDate.Split(' ');
            foreach(string item in splitted)
            {
                item.Trim();
            }
            if (splitted.Length != 3)
            {
               
                Console.WriteLine("Sorry invalid format!");
            }
            else
            {
                if(splitted[0].Length!=2 || splitted[1].Length!=2 || splitted[2].Length != 4)
                {
                    Console.WriteLine("Sorry invalid format of date!");
 

                }
                else
                {

                    bool parsingSuccess1 = int.TryParse(splitted[0], out int day);
                    bool parsingSuccess2 = int.TryParse(splitted[1], out int month);
                    bool parsingSuccess3 = int.TryParse(splitted[2], out int year);
                    Console.WriteLine(parsingSuccess1);
                    Console.WriteLine(parsingSuccess2);
                    Console.WriteLine(parsingSuccess3);

                    if (parsingSuccess1 || parsingSuccess2 || parsingSuccess3)
                    {

                        if (month >= 1 && month < 13)
                        {
                            int rangeOfDays = 0;
                            switch (month)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12:
                                    rangeOfDays = 31;
                                    break;
                                case 2:
                                    rangeOfDays = 28;
                                    if (year % 4 == 0) rangeOfDays = 29;
                                    break;
                                case 4:
                                case 6:
                                case 9:
                                case 11:
                                    rangeOfDays = 30;
                                    break;

                            }

                            if (day <= rangeOfDays)
                            {
                                Console.WriteLine("YES");
                            }
                            else
                            {
                                Console.WriteLine("NO");
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You did not entered numbers as required!");

                    }
                }
               

            }

            //3.In a company all employees use one centralized system,
            //for which an account has been created.Username
            //to each employee is generated according to the ID of the employee, using the first dits
            //that give the date of birth will be taken and the value will be calculated:
            //day * 100 + month * 1000 + year
            //So if the part of the ID number that gives the date is 1103998,
            //then we get 11 * 100 + 3 * 1000 + 1998 = 6098.
            //If the number that will be obtained after the calculation is five digits, then it is the username.
            //Otherwise, if it is four digits, then the first digit is added to be:
            //            7 - if the year of birth is up to 1960
            //8 - if the year of birth is between 1961 - 1980
            //9 - if the year of birth is between 1981 - 1999
            //Note: All employees are considered to have been born before 1999.
            for(; ; )
            {
                Console.WriteLine("Please enter your date of birth in the folowing format DD/MM/YYYY and " +
             "we will provide you with your ID and Username");
                string[] userBirthDate = Console.ReadLine().Split('/');
                if (userBirthDate[0].Length != 2 || userBirthDate[1].Length != 2 || userBirthDate[2].Length != 4)
                {
                    Console.WriteLine("Please insert the birthdate in a proper format!");
                }
                else
                {
                    bool parsingSuccessful01 = int.TryParse(userBirthDate[0], out int date);
                    bool parsingSuccessful02 = int.TryParse(userBirthDate[1], out int month);
                    bool parsingSuccessful03 = int.TryParse(userBirthDate[2], out int year);
                    if (!parsingSuccessful01 || !parsingSuccessful02 || !parsingSuccessful03)
                    {
                        Console.WriteLine("You need to enter numbers in the given format!");
                    }
                    else if (year>1999){
                        Console.WriteLine("You're too young to work :)");
                    }
                    else
                    {
                        string Id = $"{userBirthDate[0]}{userBirthDate[1]}{userBirthDate[2].Substring(1)}";
                        Console.WriteLine($"Your Id number is:" + Id);
                        int username = date * 100 + month * 1000 + year;
                        
                       
                        if (username.ToString().Length == 5)
                        {
                            Console.WriteLine("Your UserName is: " + username);
                            break;
                        }
                        else
                        {
                            if (year <= 1960)
                            {
                                Console.WriteLine("Your UserName is: " + "7"+ username.ToString());
                                break;
                            }
                            else if(year>1960 && year <= 1980)
                            {
                                Console.WriteLine("Your UserName is: " + "8" + username.ToString());
                                break;

                            }
                            else if(year>1980 && year <= 1999)
                            {
                                Console.WriteLine("Your UserName is: " + "9" + username.ToString());
                                break;

                            }
                        }
                       
                    }

                }
            }
         



                        }
        
    }
}
