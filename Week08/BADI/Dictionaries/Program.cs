using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARIES EN HOE JE ZE MOET AANMAKEN

            Dictionary<int, string> woorden = new Dictionary<int,string>();

            woorden.Add(12, "Hallo");
            woorden.Add(3, "pony");
            woorden.Add(2, "mijn");
            woorden.Add(86, "naam");
            woorden.Add(30, "Anthony");

            //op een aantal manieren printen
            //loopen door keys

            foreach (int key in woorden.Keys)
            {
                Console.WriteLine(key);
            }

            //loopen door values
            foreach (string value in woorden.Values)
            {
                Console.WriteLine(value);
            }

            //als we ze samenhouden --> printen door ieder paar
            foreach (var pair in woorden)
            {
                Console.WriteLine($"De key is {pair.Key} en de value is: {pair.Value}");
                Console.WriteLine(pair + " ");
            }

            //nog een mogelijke iteratie
            //for-loop
            for (int i = 0; i < woorden.Count; i++)
            {
                Console.WriteLine($"DOORLOOPT DE VOLGORDE WAARIN IK BEN AANGEMAAKT ! {woorden.ElementAt(i)}");
            }

            //snelle manier om elementen (key en value) toe te voegen aan dictionary.
            //ALS hij er nog niet in staat wordt deze toegevoegd, anders pas je de waarde aan.
            woorden[10] = "Coppens";
            foreach (var pair in woorden)
            {
                Console.WriteLine(pair.Value);
            }

            //verwijderen
            woorden.Remove(3); //1 argument verwijdert key en value
            woorden.Remove(12, out string verwijdertWoord); //2 argumenten, verwijdert key en value, maar slaat value op

            Console.WriteLine(verwijdertWoord);

            //iets zoeken in dictionary, based on key of value
            if (woorden.ContainsKey(86))
            {
                Console.WriteLine(woorden[86]);
            }


            //andere types dictionaries
            Dictionary<string,double> doubles = new Dictionary<string, double>{{"a", 7.2}, {"b", 13.8},
            {"c", 1.1}, {"z", 3}};

            doubles.Add("letter", 8.8);
            doubles["d"] = 7;

            foreach (var pair in doubles)
            {
                Console.WriteLine(pair);
            }


            Dictionary<double, double> D = new Dictionary<double, double>{{1.2, 2.3}, {5.6, 9.2}, {0, 8.8}};

            string[] lijnen = File.ReadAllLines("file.txt");
            foreach (var lijn in lijnen)
            {
                Console.WriteLine(lijn);
            }








        
        }
    }
}