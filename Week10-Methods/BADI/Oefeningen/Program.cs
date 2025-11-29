using System;

namespace Oefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //oefeningen van verschillende elementen combineren in methods
                string vraag = Console.ReadLine();
                switch (vraag)
                {
                    case "Factorial":
                        int getal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Factorial(getal));
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }

        static int Factorial(int getal)
        {
            int berekening = 1;

            for (int i = 1; i <= getal; i++)
            {
                berekening *= i;
            }

            return berekening;
        }
    }
}