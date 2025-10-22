using System;

namespace ARRAY1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating arrays
            int[] intArray = new int[8]; // --> {0,0,0,0,0,0,0,0}
            string[] strings = new string[3]; // --> {"", "", ""}

            strings[0] = "Harry";
            strings[2] = "Hermione";
            strings[1] = "Voldemort";
            //strings[3] = "Ronald";
            //Console.WriteLine(strings[3]); --> size of strings is only 3, cannot push a 4th number.


            //combine creating and adding values
            double[] doubles = { 3.1, 2.8, 7, 13.5, 9, 12 };
            Console.WriteLine(doubles.Length);
            int[] ints = { 8, 2, 9, 5, 6, 3, 1, 7 };


            //calling for values from an array
            Console.WriteLine($"first char of doubles: {doubles[0]}");
            Console.WriteLine($"last char of doubles: {doubles[doubles.Length - 1]}");
            Console.WriteLine($"last char of doubles: {doubles[^1]}");
            Console.WriteLine($"last char of doubles: {doubles[5]}");

            //looping through arrays
            //for foreach while

            //for 
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.Write(doubles[i] + " ");
            }
            Console.WriteLine();

            //foreach
            foreach (double D in doubles)
            {
                Console.Write(D + " ");
            }
            Console.WriteLine();


            int index = 0;
            while (index < doubles.Length)
            {
                Console.Write(doubles[index] + " ");
                index++; //without this one, we have another infinite loop
            }
            Console.WriteLine();



            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //overwriting an existing array
            doubles = new double[] { 1, 3, -4.5, 2, 8, 7.3 };
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //filling an array 
            Random rd = new Random();
            //rd.Next(0, 1000);
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rd.Next(0, 1000);
            }

            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //filling an array with split
            Console.Write($"Give me your favourite car brands: ");
            string answer = Console.ReadLine();

            string[] carsForOrda = answer.Split(' ');
            //mercedes bmw porsche lexus ferrari lamborghini rangeRover jeep volkswagen audi opel peugeot dacia nissan seat skoda volvo ford saab
            foreach (var item in carsForOrda)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine();


            //filling and converting 2 WAYS --> algorithmic and oneliner
            Console.Write($"Provide me a sequence of numbers: ");

            string[] numberinos = Console.ReadLine().Split(' ');
            int[] numbers = new int[numberinos.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberinos[i]);
            }

            foreach (var item in numbers)
            {
                Console.Write((item + 12) + "-");
            }
            Console.WriteLine();


            //BIG ONELINER TO SAVE YOU TIME HOWEVER FORBIDDEN THIS WEEK

            numbers = Array.ConvertAll(numberinos, Convert.ToInt32);

            //some handy functions
            Console.WriteLine($"sum: {numbers.Sum()}");
            Console.WriteLine($"min: {numbers.Min()}");
            Console.WriteLine($"max: {numbers.Max()}");
            Console.WriteLine($"Average: {numbers.Average()}");

            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //ALGORTHMIC SORTING --> bubble sort
            //https://en.wikipedia.org/wiki/Bubble_sort

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            
        }
    }
}