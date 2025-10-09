using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multiplication table of a given number
            Console.Write("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //idiot version
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");
            Console.WriteLine($"{number} * 5 = {number * 5}");
            Console.WriteLine($"{number} * 6 = {number * 6}");
            Console.WriteLine($"{number} * 7 = {number * 7}");
            Console.WriteLine($"{number} * 8 = {number * 8}");
            Console.WriteLine($"{number} * 9 = {number * 9}");
            Console.WriteLine($"{number} * 10 = {number * 10}");

            //better version
            Console.WriteLine("\n\nFOR LOOP i = 0 i <= 10");
            int result;

            for (int i = 0; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            Console.WriteLine("\n\nFOR LOOP i = 1 i <= 10");
            for (int i = 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World!");
            }


            Console.WriteLine("\n\nFOR LOOP i = 0 i <= 10 stepsize 2");
            for (int i = 0; i <= 10; i += 2)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            /* CAREFUL FOR AN INFINITE LOOP --> starting at 0 and multiplying by 0 = 0
            Console.WriteLine("\n\nFOR LOOP i = 0 i <= 10 stepsize multiply by 2");
            for (int i = 0; i <= 10; i *= 2)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }*/

            Console.WriteLine("\n\nFOR LOOP i = 0 i <= 10 stepsize multiply by 2");
            for (int i = 1; i <= 20; i *= 2)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine($"\nFOR LOOP i = 10 i >= 0 i--");
            for (int i = 10; i >= 0; i--) //i = i - 1 --> needed to make this one work
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            //typical sequences and how they run
            //multiple version of the sequence
            //print 3 6 9 12 15 18 21
            for (int i = 3; i <= 99; i += 3)
            {
                Console.Write(i + " "); //or $"{i} "
            }

            Console.WriteLine();
            for (int i = 1; i <= 33; i++)
            {
                result = i * 3;
                Console.Write(result + " ");
            }

            //same sequence but if we work with i only print the possible divisions of i
            Console.WriteLine("\nversion 3: 3 6 9 12 15 18 21 ...");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            //nesting loops --> loop in a loop
            Console.Write("\n\nEnter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTabel of j's");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            //table of dynamic stars
            Console.WriteLine("\nTable of stars");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //table of i
            Console.WriteLine("\nTable of i");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }



            //PYRAMID
            Console.WriteLine("\nPyramid");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}