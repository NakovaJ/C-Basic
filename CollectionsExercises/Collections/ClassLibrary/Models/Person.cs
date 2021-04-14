using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Models
{
    public class Person
    {
         public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public MusicGenre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person() { }

        public void GetFavouriteSongs()
        {
            if (FavouriteSongs.Count == 0)
            {
                Console.WriteLine("This person really hates music!");
            }
            else if(FavouriteSongs.Count==1)
            {
                Console.WriteLine($"This is {FirstName}'s favourite song:");
                Console.WriteLine();
                Console.WriteLine($" {FavouriteSongs[0].Title}!");
                Console.WriteLine($" It lasts {FavouriteSongs[0].Length} minutes!");
                Console.WriteLine($" And it is {FavouriteSongs[0].Genre} genre!");


            }
            else
            {
                Console.WriteLine($"These are {FirstName}'s favourite songs:");
                foreach(Song item in FavouriteSongs)
                {
                    Console.WriteLine();
                    Console.WriteLine($" {item.Title}!");
                    Console.WriteLine($" It lasts {item.Length} minutes!");
                    Console.WriteLine($" And it is {item.Genre} genre!");
                }
               
            }

        }


        //    ●Create a class Person with the following properties: Id, FirstName, LastName,
        //    Age, FavoriteMusicType(Genre enum) and FavoriteSongs
        //    ●FavoriteSongs is a list of Songs
        //    ●Create a method called GetFavSongs() that will print out all the
        //    titles of their favorite songs or write a message that this person 
        //    hates music if there are no favorite songs in their list
    }
}

