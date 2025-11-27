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
            Console.WriteLine($"laatste getal van doubles: {doubles[doubles.Length - 1]}");


            //loopen door arrays
            //for loop

            for (int i = 0; i < doubles.Length; i++)
            {
                Console.Write(doubles[i] + " ");
            }
            Console.WriteLine();

            //while
            int index = 0;
            while (index < doubles.Length)
            {
                Console.Write(doubles[index] + " ");
                index++; //zonder deze = infinite loop
            }
            Console.WriteLine();

            //foreach
            foreach (double d in doubles)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();


            //array vullen met een for-loop MET random getallen
            int[] randomGetallen = new int[15];
            Random random = new Random();

            for (int i = 0; i < randomGetallen.Length; i++)
            {
                randomGetallen[i] = random.Next(0, 1001);
            }

            foreach (var item in randomGetallen)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //array klaarzetten en vullen adhv split
            Console.Write("Geef sauzen in, liefst je favoriete: ");
            string antwoord = Console.ReadLine();

            string[] sauzen = antwoord.Split(' ');

            foreach (var item in sauzen)
            {
                Console.Write(item + "--");
            }
            Console.WriteLine();


            //omzetten van array ene datatype naar het andere
            Console.Write("Geef een aantal getallen met spatie gesplitst: ");
            string[] getallen = Console.ReadLine().Split(' '); // "38 130 3877 20"
            int[] getallenOmTeRekenen = new int[getallen.Length];

            for (int i = 0; i < getallen.Length; i++)
            {
                getallenOmTeRekenen[i] = Convert.ToInt32(getallen[i]);
            }

            foreach (int item in getallenOmTeRekenen)
            {
                Console.Write((item + 5) + " ");
            }
            Console.WriteLine();


            getallenOmTeRekenen = Array.ConvertAll(getallen, Convert.ToInt32);



            //basis methodes om te gebruiken
            Console.WriteLine("som: " + getallenOmTeRekenen.Sum());
            Console.WriteLine("min: " + getallenOmTeRekenen.Min());
            Console.WriteLine("max: " + getallenOmTeRekenen.Max());
            Console.WriteLine("gemiddelde: " + getallenOmTeRekenen.Average());
            Array.Sort(getallenOmTeRekenen);
            foreach (int item in getallenOmTeRekenen)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Array.Reverse(getallenOmTeRekenen);

            foreach (int item in getallenOmTeRekenen)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //sorteren van een array op algoritmische manier!
            //BUBBLE SORT --> https://en.wikipedia.org/wiki/Bubble_sort
            //checken vanaf de start 2 opeenvolgende getallen, als eerste groter is dan tweede, wissel van
            //plaats, zoniet check volgende 2 tot 1 getal juist staat, begin opnieuw vanvoor en herhaal
            //tot alles gesorteerd is

            int[] array = { 1, 8, 9, 13, -5, 3, 4, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("gesorteerd: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}