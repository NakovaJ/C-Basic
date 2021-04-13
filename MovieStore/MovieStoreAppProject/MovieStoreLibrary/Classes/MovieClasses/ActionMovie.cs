using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes.MovieClasses
{
    public class ActionMovie:Movie
    {
        public ActionMovie()
        {
            Genre = MovieGenre.Action;
        }
        public ActionMovie(string title,string description,int year)
        {
            Title = title;
            Description = description;
            Year = year;
        }

    }
}
