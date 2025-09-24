using System;

namespace Variabelen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine();
            //Declareren en initialiseren
            string naam = "Anthony";

            //eerst declareren, daaronder initialiseren
            string N;
            N = "TEST";

            naam = "Alberto";
            Console.WriteLine(naam);

            char character = 'a';
            Console.WriteLine(character);

            int x, y;
            x = 5;
            y = 8;

            byte B = 240; //min 0 max 255
            short S = 18902; // 16 bit
            long L = 1823463248763487342; //64 bit

            Console.WriteLine(B);
            Console.WriteLine(x);
            Console.WriteLine(y);
            double D = 40.8923487364; //tot 15 cijfers na de komma
            float F = 40.789f;

            Console.WriteLine($"x = {x} en y = {y}");
            // ++ en -- --> optellen en aftrekken
            Console.WriteLine("x = " + x);
            x++; //x = x + 1
            Console.WriteLine("x = " + x);
            --x; //x = x - 1
            Console.WriteLine("x = " + x);

            //postfix en prefix
            Console.WriteLine($"x++ heeft als resultaat: {x++}");
            Console.WriteLine($"++x heeft als resultaat: {++x}");
            Console.WriteLine($"x-- heeft als resultaat: {x--}");
            Console.WriteLine($"--x heeft als resultaat: {--x}");

            //wiskundige operatoren
            Console.WriteLine($"{x} + {y} = {x + y}");//13
            Console.WriteLine($"{x} - {y} = {x - y}");//-3
            Console.WriteLine($"{x} * {y} = {x * y}");//40
            Console.WriteLine($"{x} / {y} = {x / y}");//0
            Console.WriteLine($"{x} % {y} = {x % y}"); //modulo -->5

            D = 17;
            x = 17;
            y = 8;
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} % {y} = {x % y}");

            Console.WriteLine(D / y);
            Console.WriteLine($"10 % 9 = {10 % 9}");
            Console.WriteLine($"10 % 8 = {10 % 8}");
            Console.WriteLine($"10 % 7 = {10 % 7}");
            Console.WriteLine($"10 % 6 = {10 % 6}");
            Console.WriteLine($"10 % 5 = {10 % 5}");
            Console.WriteLine($"10 % 4 = {10 % 4}");

            int resultaatNaDeling = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultaatNaDeling * 3)}");

            
        }
    }
}