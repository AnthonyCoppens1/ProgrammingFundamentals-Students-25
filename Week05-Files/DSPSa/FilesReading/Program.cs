using System;
using System.IO;

namespace FilesReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read a file by opening it and reading through its content. Either print out the text and close it
            //or close it and print

            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();

            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------");

            int lineNR = 1;

            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                string line = input.ReadLine();
                Console.WriteLine(lineNR + line);
                lineNR++;
            }

            input.Close();


            //reading through a text char by char and adding some element to split it.
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write(" " + (char)input.Read());
            }
            input.Close();


            //foreach loop
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("-->" + item);
            }

            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write("_" + c);
            }
        }
    }
}