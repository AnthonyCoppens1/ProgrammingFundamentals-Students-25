using System;
using System.IO;

namespace HarryCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using a csv/excel file to structure code and get information.
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Slytherin"))
                {
                    int firstSemi = item.IndexOf(';');
                    string newSentence = item.Substring(firstSemi + 1);
                    int secondSemi = newSentence.IndexOf(';');

                    Console.WriteLine(newSentence.Substring(0, secondSemi));
                }
            }

            //track species of ravenclaw
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Ravenclaw"))
                {
                    string[] parts = item.Split(';');
                    Console.WriteLine(parts[7]);
                }
            }
        }
    }
}