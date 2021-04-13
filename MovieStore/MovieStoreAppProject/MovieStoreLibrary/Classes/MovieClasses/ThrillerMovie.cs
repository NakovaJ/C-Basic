using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class ThrillerMovie:Movie
    {
        public ThrillerMovie()
        {
            Genre = MovieGenre.Thriller;
        }
        public ThrillerMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
