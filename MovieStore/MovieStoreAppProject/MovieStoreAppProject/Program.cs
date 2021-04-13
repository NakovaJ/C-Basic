using System;
using MovieStoreLibrary.Classes;
using MovieStoreLibrary.Classes.MovieClasses;
using MovieStoreLibrary.Enums;
using MovieAppServicies.ForEmployees;
using MovieAppServicies.ForCustomers;


using System.Linq;


namespace MovieStoreAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[] {
                new Employee("Jelena","Nakova",31,"jelena01","Jelena01","09/04/2021",70667891,200),
                new Employee("Marko", "Nakov", 15, "marko01", "Marko01","03/04/2021", 070998839,250),
                new Employee("Mihaela", "Nakova", 20, "mihaela01", "Mihaela01","01/01/2021", 070390234,300),
                new Employee("Marjan", "Nakov", 35, "marjan01", "Marjan01","03/04/2021", 075452568,90)
            };
            User[] customers = new User[]
            {
                new User("Ana","Apostolova",30,"anaana01","Anaana01",78123456,"02/02/2020",1001,"a",new Movie[]{

            new ComedyMovie("HotRode","Self-proclaimed stuntman Rod Kimble is preparing for the jump of his life - to clear fifteen buses to raise money for his abusive stepfather Frank's life-saving heart operation.",2007),
            new ActionMovie("Mad Max","In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.",2015),
                }),
                new User("Cvetan","Vasilev",25,"cvetan01","Cvetan01",075643928,"01/01/2021",1002,"m",new Movie[]{

            new CrimeMovie("The Irishman","An old man recalls his time painting houses for his friend, Jimmy Hoffa, through the 1950-70s.",2019),
            new HistoricalMovie("The imitation game","During World War II, the English mathematical genius Alan Turing tries to crack the German Enigma code with help from fellow mathematicians.",2014),
                }),
                new User("Gjoko","Gjorgiev",49,"gjoko01","Gjoko01",70456123,"09/08/2020",1003,"a",new Movie[]{
            new RomanceMovie("Titanik","A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",1997),
                }),
                new User("Keti","Koneva",36,"keti01","Keti01",72157982,"04/04/2021",1004,"m",new Movie[0]),
                new User("Vladimir","Stolev",78,"vladimirS","Vladimir01",075983451,"02/03/2021",1005,"m",new Movie[0]),
                new User("Jana","Taseva",56,"jana01","Janaa01",071832656,"31/12/2020",1006,"y",new Movie[]{
            new AdventureMovie("Avengers","Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.",2012),
            new FantasyMovie("The Hobbit","A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it from the dragon Smaug.",2012),
                }),
                new User("Ivana","Miteva",47,"ivana01","Inava01",072223876,"19/03/2021",1007,"m",new Movie[]{
            new ActionMovie("Die Hard","An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles.",1988),
                }),
                new User("Radica","Todorovska",29,"radica01","Radica01",76545997,"30/03/2021",1008,"y",new Movie[0]),
                new User("Toni","Davidov",68,"toni01","ToniDa01",70888463,"15/09/2020",1009,"y",new Movie[0]),
                new User("Nikola","Nikolovski",42,"nikola01","Nikola01",73090878,"01/02/2021",1010,"m",new Movie[0])

            };

            Member[] allMembers = new Member[]
            {
                 new Employee("Jelena","Nakova",31,"jelena01","Jelena01","09/04/2021",70667891,150),
                new Employee("Marko", "Nakov", 15, "marko01", "Marko01","03/04/2021", 070998839,250),
                new Employee("Mihaela", "Nakova", 20, "mihaela01", "Mihaela01","01/01/2021", 070390234,300),
                new Employee("Marjan", "Nakov", 35, "marjan01", "Marjan01","03/04/2021", 075452568,90),
                new User("Ana","Apostolova",30,"anaana01","Anaana01",78123456,"02/02/2020",1001,"a",new Movie[]{

            new ComedyMovie("HotRode","Self-proclaimed stuntman Rod Kimble is preparing for the jump of his life - to clear fifteen buses to raise money for his abusive stepfather Frank's life-saving heart operation.",2007),
            new ActionMovie("Mad Max","In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.",2015),
                }),
                new User("Cvetan","Vasilev",25,"cvetan01","Cvetan01",075643928,"01/01/2021",1002,"m",new Movie[]{

            new CrimeMovie("The Irishman","An old man recalls his time painting houses for his friend, Jimmy Hoffa, through the 1950-70s.",2019),
            new HistoricalMovie("The imitation game","During World War II, the English mathematical genius Alan Turing tries to crack the German Enigma code with help from fellow mathematicians.",2014),
                }),
                new User("Gjoko","Gjorgiev",49,"gjoko01","Gjoko01",70456123,"09/08/2020",1003,"a",new Movie[]{
            new RomanceMovie("Titanik","A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",1997),
                }),
                new User("Keti","Koneva",36,"keti01","Keti01",72157982,"04/04/2021",1004,"m",new Movie[0]),
                new User("Vladimir","Stolev",78,"vladimirS","Vladimir01",075983451,"02/03/2021",1005,"m",new Movie[0]),
                new User("Jana","Taseva",56,"jana01","Jana01",071832656,"31/12/2020",1006,"y",new Movie[]{
            new AdventureMovie("Avengers","Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.",2012),
            new FantasyMovie("The Hobbit","A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it from the dragon Smaug.",2012),
                }),
                new User("Ivana","Miteva",47,"ivana01","Inava01",072223876,"19/03/2021",1007,"m",new Movie[]{
            new ActionMovie("Die Hard","An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles.",1988),
                }),
                new User("Radica","Todorovska",29,"radica01","Radica01",76545997,"30/03/2021",1008,"y",new Movie[0]),
                new User("Toni","Davidov",68,"toni01","ToniDa01",70888463,"15/09/2020",1009,"y",new Movie[0]),
                new User("Nikola","Nikolovski",42,"nikola01","Nikola01",73090878,"01/02/2021",1010,"m",new Movie[0])
            };
            Movie[] allMovies = new Movie[]
            {
            new ActionMovie("Mad Max","In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max.",2015),
            new ActionMovie("Die Hard","An NYPD officer tries to save his wife and several others taken hostage by German terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles.",1988),
            new ActionMovie("Mission Impossible","Ethan Hunt and his IMF team, along with some familiar allies, race against time after a mission gone wrong.",2018),
            new AdventureMovie("LordOfTheRings","A young hobbit, Frodo, who has found the One Ring that belongs to the Dark Lord Sauron, begins his journey with eight companions to Mount Doom, the only place where it can be destroyed.",2001),
            new AdventureMovie("Avengers","Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.",2012),
            new ComedyMovie("HotRode","Self-proclaimed stuntman Rod Kimble is preparing for the jump of his life - to clear fifteen buses to raise money for his abusive stepfather Frank's life-saving heart operation.",2007),
            new ComedyMovie("GameNight","A group of friends who meet regularly for game nights find themselves entangled in a real-life mystery when the shady brother of one of them is seemingly kidnapped by dangerous gangsters.",2018),
            new ComedyMovie("The first wives club","Reunited by the death of a college friend, three divorced women seek revenge on the husbands who left them for younger women.",1996),
            new CrimeMovie("The Irishman","An old man recalls his time painting houses for his friend, Jimmy Hoffa, through the 1950-70s.",2019),
            new FantasyMovie("The Hobbit","A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it from the dragon Smaug.",2012),
            new HistoricalMovie("The imitation game","During World War II, the English mathematical genius Alan Turing tries to crack the German Enigma code with help from fellow mathematicians.",2014),
            new HorrorMovie("Middsomar","A couple travels to Scandinavia to visit a rural hometown's fabled Swedish mid-summer festival. What begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult.",2019),
            new RomanceMovie("Titanik","A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",1997),
            new ScienceFictionMovie("Interstelar","A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",2014),
            new ThrillerMovie("Gone Girl","With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.",2014)

            };

            while (true)
            {
                Console.Clear();
                string thread = ClassEmployee.WelcomeToMovieApp();
                //thread should be: login or register;
                Console.Clear();
                if (thread == "login")
                {
                    Console.Clear();
                    Member memberActive = ClassEmployee.Login(allMembers);
                    if (memberActive.Role == AppRole.Employee)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"Dear {memberActive.FirstName} we hope you are having a great working day!");
                        while (true)
                        {

                            Console.WriteLine();
                            Console.WriteLine("Please choose the coresponding number from the menu!");
                            Console.WriteLine("Press 1 -------->  Check registered members in the store!");
                            Console.WriteLine("Press 2 -------->  Movies!");
                            Console.WriteLine("Press 3 -------->  Add new user!");
                            Console.WriteLine("Press 4 -------->  Delete existing user!");
                            Console.WriteLine("Press 5 -------->  Check your estimated bonus for this month!");
                            Console.WriteLine("Press x -------->  To logout!");
                            string userInput = Console.ReadLine();
                            if (userInput.ToLower() == "x") break;


                            if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5")
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine($"Dear {memberActive.FirstName} we hope you are having a great working day!");
                                Console.WriteLine();
                                Console.WriteLine("Please choose only from the given options!!!");
                            }
                            else
                            {
                                switch (userInput)
                                {
                                    case "1":
                                        ClassEmployee.RegisteredUsers(allMembers, customers);
                                        break;

                                    case "2":
                                        ClassEmployee.DisplayMovies(customers, allMovies);
                                        break;
                                    case "3":
                                        User newUser = ClassEmployee.AddNewUser(allMembers, customers);
                                        Console.Clear();
                                        if (newUser.Age != 0)
                                        {
                                            Array.Resize(ref customers, customers.Length + 1);
                                            Array.Resize(ref allMembers, allMembers.Length + 1);
                                            customers[customers.Length - 1] = newUser;
                                            allMembers[allMembers.Length - 1] = newUser;
                                        }


                                        break;
                                    case "4":
                                        int[] results = ClassEmployee.DeleteExistingUser(customers, allMembers);
                                        while (true)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Are you sure you want to delete user {customers[results[0] - 1].FirstName} {customers[results[0] - 1].LastName} with username:{customers[results[0] - 1].UserName} and MemberID:{customers[results[0] - 1].MemberNumber}?");
                                            Console.WriteLine();
                                            Console.WriteLine("Press 1 ------->to delete this user!");
                                            Console.WriteLine("Press x ------->to cancel deleting of the user and go back!");
                                            string userPreference = Console.ReadLine();
                                            if (userPreference == "1")
                                            {
                                                customers = customers.Where((source, index) => index != results[0] - 1).ToArray();
                                                allMembers = allMembers.Where((source, index) => index != results[1]).ToArray();
                                                Console.Clear();
                                                break;
                                            }
                                            else if (userPreference == "x")
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Please choose only from the provided options!");
                                            }
                                        }



                                        break;
                                    case "5":
                                        ClassEmployee.CheckEmployeeBonus((Employee)memberActive);
                                        break;
                                }
                            }

                        }

                    }
                    else if (memberActive.Role == AppRole.User)
                    {
                        User userActive = null;
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"Dear {memberActive.FirstName} welcome to our awesome MOVIESTOREApp!");
                        while (true)
                        {

                            Console.WriteLine();
                            Console.WriteLine("Please choose the coresponding number from the menu!");
                            Console.WriteLine("Press 1 -------->  Check your info and subscription type!");
                            Console.WriteLine("Press 2 -------->  Check all movies we can offer you for rent!");
                            Console.WriteLine("Press 3 -------->  See all movies you owe to the movie store!!");
                            Console.WriteLine("Press x -------->  To logout!");
                            string userInput = Console.ReadLine();
                            if (userInput.ToLower() == "x") break;
                            if (userInput != "1" && userInput != "2" && userInput != "3")
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine($"Dear {memberActive.FirstName} welcome to our awesome MOVIESTOREApp!");
                                Console.WriteLine();
                                Console.WriteLine("Please choose only from the given options!!!");
                            
                            }
                            else
                            {
                                foreach (User person in customers)
                                {
                                    if (memberActive.UserName == person.UserName)
                                    {
                                        userActive = person;
                                    }
                                }
                                switch (userInput)
                                {
                                    case "1":
                                        Console.Clear();
                                        ClassCustomer.DisplayUserInfo(userActive);
                                        Console.Clear();
                                        break;
                                    case "2":
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("To go back to the previous menu press  x  !");
                                            Console.WriteLine();

                                            Console.WriteLine("DISPLAY ONLY INSTORE MOVIES:");
                                            Console.WriteLine();
                                            bool isMovieHere2 = false;
                                            int i = 1;
                                            Movie[] notRentedMovies = new Movie[0];

                                            foreach (Movie item in allMovies)
                                            {
                                                isMovieHere2 = false;

                                                foreach (User person in customers)
                                                {
                                                    foreach (Movie rentedMovie in person.RentedMovies)
                                                    {
                                                        if (rentedMovie.Title == item.Title)
                                                        {
                                                            isMovieHere2 = true;
                                                        }
                                                    }


                                                }

                                                if (!isMovieHere2)
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine($"Press {i}------>to rent this movie!");

                                                    Console.WriteLine($"TITLE: {item.Title}");
                                                    Console.WriteLine($"YEAR: {item.Year}");
                                                    Console.WriteLine($"DESCRIPTION: {item.Description}");
                                                    i++;
                                                    Array.Resize(ref notRentedMovies, notRentedMovies.Length + 1);
                                                    notRentedMovies[notRentedMovies.Length - 1] = new Movie()
                                                    {
                                                        Title = item.Title,
                                                        Year = item.Year,
                                                        Description = item.Description
                                                    };
                                                }

                                            }
                                            Movie[] xxx = userActive.RentedMovies;
                                            string x = Console.ReadLine();
                                            if (x.ToLower() == "x")
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                            bool successfulParsing = int.TryParse(x, out int requestedMovie);
                                            if (successfulParsing)
                                            {
                                                if (requestedMovie <= notRentedMovies.Length) { 
                                                foreach (Movie stuff in allMovies)
                                                {
                                                    if (notRentedMovies[requestedMovie - 1].Title == stuff.Title)
                                                    {
                                                        Array.Resize(ref xxx, xxx.Length + 1);
                                                        xxx[xxx.Length - 1] = stuff;
                                                        userActive.RentedMovies = xxx;
                                                        break;
                                                    }
                                                }
                                                Console.Clear();
                                                Console.WriteLine($" {notRentedMovies[requestedMovie - 1].Title} was successfully added to your list of Movies!");
                                                Console.WriteLine("Please press x ------> to go back!");
                                                if (Console.ReadLine() == "x")
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                                }
                                                
                                            }
                                            

                                            
                                        }
                                       
                                        break;
                                    case "3":
                                        Console.Clear();
                                        ClassCustomer.DisplayRentedMovies(userActive);
                                        Console.Clear();
                                        break;
                                }
                            }
                        }
                    }
                  

                }
                else
                {
                   
                   
                        User newUser = ClassCustomer.RegisterNewUser(allMembers, customers);
                        Console.Clear();
                        if (newUser.Age != 0)
                        {
       
                            Array.Resize(ref customers, customers.Length + 1);
                            Array.Resize(ref allMembers, allMembers.Length + 1);
                            customers[customers.Length - 1] = newUser;
                            allMembers[allMembers.Length - 1] = newUser;
                        }
                        
                    

                }

            }

































        }


    }
}

