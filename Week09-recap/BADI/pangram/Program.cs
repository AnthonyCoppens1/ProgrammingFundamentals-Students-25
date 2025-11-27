using System;

namespace pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lijnen = File.ReadAllLines("tekst.txt".ToLower());
            //Gebruik lijnen [0]
            //Dictionary aanmaken
            Dictionary <char, int> X = new Dictionary <char, int> ();
            //Je kan ook alles de waarde 0 geven, en kijken tegenover het alfabet
            //zo in de text de ontbrekende bv 1 te geven

            foreach (char c in lijnen[0])
            {
                if (!X.ContainsKey(c)) //Als het de key nog niet bevat
                {
                    X[c] = 1;
                    //of
                    //D.Add(c, 1);
                }
                else
                {
                    //x = x + 1;
                    //x += 1;
                    //x++;
                    //Dus bij deze
                    X[c]++;
                    //Wat er hier gebeurt is D[c] telt als value 1 op
                    //{{'d: 1}}: 'd': 1 'e' : 2 ' ' : 1 'b' : 1 'r' : 1 'u' : 1
                    // de bruine lynx springt op de zijde zachte vrouw met grote poten
                }

            }
            string alfa = "abcdefghijklmnopqrstuvwxyz";
            string ontbreekt ="";
            foreach (char c in alfa)
            {
                if (!X.ContainsKey(c))
                {
                    ontbreekt+=c;
                }
               
            }
            Console.WriteLine(ontbreekt);

            //Databank van studenten
            //Welke queries gebruiken we voor een data
            //INSERT UPDATE DELETE
            //Naam, geboortedatum, opleiding, fase

            List<string> naam = new List<string> ();
            List<DateTime> geboorteDatum = new List<DateTime> ();
            List<string> opleiding = new List<string> ();
            List<int> fase = new List<int> ();
            Console.WriteLine();
            string input = Console.ReadLine();
            Console.WriteLine("Write STOP to stop the program");
            while (input != "STOP")
            {
                if (input == "INSERT")
                {
                    Console.Write($"naam : ");
                    naam.Add(Console.ReadLine());
                    Console.Write($"Geboortedatum : ");
                    geboorteDatum.Add(Convert.ToDateTime(Console.ReadLine()));
                    Console.Write($"Fase : ");

                }
               
            }
        }
    }
}
            