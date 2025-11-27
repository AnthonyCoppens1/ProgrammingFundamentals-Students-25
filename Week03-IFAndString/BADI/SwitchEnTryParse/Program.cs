using System;

namespace SwitchEnTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekdag = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekdag);
            string dagInWoorden = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dagInWoorden);


            DateTime datum = DateTime.Now;
            Console.WriteLine(datum);
            DateTime gisteren = new DateTime(2025, 09, 30);
            Console.WriteLine(gisteren.Year);

            DateTime geboortedatum = new DateTime(1995, 07, 31);

            switch (dagInWoorden)
            {
                case "Monday":
                    Console.WriteLine("kut, weer een nieuwe week");
                    break;
                case "Tuesday":
                    Console.WriteLine("leuk!");
                    break;
                case "Wednesday":
                    Console.WriteLine("ffs weer Anthony zien...");
                    break;
                case "Thursday":
                    Console.WriteLine("Donderdag is een dag als een andere");
                    break;
                case "Friday":
                    Console.WriteLine("Dit is de dag!!!");
                    break;
                case "WEEKEND":
                    Console.WriteLine("WOHOOOOO weekend");
                    break;
                default:
                    Console.WriteLine("Ben je nu echt zo incapabel dat je geen naam van een weekdag in het Engels kan typen");
                    break;
            }



            //TRYPARSE --> voorlopig om onze crashes en problemen op te lossen
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;

            if (x > y)
            {
                Console.WriteLine("x is groter dan y");
            }

            //ontwijken met een if en tryparse

            string antwoord = Console.ReadLine(); //30
            int z;
            bool succes = Int32.TryParse(antwoord, out z); //bool --> boolean --> enkel True of False, niets anders

            if (succes)
            {
                if (z > y)
                {
                    Console.WriteLine("z is groter dan y");
                }
            }
            else
            {
                Console.WriteLine("Oops, fout format van je input!");
                Console.WriteLine($"{antwoord} was je input");
            }


            //tryparsing deel 2
            //programma dat temp checkt en bij bepaalde temp voor ik iets uit
            if (!Double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine("Dit was geen correcte temperatuur");
            }
            else
            {

                if (temp < 0)
                {
                    Console.WriteLine("Veel te koud om buiten te komen.");
                }
            }


            
        }
    }
}