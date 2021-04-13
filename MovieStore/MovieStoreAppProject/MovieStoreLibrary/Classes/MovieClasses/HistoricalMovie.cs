using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class HistoricalMovie:Movie
    {
        public HistoricalMovie()
        {
            Genre = MovieGenre.Historical;
        }
        public HistoricalMovie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }
    }
}
