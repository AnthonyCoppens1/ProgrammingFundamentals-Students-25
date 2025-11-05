using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            make a dynamic team setup for football that would display the players in a grid type way.
            using a jagged array and making it work for a whole team
            */

            string[][] players = new string[3][];

            int counter = 0;

            foreach (string[] position in players) //can also use "var" as a datatype if you're uncertain on it
            {
                if (counter == 0)
                {
                    Console.WriteLine($"Defenders: ");
                }
                else if (counter == 1)
                {
                    Console.WriteLine($"Midfield: ");
                }
                else
                {
                    Console.WriteLine($"Attack: ");
                }
                players[counter] = Console.ReadLine().Split(' ');
                counter++;
            }

            /*for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"Players for segment {i}: ");
                players[i] = Console.ReadLine().Split(' ');
            }*/

            //print every player to see what's there
            foreach (var item in players)
            {
                foreach (var player in item)
                {
                    Console.Write(player + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}