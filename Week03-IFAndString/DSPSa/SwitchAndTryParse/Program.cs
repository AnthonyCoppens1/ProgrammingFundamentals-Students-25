using System;

namespace SwitchAndTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekday = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekday);

            string dayInWords = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dayInWords);

            DateTime yesterday = new DateTime(2025, 09, 29);
            Console.WriteLine(yesterday.Year);

            DateTime birthday = new DateTime(1995, 07, 31);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            int age = now.Year - birthday.Year;
            Console.WriteLine($"You are {age} years old!");


            //switch cases to check something as an alternative to if-statements
            if (weekday == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (weekday == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (weekday == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Not a valid number!");
            }


            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                default:
                    Console.WriteLine("WOHOOOOOOO weekend!");
                    break;
            }

            string word = "Tuesday";

            switch (dayInWords)
            {
                case "Tuesday":
                    Console.WriteLine("today is today");
                    break;
                /*case word: --> cases can never be variables.
                    break;*/
                default:
                    Console.WriteLine("sadly no programming fundamentals today!!");
                    break;
            }


            //TRYPARSE --> AVOID ERRORS
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            //if I enter something like "twenty" it'll give me a formatexception and crash!
            //avoiding this

            Console.Write("z = ");
            string answer = Console.ReadLine();
            int z; //parse answer and if it works --> save it under z

            bool succes = Int32.TryParse(answer, out z);
            if (succes)
            {
                if (z > y)
                {
                    Console.WriteLine("z is greater than y");
                }
            }
            else
            {
                Console.WriteLine("Oops, crazy input");
            }
            Console.WriteLine("TEST");

            //tryparsing part 2
            Console.Write("Enter a temp: ");
            if (Int32.TryParse(Console.ReadLine(), out int temp))
            {
                if (temp < 0)
                {
                    Console.WriteLine("brrr it's freezing");
                }
                else
                {
                    Console.WriteLine("Nice temp!");
                }
            }
            else
            {
                Console.WriteLine("Crazy input");
            }

            if (!Int32.TryParse(Console.ReadLine(), out int secondTemp))
            {
                Console.WriteLine("Crazy input");
            }
            else
            {
                Console.WriteLine("TEMP IS GIVEN");
            }


        }
    }
}