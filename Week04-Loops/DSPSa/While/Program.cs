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

            /*Console.Write("Guess the number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int counter = 1;
            while (number != guess && counter < 10)
            {
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }

            Console.WriteLine($"CONGRATS, the number was {number} and you guessed {counter} times");*/

            
            //beware of the order of statements and your code, printing first followed by calculating vs the opposite
            //sequence of 3 6 9 12 15 18 ... Int16.MaxValue
            int i = 3;

            while (i < 99)
            {
                Console.Write(i + " ");
                i += 3;
            }


            Console.WriteLine();
            i = 3;
            while (i < 99)
            {
                i += 3;
                Console.Write(i + " ");
            }


            //do while will always loop at least 1 time
            //care about the order of your again once again!!!

            Console.Write("\nSequence of 3 6 9: ");
            i = 3;

            do
            {
                Console.Write(i + " ");
                i += 3;
            } while (i < 99);

        }
    }
}