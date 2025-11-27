using System;

namespace HarryPotter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            I want to read in a file and its contents up until a certain point. The file is the one from Harry potter
            After reaching said point, move the content up until the point into a new file. We do this in one of
            2 techniques, a while and a foreach
            */

            //while
            int lines = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            StreamReader read = File.OpenText("HarryPotter.txt"); //@ allows you to use spaces in a file name
            StreamWriter write = File.CreateText($"Harry-{lines}.txt");

            while (counter < lines)
            {
                write.WriteLine(counter + " " + read.ReadLine());
                counter++;
            }

            write.Close();
            read.Close();


            //foreach
            lines = Convert.ToInt32(Console.ReadLine());
            counter = 0;

            write = File.CreateText($"Harry-{lines}-FOREACH.txt");
            foreach (string line in File.ReadLines("HarryPotter.txt"))
            {
                if (counter < lines)
                {
                    write.WriteLine(counter + " " + line);
                    counter++;
                }
                else
                {
                    break;
                }
            }
            write.Close();


            


        }
    }
}