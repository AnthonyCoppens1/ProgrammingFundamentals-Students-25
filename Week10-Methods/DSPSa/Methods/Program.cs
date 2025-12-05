using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Methods
{
    internal class Program
    {
        //static int[] numbers = {4, 5, 1, 0, 2, 3};

        static void Main(string[] args)
        {
            
            HelloWorld();
            Console.WriteLine(Add(5, 10));
            int answer = Add(201, 99);
            Console.WriteLine(answer + 15);

            int[] numbers = {8, 3, 1, 7, 2, 5, 4};
            Print(numbers);
            Array.Sort(numbers);
            Print(numbers);
            Array.Reverse(numbers);
            Print(numbers);


            /*int size = Convert.ToInt32(Console.ReadLine());
            int[] newArray = Fill(size);
            Print(newArray);*/

            //Print(Fill(size)); --> second option if you don't want to save this first

            int[] newArray = Fill();
            Print(newArray);

            double[] D = {3.1, 7.8, 12.61, 3.9};
            Print(D);

            bool[] B = {true, false, false, false, true, true, false};
            Print(B);


            //2 BIG DIFFERENCES
            //PASS BY VALUE VS PASS BY REFERENCE
            //by value
            int studentGrade = 75;
            Console.WriteLine($"Good job, your grade is {studentGrade}!");
            GiveExtra(studentGrade); //you'll see the grade doesn't update
            Console.WriteLine($"AMAZING, after the extra credits you have: {studentGrade}");

            //by reference
            int[] grades = new int[1];
            grades[0] = 80;
            Console.WriteLine($"Superb job, your grade is now {grades[0]}");
            GiveExtra(ref grades);
            Console.WriteLine($"Another amazing test, I knew I believed in you! {grades[0]}");


            //returning multiple datatypes with a method
            int x = 8;
            int y = 10;
            
            (int multi, int sub) =  MultiplyAndSubtract(x,y);
            Console.WriteLine($"The multi is {multi} and the subtraction is {sub}");


            //using OUT
            //old way with TryParse()
            Console.WriteLine($"Enter an array size: ");
            string answerino = Console.ReadLine();
            
            int newSize;
            int[] A;

            if (Int32.TryParse(answerino, out newSize))
            {
                A = Fill(newSize);
            }
            else
            {
                A = Fill();
            }
            Print(A);


            //ANOTHER WAY OF USING OUT IN COMBINATION WITH METHODS
            int addition;
            int multiply;

            AddAndMulti(10, 25, out addition, out multiply);
            Console.WriteLine(addition);
            Console.WriteLine(multiply);


            //optional parameters
            AddRandomNumbers(15);
            AddRandomNumbers(10, 9, 1);
            AddRandomNumbers(10,z: 15);


            //params keyword
            /*int[] newestArray = {2, 5, 4, 3, 2, 1};
            Print(newestArray);*/

            PrintnewestArray(2, 5, 4, 3, 2, 1, 7, 8, 2, 1, 9);
        }

        static void PrintnewestArray(params int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item +  " ");
            }
            Console.WriteLine();
        }


        static void AddRandomNumbers(int x, int y = 5, int z = 8)
        {
            Console.WriteLine(x + y + z);
        }




        static void AddAndMulti(int x, int y, out int added, out int multiplied)
        {
            added = x + y;
            multiplied = x * y;
        }

        static (int,int) MultiplyAndSubtract(int x, int y)
        {
            int multi = x * y;
            int subtraction = y - x;

            return (multi, subtraction);
        }

        static void GiveExtra(int studentGrade)
        {
            studentGrade += 25;
        }

        static void GiveExtra(ref int[] grades)
        {
            grades[0] += 25;
        }


        static int[] Fill(int size = 15)
        {
            Random rd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++) //size also works as length
            {
                array[i] = rd.Next(0, 100);
            }
            Array.Sort(array);

            return array;
            //Array.Sort(array); --> if you want to return a sorted one, push before return
        }

        static void Print(double[] doubles)
        {
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();            
        }

        static void Print(bool[] bools)
        {
            foreach (var item in bools)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Print(string[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print()
        {
            int[] numbers = {4, 5, 3, 2, 1, 0};

            foreach (var item in numbers)
            {
                Console.Write(item + "**");
            }
            Console.WriteLine();
        }



        //VOID METHOD DOESNT RETURN ANYTHING, JUST EXECUTES SOMETHING
        /*static void Add(int number1, int number2)
        {
            int answer = number1 + number2;
            Console.WriteLine(answer);
        }*/

        //ANYTHING BUT A VOID METHOD
        static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;

        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

    }
}