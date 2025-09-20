using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Anthony speaking!");

            Console.Write("TEST");
            Console.Write(" maybe one more test");

            string text = "I'm glad this class of 4 hours is almost over.";
            Console.WriteLine();
            Console.WriteLine(text);


            string name = "Ahmed";
            Console.WriteLine(name);

            /*name = "Dora";
            Console.WriteLine(name);*/

            name = Console.ReadLine();
            Console.WriteLine(name);

            //This is a comment, you can read it, but this is never executed. Only for information purposes.
            //blabla more comment
            /*This is comments
            This is still a comment line
            And we can keep on going*/

            //formatting text in Console.WriteLine()
            //option 1
            Console.WriteLine("Welcome to class " + name + ", how was your vacation?");

            //option 2
            Console.WriteLine($"Welcome to class {name}, how was your vacation?");

            //option 3
            string x = "in Mexico!!!";
            Console.WriteLine("Welcome to class {0}, how was your vacation?", name);
            Console.WriteLine("Welcome to class {0}, how was your vacation {1}?", name, x);

        }
    }
}