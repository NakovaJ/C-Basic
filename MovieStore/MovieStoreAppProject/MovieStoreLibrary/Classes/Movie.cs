using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes
{
    public class Movie
    {
       public string Title { get; set; }
       public  string Description { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
        private int Price { get; set; }

        public Movie() { }
        
       
        public void SetPrice()
        {
            Random rnd = new Random();
            if (Year < 2000) {
                Price = rnd.Next(100, 200);
            }
            if(Year>=2000 && Year < 2010)
            {
                Price = rnd.Next(200, 300);
            }
            else
            {
                Price = rnd.Next(300, 500);
            }
        }
    }
}
