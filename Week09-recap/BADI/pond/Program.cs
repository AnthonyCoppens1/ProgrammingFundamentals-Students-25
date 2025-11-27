using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int diepte = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= diepte; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("0 ");
                    }
                    for (int k = diepte; k > i; k--)
                    {
                        Console.Write("~ ");
                    }
                    for (int l = diepte; l > i; l--)
                    {
                        Console.Write("~ ");
                    }
                    for (int m = 0; m < i; m++)
                    {
                        Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }

            //VERSIE GOLVEN SAMENVOEGEN
            try
            {
                int diepte = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= diepte; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("0 ");
                    }
                    for (int k = diepte * 2; k > i * 2; k--) //diepte: 3 --> k = 6 --> i = 2
                    {
                        Console.Write("~ ");
                    }
                    
                    for (int m = 0; m < i; m++)
                    {
                        Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}