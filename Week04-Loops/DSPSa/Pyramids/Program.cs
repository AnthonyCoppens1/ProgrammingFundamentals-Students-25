using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Print out the following pyramids:
            1. 
            *
            * *
            * * *
            * * * *

            2.
            * * * *
            * * *
            * *
            *

            3.
                  *
                * *
              * * *
            * * * * 

            4.
            * * * *
              * * *
                * *
                  *     
            
            
            */



            // 1st pyramid
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //pyramid number 2
            Console.WriteLine("PYRAMID 2");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPYRAMID 3");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }



            Console.WriteLine("\nPYRAMID 4");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}