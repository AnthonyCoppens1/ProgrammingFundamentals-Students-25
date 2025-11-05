using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            int nr;

            if (Int32.TryParse(answer, out nr))
            {
                try
                {
                    StreamReader file = File.OpenText("englih.txt");
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Oops there's a mistake! {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("wrong number");
            }
        }
    }
}