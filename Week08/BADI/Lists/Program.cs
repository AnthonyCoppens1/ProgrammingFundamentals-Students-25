using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //voorbeeld van arrays om te vergelijken met Lists
            //1D arrays

            int[] array = new int[5];
            array[0] = 5;
            array[1] = 10;
            array[2] = 15;
            array[3] = 20;
            array[4] = 25;

            //int[] array = { 5, 10, 15, 20, 25 }; --> andere manier om waarde aan array te koppelen

            //LISTS
            //variabele lengte die afhangt van de hoeveelheid elementen in de list op dat moment

            List<int> intjes = new List<int>();
            intjes.Add(5);
            intjes.Add(10);
            intjes.Add(15);
            intjes.Add(20);
            intjes.Add(25);

            //voegt element op einde van list steeds toe



            //print out list int
            //Console.WriteLine(intjes.Count); --> manier om te tellen hoe lang een list is.
            for (int i = 0; i < intjes.Count; i++)
            {
                Console.Write(intjes[i] + " ");
            }
            Console.WriteLine();


            //getallen toevoegen op een bepaalde plek
            intjes.Insert(2, 12); //--> oude positie schuift 1 index naar achter

            //wat als ik dezelfde index gebruik
            intjes.Insert(4, 21);
            intjes.Insert(4, 22);

            for (int i = 0; i < intjes.Count; i++)
            {
                Console.Write(intjes[i] + " ");
            }
            Console.WriteLine();

            //meerdere getallen toevoegen --> kan vanuit array
            int[] getallen = { 7, 8, 9 };
            intjes.AddRange(getallen); //maar 1 argument --> voegt array toe aan list

            //range op bepaalde plek
            intjes.InsertRange(1, getallen);


            //nog een manier op door de list te loopen
            foreach (int i in intjes)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(intjes.Count);

            //789 zit er 2 keer in --> zoeken naar een manier om 1 van de 2 te verwijderen
            intjes.Remove(7); //eerste index van specifiek getal wordt weggehaald!
            intjes.Remove(8);
            intjes.Remove(9);

            Console.WriteLine(intjes.Count);
            foreach (int i in intjes)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            intjes.Add(10);
            intjes.Add(10); //5 10 12 15 22 21 20 25 7 8 9 10 10

            intjes.RemoveAt(11); //verwijderen op specifieke index

            foreach (int i in intjes)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //nieuwe List vanaf dit punt, andere manier om getallen door te voeren
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(10);

            /*for (int i = 1; i < 9; i++)
            {
                N.Insert(i, i + 1);
            }*/

            /*for (int i = 2; i <= 9; i++)
            {
                N.Insert(i - 1, i);
            }*/

            for (int i = 9; i > 1; i--)
            {
                N.Insert(1, i);
            }
            /*volgorde hier is:
            1 10
            1 9 10
            1 8 9 10
            1 7 8 9 10
            1 6 7 8 9 10
            tot:
            1 2 3 4 5 6 7 8 9 10            
            */

            foreach (int i in N)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            //STRING IN EEN LIST
            List<string> str = new List<string> { "één", "twee", "drie" };

            foreach (var woord in str)
            {
                Console.Write(woord + " ");
            }
            Console.WriteLine();

            str.Add("vier");
            str.Add("vijf");
            str.Add("zes");

            str.Insert(2, "2,5"); //index 2 genomen en naar achter geduwd, rest komt erbij.

            str.Add("twee");
            foreach (var woord in str)
            {
                Console.Write(woord + " ");
            }
            Console.WriteLine();

            str.Remove("twee");
            str.RemoveAt(4); //"vijf" gaat eruit! --> want "twee" is er ook al uit --> één 2,5 drie vier vijf zes twee

            foreach (var woord in str)
            {
                Console.Write(woord + " ");
            }
            Console.WriteLine();

            //elementen zoeken in een list
            int index = str.IndexOf("drie");
            Console.WriteLine(index);

            str.Insert(0, "zes");
            //laatste index van iets
            int laatste = str.LastIndexOf("zes");
            Console.WriteLine(laatste); //reeks is: zes één 2,5 drie vier zes twee

            str.Add("Coppens");
            if (str.Contains("Coppens"))
            {
                index = str.IndexOf("Coppens");
                str.Insert(index, "Anthony");
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            //omzetten van een list naar array en omgekeerd
            string[] strings = str.ToArray();

            //van array naar list
            double[] D = { 2.1, 3.4, 5.2, 6.7, 9.8 };
            List<double> doubleList = D.ToList();


            //stel je krijgt input:
            string[] input = Console.ReadLine().Split(" ");
            int[] G = Array.ConvertAll(input, Convert.ToInt32);

            List<int> getalletjes = G.ToList();

            foreach (var getal in getalletjes)
            {
                Console.Write(getal + 1);
            }
            Console.WriteLine();


            //nog 2 voorbeelden van lists
            List<bool> B = new List<bool> { true, false, false, false, true, true, false };
            //MOGELIJK: List<List<int>> L = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 } };


            //voorbeeld van removeAll
            /*List<int> X = new List<int>{5, 6, 7, 8, 9, 5, 2, 5};
            int patroon = 5;
            var test = X.Where(item => Regex.IsMatch(item, patroon));
            
            zoeken naar manier om predicate<T> te structureren
            */

            

        }
    }
}