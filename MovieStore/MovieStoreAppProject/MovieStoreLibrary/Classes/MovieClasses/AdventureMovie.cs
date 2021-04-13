using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class AdventureMovie:Movie
    {
        public AdventureMovie()
        {
            Genre = MovieGenre.Adventure;
        }
        public AdventureMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
