using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class RomanceMovie:Movie
    {
        public RomanceMovie()
        {
            Genre = MovieGenre.Romance;
        }
        public RomanceMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
