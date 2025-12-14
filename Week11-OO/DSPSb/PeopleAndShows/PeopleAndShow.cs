using System;
using System.Diagnostics;

namespace PeopleAndShows
{
    public abstract class Media
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public Media(string title, string genre, int releaseyear)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseyear;
        }
    }

    public class Movie: Media
    {
        public Movie(string title, string genre, int releaseyear): base(title, genre, releaseyear)
        {
        }
        public override string ToString()
        {
            return $"MOVIE: {Title} made in {ReleaseYear}";
        }
        
    }

    public class Show: Media
    {

        public Show(string title, string genre, int releaseyear): base(title, genre, releaseyear)
        {
        }

        public override string ToString()
        {
            return $"SHOW: {Title} made in {ReleaseYear}";
        }
    }

    public class Person
    {
        //properties of objects of the class person
        //prop + tab for new property template --> doesnt work in codegrade
        public string Name { get; set; }
        public List<Media> FavouriteShowsAndMovies { get; set; } = new();
        private DateOnly Birthday { get; set; }
        public string Country { get; set; }
        public int Age { get {return AgeCalc();} }

        //constructor to be able to create an object of the class Person
        //ctor + tab for new constructor --> doesnt work in codegrade
        public Person(string name, DateOnly birthday, string country)
        {
            Name = name;
            Birthday = birthday;
            Country = country;
        }

        public override string ToString()
        {
            return $"Name: {Name} is {Age} year old and loves:\n";
        }

        private int AgeCalc()
        {
            DateTime now = DateTime.Now;
            int Age = now.Year - Birthday.Year;
            return Age;
        }


    }
}