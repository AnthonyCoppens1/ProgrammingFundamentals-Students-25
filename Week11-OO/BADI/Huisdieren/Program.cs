using System;

namespace Huisdieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon Anthony = new Persoon("Anthony", "Coppens", new DateOnly(1995, 07, 31));
            Persoon Elke = new Persoon("Elke", "Boonen", new DateOnly(1980, 4, 23));
            Persoon Collin = new Persoon("Collin", "Van der Vorst", new DateOnly(1991, 04, 16));
            Persoon Romeo = new Persoon("Romeo", "Heylen", new DateOnly(2006, 05, 17));

            List<Persoon> Mensen = new List<Persoon>{Anthony, Elke, Collin, Romeo};
            foreach(Persoon p in Mensen)
            {
                if (p.Geboortedatum.Year > 1990)
                {
                    Console.WriteLine(p.Voornaam);
                }
            }

            Anthony.Dieren.Add(new Kat("Mops"));
            Anthony.Dieren.Add(new Kat("Yuki"));
            Elke.Dieren.Add(new Kat("Gerard"));
            Elke.Dieren.Add(new Walvis("Mieke"));
            Romeo.Dieren.Add(new Kat("Rio"));
            Romeo.Dieren.Add(new Kat("Mar"));
            Romeo.Dieren.Add(new Kat("Roos"));
            Romeo.Dieren.Add(new Hond("Hazel"));
            Romeo.Dieren.Add(new Hond("Scott"));
            Romeo.Dieren.Add(new Hond("June"));
            Romeo.Dieren.Add(new Walvis("SirPoopsAlot"));

            foreach (var persoon in Mensen)
            {
                Console.WriteLine(persoon);
                foreach (var dier in persoon.Dieren)
                {
                    Console.WriteLine($"\t- {dier}");
                }
                Console.WriteLine();
            }
        }
    }
}