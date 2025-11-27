using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multiply a given number by 1, 2, 3, ... --> multiplication table

            Console.Write("Enter a number: ");
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
            Console.WriteLine("\nFOR LOOP -> i = 0, i <= 10");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            Console.WriteLine("\nFOR LOOP -> i = 1, i <= 10"); //same as if --> i < 11
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            Console.WriteLine("\nFOR LOOP -> i = 0, i <= 10 STEPSIZE 2");
            for (int i = 0; i <= 10; i += 2) //i = 0 -> i = 2 -> i = 4 ... -> i = 10 -> i = 12 --> FALSE
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }


            Console.WriteLine("\nFOR LOOP -> i = 0, i <= 10 STEPSIZE 2");
            for (int i = 1; i <= 20; i *= 2)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            int result;
            Console.WriteLine("\nFOR LOOP i = 10; i >= 0; i--");
            for (int i = 10; i >= 0; i--)
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            //print sequence of 3 6 9 12 15 18 21 24 ... 99
            Console.WriteLine();
            Console.WriteLine("Sequence 1 of 3 6 9");
            for (int i = 1; i <= 33; i++) //i = 1 
            {
                result = i * 3;
                Console.Write(result + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sequence 2 of 3 6 9");
            for (int i = 3; i <= 100; i += 3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sequence 3 of 3 6 9");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            //nested loops
            Console.Write("\n\nEnter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ntable of the numbers housed by j");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ntable of the numbers housed by i");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            /*

            *
            * *
            * * *
            * * * *
            
            */
            Console.WriteLine("This is where my pyramid starts!");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }





        }
    }
}