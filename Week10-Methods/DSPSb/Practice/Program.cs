using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string question = Console.ReadLine();
            switch (question)
            {
                case "Floyd":
                    int size = Convert.ToInt32(Console.ReadLine());
                    Floyd(size);
                break;

                case "Harmonic":
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Math.Round(Harmonic(n),5));
                break;

                case "Pangram":
                    string sentence = Console.ReadLine();
                    bool check = Pangram(sentence);
                    Console.WriteLine(check);
                break;

                default:
                    Console.WriteLine("crazy input");
                break;
            }
        }

        static bool Pangram(string sentence)
        {
            bool pangram = true;

            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            for (int i = 65; i < 91; i++)
            {
                alphabet.Add((char)i, 0);
            }

            foreach (char c in sentence.ToUpper())
            {
                if (alphabet.ContainsKey(c))
                {
                    alphabet[c]++;
                }
            }

            foreach (var value in alphabet.Values)
            {
                if (value == 0)
                {
                    pangram = false;
                }
            }

            return pangram;

        }

        static double Harmonic(int n)
        {
            double sum = 0;
            string s = "";

            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    s += "1/" + i + " + ";
                }
                else
                {
                    s += "1/" + i;
                }

                sum += 1/(double)i;
            }
            Console.WriteLine(s);

            return sum;
        }





        static void Floyd(int size)
        {
            int counter = 1;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }


    }
}