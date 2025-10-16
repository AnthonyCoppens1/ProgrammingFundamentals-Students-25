using System;

namespace WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start the messaging sequence, as long as you don't press stop, it'll keep going: ");
            string answer = Console.ReadLine(); //test

            while (answer != "STOP")
            {
                Console.Write("Keep on going, STOP to stop!");
                answer = Console.ReadLine();
            }

            Console.WriteLine("second loop");
            answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.Write("Go again: ");
                answer = Console.ReadLine();
            }


            //guessing game

            Console.Write("Guess the number: ");
            Random randomGuess = new Random();
            int number = randomGuess.Next(1, 20);

            int guess = Convert.ToInt32(Console.ReadLine());
            int attempts = 1;

            while (guess != number && attempts < 5)
            {
                if (guess > number)
                {
                    Console.WriteLine("Number is lower than you think!");
                }
                else
                {
                    Console.WriteLine("Number is higher than you think");
                }
                Console.Write("Try again, you suck at guessing numbers: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
            }

            Console.WriteLine($"The number was {number} and you guessed it in {attempts} attempts!");




            //sequence of 3 6 9 12 15 18 21 ... 99
            //WHILE
            //care for order of calculations

            int i = 3;
            while (i < 99)
            {
                Console.Write(i + " ");
                i += 3;
            }

            Console.WriteLine("\nVersion 2:");
            i = 3;
            while (i < 99)
            {
                i += 3;
                Console.Write($"{i} ");
            }


            Console.WriteLine("\nDO WHILE WITH THE SEQUENCE");
            i = 3;
            do
            {
                i += 100;
                Console.WriteLine(i + " ");
            } while (i < 99);


        }
    }
}