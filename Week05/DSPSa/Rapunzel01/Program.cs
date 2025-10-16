using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Rapunzel01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*couple of versions of opening a file and reading all content*/

            //VERSION 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //VERSION 2
            string text = File.ReadAllText("Rapunzel.txt");

            //count the characters
            Console.WriteLine($"# of chars: {text.Length}");

            //count the lines
            Console.WriteLine($"# of lines: {File.ReadAllLines("Rapunzel.txt").Length}");

            //different way of counting lines --> read them in with a while
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();
            Console.WriteLine($"# of lines: {lines}");


            //check for w or W
            //version 1: while
            int countW = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (c == 'w' || c == 'W')
                {
                    countW++;
                }

                //other variant of the if-statement
                //if ("wW".Contains(c)) countW++;

            }
            sr.Close();
            Console.WriteLine($"Number of W or w: {countW}");


            //VERSION 2: FOREACH
            countW = 0;
            foreach (char ch in text.ToLower())
            {
                if (ch == 'w')
                {
                    countW++;
                }
            }
            Console.WriteLine($"amount of W's or w's: {countW}");


            //VERSION 3: FOR LOOP
            countW = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 119 || text[i] == 87)
                {
                    countW++;
                }
            }
            Console.WriteLine($"w's or W's --> {countW}");



            //counting the words Rapunzel and how many times it occurs
            string word = "";
            int countRapunzel = 0;

            foreach (char c in text.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        countRapunzel++;
                    }
                    word = "";
                }
            }
            Console.WriteLine($"# of rapunzels: {countRapunzel}");

            //REGEX
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            //other option --> Regex regex = new Regex("Rapunzel|RAPUNZEL|rapunzel");

            //text is a ref to --> string text = File.ReadAllText("Rapunzel.txt");
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"amount of Rapunzels: {matches.Count}");

            //real actual words:
            regex = new Regex(@"\b\w+(?:'\w+)?\b", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine($"amount of words: {matches.Count}");

            Regex r = new Regex("Rapunzel", RegexOptions.IgnoreCase);
            string s = r.Replace(text, "Anthony");
            Console.WriteLine(s);





        }
    }
}