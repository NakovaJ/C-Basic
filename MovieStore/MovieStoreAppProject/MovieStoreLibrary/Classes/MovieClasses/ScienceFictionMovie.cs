using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class ScienceFictionMovie:Movie
    {
        public ScienceFictionMovie()
        {
            Genre = MovieGenre.ScienceFiction;
        }
        public ScienceFictionMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
