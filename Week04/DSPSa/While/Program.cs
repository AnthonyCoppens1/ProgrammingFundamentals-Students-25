using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("START! press y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.Write("Press y to continue: ");
                answer = Console.ReadLine();
            }


            Console.WriteLine("GUESSING GAME!!!");
            Random randomGame = new Random();
            int number = randomGame.Next(1, 20);

            Console.Write("Guess the number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int counter = 1;
            while (number != guess && counter < 10)
            {
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }

            Console.WriteLine($"CONGRATS, the number was {number} and you guessed {counter} times");

        }
    }
}