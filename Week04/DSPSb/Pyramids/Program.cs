using System;

namespace Pyramids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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

            Console.WriteLine("pyramid 1");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\npyramid 2");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPyramid 3");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write("T ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            
            Console.WriteLine("\nPyramid 4");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 4; k >= i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}