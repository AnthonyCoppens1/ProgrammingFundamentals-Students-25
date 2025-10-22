using System;
using System.Xml.Serialization;

namespace ARRAY2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JAGGED ARRAYS DOWN THE BOTTOM
            //creating 2D
            int[,] ints = new int[2, 5];
            string[,] strings = new string[3, 3];

            strings[0, 0] = "Brown";
            strings[1, 2] = "Marron";

            string[,] animals = {{"Idunno", "Cat", "Komodo dragon", "ape", "dinosaur"},
            {"Zebra", "horse", "gazelle", "dog", "squirrel"}};

            //getting values
            Console.WriteLine(animals[1, 4]);

            animals[0, 0] = "Pig";
            Console.WriteLine(animals[0, 0]);

            Console.WriteLine(animals.Length); //total amount of items in the array
            Console.WriteLine($"rows: {animals.GetLength(0)}");
            Console.WriteLine($"cols: {animals.GetLength(1)}");

            //looping through content
            for (int i = 0; i < animals.GetLength(0); i++)
            {
                for (int j = 0; j < animals.GetLength(1); j++)
                {
                    Console.Write(animals[i, j] + " --> ");
                }
                Console.WriteLine();
            }

            //filling an array with random numbers again
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rd.Next(0, 1000);
                }
                Console.WriteLine();
            }


            //BEWARE a double foreach loop in 2D causes strings to be treated as split chars 
            foreach (string animal in animals)
            {
                foreach (var element in animal)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }


            //JAGGED ARRAYS
            //creating

            int[][] inties = new int[3][];
            inties[0] = new int[] { 1, 2, 3, 4 };
            inties[1] = new int[] { 5, 6 };
            inties[2] = new int[] { 7 };

            //creating and adding value immediately
            string[][] fruit = {new string[] {"apple", "pear", "mango"},
            new string[] {"kiwi", "pear", "lemon"},
            new string[] {"dragonfruit", "durian"}};

            double[][] doublinos = {new double[]{1.2, 3.4},
            new double[]{8.9}};

            //get values
            Console.WriteLine(fruit[1][2]);


            //looping through this
            for (int i = 0; i < fruit.Length; i++)
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write(fruit[i][j] + " ");
                }
                Console.WriteLine();
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

 
        }
    }
}