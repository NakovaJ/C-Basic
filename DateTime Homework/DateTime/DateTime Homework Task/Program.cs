using System;

namespace DateTime_Homework_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task 1
            //Print the current date with time
            //Print the date that is 10 years from now
            //Print the date that is 2 months and 15 days ago
            //Print day of week for the next 8 - th March
            //Print day of week of last year's Valentine's day
            DateTime currentDateWithTime = DateTime.Now;
            Console.WriteLine(currentDateWithTime);
            DateTime currentDate = DateTime.Today;
            DateTime date10YearsFromNow = currentDate.AddYears(10);
            Console.WriteLine(date10YearsFromNow);
            DateTime date2MonthsAnd15DaysAgo = currentDate.AddMonths(-2).AddDays(-15);
            Console.WriteLine(date2MonthsAnd15DaysAgo);
            DayOfWeek next8ThOfMarch = new DateTime(2022,03,08).DayOfWeek;
            Console.WriteLine(next8ThOfMarch);
            DayOfWeek lastYearsValentinesDay = new DateTime(2020, 02, 14).DayOfWeek;
            Console.WriteLine(lastYearsValentinesDay);
        }
    }
}
