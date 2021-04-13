using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class FantasyMovie:Movie
    {
        public FantasyMovie()
        {
            Genre = MovieGenre.Fantasy;
        }
        public FantasyMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
