using System;

namespace Array1DTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, -3, 6, 9, 2, 3, -4, 5 };

            //easy ways of finding things like sum, min, max, average, median, sorting and reversing
            Console.WriteLine("Sum: " + array.Sum());
            Console.WriteLine("Min: " + array.Min());
            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Average: " + array.Average());

            Array.Sort(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //SORTING ALGORITHM
            //https://en.wikipedia.org/wiki/Bubble_sort

            //check from start, each adjacent pair --> if 2nd is bigger than the first, if not, swap and move 1
            //check again for array and repeat until the whole array is sorted

            for (int i = 0; i < array.Length; i++)
            { //checks multiple times for max of all elements x times
                for (int j = 0; j < array.Length - 1; j++)
                { //checks the array 1 time every number
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



        }
    }
}