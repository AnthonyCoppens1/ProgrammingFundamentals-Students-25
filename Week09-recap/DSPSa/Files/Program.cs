using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //couple variants if we want to read in files
            //using a stream

            StreamReader reader = File.OpenText("file.txt");
            string text = reader.ReadToEnd(); //same as ReadAllText();
            reader.Close();

            Console.WriteLine("+" + text);


            //other variant with a stream
            int counter = 0;
            StreamReader s = File.OpenText("file.txt");
            while (!s.EndOfStream)
            {
                //string line = s.ReadLine();
                //char L = (char)s.Read();
                if ((char)s.Read() == 'e')
                {
                    counter++;
                }
            }
            s.Close();

            Console.WriteLine($"There are {counter} E's in THIS SECTION");
            

            //Variants without streams
            string[] file = File.ReadAllLines("file.txt");
            Console.WriteLine("\nLINE 3 IS THIS ONE: " + file[2]);

            string[] splitLine = file[2].Split(' ');
            for(int i = splitLine.Length-1; i >= 0; i--)
            {
                Console.Write(splitLine[i] + " ");
            }

            Console.WriteLine();
            int count = 0;
            string textOption2 = File.ReadAllText("file.txt");
            for (int i = 0; i < textOption2.Length; i++)
            {
                if (textOption2[i] == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine($"\nThere's {count} e's in the file");


        }
    }
}