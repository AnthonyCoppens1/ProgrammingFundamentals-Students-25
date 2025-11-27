using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HarryCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int first = item.IndexOf(';'); //finds the index of the first ; to determine where the first
                    //field ends and the second starts

                    string substring = item.Substring(first + 1);
                    int second = substring.IndexOf(';');
                    Console.WriteLine(substring.Substring(0, second));

                    //This CW --> prints the substring that starts at the beginning --> first char after first ;
                    //and goes until the end --> second ;
                }
            }

            Regex rx = new Regex(@"\d{4}");
            MatchCollection matches = rx.Matches(File.ReadAllText("Characters.csv"));

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value + " ");
            }
        }
    }
}