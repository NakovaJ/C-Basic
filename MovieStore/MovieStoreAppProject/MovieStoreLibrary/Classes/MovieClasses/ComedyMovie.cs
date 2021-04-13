using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class ComedyMovie:Movie
    {
        public ComedyMovie()
        {
            Genre = MovieGenre.Comedy;
        }
        public ComedyMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
