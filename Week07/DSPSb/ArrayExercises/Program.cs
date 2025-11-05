using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            report card:
                    test1   test2   test3   test4   test5
            Dutch
            PF
            DB
            CT
            CF


            PF          test1   test2   test3   ass1    ass2
            student1    0       0       0       0       0
            student2    0       5       2       6       6
            student3    2       4       6       6       6
            student4    0       0       2       5       5
            student5    0       6       3       2       4

            */
            //PF EXAMPLE
            //number of students and number of tests

            Console.Write($"Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            int[,] results = new int[students, tests];
            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < tests; j++)
                {
                    Console.Write($"Grade for student{i + 1} of test{j + 1}: ");
                    results[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < tests; j++)
                {
                    Console.Write(results[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < students; i++)
            {
                int sum = 0;
                for (int j = 0; j < tests; j++)
                {
                    sum += results[i, j];
                }
                Console.WriteLine($"Average of student {i + 1} is {sum / tests}");
            }



            //jagged arrays
            //report card of diff courses FOR ONE SINGLE INDIVIDUAL STUDENT!

            string[][] courseResults = new string[5][];
            for (int i = 0; i < courseResults.Length; i++)
            {
                //add every single row
                Console.WriteLine($"Enter the results of all the tests from this student for course {i + 1}: ");
                courseResults[i] = Console.ReadLine().Split(" ");
            }

            int counter = 1;
            foreach (var course in courseResults)
            {
                Console.Write($"Course {counter}: ");

                foreach (var test in course)
                {
                    Console.Write(test + "\t");
                }
                Console.WriteLine();
                counter++;
            }






        }
    }
}