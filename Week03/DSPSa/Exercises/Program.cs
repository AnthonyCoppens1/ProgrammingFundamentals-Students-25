using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EX 1 -->
            // Write a program that detects a heatwave
            // 5 days of a temp >= 25 and 3 of which are >= 30 --> provide message
            //use tryparsing

            bool day1 = Int32.TryParse(Console.ReadLine(), out int temp1);
            bool day2 = Int32.TryParse(Console.ReadLine(), out int temp2);
            bool day3 = Int32.TryParse(Console.ReadLine(), out int temp3);
            bool day4 = Int32.TryParse(Console.ReadLine(), out int temp4);
            bool day5 = Int32.TryParse(Console.ReadLine(), out int temp5);

            int daysthirty = 0;

            if (temp1 >= 25 && temp2 >= 25 && temp3 >= 25 && temp4 >= 25 && temp5 >= 25)
            {
                if (temp1 >= 30)
                {
                    daysthirty++;
                }
                if (temp2 >= 30)
                {
                    daysthirty++;
                }
                if (temp3 >= 30)
                {
                    daysthirty++;
                }
                if (temp4 >= 30)
                {
                    daysthirty++;
                }
                if (temp5 >= 30)
                {
                    daysthirty++;
                }

                if (daysthirty >= 3)
                {
                    Console.WriteLine("HEATWAVE ALERT");
                }

            }
            else
            {
                Console.WriteLine("Enter valid temps");
            }





            /*EX 2 --> employee scoring system
            write a program that give the employee feedback based on a score 
            out of 100. Categorise it --> 0-20 / 20-50 / 50-70 / 70-90 / 90-100
            */
        }
    }
}