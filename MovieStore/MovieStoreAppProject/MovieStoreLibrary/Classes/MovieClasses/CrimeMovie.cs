using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class CrimeMovie:Movie
    {
        public CrimeMovie()
        {
            Genre = MovieGenre.Crime;
        }
        public CrimeMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
