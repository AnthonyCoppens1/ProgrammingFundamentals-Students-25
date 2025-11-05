using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a report card style exercise in which you're able to call for an amount of students
            And also be able to call for an amount of tests. Fill the array with results and print out the report card
            */

            Console.WriteLine("Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            int[,] report = new int[tests, students];

            for (int i = 0; i < tests; i++)
            {
                for (int j = 0; j < students; j++)
                {
                    Console.Write($"Grade for student {j + 1} of test {i + 1}: ");
                    report[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write($"       \t");
            for (int i = 0; i < students; i++)
            {
                Console.Write($"s{i + 1}\t");
            }
            Console.WriteLine();

            for (int i = 0; i < tests; i++)
            {
                Console.Write($"TEST {i}:\t");
                for (int j = 0; j < students; j++)
                {
                    Console.Write(report[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < tests; j++)
                {
                    sum += report[j, i];
                }
                Console.WriteLine($"average for student {i + 1} is {sum / tests}");
                sum = 0;
            }

        }
    }
}