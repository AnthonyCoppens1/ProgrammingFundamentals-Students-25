using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Dit is een stukje tekst!");

            Console.Write("Dit is nog meer tekst die geen nieuwe lijn opent!!!!");
            Console.Write("NOG VEEL MEER TEKST!");

            //dit is een commentaarregel en ik kan hier blijven typen
            //dit is nog een regel
            /*DIt is een eerste regel comments
            ik kan op enter blijven duwen
            en alles hiertussen blijft commentaar
            dit wordt niet uitgevoerd door de computer*/

            string text = "beetje text";
            Console.WriteLine(text);
            text = "andere tekst";
            Console.WriteLine(text);

            //persoon verwelkomen bij naam
            string naam = Console.ReadLine();
            Console.WriteLine(naam);

            //opties om tekst te formatteren
            //optie 1
            Console.WriteLine("Hallo " + naam + "!");

            //optie 2
            Console.WriteLine($"Hallo {naam}!");

            //optie 3
            string x = "HELP";
            int y = 13;


            Console.WriteLine("Hallo {0}!", naam);
            Console.WriteLine("Hallo {0} {1} {2}!", naam, x, y);
            

        }
    }
}