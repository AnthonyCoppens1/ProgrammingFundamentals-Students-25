using System;

namespace Array1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating arrays
            int[] intArray = new int[10]; //all values 0
            string[] stringArray = new string[4]; //all values are "" --> empty string

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);

            int[] ints = { 1, 3, 8, 23, 99 };

            //get some values
            Console.WriteLine($"First element of intArray is {intArray[0]}");
            Console.WriteLine($"Last element of doubles: {doubles[5]}");
            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length - 1]}");
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");

            // ^ starts counting at the back so ^1 is last index, ^2 is second to last, ...

            //assigning values
            stringArray[0] = "Jean";
            stringArray[1] = "Dina";
            stringArray[2] = "Ben";
            stringArray[3] = "Sparkles";

            //stringArray[4] = "New person from downstairs"; --> can't go past max length
            //Console.WriteLine(stringArray[4]);

            Console.WriteLine(doubles[^1]);
            doubles[5] = 1.0;
            Console.WriteLine(doubles[^1]);


            //loop through an array
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine(doubles[i]);
            }

            int index = 0;
            while (index < doubles.Length)
            {
                Console.WriteLine(doubles[index]);
                index++;
            }


            //overwrite existing arrays
            doubles = new double[] { 1, 3, 4, -1, -4, 55, 8.2, 89 };
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //filling an array with a loop --> for-loop
            for (int i = 0; i < intArray.Length; i++)
            {
                //intArray[i] = i * 4;
                //Console.Write(intArray[i] + " ");

                //with user input
                Console.Write($"Give me a value to store in the array: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //check the array
            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //filling an array with a split method
            Console.WriteLine($"Enter a bunch of animals split with a space: ");
            string answer = Console.ReadLine();
            string[] animals = answer.Split(" ");
            //panda dog whale grasshopper loon cat lion    goat
            
            foreach (var item in animals)
            {
                Console.Write(item + "++");
            }
            Console.WriteLine();


            //filling an array with numbers with split and converting
            Console.WriteLine($"Hit me up with a number sequence: ");
            answer = Console.ReadLine();
            string[] numbers = answer.Split(" ");
            int[] arrayOfInts = new int[numbers.Length];

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                arrayOfInts[i] = Convert.ToInt32(numbers[i]);
            }

            foreach (var item in arrayOfInts)
            {
                Console.Write((item +10) + " ");
            }
            Console.WriteLine();
        }
    }
}