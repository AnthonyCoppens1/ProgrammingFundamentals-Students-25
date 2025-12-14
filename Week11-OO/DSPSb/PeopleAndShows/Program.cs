using System;

namespace PeopleAndShows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Vlad = new Person("Vlad", new DateOnly(2006, 12, 07), "Ukraine");
            Console.WriteLine(Vlad.Name);
            Console.WriteLine(Vlad); //PeopleAndShows.Person --> for now this won't work

            Person Anthony = new Person("Anthony", new DateOnly(1995, 07, 31), "Belgium");
            Person Ondrej = new Person("Ondrej", new DateOnly(2004, 09, 28), "Slovakia");
            Person Dries = new Person("Dries", new DateOnly(2006, 07, 07), "Belgium/Tunesia");
            Person Andy = new Person("Andy", new DateOnly(1997, 06, 10), "Taiwan");
            Person Maxim = new Person("Maxim", new DateOnly(2008, 04, 26), "Ukraine");
            Person Lina = new Person("Lina", new DateOnly(2006, 07, 05), "Bulgaria");
            Person Orda = new Person("Orda", new DateOnly(2004, 04, 11), "Rwanda");


            List<Person> people = new List<Person>{Vlad, Anthony, Ondrej, Dries, Andy, Maxim, Lina, Orda};
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Show OneTreeHill = new Show("One Tree Hill", "Basketball", 2003);
            Show Invincible = new Show("Invincible", "Superheroes", 2020);
            Show HowIMetYourMother = new Show("How I Met Your Mother", "Sit-Com", 2005);
            Show BreakingBad = new Show("BreakingBad", "Drugs", 2008);
            Show Severance = new Show("Severance", "Thriller", 2022);

            Movie Inception = new Movie("Inception", "Sci-fi", 2010);
            Movie Titanic = new Movie("Titanic", "Romance", 1997);
            Movie Dirt = new Movie("Dirt", "SnRnR", 2019);
            Movie DarkKnight = new Movie("The Dark Knight", "Thriller", 2008);
            Movie RedNotice = new Movie("RedNotice", "Action", 2021);

            Anthony.FavouriteShowsAndMovies.Add(OneTreeHill);
            Dries.FavouriteShowsAndMovies.Add(Invincible);
            Dries.FavouriteShowsAndMovies.Add(DarkKnight);
            Dries.FavouriteShowsAndMovies.Add(BreakingBad);
            Ondrej.FavouriteShowsAndMovies.Add(Dirt);
            Ondrej.FavouriteShowsAndMovies.Add(HowIMetYourMother);
            Anthony.FavouriteShowsAndMovies.Add(HowIMetYourMother);
            Andy.FavouriteShowsAndMovies.Add(Severance);
            Vlad.FavouriteShowsAndMovies.Add(Inception);
            Orda.FavouriteShowsAndMovies.Add(RedNotice);
            Orda.FavouriteShowsAndMovies.Add(Titanic);

            foreach(var person in people)
            {
                Console.WriteLine(person);
                foreach(var MovieOrShow in person.FavouriteShowsAndMovies)
                {
                    Console.WriteLine($"-{MovieOrShow}");
                }
                Console.WriteLine();
            }
            



        }
    }
}