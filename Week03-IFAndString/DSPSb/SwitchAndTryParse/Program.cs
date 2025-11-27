using System;

namespace SwitchAndTryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intermezzo on DateTime
            int weekday = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekday);

            DateTime timeRightNow = DateTime.Now;
            Console.WriteLine(timeRightNow);

            DateTime birthday = new DateTime(1995, 07, 31);
            Console.WriteLine(birthday.Year + 12);

            string weekdayName = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(weekdayName);

            //Theory on switch cases with examples
            switch (Console.ReadLine())
            {
                case "Monday":
                    Console.WriteLine("I'm so happy I get to see Anthony again <3");
                    break;
                case "Tuesday":
                    Console.WriteLine("SHOWTIME BABYYYYYYYYYY");
                    break;
                case "Wednesday":
                    Console.WriteLine("4 hours of TECHNOLOGIAAA");
                    break;
                case "Thursday":
                    Console.WriteLine("snoozing is LIFE");
                    break;
                case "Friday":
                    Console.WriteLine("sleep in and chill at computing fundamentals #BEN");
                    break;
                case "WEEKEND":
                    Console.WriteLine("Finally time to get drunk and play around in the sauna");
                    break;
                default:
                    Console.WriteLine("Are you really that incapable of typing a name of a day of the week?????");
                    break;
            }

            //works with a range --> switch cases do not work with 2 or multiple conditions in 1 case 
            //--> e.g. case >1 || >20:
            int number = 10;
            switch (number)
            {
                case 8:
                    Console.WriteLine("Don't care");
                    break;
                case > 1:
                    Console.WriteLine("WORKS");
                    break;
                default:
                    Console.WriteLine("TEST");
                    break;
            }



            //TRY PARSING
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;

            if (x > y)
            {
                Console.WriteLine("AMAZING");
            }

            Console.Write("z: ");
            string answer = Console.ReadLine();
            int z;

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
                Console.WriteLine("Write a propper number!");
            }


            Console.WriteLine("Give me a temp: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int temp);

            if (!check)
            {
                Console.WriteLine("Crazy input");
            }
            else
            {
                if (temp < 0)
                {
                    Console.WriteLine("brrr");
                }
            }

            //careful that if you now fail to convert, you don't have the opportunity to print out or use
            //the string version of whatever you entered first!
            if (Double.TryParse(Console.ReadLine(), out double D))
            {
                Console.WriteLine($"{D * D}");
            }
            else
            {
                Console.WriteLine($"crazy input");
            }








        }
    }
}