using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class HorrorMovie:Movie
        
    {
        public HorrorMovie()
        {
            Genre = MovieGenre.Horror;
        }
        public HorrorMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
