using System;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exception handling
            //old way of solving problems and a new way

            //OLD WAY
            Console.Write($"Enter the filename: ");
            string file = Console.ReadLine();

            Console.Write($"Give me a line number: ");
            int linenr;

            if (!Int32.TryParse(Console.ReadLine(), out linenr))
            {
                Console.WriteLine("Not a valid line number!");
                return;
            }

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found!");
                return;
            }
            else
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length)
                {
                    Console.WriteLine("Linenumber is too big!");
                    return;
                }
                Console.WriteLine(text[linenr]);
            }





            //NEW WAY
            try
            {
                Console.Write($"Filename: ");
                file = Console.ReadLine();
                Console.WriteLine($"Line: ");
                linenr = Convert.ToInt32(Console.ReadLine());
                string[] text = File.ReadAllLines(file);
                Console.Write(text[linenr]);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Problem with the file!");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
            finally
            {
                Console.WriteLine("TEST");
            }


        }
    }
}