using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Models
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }

        public MusicGenre Genre { get; set; }

        public Song() { }
        public Song(string title,double length,MusicGenre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;

        }
    }
}
