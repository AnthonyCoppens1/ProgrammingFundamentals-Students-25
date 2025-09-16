using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my pc!");
            Console.Write("checking the line");
            Console.Write(" This is another one to test");

            string x = "This text is saved here!";
            Console.WriteLine(x);

            string name = "Alexander";
            name = "Anthony";

            Console.WriteLine(name);
            Console.WriteLine();

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            //this is a comment, this keeps on going until I stop typing
            /*This is a comment
            this is still comments*/

            //option 1
            Console.WriteLine("Hello " + name + "!");

            //option 2
            Console.WriteLine($"Hello {name} {x}!");

            //option 3
            string y = "HELP";
            Console.WriteLine("Hello {0} {1}!", name, y);

        }
    }
}