using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();

            Console.WriteLine(text);

            //een andere manier om door een file te gaan
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.WriteLine("**" + input.ReadLine()); //lees meteen een volledige lijn
            }
            input.Close();

            Console.WriteLine();

            //char per char lezen door een file
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write($" {(char)input.Read()}"); //lezen char per char na mekaar
            }
            input.Close();

            //foreach loop
            foreach (string lijn in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("-->" + lijn);
            }

            Console.WriteLine();
            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write("_" + c);
            }
        }
    }
}