using System;
using ClassLibrary.Enums;
using ClassLibrary.Models;
using System.Collections.Generic;


namespace MusicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Don't worry", 4.01, MusicGenre.Rock);
            Song song2 = new Song("Moonlight party", 3.17, MusicGenre.Techno);
            Song song3 = new Song("In and out of love", 3.09, MusicGenre.Techno);
            Song song4 = new Song("The marriage of Figaro", 4.51, MusicGenre.Classical);
            Song song5 = new Song("Mirror", 3.17, MusicGenre.Hip_Hop);
            Song song6 = new Song("Hey Hey", 2.57, MusicGenre.Hip_Hop);



            Person jelena1 = new Person()
            {
                FirstName = "Jelena",
                LastName = "Nakova",
                Age = 31,
                FavouriteMusicType = MusicGenre.Rock,
                FavouriteSongs = new List<Song>() { song1,song2,song3}
                
            };
            jelena1.GetFavouriteSongs();

            Person jelena2 = new Person()
            {
                FirstName = "Jelena",
                LastName = "Jankovich",
                Age = 32,
                FavouriteMusicType = MusicGenre.Techno,
                FavouriteSongs = new List<Song>() { }
            };
            Console.WriteLine();
            Console.WriteLine();

            jelena2.GetFavouriteSongs();

            Console.WriteLine();
            Console.WriteLine();

            Person jelena3 = new Person()
            {
                FirstName = "Jelena",
                LastName = "Jankovik",
                Age = 30,
                FavouriteMusicType = MusicGenre.Techno,
                FavouriteSongs = new List<Song>() { song5 }
            };
            jelena3.GetFavouriteSongs();


        }
    }
}
