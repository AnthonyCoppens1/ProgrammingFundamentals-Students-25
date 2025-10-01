using System;
using System.Globalization;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-statements

            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal < 50)
            {
                Console.WriteLine("Getal is kleiner dan 50");
            }
            else if (getal > 50)
            {
                Console.WriteLine("Getal is groter dan 50");
            }
            else
            {
                //getal == 50
                Console.WriteLine("Getal is exact 50");
            }

            //gaat de eerste uitvoeren die hij tegenkomt waar de voorwaarde als True wordt gezien

            /*else {
                --> else kan nooit een statement starten
            }*/

            if (getal == 50)
            {
                Console.WriteLine("exact 50");
            }
            else
            {
                Console.WriteLine("NIET 50");
            }


            //nog een optie / optie 2
            if (getal < 50)
            {
                Console.WriteLine("KLEINER");
            }
            else
            {
                if (getal > 50)
                {
                    Console.WriteLine("GROTER");
                }
                else
                {
                    Console.WriteLine("EXACT");
                }
            }

            //optie 3
            if (getal != 50)
            {
                if (getal < 50)
                {
                    Console.WriteLine("kleiner dan 50");
                }
                else
                {
                    Console.WriteLine("groter dan 50");
                }
            }
            else
            {
                Console.WriteLine("exact 50");
            }


            //combinaties tussen if-statements en meerdere voorwaarden
            //check of een getal gelijk is of niet gelijk is aan 50
            //optie 1
            if (getal == 50)
            {
                Console.WriteLine("GELIJK");
            }
            else
            {
                Console.WriteLine("NIET GELIJK");
            }

            //optie 2
            if (getal < 50 || getal > 50)
            {
                Console.WriteLine("getal is niet 50");
            }
            else
            {
                Console.WriteLine("Getal is 50");
            }

            //optie 3
            if (getal != 50)
            {
                Console.WriteLine("anders dan 50");
            }
            else
            {
                Console.WriteLine("wel 50");
            }

            //optie 4
            if (!(getal == 50))
            {
                Console.WriteLine("Alles behalve 50");
            }
            else
            {
                Console.WriteLine("Wel 50");
            }

            //optie 5
            if (!(getal < 50) && !(getal > 50))
            {
                Console.WriteLine("Getal is 50");
            }

            //optie 6
            bool voorwaarde = getal != 50;
            if (voorwaarde) //voorwaarde momenteel is False, we checken of True == False
            {
                Console.WriteLine("Niet gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Wel 50");
            }

            //optie 7
            if (!voorwaarde)
            {
                Console.WriteLine("50");
            }
            else
            {
                Console.WriteLine("NIET 50");
            }





        }
    }
}