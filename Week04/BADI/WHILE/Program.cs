using System;
using System.Diagnostics;

namespace WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start! blijf doorgaan zolang je OK typt: ");
            string antwoord = Console.ReadLine(); // OK

            while (antwoord == "OK")
            {
                Console.Write("Geef opnieuw een woord in, OK gaat verder: ");
                antwoord = Console.ReadLine();
            }

            //gokspel --> gok verantwoord!
            Random randomGame = new Random();
            int getal = randomGame.Next(1, 20);

            Console.Write("Waag eens een gokje: ");
            int gok = Convert.ToInt32(Console.ReadLine());

            int beurten = 1;
            while (gok != getal && beurten < 5)
            {
                Console.Write("Waag nog een gok: ");
                gok = Convert.ToInt32(Console.ReadLine());
                beurten++;
            }

            Console.WriteLine($"Het getal was {getal} en je hebt dit proberen doen in {beurten} beurten!");



            //reeks van 3 6 9 12 15 18 21 ...
            Console.WriteLine("\nreeks van 3 6 9 12: ");
            int i = 3;
            while (i < 99)
            {
                Console.Write($"{i} ");
                i += 3;
            }

            //reeks van 3 6 9 12 15 18 21 ...
            //VERSIE 2
            Console.WriteLine("\nreeks van 3 6 9 12: ");
            i = 3;
            while (i < 99)
            {
                i += 3;
                Console.Write($"{i} ");
            }


            //voorbeeld van zelfde reeks met do-while
            Console.WriteLine("\nreeks van 3 6 9 12 MET DO WHILE: ");
            i = 3;
            do
            {
                i += 500;
                Console.Write(i + " ");
            } while (i < 99);
        }
    }
}