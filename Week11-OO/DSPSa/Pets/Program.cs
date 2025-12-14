using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Anthony = new Person("Anthony Coppens", new DateOnly(1995,07,31));
            Person Harkirat = new Person("Harkirat DDog", new DateOnly(2006, 09, 23));
            Person Rafaw = new Person("Rafaw Hoczyk", new DateOnly(2004, 01, 28));
            Person Milton = new Person("Milton Tahlah", new DateOnly(2005, 06, 01));
            Person Joyce = new Person("Joyce Agyeiwaa", new DateOnly(2005, 04, 23));
            Person Divine = new Person("Divine", new DateOnly(1950, 01, 01));

            List<Person> People = new List<Person>{Anthony, Harkirat, Rafaw, Milton, Joyce, Divine};

            foreach (var p in People)
            {
                Console.WriteLine(p.Birthday);
            }

            Console.WriteLine(People.Count);

            Harkirat.Pets.Add(new Dog("Hunter"));
            Harkirat.Pets.Add(new Goose("Goku"));
            Harkirat.Pets.Add(new Rabbit("Bugs"));
            Milton.Pets.Add(new Cat("HarryMeowMan"));
            Divine.Pets.Add(new Lion("Mike"));
            Divine.Pets.Add(new Goose("Francis"));
            Divine.Pets.Add(new Dog("Rocky"));
            Anthony.Pets.Add(new Cat("Yuki"));
            Anthony.Pets.Add(new Cat("Mops"));

            foreach (var person in People)
            {
                Console.WriteLine($"{person} and has the following pets: ");
                foreach(var pet in person.Pets)
                {
                    Console.WriteLine($"\t-{pet}");
                    Console.WriteLine($"\tAnd it goes: {pet.MakeSound()}");
                }
            }

            Console.WriteLine(Anthony);
            
        }
    }
}