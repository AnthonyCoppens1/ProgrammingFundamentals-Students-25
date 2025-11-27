using System;
using System.IO;

namespace ExceptionBeforeAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter filename: ");
            string file = Console.ReadLine();

            Console.Write("Enter linenumber: ");
            int linenr;

            if (!Int32.TryParse(Console.ReadLine(), out linenr))
            {
                Console.WriteLine("Not a valid linenumber! We stop!");
                return;
            }

            if (!File.Exists(file))
            {
                Console.WriteLine("Not a valid file name! We stop!");
                return;
            }
            else //in case of a correct file name!
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length)
                {
                    Console.WriteLine("Linenumber is too big! We stop!");
                    return;
                }
                Console.WriteLine(text[linenr]);
            }



            //new way /w exception handling
            try
            {
                Console.Write("Enter filename: ");
                file = Console.ReadLine();

                Console.Write("Enter linenumber: ");
                linenr = Convert.ToInt32(Console.ReadLine());

                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[linenr]);
            }
            catch (FileNotFoundException ex) //wrong filename
            {
                Console.WriteLine("File not found");
            }
            catch (IndexOutOfRangeException ex) //-7
            {
                Console.WriteLine("index out of range");
            }
            catch (FormatException ex) //3.2
            {
                Console.WriteLine("Linernumber was not a number! ");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Linenumber was too big");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine("CONTINUE");
        }
    }
}