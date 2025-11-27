using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());

            int optelsom = optellen(getal1, getal2);

            Console.WriteLine(optelsom + 15);
        }

        static int optellen(int getal1, int getal2)
        {
            int optelsom = getal1 + getal2;
            return optelsom;
        }

        /*static int optellen()
        {
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            return getal1 + getal2;
        }*/


        //method waar input in de method gebeurt, beter met parameters werken
        /*static void optellen()
        {
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getal1 + getal2);
        }*/


        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}