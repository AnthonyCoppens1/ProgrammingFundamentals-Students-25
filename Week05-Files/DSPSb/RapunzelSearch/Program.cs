using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RapunzelSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 versions as a reminder of what we just saw
            //version 1
            /*StreamReader stream = File.OpenText("Rapunzel.txt");
            string textOfRapunzel = stream.ReadToEnd();
            stream.Close();*/

            //version 2
            string text = File.ReadAllText("Rapunzel.txt"); //opens, reads, saves and closes the file in 1 go!

            //amount of chars in a text?
            Console.WriteLine($"# of chars: {text.Length}");

            //counting the lines
            int lines = File.ReadAllLines("Rapunzel.txt").Length;
            Console.WriteLine($"number of lines: {lines}");

            //variant 2
            Console.WriteLine($"VARIANT 2 number of lines: {File.ReadAllLines("Rapunzel.txt").Length}");


            //variant 3
            StreamReader sr = File.OpenText("Rapunzel.txt");
            lines = 0;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();

            Console.WriteLine($"Number of lines in variant 3: {lines}");


            //counting individual characters --> F or f
            //for loop --> version 1
            int countF = 0;

            for (int i = 0; i < text.Length; i++) //7294 --> full length of the string aka text
            {
                if (text[i] == 'f' || text[i] == 'F')
                {
                    countF++;
                }
            }
            Console.WriteLine($"Amount of F's --> {countF}");


            //while loop --> version 2
            countF = 0;
            sr = File.OpenText("Rapunzel.txt");

            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if ("Ff".Contains(c))
                {
                    countF++;
                }
            }
            sr.Close();
            Console.WriteLine($"Amount of F --> WHILE VERSION: {countF}");


            //version 3: foreach
            countF = 0;
            foreach (char c in text.ToLower())
            {
                if (c == 'f')
                {
                    countF++;
                }
            }

            Console.WriteLine($"F's in the house of foreach: {countF}");



            //counting the amount of rapunzels in the text!
            //no-regex way
            string word = "";
            int counter = 0;

            foreach (char c in text.ToLower())
            {
                if (Char.IsLetter(c))
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        counter++;
                    }
                    word = "";
                }
            }
            Console.WriteLine($"Number of rapunzels: {counter}");


            //working with regex!!!
            Regex rx = new Regex("rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine($"Amount of rapunzels: {matches.Count}");

            //2489
            //regex to find the amount of words

            rx = new Regex(@"\b\w+(?:'\w+)?\b", RegexOptions.IgnoreCase);
            matches = rx.Matches(text);
            Console.WriteLine($"Amount of words: {matches.Count}");

            //regex to replace something
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            string s = regex.Replace(text, "Anthony");
            Console.WriteLine(s);
        }
    }
}