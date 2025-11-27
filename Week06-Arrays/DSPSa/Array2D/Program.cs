using System;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JAGGED ARRAYS AT THE BOTTOM
            //creating 2D arrays
            int[,] ints = new int[4, 5];
            string[,] fruit = {{"apple", "pomelo", "banana", "starfruit"},
            {"kiwi", "orange", "lime", "pineapple"},
            {"fig", "mango", "watermelone", "pear"}};


            //getting values
            //do keep in mind we now start at 0,0
            Console.WriteLine($"First element of fruit: {fruit[0, 0]}");
            Console.WriteLine($"Grab orange from fruit: {fruit[1, 1]}");
            Console.WriteLine($"last item of fruit: {fruit[2, 3]}");

            Console.WriteLine(fruit.Length); //carefull --> length is going to grab the total of all elements
            Console.WriteLine("# of rows: " + fruit.GetLength(0));
            Console.WriteLine("# of cols: " + fruit.GetLength(1));

            Console.WriteLine(fruit[1, 0]);
            fruit[1, 0] = "dragonfruit";
            Console.WriteLine(fruit[1, 0]);



            //looping through existing array(2D)
            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //foreach treats the whole 2D array as 1.
            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //TESTING NESTED FOREACH --> careful, every word with the outer one is treated as a hit, inner one
            //is going to split char by char
            foreach (var item in fruit)
            {
                foreach (var f in item)
                {
                    Console.Write(f + " ");
                }
                Console.WriteLine();
            }


            //filling an array --> ints --> with random numbers
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rd.Next(0, 21);
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }



            /* JAGGED ARRAYS
            */
            //creating jagged arrays
            int[][] inties = new int[3][];
            inties[0] = new int[] { 1, 2, 3, 4 };
            inties[1] = new int[] { 5 };
            inties[2] = new int[] { 6, 8 };

            string[][] fruities = {new string[] {"apple", "pineapple"},
            new string[] {"Lime"},
            new string[] {"pear", "fig", "mango", "dragonfruit"}};

            double[][] doubles = {new double[] {3.2, 5.1},
            new double[] {1.2, 3.2, 4.2}};

            bool[][] bools = {new bool[] {true, false, false},
            new bool[] {true}};


            //GETTING VALUES
            Console.WriteLine(fruities[2][1]);
            Console.WriteLine(doubles[0][1]);
            doubles[0][1] = 7;
            Console.WriteLine(doubles[0][1]);

            //looping through them

            for (int i = 0; i < fruities.Length; i++)
            {
                for (int j = 0; j < fruities[i].Length; j++)
                {
                    Console.Write(fruities[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //test foreach again
            foreach (var item in fruities)
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