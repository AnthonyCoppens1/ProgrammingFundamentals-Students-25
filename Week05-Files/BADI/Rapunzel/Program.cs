using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Rapunzel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //versie 1 file inlezen
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textOmTeChecken = sr.ReadToEnd();
            sr.Close();
            */

            //versie 2 file inlezen
            string text = File.ReadAllText("Rapunzel.txt");

            //letters in file
            Console.WriteLine($"aantal chars: {text.Length}");

            //lijnen tellen
            Console.WriteLine($"aantal lijnen: {File.ReadAllLines("Rapunzel.txt").Length}");

            StreamReader r = File.OpenText("Rapunzel.txt");
            int lijnen = 0;

            while (!r.EndOfStream)
            {
                r.ReadLine();
                lijnen++;
            }
            r.Close();
            Console.WriteLine($"# lijnen: {lijnen}");


            //we zoeken de w en W in de tekst
            //op 3 manieren zoeken, for, while en foreach
            //FOR om w's te tellen
            int teller = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'w' || text[i] == 'W')
                {
                    teller++;
                }
            }
            Console.WriteLine($"aantal w's = {teller}");


            //WHILE VERSIE
            teller = 0;
            r = File.OpenText("Rapunzel.txt");
            while (!r.EndOfStream)
            {
                char c = (char)r.Read();
                if (c == 119 || c == 87)
                {
                    teller++;
                }
            }
            Console.WriteLine($"aantal w's = {teller}");


            //foreach versie
            teller = 0;
            foreach (char item in text)
            {
                if ("wW".Contains(item))
                {
                    teller++;
                }
            }
            Console.WriteLine($"aantal w's = {teller}");

            //RAPUNZELS TELLEN
            string woord = "";
            int rapunzelteller = 0;

            foreach (char ch in text.ToLower()) //ref naar string text = File.ReadAllText("Rapunzel.txt");   
            {
                if (Char.IsLetter(ch)) // of "azertyuiopmlkjhgfdsqwxcvbn".Contains(ch)
                {
                    woord += ch;
                }
                else
                {
                    if (woord == "rapunzel")
                    {
                        rapunzelteller++;
                    }
                    woord = "";
                }
            }

            Console.WriteLine($"# rapunzels: {rapunzelteller}");


            //REGEX FOR LIFE
            //opnieuw rapunzels tellen met regex
            Regex rx = new Regex("rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine($"# rapunzels: {matches.Count}");

            rx = new Regex("rapunzel|RAPUNZEL|Rapunzel");
            matches = rx.Matches(text);
            Console.WriteLine($"# rapunzels: {matches.Count}");        


            rx = new Regex(@"\b\w+(?:'\w+)?", RegexOptions.IgnoreCase);
            matches = rx.Matches(text);
            Console.WriteLine($"# woorden: {matches.Count}");    

        }
    }
}