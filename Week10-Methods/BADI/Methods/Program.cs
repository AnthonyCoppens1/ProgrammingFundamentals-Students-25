using System;
using System.Data;

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
            int[] array = {9, 1, 8, 3, 6, 5, 2, 4, 10, 85, 31, 71, 45, 82};
            Print(array);
            Array.Sort(array);
            Print(array);
            Array.Reverse(array);
            Print(array);

            int[] getallen = Vullen();         
            Print(getallen); 

            string[] fruit = {"Banaan", "appel", "peer", "citroen", "mango", "appelsien"};
            Print(fruit);
            Array.Sort(fruit);
            Print(fruit);

            double[] doubles = {3.1, 2.2, 5.8, 3.9, 7.2};
            Print(doubles);

            bool[] B = {true, false, false, true, true, false, false, false};
            Print(B);
            Array.Sort(B);
            Print(B);


            int CijferVanStudent = 75;
            Console.WriteLine($"De student heeft {CijferVanStudent} als punt VOOR EXTRA CREDITS");
            //PASS BY REFERENCE
            ExtraCredits(ref CijferVanStudent);
            Console.WriteLine($"NA EXTRA CREDITS: {CijferVanStudent}");


            (int a, int b) = OptellenEnDelen(50, 10);

            Console.WriteLine($"optellen: {a} en delen: {b}");


            //oude versie van out
            Console.Write("Geef een grootte qua array: ");
            string antwoord = Console.ReadLine();
            int size;
            int[] arraytje;

            if (Int32.TryParse(antwoord, out size))
            {
                arraytje = Vullen(size);
            }
            else
            {
                arraytje = Vullen();
            }

            Print(arraytje);


            int opgeteld;
            int vermenigvuldigd;
            OpgeteldEnVermenigvuldigd(5, 10, out opgeteld, out vermenigvuldigd);
            Console.WriteLine($"De optelling was: {opgeteld} en de vermenigvuldiging was {vermenigvuldigd}");

            VoegSamen(12, 13, 14); //39
            VoegSamen(12, z:25); //38
            VoegSamen(y:5);


            //PARAMS KEYWORD
            int[] myArray = {5, 6, 7, 8, 9, 10};
            PrintArray(myArray);

            PrintArray(1, 2, 3, 4, 5, 6, 7, 8);

        }

        //Params als keyword voor een int[] bijvoorbeeld zorgt ervoor dat je in je main bij je method-call
        //gewoon een aantal getallen kan invoeren zonder op voorhand een array daar aan te
        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }



        static void VoegSamen(int x = 5, int y = 1, int z = 3)
        {
            Console.WriteLine(x + y + z);
        }

        static void OpgeteldEnVermenigvuldigd(int a, int b, out int opgeteld, out int vermenigvuldigd)
        {
            opgeteld = a + b;
            vermenigvuldigd = a * b;
        }

        static (int, int) OptellenEnDelen(int x, int y)
        {
            int optelsom = x + y;
            int deling = x / y;

            return (optelsom, deling);
        }


        //PASS BY REFERENCE
        static void ExtraCredits(ref int CijferVanStudent)
        {
            CijferVanStudent += 25;
        }

        //PASS BY VALUE METHODE, WAARDE IN MAIN BLIJFT ZELFDE
        /*static void ExtraCredits(int CijferVanStudent)
        {
            CijferVanStudent += 25;
        }
        */

        static int[] Vullen(int grootte = 20)
        {
            Random rd = new Random();
            int[] tijdelijk = new int[grootte];
            for (int i = 0; i < grootte; i++)
            {
                tijdelijk[i] = rd.Next(-6, 7);
            }
            Array.Sort(tijdelijk);
            return tijdelijk;

            //Array.Sort(tijdelijk); --> proberen een gesorteerde versie hieronder door te sturen
            //is dode code, vanaf een return eronder gebeurt niets!
        }

        static void Print(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }


        static void Print(bool[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
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