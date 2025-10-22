using System;
using System.IO;

namespace HarryPotterTxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Read the file line by line and store the lines in a seperate file
            But only up until a certain point. The amount of lines should be in the file name
            */
            //option 1 --> while
            Console.Write($"Give me a number of lines: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            StreamReader sr = File.OpenText("HarryPotter.txt");
            StreamWriter write = File.CreateText($"Harry-{lines}.txt");

            while (counter < lines)
            {
                write.WriteLine(counter + " " + sr.ReadLine());
                counter++;
            }

            write.Close();
            sr.Close();


            //option 2 --> foreach
            Console.Write($"Give me a number of lines: ");
            lines = Convert.ToInt32(Console.ReadLine());
            counter = 0;

            StreamWriter sw = File.CreateText($"Harry-{lines}-OPTION2.txt");
            foreach (string line in File.ReadLines("HarryPotter.txt"))
            {
                if (counter < lines)
                {
                    sw.WriteLine(counter + " " + line);
                    counter++;
                }
                else
                {
                    break;
                }
            }
            sw.Close();       

        }
    }
}