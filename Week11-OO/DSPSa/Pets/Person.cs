using System;

namespace Pets
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public Pet(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
        public override string ToString()
        {
            return $"{Name} is the best pet you will ever know.";
        }
    }


    public class Lion: Pet
    {
        public Lion(string name): base(name)
        {
        }

        public override string MakeSound() => "ROAR";        
    }

    public class Rabbit: Pet
    {
        public Rabbit(string name): base(name)
        {
        }

        //this is also a possible way to design or write your methods
        public override string MakeSound() => "AAAAAAAAAAAAA";
    }

    public class Goose: Pet
    {
        public Goose(string name): base(name)
        {
        }

        //this is also a possible way to design or write your methods
        public override string MakeSound() => "Honk Honk Honk";
    }

    public class Cat: Pet
    {
        public Cat(string name): base(name)
        {
        }

        public override string MakeSound()
        {
            return "MeowMeowMeow";
        }
    }

    public class Dog: Pet
    {

        public Dog(string name): base(name)
        {
        }

        public override string MakeSound()
        {
            return "BARKBARKBARK";
        }
    }

    public class Person
    {
        //prop + tab for shortcut to add a property
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
        public List<Pet> Pets { get; set; } = new();

        //ctor + tab for shortcut to add a constructor
        public Person(string name, DateOnly birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{Name} is a cool person!";
        }
    }
}