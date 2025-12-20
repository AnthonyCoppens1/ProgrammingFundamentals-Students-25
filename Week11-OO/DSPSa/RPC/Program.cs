using System;

namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPS game = new RPS();
            string answer;
            Console.WriteLine($"Choose: Rock (0) - Paper (1) - Scissors (2)");
            while (Convert.ToInt32(answer = Console.ReadLine()) != 4 && Math.Abs(game.MyScore - game.ComputerScore) < 2)
            {
                game.Myself = (Move)Convert.ToInt32(answer);
                string result = game.Choice();
                Console.WriteLine(result);
                Console.WriteLine(Math.Abs(game.MyScore - game.ComputerScore));
            }

            Console.WriteLine($"Final score: {game}");
        }
    }
}