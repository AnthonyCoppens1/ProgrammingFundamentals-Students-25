using System;
using System.IO;

namespace FilesReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opening a file to read through it and then closing it after we've done something with it
            //or doing something with it before closing.

            StreamReader sr = File.OpenText("Rapunzel.txt");
            string text = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine(text);

            //different way of print rapunzel's life story
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                Console.WriteLine("-->" + sr.ReadLine());
            }
            sr.Close();

            //reading char by char
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                Console.Write(" " + (char)sr.Read());
            }
            sr.Close();

            //foreach loop to make your life easy!
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("**!**" + item);
            }

            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write("_" + c);
            }





        }
    }
}