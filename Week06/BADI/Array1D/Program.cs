using System;

namespace Array1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays aanmaken

            int[] intArray = new int[10]; //vaste lengte, zal nooit wijzigen
            string[] stringArray = new string[4];

            double[] doubles = { 3.2, 5.1, 8, 13, -5.4 };
            Console.WriteLine(doubles.Length);
            int[] ints = { 1, 3, 8, 9, 12, 23, 99, 48 };

            //waarden toevoegen
            stringArray[0] = "Jean";
            stringArray[1] = "Dina";
            stringArray[2] = "Ben";
            stringArray[3] = "Sparkles";

            //stringArray[4] = "Nieuwe bovenbuur!"; --> te grote index, max 4 posities

            Console.WriteLine(intArray[4]); //op dit punt is intArray gevuld met alleen maar nullen --> 0 0 0

            //oproepen van waarden
            Console.WriteLine($"eerste getal van doubles: {doubles[0]}");
            Console.WriteLine($"laatste getal van doubles: {doubles[4]}");
            Console.WriteLine($"laatste getal van doubles: {doubles[^1]}");
            Console.WriteLine($"laatste getal van doubles: {doubles[doubles.Length-1]}");

            


        }
    }
}