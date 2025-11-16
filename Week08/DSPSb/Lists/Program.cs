using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using System.Xml.Serialization; //LIBRARY NEEDED FOR COLLECTIONS = LISTS AND DICTIONARIES

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //small mini recap of arrays
            //1D 
            int[] array = new int[5];
            array[0] = 5;
            array[1] = 10;
            array[2] = 15;
            array[3] = 20;
            array[4] = 25;

            //Lists and how to work with them!
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);
            numbers.Add(25);

            //combining the first 2 steps of previous part --> declaration and initialisation
            //List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };

            //LOOPING THROUGH CONTENT OF A LIST
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            //inserting
            numbers.Insert(2, 12);
            numbers.Insert(4, 21);
            numbers.Insert(4, 22);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //add multiple elements:
            int[] a = { 7, 8, 9 };
            numbers.AddRange(a); //adds the numbers to the back of the list

            //insert the range
            numbers.InsertRange(1, a);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //789 is double, remove some of them!
            numbers.Remove(7);
            numbers.Remove(8);
            numbers.Remove(9);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //inserting 5 in the middle
            numbers.Insert(5, 5);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //wanting to remove the duplicate 5 in the middle
            numbers.RemoveAt(5); // --> can also remove other numbers --> .RemoveAt(7) removes the '20'
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            //removing a section, an amount of numbers starting at a specific spot!
            numbers.RemoveRange(8, 3);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            string[] input = Console.ReadLine().Split();
            int[] inties = Array.ConvertAll(input, Convert.ToInt32);

            //converting an array into a list
            List<int> space = inties.ToList();

            //converting a list into an array
            int[] spots = numbers.ToArray();



            //some more practice on lists
            List<int> N = new List<int> { 1, 10 };
            //change the list from {1, 10} to --> {1, 2, 3, 4, 5, 6, 7, 8, 9 10}
            /*for (int i = 1; i <= 8; i++)
            {
                N.Insert(i, i + 1);
            }*/

            for (int i = 9; i > 1; i--)
            {
                N.Insert(1, i);
            }

            foreach (var number in N)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            //list of strings
            List<string> str = new List<string> { "one", "two", "three" };

            //str.Add("four and five"); --> beware if you're printing, "four and five" is one item in the list

            str.Add("four");
            str.Add("five");
            str.Add("six");
            str.Insert(0, "zero");
            str.Add("one");

            foreach (var word in str)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            str.Remove("one");
            str.RemoveAt(4);

            foreach (var word in str)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.WriteLine(str.IndexOf("three")); 

            int indexy = str.IndexOf("six");
            Console.WriteLine(indexy);


            str.Add("Coppens");

            if (str.Contains("Coppens"))
            {
                str.Insert(str.IndexOf("Coppens"), "Anthony");
            }

            foreach (var word in str)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            List<double> doubles = new List<double> { 2.3, 1.2, 4.5, 7, 3.8 };
            List<bool> boolies = new List<bool> { true, false, false, false, true, true, false };

            List<List<string>> stringies = new List<List<string>>{new List<string>{"help", "this"},
            new List<string>{"is", "too"},
            new List<string>{"difficult", "for"},
            new List<string>{"my", "brain"} };

            





        }
    }
}