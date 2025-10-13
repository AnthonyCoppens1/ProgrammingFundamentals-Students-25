using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tafel van een getal --> maaltafel *1 *2 *3 ... *10

            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            //oude en slechte of domme optie
            Console.WriteLine($"{getal} * 1 = {getal * 1}");
            Console.WriteLine($"{getal} * 2 = {getal * 2}");
            Console.WriteLine($"{getal} * 3 = {getal * 3}");
            Console.WriteLine($"{getal} * 4 = {getal * 4}");
            Console.WriteLine($"{getal} * 5 = {getal * 5}");

            //betere versie
            Console.WriteLine("\nFOR LOOP i = 0, i <= 10");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            } // i van iterator


            Console.WriteLine("\nFOR LOOP i = 1, i <= 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }


            Console.WriteLine("\nFOR LOOP i = 0, i <= 10, stappen van 2");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }


            Console.WriteLine("\nFOR LOOP i = 0, i <= 10, veelvouden van 2");
            for (int i = 1; i <= 10; i *= 2)
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }


            Console.WriteLine("\nFOR LOOP i = 10, i >= 0, i--");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{getal} * {i} = {getal * i}");
            }


            //print de volgende reeks --> 3 6 9 12 15 18 --> 99
            for (int i = 3; i <= 99; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //versie 2
            for (int i = 1; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


            //versie 3
            int resultaat;
            for (int i = 1; i <= 33; i++)
            {
                resultaat = i * 3;
                Console.Write(resultaat + " ");
            }


            //loop in een loop
            Console.Write("\ngeef x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("geef y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }





        }
    }
}