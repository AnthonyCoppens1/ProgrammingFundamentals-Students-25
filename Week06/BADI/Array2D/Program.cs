using System;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D arrays aanmaken
            int[,] ints = new int[2, 3];
            string[,] fruit =
            {{"Banaan", "appel", "mango", "ananas"},
            {"aardbei", "citroen", "framboos", "kers"},
            {"perzik", "papaya", "kiwi", "kakifruit"}};

            //waarden oproepen
            Console.WriteLine($"eerste element: {fruit[0, 0]}");
            Console.WriteLine($"laatste element: {fruit[2, 3]}");
            Console.WriteLine($"laatste element: {fruit[fruit.GetLength(0) - 1, fruit.GetLength(1) - 1]}");
            Console.WriteLine(fruit.Length);
            Console.WriteLine($"rijen: {fruit.GetLength(0)}");
            Console.WriteLine($"kolommen: {fruit.GetLength(1)}");

            //erdoor loopen
            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            foreach (var item in fruit)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + " ");
                }
                Console.WriteLine();
            }


            //vullen met random getallen
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rd.Next(0, 1001);
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}