using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileCheck = Console.ReadLine(); //type a name of an artist --> e.g. Ed Sheeran
            Regex rg = new Regex(fileCheck.ToLower()); //looking for ed sheeran

            string text = File.ReadAllText(fileCheck.Replace(" ", "") + ".txt"); //transforms Ed Sheeran into EdSheeran.txt
            MatchCollection matches = rg.Matches(text);
            Console.WriteLine($"{matches.Count} occurences of {fileCheck}");

        
        }
    }
}