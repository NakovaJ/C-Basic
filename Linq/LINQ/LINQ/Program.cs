using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			Console.WriteLine("----all people aged 50 or more----");
			List<Person> pplAgeFiftyPlus = people
											.Where(x => x.Age > 50)
											.ToList();
			pplAgeFiftyPlus.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 02
			// all people name starts with B
			Console.WriteLine("----all people name starts with B----");

			List<Person> pplNameStartsWithB = people
											 .Where(x => x.FirstName.StartsWith("B"))
											 .ToList();
			pplNameStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("----first person whose surname starts with T----");

			List<Person>pplSurnameStartsWithT = people
									 .Where(x => x.LastName.StartsWith("T"))
									 .ToList();
			pplSurnameStartsWithT.ForEach(x => Console.WriteLine(x.LastName));
			// Task 04
			// find youngest and oldest person
			Console.WriteLine("------------find youngest and oldest person-------------");
			      Person youngestPerson = people
										   .OrderByDescending(x => x.Age)
										   .LastOrDefault();
			Console.WriteLine(youngestPerson.FirstName);
			Person oldestPerson = people
									.OrderByDescending(x => x.Age)
									.FirstOrDefault();
			Console.WriteLine(oldestPerson.FirstName);



			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("------------find all male people aged 45 or more-------------");

			List<Person> malePplAged45Plus = people
											 .Where(x => x.Gender == 'M')
											 .Where(x => x.Age >= 45)
											 .ToList();
			malePplAged45Plus.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 06
			// find all females whose name starts with V
			Console.WriteLine("------------find all females whose name starts with V-------------");

			List<Person> femaleNameStartsWithV = people
												 .Where(x => x.Gender == 'F')
												 .Where(x => x.FirstName.StartsWith("V"))
												 .ToList();
			femaleNameStartsWithV.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 07
			// find last female person older than 30 whose name starts with p
			Console.WriteLine("-----------find last female person older than 30 whose name starts with p-----------");

			Person lastFemaleOlderThan30StartsWithP = people
															.Where(x => x.Gender == 'F')
															.Where(x => x.Age > 30)
															.Where(x => x.FirstName.StartsWith("P"))
															.LastOrDefault();


			// Task 08
			// find first male younger than 40
			Console.WriteLine("-----------find first male younger than 40-----------");

			Person firstMaleYoungerThan40 = people
											 .Where(x => x.Gender == 'M')
											 .Where(x => x.Age < 40)
											 .FirstOrDefault();
			Console.WriteLine(firstMaleYoungerThan40.FirstName);

			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			Console.WriteLine("-----------print the names of the male persons that have firstName longer than lastName-----------");

			List<Person> malesWithLongerNames = people
												.Where(x => x.Gender == 'M')
												.Where(x => x.FirstName.Length > x.LastName.Length)
												.ToList();
			malesWithLongerNames.ForEach(x => Console.WriteLine(x.FirstName));
			Console.WriteLine(malesWithLongerNames.Count());

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			Console.WriteLine("-------print the lastNames of the female persons that have odd number of age-----------");

			List<Person> femalesWithOddNoAge = people
												 .Where(x => x.Gender == 'F')
												 .Where(x => x.Age % 2 != 0)
												 .ToList();
			femalesWithOddNoAge.ForEach(x => Console.WriteLine(x.LastName));
												 

        }
	}
}
